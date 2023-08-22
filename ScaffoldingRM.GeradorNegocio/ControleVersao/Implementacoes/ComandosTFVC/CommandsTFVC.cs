using System;
using System.Diagnostics;

namespace ScaffoldingRM.GeradorNegocio.ControleVersao.Implementacoes.ComandosTFVC
{
  public class CommandsTFVC : IControleVersao
  {
    private void ExecutarProcesso(string comando) {
      try
      {
        ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + comando);
        procStartInfo.RedirectStandardOutput = true;
        procStartInfo.UseShellExecute = false;
        procStartInfo.CreateNoWindow = true;

        Process proc = new Process();
        proc.StartInfo = procStartInfo;
        proc.Start();

        //string result = proc.StandardOutput.ReadToEnd();
      }
      catch (Exception)
      {
        throw;
      }
    }
    public void CheckOut(string arquivo)
    {
        string comando = $@"tf checkout {arquivo}";
        ExecutarProcesso(comando);
    }
    public void AddItem(string arquivo)
    {
      string comando = $@"tf add {arquivo}";
      ExecutarProcesso(comando);
    }
  }
}
