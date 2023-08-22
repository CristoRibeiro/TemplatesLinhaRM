namespace ScaffoldingRM.GeradorNegocio.Enum
{

  public class TipoClasse
  {
    private TipoClasse(string value) { Value = value; }

    public string Value { get; private set; }

    public static TipoClasse Form { get { return new TipoClasse("Form"); } }
    public static TipoClasse Data { get { return new TipoClasse("Data"); } }
    public static TipoClasse Action { get { return new TipoClasse("Action"); } }
    public static TipoClasse Props { get { return new TipoClasse("Props"); } }
    public static TipoClasse ActionDesigner { get { return new TipoClasse("Action.Designer"); } }
    public static TipoClasse FormDesigner { get { return new TipoClasse("Form.Designer"); } }
    public static TipoClasse Modulo { get { return new TipoClasse("Mod"); } }
    public static TipoClasse DataSet { get { return new TipoClasse("DataSet"); } }
    public static TipoClasse DataSetDesigner { get { return new TipoClasse("DataSet.Designer"); } }
    public static TipoClasse DataSetXsd { get { return new TipoClasse("DataSetXsd"); } }
    public static TipoClasse RMSObject { get { return new TipoClasse("Obj"); } }
    public static TipoClasse ObjectItem { get { return new TipoClasse("ObjectItem"); } }
    public static TipoClasse InterfaceMod { get { return new TipoClasse("InterfaceMod"); } }

    public override string ToString()
    {
      return Value;
    }
  }
}
