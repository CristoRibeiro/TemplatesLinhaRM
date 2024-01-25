using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Modulo
{
  public class FactoryCodigoFonteModulo : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase moduloDto)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configModulo = FactoryConfigCodigoFonteModulo.ObterIntancia();
      configModulo.NomeEntidade = moduloDto.NomeEntidade;
      configModulo.Projeto = new Projeto(moduloDto.FullPathProjeto);

      var pathIntf = moduloDto.FullPathProjeto.Replace(".Server.", ".Intf.");
      pathIntf = pathIntf.Replace(".Server\\", ".Intf\\");

      IConfigCodigoFonte configInterfaceModulo = FactoryConfigCodigoFonteInterfaceModulo.ObterIntancia();
      configInterfaceModulo.NomeEntidade = moduloDto.NomeEntidade;
      configInterfaceModulo.Projeto = new Projeto(pathIntf);

      var codigoFonteInterfaceModulo = new CriarInterfaceModuloCodigoFonte(configInterfaceModulo, geradorCodigoFonte);
      configModulo.FontesAdicionais.Add(TipoClasse.InterfaceMod, codigoFonteInterfaceModulo);

      return new CriarModuloCodigoFonte(configModulo, geradorCodigoFonte);
    }
  }
}
