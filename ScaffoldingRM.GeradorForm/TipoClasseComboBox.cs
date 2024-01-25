using ScaffoldingRM.GeradorNegocio.Enum;

namespace ScaffoldingRM.GeradorForm
{
  public class TipoClasseComboBox
  {
    public string Nome { get; set; }
    public TipoClasse TipoClasse { get; set; }

    public TipoClasseComboBox(string nome, TipoClasse tipoClasse)
    {
      Nome = nome;
      TipoClasse = tipoClasse;
    }
  }
}
