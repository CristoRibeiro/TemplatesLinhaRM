using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Action
{
  public class CriarActionDesignerCodigoFonte : CodigoFonteBase
  {
    public CriarActionDesignerCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();
      ConfigCodigoFonte.Parametros.Add("NomeClasseForm", ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade + TipoClasse.Form);
      ConfigCodigoFonte.Parametros.Add("NomeClasseData", ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade + TipoClasse.Data);
    }
  }
}
