using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.DataProps
{
  public class FactoryCodigoFonteDataProps : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase dtoBase)
    {
      var dtoDataProps = (DTOFonteDataProps)dtoBase;

      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteDataProps.ObterIntancia();
      configForm.NomeEntidade = dtoDataProps.NomeEntidade;
      configForm.Projeto = new Projeto(dtoDataProps.FullPathProjeto);

      return new CriarDataPropsCodigoFonte(configForm, geradorCodigoFonte, dtoDataProps.NomeTabela);
    }
  }
}
