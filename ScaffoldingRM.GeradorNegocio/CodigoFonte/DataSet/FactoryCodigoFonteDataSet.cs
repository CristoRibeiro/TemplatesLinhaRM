using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.DataSet
{
  public static class FactoryCodigoFonteDataSet
  {
    public static ICodigoFonte ObterIntancia(string nomeEntidade, string pathProjeto, string nomeTabela)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configDataSet = FactoryConfigCodigoFonteDataSet.ObterIntancia();
      configDataSet.NomeEntidade = nomeEntidade;
      configDataSet.Projeto = new Projeto(pathProjeto);
      
      return new CriarDataSetCodigoFonte(configDataSet, geradorCodigoFonte, nomeTabela);
    }
  }
}
