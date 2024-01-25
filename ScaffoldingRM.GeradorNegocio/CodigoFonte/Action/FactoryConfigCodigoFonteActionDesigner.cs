using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.Common
{
  public static class FactoryConfigCodigoFonteActionDesigner
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Action", "Sau", "Action.Designer.tt", "Designer.cs");
    
  }
}
