using ScaffoldingRM.GeradorNegocio.CodigoFonte.Base;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Form;
using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.DataSet
{
  public class CriarDataSetCodigoFonte : CodigoFonteBase
  {
    public string NomeTabela { get; set; }
    public CriarDataSetCodigoFonte(IConfigCodigoFonte configCodigoFonte, IGeradorCodigoFonte geradorCodigoFonte, string nomeTabela)
    {
      ConfigCodigoFonte = configCodigoFonte;
      GeradorCodigoFonte = geradorCodigoFonte;
      NomeTabela = nomeTabela;
    }

    public override void GerarCodigoFonte()
    {
      CriarPartialClass();
      base.GerarCodigoFonte();
    }

    public override void AdicionarParametros()
    {
      base.AdicionarParametros();

      ConfigCodigoFonte.Parametros.Add("NomeClasseProps", ConfigCodigoFonte.Prefixo + ConfigCodigoFonte.NomeEntidade + TipoClasse.Props);
      ConfigCodigoFonte.Parametros.Add("NomeTabela", NomeTabela);
    }

    private void CriarPartialClass()
    {
      IConfigCodigoFonte configDataSetXsd = FactoryConfigCodigoFonteDataSetXsd.ObterIntancia();
      configDataSetXsd.NomeEntidade = ConfigCodigoFonte.NomeEntidade;
      configDataSetXsd.Projeto = new Projeto(ConfigCodigoFonte.Projeto.NomeProjetoCompleto);

      IConfigCodigoFonte configDataSetDesigner = FactoryConfigCodigoFonteDataSetDesigner.ObterIntancia();
      configDataSetDesigner.NomeEntidade = ConfigCodigoFonte.NomeEntidade;
      configDataSetDesigner.Projeto = new Projeto(ConfigCodigoFonte.Projeto.NomeProjetoCompleto);

      ConfigCodigoFonte.FontesAdicionais.Add(TipoClasse.DataSetXsd, new CriarDataSetCodigoFonteXsd(configDataSetXsd, GeradorCodigoFonte, NomeTabela));
      ConfigCodigoFonte.FontesAdicionais.Add(TipoClasse.DataSetDesigner, new CriarDataSetCodigoFonteDesigner(configDataSetDesigner, GeradorCodigoFonte, NomeTabela));
    }
  }
}
