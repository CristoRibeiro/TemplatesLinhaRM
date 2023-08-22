using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.ObjectItem
{
  public static class FactoryConfigCodigoFonteObjectItem
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Dto", "Sau", "ObjectItem.tt", "cs");
  }
}
