using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Action
{
  public class CriarActionCodigoFonte : CodigoFonteBase
  {
    public override void GerarCodigoFonte()
    {
      CriarPartialClass();
      base.GerarCodigoFonte();
    }

    public CriarActionCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
    }

    private void CriarPartialClass()
    {
      IConfigCodigoFonte configActionDesigner = FactoryConfigCodigoFonteActionDesigner.ObterIntancia();
      configActionDesigner.NomeEntidade = ConfigCodigoFonte.NomeEntidade;
      configActionDesigner.Projeto = new Projeto(ConfigCodigoFonte.Projeto.NomeProjetoCompleto);

      ConfigCodigoFonte.FontesAdicionais.Add(TipoClasse.ActionDesigner, new CriarActionDesignerCodigoFonte(configActionDesigner, GeradorCodigoFonte));
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();

      string nomeResource = Constantes.SSauCaption + ConfigCodigoFonte.NomeEntidade;
      ConfigCodigoFonte.Resources.Add(nomeResource);

      ConfigCodigoFonte.Parametros.Add("NomeCaptionForm", nomeResource);
      ConfigCodigoFonte.Parametros.Add("CodigoSeguranca", "0");
      ConfigCodigoFonte.Parametros.Add("TipoRmsAction", "RMSActionMasterView");

    }
  }
}
