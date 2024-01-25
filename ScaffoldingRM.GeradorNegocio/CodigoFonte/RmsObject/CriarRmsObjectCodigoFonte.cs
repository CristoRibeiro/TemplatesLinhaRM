using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Extensions;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsObject
{
  public class CriarRmsObjectCodigoFonte : CodigoFonteBase
  {
    public CriarRmsObjectCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();
      ConfigCodigoFonte.Parametros.Add("NomeEntidade", ConfigCodigoFonte.NomeEntidade);
      ConfigCodigoFonte.Parametros.Add("NomeDto", ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoDTO);
      ConfigCodigoFonte.Parametros.Add("NomeInstanciaDto", ConfigCodigoFonte.NomeEntidade.ToCamelCase() + Constantes.SufixoDTO);
    }
  }
}
