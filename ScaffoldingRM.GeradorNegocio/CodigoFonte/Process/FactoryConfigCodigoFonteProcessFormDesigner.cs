using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.Common
{
  public static class FactoryConfigCodigoFonteProcessFormDesigner
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("ProcForm", "Sau", "ProcessFormDesigner.tt", "Designer.cs");

  }
}
