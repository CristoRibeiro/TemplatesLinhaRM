using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Action
{
  public static class FactoryCodigoFonteAction
  {
    public static ICodigoFonte ObterIntancia(string nomeEntidade, string diretorioProjeto)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteAction.ObterIntancia();
      configForm.NomeEntidade = nomeEntidade;
      configForm.Projeto = new Projeto(diretorioProjeto);

      return new CriarActionCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
