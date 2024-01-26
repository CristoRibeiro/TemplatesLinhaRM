using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsServer
{
  public class FactoryCodigoFonteInterfaceRmsServer : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase dtoBase)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteInterfaceRmsServer.ObterIntancia();
      configForm.NomeEntidade = dtoBase.NomeEntidade;
      configForm.Projeto = new Projeto(dtoBase.FullPathProjeto);

      return new CriarInterfaceRmsServerCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
