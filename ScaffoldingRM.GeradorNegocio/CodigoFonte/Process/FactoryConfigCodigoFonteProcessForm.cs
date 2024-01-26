using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.Common
{
  public static class FactoryConfigCodigoFonteProcessForm
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("ProcForm", "Sau", "ProcessForm.tt", "cs");

  }
}
