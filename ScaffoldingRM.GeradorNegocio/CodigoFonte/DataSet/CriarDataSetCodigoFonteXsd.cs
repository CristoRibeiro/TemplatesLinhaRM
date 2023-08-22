using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public class CriarDataSetCodigoFonteXsd : CodigoFonteBase
  {
    public string NomeTabela { get; set; }
    public CriarDataSetCodigoFonteXsd(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte, string nomeTabela)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
      NomeTabela = nomeTabela;
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();
      ConfigCodigoFonte.Parametros.Add("NomeTabela", NomeTabela);
    }
  }
}