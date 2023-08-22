using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Form
{
  public class CriarFormCodigoFonte : CodigoFonteBase
  {
    public CriarFormCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
    }

    public override void GerarCodigoFonte()
    {
      CriarPartialClass();
      base.GerarCodigoFonte();
    }

    private void CriarPartialClass()
    {
      IConfigCodigoFonte configFormDesigner = FactoryConfigCodigoFonteFormDesigner.ObterIntancia();
      configFormDesigner.NomeEntidade = ConfigCodigoFonte.NomeEntidade;
      configFormDesigner.Projeto = new Projeto(ConfigCodigoFonte.Projeto.NomeProjetoCompleto);

      ConfigCodigoFonte.FontesAdicionais.Add(TipoClasse.FormDesigner, new CriarFormCodigoFonteDesigner(configFormDesigner, GeradorCodigoFonte));
    }
  }
}
