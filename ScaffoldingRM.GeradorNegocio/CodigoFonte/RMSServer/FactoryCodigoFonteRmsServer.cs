using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsServer
{
  public class FactoryCodigoFonteRmsServer : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase dtoBase)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configRmsServer = FactoryConfigCodigoFonteRmsServer.ObterIntancia();
      configRmsServer.NomeEntidade = dtoBase.NomeEntidade;
      configRmsServer.Projeto = new Projeto(dtoBase.FullPathProjeto);

      var pathIntf = dtoBase.FullPathProjeto.Replace(".Server.", ".Intf.");
      pathIntf = pathIntf.Replace(".Server\\", ".Intf\\");

      var dtoIntf = new DTOFonteBase
      {
        FullPathProjeto = pathIntf,
        NomeEntidade = dtoBase.NomeEntidade
      };

      configRmsServer.FontesAdicionais.Add(TipoClasse.InterfaceRMSServer, new FactoryCodigoFonteInterfaceRmsServer().ObterIntancia(dtoIntf));

      return new CriarRmsServerCodigoFonte(configRmsServer, geradorCodigoFonte);
    }
  }
}
