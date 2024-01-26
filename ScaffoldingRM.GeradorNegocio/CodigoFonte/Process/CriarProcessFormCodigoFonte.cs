using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public class CriarProcessFormCodigoFonte : CodigoFonteBase
  {
    public CriarProcessFormCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();

      ConfigCodigoFonte.Parametros.Add("TipoRmsForm", "RMSFormParamsProc");
      ConfigCodigoFonte.Parametros.Add("NomeInterfaceServer", "I" + Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoServer);
      ConfigCodigoFonte.Parametros.Add("NomeServer", Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoServer);
      ConfigCodigoFonte.Parametros.Add("NomeParamsProc", Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoParamsProc);
    }
  }
}