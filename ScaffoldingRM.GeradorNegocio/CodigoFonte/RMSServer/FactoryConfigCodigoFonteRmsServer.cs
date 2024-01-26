using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsServer
{
  public static class FactoryConfigCodigoFonteRmsServer
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Server", "Sau", "RMSServer.tt", "cs");
  }
}
