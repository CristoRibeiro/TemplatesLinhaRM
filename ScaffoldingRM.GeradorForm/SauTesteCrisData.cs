using System.Data;
using RM.Lib;
using RM.Lib.Server;
using RM.Lib.Notification;
using ScaffoldingRM.Intf;


namespace ScaffoldingRM.Data
{
  [System.ServiceModel.ServiceBehavior(IncludeExceptionDetailInFaults = true)]
  [RMSServerInfo(typeof(Properties.Resources), nameof(Properties.Resources.SSauInfoServerTesteCris), CodSistema.Sau)]
  [RMSServerSecurityInfo(typeof(Properties.Resources), nameof(Properties.Resources.SSauInfoServerTesteCris), CodSistema.Sau, 0)]
  [RMSSecurityFilter()]
  public class SauTesteCrisData : RMSDataServer 
  { 
	private string _sqlBase = @"";

	protected override void DoGetDataSet(out DataSet dataSet)
	{
		dataSet = new SauTesteCris();
	}

	protected override void DoReadView(DataSet dataSet, object[] filter, object ownerData)
	{
		string sql = _sqlBase + " /*WHERE*/";
		DBS.QueryFill(dataSet, SauTesteCrisProps.sztestecris, sql, 0, 0, filter);
	}

	protected override void DoReadRecord(DataSet dataSet, object[] primaryKey, object ownerData)
	{
		string sql = _sqlBase + @"WHERE CAMPOSCHAVES";
	
		DBS.QueryFill(dataSet, SauTesteCrisProps.sztestecris, sql, primaryKey);
	}

	protected override void ValidateRow(DataRow row)
	{
		INotification notification = Notification.Instance;
	
		using (var dbo = new DataObjects())
		using (var testeCrisMod = CreateModule<ISauTesteCrisMod>("SauTesteCrisMod>"))
		{
			var testeCrisDto = dbo.ReadFromRow<SauTesteCrisDto>(row);
		
		/* Validações utilizando o módulo */
		};

		if (notification.HasAnyNotification)
			throw new RMSValidateException(notification.GetMessages());
	}	
  }
}