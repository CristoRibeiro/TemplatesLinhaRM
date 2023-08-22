using Microsoft.IO;
using ScaffoldingRM.GeradorNegocio.Util;

namespace ScaffoldingRM.GeradorNegocio.Common
{
  public  class Projeto
  {
    public string Diretorio { get; }
    public string Nome { get; }
    public string NomeProjetoCompleto { get; }
    
    public Projeto(string fullPath)
    {
      FileInfo fileInfo = new FileInfo(fullPath);

      Diretorio = fileInfo.DirectoryName ;
      Nome = fileInfo.Name;
      NomeProjetoCompleto = fullPath;
    }
  }
}
