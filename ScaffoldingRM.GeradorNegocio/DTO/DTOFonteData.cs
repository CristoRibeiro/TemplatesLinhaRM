namespace ScaffoldingRM.GeradorNegocio.DTO
{
  public class DTOFonteData : IDTOFonteBase
  {
    public string NomeTabela { get; set; }
    public bool GerarModulo { get; set; }
    public bool GerarObjectItem { get; set; }
    public bool GerarRmsObject { get; set; }
    public bool GerarDataProps { get; set; }
    public bool GerarDataSet { get; set; }
    public string NomeEntidade { get; set; }
    public string FullPathProjeto { get; set; }
  }
}
