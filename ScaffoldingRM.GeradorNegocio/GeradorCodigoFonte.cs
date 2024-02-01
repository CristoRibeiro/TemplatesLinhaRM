using EnvDTE;
using EnvDTE80;
using Mono.TextTemplating;
using ScaffoldingRM.GeradorNegocio.ControleVersao;
using ScaffoldingRM.GeradorNegocio.Interface;
using System;
using System.Collections;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Reflection;
using System.Resources;
using VSLangProj;

namespace ScaffoldingRM.GeradorNegocio
{
  public class GeradorCodigoFonte : IGeradorCodigoFonte
  {
    IControleVersao _controleVersao;
    private static GeradorCodigoFonte _instancia;

    public static GeradorCodigoFonte ObterGerador(IControleVersao controleVersao)
    {
      if (_instancia == null)
      {
        _instancia = new GeradorCodigoFonte(controleVersao);
      }
      return _instancia;
    }

    private GeradorCodigoFonte(IControleVersao controleVersao)
    {
      _controleVersao = controleVersao;
    }

    public void GerarCodigoFonte(IConfigCodigoFonte configuracaoCodigoFonte)
    {
      string diretorioTemplate = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Templates");

      var templateCodigoFonte = $@"{diretorioTemplate}\{configuracaoCodigoFonte.Template}";
      var codigoFonteSaida = $@"{configuracaoCodigoFonte.Projeto.Diretorio}\{configuracaoCodigoFonte.NomeArquivo}.{configuracaoCodigoFonte.Extensao}";

      var gerador = new TemplateGenerator();

      AdicionarParametrosTemplate(configuracaoCodigoFonte, gerador);


      var geradoComSucesso = gerador.ProcessTemplateAsync(templateCodigoFonte, codigoFonteSaida).Result;

      if (!geradoComSucesso)
      {
        foreach (var error in gerador.Errors)
        {
          throw new Exception(error.ToString());
        }
      }

      _controleVersao.CheckOut(configuracaoCodigoFonte.Projeto.NomeProjetoCompleto);

      _controleVersao.AddItem(codigoFonteSaida);

      AdicionarArquivoNoProject(configuracaoCodigoFonte.Projeto.NomeProjetoCompleto, codigoFonteSaida);

      AdicionarResources(configuracaoCodigoFonte, configuracaoCodigoFonte.Projeto.NomeProjetoCompleto);

      GerarFontesAdicionais(configuracaoCodigoFonte);
    }

    private void AdicionarResources(IConfigCodigoFonte configuracaoCodigoFonte, string projectName)
    {
      if (!configuracaoCodigoFonte.Resources.Any())
        return;

      string resxFilePath = configuracaoCodigoFonte.Projeto.Diretorio + "\\Properties\\Resources.resx";

      if (!File.Exists(resxFilePath))
        return;

      _controleVersao.CheckOut(resxFilePath);
      System.Threading.Thread.Sleep(5000);

      using (ResXResourceReader resxReader = new ResXResourceReader(resxFilePath))
      {
        var existingResources = new SortedList();
        foreach (DictionaryEntry entry in resxReader)
        {
          if (!existingResources.Contains(entry.Key))
            existingResources.Add(entry.Key, entry.Value);
        }

        foreach (var resource in configuracaoCodigoFonte.Resources)
        {
          if (!existingResources.Contains(resource))
            existingResources.Add(resource, resource);
        }
        resxReader.Close();

        using (ResXResourceWriter resxWriter = new ResXResourceWriter(resxFilePath))
        {
          foreach (DictionaryEntry entry in existingResources)
            resxWriter.AddResource(entry.Key.ToString(), entry.Value);
          resxWriter.Close();
        }

        DTE dte = (DTE)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");

        Solution solution = dte.Solution;
        Project project = ObterProjeto(solution, projectName);

        ProjectItem foundItem = ObterItemProjetoPorNome(project, "Resources.resx");

        if (foundItem != null)
        {
          VSProjectItem vsProjectItem = foundItem.Object as VSProjectItem;
          if (vsProjectItem != null)
          {
            vsProjectItem.RunCustomTool();
          }
        }

      }
    }

    public ProjectItem ObterItemProjetoPorNome(Project project, string itemName)
    {
      foreach (ProjectItem projectItem in project.ProjectItems)
      {
        if (projectItem.Name == itemName)       
          return projectItem;

        ProjectItem subItem = ObterItemProjetoRecursivo(projectItem, itemName);
        
        if (subItem != null)
          return subItem;
      }
      return null;
    }

    private ProjectItem ObterItemProjetoRecursivo(ProjectItem projectItem, string itemName)
    {
      if (projectItem.ProjectItems != null)
      {
        foreach (ProjectItem subItem in projectItem.ProjectItems)
        {
          if (subItem.Name == itemName)
            return subItem;

          ProjectItem nestedSubItem = ObterItemProjetoRecursivo(subItem, itemName);
          if (nestedSubItem != null)
            return nestedSubItem;
        }
      }      
      return null;
    }

    public Project ObterProjeto(Solution solution, string projectName)
    {
      foreach (Project project in solution.Projects)
      {
        if (project.Name == projectName)
        {
          return project;
        }

        if (project.Kind == ProjectKinds.vsProjectKindSolutionFolder)
        {
          Project subProject = ObterPastaSolucao(project, projectName);
          if (subProject != null)
          {
            return subProject;
          }
        }
      }

      return null;
    }

    public Project ObterPastaSolucao(Project solutionFolder, string projectName)
    {
      foreach (ProjectItem projectItem in solutionFolder.ProjectItems)
      {
        if (projectItem?.SubProject != null)
        {
          if (projectItem.SubProject.FullName == projectName)
          {
            return projectItem.SubProject;
          }

          if (projectItem.SubProject.Kind == ProjectKinds.vsProjectKindSolutionFolder)
          {
            Project subProject = ObterPastaSolucao(projectItem.SubProject, projectName);
            if (subProject != null)
            {
              return subProject;
            }
          }
        }
      }
      return null;
    }

    private void AdicionarArquivoNoProject(string nomeProjeto, string nomeArquivo)
    {
      DTE dte = (DTE)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");

      Solution solution = dte.Solution;
      Project project = ObterProjeto(solution, nomeProjeto);

      project?.ProjectItems.AddFromFile(nomeArquivo);
    }

    private static void AdicionarParametrosTemplate(IConfigCodigoFonte configuracaoCodigoFonte, TemplateGenerator gerador)
    {
      foreach (var item in configuracaoCodigoFonte.Parametros)
        gerador.AddParameter(null, null, item.Key, item.Value);
    }

    private void GerarFontesAdicionais(IConfigCodigoFonte configuracaoCodigoFonte)
    {
      foreach (var fonte in configuracaoCodigoFonte.FontesAdicionais)
        fonte.Value.GerarCodigoFonte();
    }
  }
}
