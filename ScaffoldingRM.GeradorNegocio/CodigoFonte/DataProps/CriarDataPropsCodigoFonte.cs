using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.DataProps
{
  public class CriarDataPropsCodigoFonte : CodigoFonteBase
  {
    public string NomeTabela { get; }
    public CriarDataPropsCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte, string nomeTabela)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
      NomeTabela = nomeTabela;
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();
      ConfigCodigoFonte.Parametros.Add("NomeTabela", NomeTabela);
      ConfigCodigoFonte.Parametros.Add("ResourceDataProps", "S" + ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade); 
    }

  }
}
