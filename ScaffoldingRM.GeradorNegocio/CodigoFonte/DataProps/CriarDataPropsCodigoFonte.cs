using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
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

      string nomeResource = "S" + ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade;
      ConfigCodigoFonte.Resources.Add(nomeResource);

      ConfigCodigoFonte.Parametros.Add("NomeTabela", NomeTabela);
      ConfigCodigoFonte.Parametros.Add("ResourceDataProps", nomeResource); 
    }

  }
}
