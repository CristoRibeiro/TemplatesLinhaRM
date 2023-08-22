using EnvDTE;
using EnvDTE80;
using Mono.TextTemplating;
using ScaffoldingRM.GeradorNegocio.ControleVersao;
using ScaffoldingRM.GeradorNegocio.Interface;
using System;
using System.IO;
using System.Reflection;

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

      GerarComandosAdicionais(configuracaoCodigoFonte);
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
        if (projectItem.SubProject != null)
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

    private void GerarComandosAdicionais(IConfigCodigoFonte configuracaoCodigoFonte)
    {
      foreach (var comando in configuracaoCodigoFonte.FontesAdicionais)
        comando.Value.GerarCodigoFonte();
    }
  }
}
