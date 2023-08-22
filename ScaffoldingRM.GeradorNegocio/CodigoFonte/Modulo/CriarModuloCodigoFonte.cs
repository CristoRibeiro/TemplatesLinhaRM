using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Extensions;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Modulo
{
  public class CriarModuloCodigoFonte : CodigoFonteBase
  {
    public CriarModuloCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();

      ConfigCodigoFonte.Parametros.Add("NomeClasseDto", ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoDTO);
      ConfigCodigoFonte.Parametros.Add("NomeInstanciaModulo", ConfigCodigoFonte.NomeEntidade);
      ConfigCodigoFonte.Parametros.Add("NomeObject", ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoObj);
      ConfigCodigoFonte.Parametros.Add("NomeIntanciaClasseDto", ConfigCodigoFonte.NomeEntidade.ToCamelCase() + Constantes.SufixoDTO);
    }
  }
}
