using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Action
{
  public class FactoryCodigoFonteAction : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase dtoBase)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteAction.ObterIntancia();
      configForm.NomeEntidade = dtoBase.NomeEntidade;
      configForm.Projeto = new Projeto(dtoBase.FullPathProjeto);

      return new CriarActionCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
