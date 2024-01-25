namespace ScaffoldingRM.GeradorNegocio.DTO
{
  public class DTOFonteDataSet : IDTOFonteBase
  {
    public string NomeTabela { get; set; }
    public string NomeEntidade { get; set; }
    public string FullPathProjeto { get; set; }
  }
}
