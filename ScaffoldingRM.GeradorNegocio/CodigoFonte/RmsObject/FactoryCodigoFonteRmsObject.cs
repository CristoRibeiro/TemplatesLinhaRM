using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsObject
{
  public class FactoryCodigoFonteRmsObject : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase dtoBase)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteRmsObject.ObterIntancia();
      configForm.NomeEntidade = dtoBase.NomeEntidade;
      configForm.Projeto = new Projeto(dtoBase.FullPathProjeto);

      return new CriarRmsObjectCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
