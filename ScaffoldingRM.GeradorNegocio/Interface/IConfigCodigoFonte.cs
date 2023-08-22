using ScaffoldingRM.GeradorNegocio.Common;
using ScaffoldingRM.GeradorNegocio.Enum;
using System.Collections.Generic;

namespace ScaffoldingRM.GeradorNegocio.Interface
{
  public interface IConfigCodigoFonte
  {
    string NomeEntidade { get; set; }
    Projeto Projeto { get; set; }
    IDictionary<string, string> Parametros { get; }
    IDictionary<TipoClasse, ICodigoFonte> FontesAdicionais { get; }
    string Prefixo { get; }
    string Sufixo { get; }
    string Template { get; }
    string Extensao { get; }
    string NomeClasse { get; }
    string NomeArquivo { get; }
  }
}
