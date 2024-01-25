using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.DataSet
{
  public static class FactoryConfigCodigoFonteDataSetXsd
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase(string.Empty, "Sau", "DataSet.xsd.tt", "xsd");
  }
}
