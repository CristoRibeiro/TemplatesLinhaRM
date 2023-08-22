using ScaffoldingRM.GeradorNegocio.ControleVersao.Implementacoes.ComandosTFVC;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio
{
  public static class GeradorCodigoFonteFactory
  {

    public static IGeradorCodigoFonte ObterInstancia()
    {
      return GeradorCodigoFonte.ObterGerador(new CommandsTFVC());
    }

  }
}
