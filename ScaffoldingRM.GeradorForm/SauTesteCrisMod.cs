using RM.Lib;
using RM.Lib.Notification;
using RM.Lib.Server;
using RM.Sau.ScaffoldingRM.Intf;

namespace ScaffoldingRM.Server
{
  public class SauTesteCrisMod : RMSModule, ISauTesteCrisMod
  {
    public ObjectList<SauTesteCrisDto> ObterListaSauTesteCrisMod (int codColigada, int codTesteCris )
    {
      using (var obj = CreateObject<SauTesteCrisObj>())
        return obj.ObterListaSauTesteCrisMod(codColigada, codTesteCris);
    }

    public INotification ValidarRegistro(SauTesteCrisDto testeCrisDto)
    {

      var notification = Notification.Instance;

      if (ExisteRegistro( testeCrisDto))
        notification.AddWarning(Properties.Resources.SSauMsgErroJaExiste);

      return notification;
    }

    public bool ExisteRegistro(SauTesteCrisDto testeCrisDto)
    {
      using (var obj = CreateObject<SauTesteCrisObj>())
      {
        return obj.ExisteRegistro(testeCrisDto);
      }
    }
  }
}

