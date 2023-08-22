using ScaffoldingRM.GeradorNegocio.CodigoFonte.DataProps;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.DataSet;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Modulo;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.ObjectItem;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsObject;
using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;
using ScaffoldingRM.GeradorNegocio.Util;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Data
{
  public static class FactoryCodigoFonteData
  {
    public static ICodigoFonte ObterIntancia(DTOFonteData DataDto)
    {
      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteData.ObterIntancia();
      configForm.NomeEntidade = DataDto.NomeEntidade;
      configForm.Projeto = new Projeto(DataDto.FullPathProjeto);

      var pathIntf = DataDto.FullPathProjeto.Replace(".Data.", ".Intf.");
      pathIntf = pathIntf.Replace(".Data\\", ".Intf\\");

      var pathServer = DataDto.FullPathProjeto.Replace(".Data", ".Server");
      pathServer = pathServer.Replace(".Data", ".Server");

      if (DataDto.GerarModulo)
      {
        var dtoModulo = new DTOFonteModulo
        {
          NomeEntidade = DataDto.NomeEntidade,
          FullPathProjeto = pathServer
        };

        configForm.FontesAdicionais.Add(TipoClasse.Modulo, FactoryCodigoFonteModulo.ObterIntancia(dtoModulo));
      }

      if (DataDto.GerarDataSet)
        configForm.FontesAdicionais.Add(TipoClasse.DataSet, FactoryCodigoFonteDataSet.ObterIntancia(DataDto.NomeEntidade, pathIntf, DataDto.NomeTabela));

      if (DataDto.GerarDataProps)
        configForm.FontesAdicionais.Add(TipoClasse.Props, FactoryCodigoFonteDataProps.ObterIntancia(DataDto.NomeEntidade, pathIntf, DataDto.NomeTabela));

      if (DataDto.GerarObjectItem)
        configForm.FontesAdicionais.Add(TipoClasse.ObjectItem, FactoryCodigoFonteObjectItem.ObterIntancia(DataDto.NomeEntidade, pathIntf));

      if (DataDto.GerarRmsObject)
        configForm.FontesAdicionais.Add(TipoClasse.RMSObject, FactoryCodigoFonteRmsObject.ObterIntancia(DataDto.NomeEntidade, pathServer));

      return new CriarDataCodigoFonte(configForm, geradorCodigoFonte, DataDto.NomeTabela);
    }
  }
}
