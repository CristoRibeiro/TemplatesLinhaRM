using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public class CriarFormCodigoFonteDesigner : CodigoFonteBase
  {
    public CriarFormCodigoFonteDesigner(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
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
