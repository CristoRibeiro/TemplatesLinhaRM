using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.DataSet
{
  public class FactoryCodigoFonteDataSet : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase dtoBase)
    {
      var DTODataSet = (DTOFonteDataSet)dtoBase;
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configDataSet = FactoryConfigCodigoFonteDataSet.ObterIntancia();
      configDataSet.NomeEntidade = dtoBase.NomeEntidade;
      configDataSet.Projeto = new Projeto(dtoBase.FullPathProjeto);
      
      return new CriarDataSetCodigoFonte(configDataSet, geradorCodigoFonte, DTODataSet.NomeTabela);
    }
  }
}
