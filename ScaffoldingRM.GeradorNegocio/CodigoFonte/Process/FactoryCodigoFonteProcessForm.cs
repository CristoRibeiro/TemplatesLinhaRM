using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public class FactoryCodigoFonteProcessForm : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase processFormDTO)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteProcessForm.ObterIntancia();
      configForm.NomeEntidade = processFormDTO.NomeEntidade;
      configForm.Projeto = new Projeto(processFormDTO.FullPathProjeto);

      IConfigCodigoFonte configFormDesigner = FactoryConfigCodigoFonteProcessFormDesigner.ObterIntancia();
      configFormDesigner.NomeEntidade = processFormDTO.NomeEntidade;
      configFormDesigner.Projeto = new Projeto(processFormDTO.FullPathProjeto);

      var codigoDesigner = new CriarProcessFormCodigoFonteDesigner(configFormDesigner, geradorCodigoFonte);

      configForm.FontesAdicionais.Add(TipoClasse.ProcessFormDesigner, codigoDesigner);

      return new CriarProcessFormCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
