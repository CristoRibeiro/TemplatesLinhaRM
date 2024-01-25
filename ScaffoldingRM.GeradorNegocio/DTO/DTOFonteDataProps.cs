namespace ScaffoldingRM.GeradorNegocio.DTO
{
  public class DTOFonteDataProps : IDTOFonteBase
  {
    public string NomeTabela { get; set; }
    public string NomeEntidade { get; set; }
    public string FullPathProjeto { get; set; }
  }
}
