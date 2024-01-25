using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Extensions;
using ScaffoldingRM.GeradorNegocio.Interface;
using System.Linq;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Modulo
{
  public class CriarInterfaceModuloCodigoFonte : CodigoFonteBase
  {
    public CriarInterfaceModuloCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();

      ConfigCodigoFonte.Parametros.Add("NomeClasseDto", Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoDTO);
      ConfigCodigoFonte.Parametros.Add("NomeClasseModulo", Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoModulo);
      ConfigCodigoFonte.Parametros.Add("NomeEntidade",   ConfigCodigoFonte.NomeEntidade);
      ConfigCodigoFonte.Parametros.Add("NomeInstanciaClasseDto", ConfigCodigoFonte.NomeEntidade.ToCamelCase() + Constantes.SufixoDTO);
    }
  }
}
