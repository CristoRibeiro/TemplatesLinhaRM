namespace ScaffoldingRM.GeradorNegocio.DTO
{
  public class DTOFonteForm : IDTOFonteBase
  {
    public bool GerarData { get; set; }
    public bool GerarAction { get; set; }
    public string FullPathProjetoAction { get; set; }
    public DTOFonteData DtoData { get; set; }
    public string NomeEntidade { get; set; }
    public string FullPathProjeto { get; set; }
  }
}