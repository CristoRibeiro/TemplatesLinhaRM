using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.Common
{
  public static class FactoryConfigCodigoFonteProcessServer
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Proc", "Sau", "ProcessServer.tt", "cs");

  }
}
