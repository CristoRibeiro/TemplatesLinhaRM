using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Modulo
{
  public static class FactoryCodigoFonteModulo
  {
    public static ICodigoFonte ObterIntancia(DTOFonteModulo moduloDto)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configModulo = FactoryConfigCodigoFonteModulo.ObterIntancia();
      configModulo.NomeEntidade = moduloDto.NomeEntidade;
      configModulo.Projeto = new Projeto(moduloDto.FullPathProjeto);

      var pathIntf = moduloDto.FullPathProjeto.Replace(".Data.", ".Intf.");
      pathIntf = pathIntf.Replace(".Data\\", ".Intf\\");

      IConfigCodigoFonte configInterfaceModulo = FactoryConfigCodigoFonteInterfaceModulo.ObterIntancia();
      configInterfaceModulo.NomeEntidade = moduloDto.NomeEntidade;
      configInterfaceModulo.Projeto = new Projeto(pathIntf);

      var codigoFonteInterfaceModulo = new CriarInterfaceModuloCodigoFonte(configInterfaceModulo, geradorCodigoFonte);
      configModulo.FontesAdicionais.Add(TipoClasse.InterfaceMod, codigoFonteInterfaceModulo);

      return new CriarModuloCodigoFonte(configModulo, geradorCodigoFonte);
    }
  }
}
