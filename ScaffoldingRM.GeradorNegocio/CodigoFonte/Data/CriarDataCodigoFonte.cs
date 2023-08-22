using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.Extensions;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Data
{
  public class CriarDataCodigoFonte : CodigoFonteBase
  {
    private string NomeTabela;
    public CriarDataCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
    }
    public CriarDataCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte, string nomeTabela)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
      NomeTabela = nomeTabela;
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();
      ConfigCodigoFonte.Parametros.Add("NomeResourceInfoServer", new NomeResourceInforServer(ConfigCodigoFonte.NomeEntidade).ToString());
      ConfigCodigoFonte.Parametros.Add("NomeClasseDataSet", ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade);
      ConfigCodigoFonte.Parametros.Add("NomeClasseDataProps", ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoProps);
      ConfigCodigoFonte.Parametros.Add("NomeTabela", NomeTabela ?? string.Empty);
      ConfigCodigoFonte.Parametros.Add("NomeModulo", ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoModulo);
      ConfigCodigoFonte.Parametros.Add("NomeDto", ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoDTO);
      ConfigCodigoFonte.Parametros.Add("NomeInstanciaModulo", ConfigCodigoFonte.NomeEntidade.ToCamelCase() + Constantes.SufixoModulo);
      ConfigCodigoFonte.Parametros.Add("NomeInstanciaDto", ConfigCodigoFonte.NomeEntidade.ToCamelCase() + Constantes.SufixoDTO);

    }
  }
}
