using ScaffoldingRM.GeradorNegocio.CodigoFonte.DataProps;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.DataSet;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Modulo;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.ObjectItem;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsObject;
using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Data
{
  public class FactoryCodigoFonteData : IFactoryCodigoFonte
  {
    const string EXTENSION_DATA = ".Data";
    const string EXTENSION_INTF = ".Intf";
    const string EXTENSION_SERVER = ".Server";

    public ICodigoFonte ObterIntancia(IDTOFonteBase dtoBase)
    {
      var dataDto = (DTOFonteData)dtoBase;

      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteData.ObterIntancia();
      configForm.NomeEntidade = dataDto.NomeEntidade;
      configForm.Projeto = new Projeto(dataDto.FullPathProjeto);

      var pathIntf = dataDto.FullPathProjeto.Replace($"{EXTENSION_DATA}.", $"{EXTENSION_INTF}.");
      pathIntf = pathIntf.Replace($"{EXTENSION_DATA}\\", $"{EXTENSION_INTF}\\");

      var pathServer = dataDto.FullPathProjeto.Replace(EXTENSION_DATA, EXTENSION_SERVER);
      pathServer = pathServer.Replace(EXTENSION_DATA, EXTENSION_SERVER);

      if (dataDto.GerarModulo)
      {
        IDTOFonteBase dtoModulo = new DTOFonteModulo
        {
          NomeEntidade = dataDto.NomeEntidade,
          FullPathProjeto = pathServer
        };

        configForm.FontesAdicionais.Add(TipoClasse.Modulo, new FactoryCodigoFonteModulo().ObterIntancia(dtoModulo));
      }

      if (dataDto.GerarDataSet)
      {
        IDTOFonteBase dtoDataSet = new DTOFonteDataSet
        {
          NomeEntidade = dataDto.NomeEntidade,
          FullPathProjeto = pathIntf,
          NomeTabela = dataDto.NomeTabela
        };
        configForm.FontesAdicionais.Add(TipoClasse.DataSet, new FactoryCodigoFonteDataSet().ObterIntancia(dtoDataSet));
      }


      if (dataDto.GerarDataProps)
      {
        IDTOFonteBase dtoDataProps = new DTOFonteDataProps
        {
          NomeEntidade = dataDto.NomeEntidade,
          FullPathProjeto = pathIntf,
          NomeTabela = dataDto.NomeTabela
        };
        configForm.FontesAdicionais.Add(TipoClasse.Props, new FactoryCodigoFonteDataProps().ObterIntancia(dtoDataProps));
      }

      if (dataDto.GerarObjectItem)
      {
        IDTOFonteBase dtoObjectItem = new DTOFonteModulo
        {
          FullPathProjeto = pathIntf,
          NomeEntidade = dataDto.NomeEntidade
        };

        configForm.FontesAdicionais.Add(TipoClasse.ObjectItem, new FactoryCodigoFonteObjectItem().ObterIntancia(dtoObjectItem));
      }

      if (dataDto.GerarRmsObject)
      {
        IDTOFonteBase dtoRMSObject = new DTOFonteModulo
        {
          FullPathProjeto = pathServer,
          NomeEntidade = dataDto.NomeEntidade
        };
        configForm.FontesAdicionais.Add(TipoClasse.RMSObject, new FactoryCodigoFonteRmsObject().ObterIntancia(dtoRMSObject));
      } 

      return new CriarDataCodigoFonte(configForm, geradorCodigoFonte, dataDto.NomeTabela);
    }
  }
}
