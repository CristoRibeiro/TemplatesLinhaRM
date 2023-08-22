using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsObject
{
  public static class FactoryCodigoFonteRmsObject
  {
    public static ICodigoFonte ObterIntancia(string nomeEntidade, string pathProjeto)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteRmsObject.ObterIntancia();
      configForm.NomeEntidade = nomeEntidade;
      configForm.Projeto = new Projeto(pathProjeto);
      
      return new CriarRmsObjectCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
