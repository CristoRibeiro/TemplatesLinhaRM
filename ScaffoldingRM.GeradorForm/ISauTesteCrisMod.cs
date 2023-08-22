using ScaffoldingRM.Intf;
using RM.Sau.Lib;
using System;
using System.ServiceModel;

namespace ScaffoldingRM.Intf.Interfaces
{
  [ServiceContract(Namespace = SauConsts.TOTVSNameSpace)]
  public interface IISauTesteCrisMod : IRMSModule
  {
    [OperationContract]
    ObjectList<ISauTesteCrisDto> ObterListaISauTesteCrisMod (int codColigada, int codTesteCris );

    [OperationContract]
    bool ExisteRegistro(ISauTesteCrisDto testeCrisDto);
  }
}
