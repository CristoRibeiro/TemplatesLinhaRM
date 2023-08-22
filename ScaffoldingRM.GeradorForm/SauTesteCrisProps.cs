using RM.Lib;
using ScaffoldingRM.Intf.Properties

namespace ScaffoldingRM.Intf
{
  public class SauTesteCrisProps : DataSetProperties
  {
    public const string sztestecris = "SZTESTECRIS";

    public SauTesteCrisProps(System.Data.DataSet dataSet)
    {
      System.Data.DataTable szTesteCris = dataSet.Tables[sztestecris];
      if (sztestecris != null)
      {
        DataProps.SetProps(sztestecris, TabProps.Caption, Resources.SSauTesteCris);

        DataProps.SetProps(szTesteCris, "CODCOLIGADA",
          ColProps.Caption, Resources.SSauCaptionCODCOLIGADA,
          ColProps.MaxLength, -1,
          ColProps.AllowDBNull, false,
          ColProps.AllowInsert, true,
          ColProps.AllowEdit, false,
          ColProps.AllowFilter, false,
          ColProps.Visible, false);
     }
  }
 }
}
