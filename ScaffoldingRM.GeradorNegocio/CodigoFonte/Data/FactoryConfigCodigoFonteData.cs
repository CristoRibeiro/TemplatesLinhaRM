using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Data
{
  public static class FactoryConfigCodigoFonteData
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Data", "Sau", "Data.tt", "cs");
  }
}
