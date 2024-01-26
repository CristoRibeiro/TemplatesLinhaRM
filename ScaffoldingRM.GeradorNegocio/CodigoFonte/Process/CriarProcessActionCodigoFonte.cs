using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Interface;
using System;
using System.Resources;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public class CriarProcessActionCodigoFonte : CodigoFonteBase
  {
    public CriarProcessActionCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();

      string nomeResource = Constantes.SSauCaption + ConfigCodigoFonte.NomeEntidade;
      ConfigCodigoFonte.Resources.Add(nomeResource);

      ConfigCodigoFonte.Parametros.Add("TipoRmsAction", "RMSActionProc");
      ConfigCodigoFonte.Parametros.Add("NomeCaptionForm", nomeResource);
      ConfigCodigoFonte.Parametros.Add("NomeClasseForm", Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoFormProc);
      ConfigCodigoFonte.Parametros.Add("NomeClasseServer", Constantes.PrefixoSaude + ConfigCodigoFonte.NomeEntidade + Constantes.SufixoProcessProc);
    }
  }
}