using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Modulo
{
  public static class FactoryConfigCodigoFonteInterfaceModulo
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Mod", "ISau", "InterfaceModulo.tt", "cs");
  }
}
