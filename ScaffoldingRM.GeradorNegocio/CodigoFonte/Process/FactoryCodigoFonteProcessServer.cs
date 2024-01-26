using ScaffoldingRM.GeradorNegocio.CodigoFonte.Action;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public class FactoryCodigoFonteProcessServer : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase processServerDto)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteProcessServer.ObterIntancia();
      configForm.NomeEntidade = processServerDto.NomeEntidade;
      configForm.Projeto = new Projeto(processServerDto.FullPathProjeto);

      return new CriarProcessServerCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
