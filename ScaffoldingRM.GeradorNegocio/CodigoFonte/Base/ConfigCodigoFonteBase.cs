using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.Enum;
using ScaffoldingRM.GeradorNegocio.Interface;
using System.Collections.Generic;

namespace ScaffoldingRM.GeradorNegocio.CodigoFonte.Base
{
  public class ConfigCodigoFonteBase : IConfigCodigoFonte
  {
    private IDictionary<TipoClasse, ICodigoFonte> comandosAdicionais;
    private IDictionary<string, string> parametros;
    private IList<string> resources;
    public string NomeEntidade { get; set; }
    public Projeto Projeto { get; set; }
    public IDictionary<string, string> Parametros
    {
      get
      {
        if (parametros == null)
        {
          parametros = new Dictionary<string, string>();
        }
        return parametros;
      }
    }
    public IDictionary<TipoClasse, ICodigoFonte> FontesAdicionais
    {
      get
      {
        if (comandosAdicionais == null)
        {
          comandosAdicionais = new Dictionary<TipoClasse, ICodigoFonte>();
        }
        return comandosAdicionais;
      }
    }
    public string Prefixo { get; private set; }
    public string TipoClasse { get; set; }
    public string Sufixo { get; protected set; }
    public string Template { get; protected set; }
    public string Extensao { get; protected set; }
    public virtual string NomeClasse => $@"{Prefixo}{NomeEntidade}{Sufixo}";
    public virtual string NomeArquivo => $@"{Prefixo}{NomeEntidade}{Sufixo}";
    public IList<string> Resources
    {
      get
      {
        if (resources == null)
        {
          resources = new List<string>();
        }
        return resources;
      }
    }
    public ConfigCodigoFonteBase(string sufixo, string prefixo, string template, string extensao)
    {
      Sufixo = sufixo;
      Prefixo = prefixo;
      Template = template;
      Extensao = extensao;
    }
  }
}
