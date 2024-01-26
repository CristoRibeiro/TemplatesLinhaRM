using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;
using System.Linq;
using System.Reflection.Metadata;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public class CriarProcessServerCodigoFonte : CodigoFonteBase
  {
    public CriarProcessServerCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();

      string nomeResource = Constantes.SSauInfoServer + ConfigCodigoFonte.NomeEntidade;
      ConfigCodigoFonte.Resources.Add(nomeResource);

      ConfigCodigoFonte.Parametros.Add("InfoServer", nomeResource);
      ConfigCodigoFonte.Parametros.Add("NomeEntidade", ConfigCodigoFonte.NomeEntidade);
      ConfigCodigoFonte.Parametros.Add("NomeParamsProc", Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoParamsProc);
      ConfigCodigoFonte.Parametros.Add("NomeDto", Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoDTO);
      ConfigCodigoFonte.Parametros.Add("NomeInterfaceModulo", "I" + Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoModulo);
      ConfigCodigoFonte.Parametros.Add("NomeModulo", Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoModulo);

    }
  }
}