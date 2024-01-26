using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Extensions;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsServer
{
  public class CriarRmsServerCodigoFonte : CodigoFonteBase
  {
    public CriarRmsServerCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();

      var nomeResource = Constantes.SSauInfoServer + ConfigCodigoFonte.NomeEntidade;
      ConfigCodigoFonte.Resources.Add(nomeResource);

      ConfigCodigoFonte.Parametros.Add("NomeEntidade", ConfigCodigoFonte.NomeEntidade);
      ConfigCodigoFonte.Parametros.Add("NomeResource", nomeResource); 
      ConfigCodigoFonte.Parametros.Add("NomeModulo", Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoModulo);
      ConfigCodigoFonte.Parametros.Add("NomeDto", ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoDTO);
      ConfigCodigoFonte.Parametros.Add("NomeInstanciaDto", ConfigCodigoFonte.NomeEntidade.ToCamelCase() + Constantes.SufixoDTO);
    }
  }
}