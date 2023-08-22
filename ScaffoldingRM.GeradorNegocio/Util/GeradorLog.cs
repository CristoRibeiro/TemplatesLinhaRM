using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaffoldingRM.GeradorNegocio.Util
{
  public static class GeradorLog
  {
    public static void Gerar(string mensagem) {
      var diretorioLog = @"c:\log.txt";

      if (!File.Exists(diretorioLog))
      {
        FileStream arquivo = File.Create(diretorioLog);
        arquivo.Close();
      }
      using (StreamWriter w = File.AppendText(diretorioLog))
      {
        w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");        
        w.WriteLine($"{mensagem}");
      }
    }
  }
}
