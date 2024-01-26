using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.Common
{
  public static class FactoryConfigCodigoFonteProcessParamsProc
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("ParamsProc", "Sau", "ProcessParamsProc.tt", "cs");

  }
}
