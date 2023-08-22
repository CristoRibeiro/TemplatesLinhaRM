using ScaffoldingRM.GeradorNegocio.CodigoFonte.Action;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public static class FactoryCodigoFonteForm
  {
    public static ICodigoFonte ObterIntancia(DTOFonteForm formDto)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteForm.ObterIntancia();
      configForm.NomeEntidade = formDto.NomeEntidade;
      configForm.Projeto = new Projeto(formDto.FullPathProjeto);

      if (formDto.GerarData)
        configForm.FontesAdicionais.Add(TipoClasse.Data, FactoryCodigoFonteData.ObterIntancia(formDto.DtoData));

      if (formDto.GerarAction)
      {
        configForm.FontesAdicionais.Add(TipoClasse.Action, FactoryCodigoFonteAction.ObterIntancia(formDto.NomeEntidade, formDto.FullPathProjetoAction));
      }

      return new CriarFormCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
