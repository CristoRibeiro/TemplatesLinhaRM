using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.ObjectItem
{
  public static class FactoryCodigoFonteObjectItem
  {
    public static ICodigoFonte ObterIntancia(string nomeEntidade, string pathProjeto)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteObjectItem.ObterIntancia();
      configForm.NomeEntidade = nomeEntidade;
      configForm.Projeto = new Projeto(pathProjeto);
      
      return new CriarObjectItemCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
