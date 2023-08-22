using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Base
{
  public abstract class CodigoFonteBase : ICodigoFonte
  {
    public IConfigCodigoFonte ConfigCodigoFonte { get; set; }
    public IGeradorCodigoFonte GeradorCodigoFonte { get; set; }

    public virtual void GerarCodigoFonte()
    {
      AdicionarParametros();
      GeradorCodigoFonte.GerarCodigoFonte(ConfigCodigoFonte);
    }

    public virtual ICodigoFonte ObterComandoAdicional(TipoClasse tipoClasse)
    {

      return ConfigCodigoFonte.FontesAdicionais[tipoClasse];
    }

    public virtual void AdicionarParametros()
    {
      ConfigCodigoFonte.Parametros.Add("NomeClasse", ConfigCodigoFonte.NomeClasse);

      var nomeNameSpace = ConfigCodigoFonte.Projeto.Nome.Substring(0, ConfigCodigoFonte.Projeto.Nome.LastIndexOf("."));
      var ultimoPontoArquivo = nomeNameSpace.LastIndexOf(".");

      if (ultimoPontoArquivo > 0)
        nomeNameSpace = nomeNameSpace.Substring(0, nomeNameSpace.LastIndexOf("."));

      ConfigCodigoFonte.Parametros.Add("NomeNameSpace", nomeNameSpace);
    }

  }
}
