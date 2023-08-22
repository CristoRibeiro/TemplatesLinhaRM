namespace ScaffoldingRM.GeradorNegocio.Common
{
  public struct NomeResourceInforServer
  {
    private string nomeResource;
    public NomeResourceInforServer(string nomeEntidade)
    {
      nomeResource = string.Format("SSauInfoServer{0}", nomeEntidade);
    }

    public override string ToString()
    {
      return nomeResource;
    }
  }
}
