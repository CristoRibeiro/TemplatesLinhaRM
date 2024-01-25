using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.Common
{
  public static class FactoryConfigCodigoFonteFormDesigner
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Form", "Sau", "Form.Designer.tt", "Designer.cs");
  }
}
