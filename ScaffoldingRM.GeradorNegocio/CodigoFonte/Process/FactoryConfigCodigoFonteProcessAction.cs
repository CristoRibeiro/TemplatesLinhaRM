using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.Common
{
  public static class FactoryConfigCodigoFonteProcessAction
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("ProcAction", "Sau", "ProcessAction.tt", "cs");

  }
}
