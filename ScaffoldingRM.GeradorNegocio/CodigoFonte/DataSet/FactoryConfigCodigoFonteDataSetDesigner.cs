using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.DataSet
{
  public static class FactoryConfigCodigoFonteDataSetDesigner
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase(string.Empty, "Sau", "DataSet.Designer.tt", "Designer.cs");
  }
}
