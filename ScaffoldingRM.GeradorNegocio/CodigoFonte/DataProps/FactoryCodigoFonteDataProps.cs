using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.DataProps
{
  public static class FactoryCodigoFonteDataProps
  {
    public static ICodigoFonte ObterIntancia(string nomeEntidade, string pathProjeto, string nomeTabela)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteDataProps.ObterIntancia();
      configForm.NomeEntidade = nomeEntidade;
      configForm.Projeto = new Projeto(pathProjeto);
      
      return new CriarDataPropsCodigoFonte(configForm, geradorCodigoFonte, nomeTabela);
    }
  }
}
