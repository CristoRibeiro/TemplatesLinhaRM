namespace ScaffoldingRM.GeradorNegocio.Interface
{
  public interface ICodigoFonte
  {
    IConfigCodigoFonte ConfigCodigoFonte { get; set; }
    IGeradorCodigoFonte GeradorCodigoFonte { get; set; }
    void GerarCodigoFonte();
  }
}
