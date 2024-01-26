using ScaffoldingRM.GeradorNegocio.CodigoFonte.Action;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public class FactoryCodigoFonteProcessParamsProc : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase paramsProcDto)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteProcessParamsProc.ObterIntancia();
      configForm.NomeEntidade = paramsProcDto.NomeEntidade;
      configForm.Projeto = new Projeto(paramsProcDto.FullPathProjeto);

      return new CriarProcessParamsProcCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
