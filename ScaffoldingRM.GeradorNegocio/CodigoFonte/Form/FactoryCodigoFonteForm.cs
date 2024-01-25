using ScaffoldingRM.GeradorNegocio.CodigoFonte.Action;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public class FactoryCodigoFonteForm : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase formDtoBase)
    {
      var formDTO = (DTOFonteForm)formDtoBase;

      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteForm.ObterIntancia();
      configForm.NomeEntidade = formDTO.NomeEntidade;
      configForm.Projeto = new Projeto(formDTO.FullPathProjeto);

      if (formDTO.GerarData)
        configForm.FontesAdicionais.Add(TipoClasse.Data, new FactoryCodigoFonteData().ObterIntancia(formDTO.DtoData));

      if (formDTO.GerarAction)
        configForm.FontesAdicionais.Add(TipoClasse.Action, new FactoryCodigoFonteAction().ObterIntancia(formDTO));

      return new CriarFormCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
