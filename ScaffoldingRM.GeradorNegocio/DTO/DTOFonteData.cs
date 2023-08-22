namespace ScaffoldingRM.GeradorNegocio.DTO
{
  public class DTOFonteData : DTOFonteBase
  {
    public string NomeTabela { get; set; }
    public bool GerarModulo { get; set; }
    public bool GerarObjectItem { get; set; }
    public bool GerarRmsObject { get; set; }
    public bool GerarDataProps { get; set; }
    public bool GerarDataSet { get; set; }

  }
}
