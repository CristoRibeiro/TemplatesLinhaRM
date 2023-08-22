namespace ScaffoldingRM.GeradorNegocio.ControleVersao
{
  public interface IControleVersao
  {
    void CheckOut(string arquivo);
    void AddItem(string arquivo);
  }
}
