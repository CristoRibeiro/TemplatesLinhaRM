namespace ScaffoldingRM.GeradorNegocio.DTO
{
  public class DTOFonteForm : DTOFonteBase
  {
    public bool GerarData { get; set; }
    public bool GerarAction { get; set; }
    public string FullPathProjetoAction { get; set; }
    public DTOFonteData DtoData { get; set; }
  }
}