namespace ScaffoldingRM.GeradorNegocio.DTO
{
  public class DTOFonteProcessAction : IDTOFonteBase
  {
    public bool GerarProcessForm { get; set; }
    public bool GerarProcessServer { get; set; }
    public bool GerarProcessParmsProc { get; set; }
    public bool GerarProcessRmsObject { get; set; }
    public bool GerarProcessRmsServer { get; set; }
    public bool GerarModulo { get; set; }
    public bool GerarDto { get; set; }
    public string NomeEntidade { get; set; }
    public string FullPathProjeto { get; set; }
  }
}