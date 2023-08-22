using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Action
{
  public static class FactoryConfigCodigoFonteAction
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Action", "Sau", "Action.tt", "cs");
  }
}