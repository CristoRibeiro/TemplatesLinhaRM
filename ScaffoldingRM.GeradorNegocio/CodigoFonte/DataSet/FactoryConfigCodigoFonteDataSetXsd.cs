using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.DataSet
{
  internal class FactoryConfigCodigoFonteDataSetXsd
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase(string.Empty, "Sau", "DataSet.xsd.tt", "xsd");
  }
}
