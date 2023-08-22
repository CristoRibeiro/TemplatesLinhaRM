using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.DataProps
{
  public static class FactoryConfigCodigoFonteDataProps
  {
    public static IConfigCodigoFonte ObterIntancia() => new ConfigCodigoFonteBase("Props", "Sau", "DataProps.tt", "cs");
  }
}
