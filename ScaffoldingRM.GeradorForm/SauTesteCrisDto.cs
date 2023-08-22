using RM.Lib;
using RM.Sau.Lib;
using System;
using System.Runtime.Serialization;

namespace ScaffoldingRM.Intf
{
  [Serializable]
  [DataContract(Namespace = SauConsts.TOTVSNameSpace)]
  public class SauTesteCrisDto : ObjectItem
  {
    [DataMember]
    [Column(Name = "CODCOLIGADA")]
    public int CodColigada { get; set; }
  }
}
