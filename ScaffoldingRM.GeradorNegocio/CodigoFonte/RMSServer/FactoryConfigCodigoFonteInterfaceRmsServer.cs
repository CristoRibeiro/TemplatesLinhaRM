using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsServer
{
  public static class FactoryConfigCodigoFonteInterfaceRmsServer
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Server", "ISau", "InterfaceRmsServer.tt", "cs");
  }
}
