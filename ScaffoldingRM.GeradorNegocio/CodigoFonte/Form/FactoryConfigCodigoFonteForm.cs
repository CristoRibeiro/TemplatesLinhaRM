using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.Common
{
  public static class FactoryConfigCodigoFonteForm
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Form", "Sau", "Form.tt", "cs");

  }
}
