using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsObject
{
  public static class FactoryConfigCodigoFonteRmsObject
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Obj", "Sau", "RMSObject.tt", "cs");
  }
}
