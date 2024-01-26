using ScaffoldingRM.GeradorNegocio.CodigoFonte.Modulo;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.ObjectItem;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsObject;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsServer;
using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public class FactoryCodigoFonteProcessAction : IFactoryCodigoFonte
  {
    public ICodigoFonte ObterIntancia(IDTOFonteBase dtoBase)
    {
      var processActionDto = (DTOFonteProcessAction)dtoBase;

      IGeradorCodigoFonte geradorCodigoFonte = GeradorCodigoFonteFactory.ObterInstancia();

      IConfigCodigoFonte configForm = FactoryConfigCodigoFonteProcessAction.ObterIntancia();
      configForm.NomeEntidade = processActionDto.NomeEntidade;
      configForm.Projeto = new Projeto(processActionDto.FullPathProjeto);


      var pathServer = processActionDto.FullPathProjeto.Replace(".Form.", ".Server.");
      pathServer = pathServer.Replace(".Form\\", ".Server\\");

      var pathIntf = processActionDto.FullPathProjeto.Replace(".Form.", ".Intf.");
      pathIntf = pathIntf.Replace(".Form\\", ".Intf\\");

      var processIntfDTO = new DTOFonteBase
      {
        FullPathProjeto = pathIntf,
        NomeEntidade = processActionDto.NomeEntidade
      };
      var processServerDTO = new DTOFonteBase
      {
        FullPathProjeto = pathServer,
        NomeEntidade = processActionDto.NomeEntidade
      };

      if (processActionDto.GerarProcessForm)
        configForm.FontesAdicionais.Add(TipoClasse.ProcessForm, new FactoryCodigoFonteProcessForm().ObterIntancia(processActionDto));

      if (processActionDto.GerarProcessServer)
        configForm.FontesAdicionais.Add(TipoClasse.ProcessServer, new FactoryCodigoFonteProcessServer().ObterIntancia(processServerDTO));

      if (processActionDto.GerarModulo)
        configForm.FontesAdicionais.Add(TipoClasse.Modulo , new FactoryCodigoFonteModulo().ObterIntancia(processServerDTO));

      if (processActionDto.GerarProcessParmsProc)
        configForm.FontesAdicionais.Add(TipoClasse.ProcessParamsProc, new FactoryCodigoFonteProcessParamsProc().ObterIntancia(processIntfDTO));
      
      if (processActionDto.GerarDto)
        configForm.FontesAdicionais.Add(TipoClasse.ObjectItem, new FactoryCodigoFonteObjectItem().ObterIntancia(processIntfDTO));

      if (processActionDto.GerarProcessRmsObject)
        configForm.FontesAdicionais.Add(TipoClasse.RMSObject , new FactoryCodigoFonteRmsObject().ObterIntancia(processServerDTO));

      if (processActionDto.GerarProcessRmsServer)
        configForm.FontesAdicionais.Add(TipoClasse.RMSServer, new FactoryCodigoFonteRmsServer().ObterIntancia(processServerDTO));

      return new CriarProcessActionCodigoFonte(configForm, geradorCodigoFonte);
    }
  }
}
