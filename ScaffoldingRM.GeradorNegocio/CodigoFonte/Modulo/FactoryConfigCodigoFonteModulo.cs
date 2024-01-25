using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Modulo
{
  public static class FactoryConfigCodigoFonteModulo 
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Mod", "Sau", "Modulo.tt", "cs");
    
  }
}
