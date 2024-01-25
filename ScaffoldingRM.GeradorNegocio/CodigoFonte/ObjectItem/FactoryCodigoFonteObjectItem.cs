using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.ObjectItem
{
  public class FactoryCodigoFonteObjectItem : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase dtoBase)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteObjectItem.ObterIntancia();
      configForm.NomeEntidade = dtoBase.NomeEntidade;
      configForm.Projeto = new Projeto(dtoBase.FullPathProjeto);

      return new CriarObjectItemCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
