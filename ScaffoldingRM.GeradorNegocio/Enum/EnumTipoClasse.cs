using ScaffoldingRM.GeradorNegocio.CodigoFonte.Action;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.DataProps;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.DataSet;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Form;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Modulo;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.ObjectItem;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.RmsObject;
using ScaffoldingRM.GeradorNegocio.Interface;

namespace ScaffoldingRM.GeradorNegocio.Enum
{

  public class TipoClasse
  {
    private TipoClasse(string value, IFactoryCodigoFonte factoryCodigoFonte, string descricao)
    {
      Value = value;
      FactoryCodigoFonte = factoryCodigoFonte;
      Descricao = descricao;
    }

    public string Value { get; private set; }
    public IFactoryCodigoFonte FactoryCodigoFonte { get; private set; }
    public string Descricao { get; private set; }

    public static TipoClasse Form { get { return new TipoClasse("Form", new FactoryCodigoFonteForm(),"Form"); } }
    public static TipoClasse Data { get { return new TipoClasse("Data", new FactoryCodigoFonteData(), "Data"); } }
    public static TipoClasse Action { get { return new TipoClasse("Action", new FactoryCodigoFonteAction(), "Action"); } }
    public static TipoClasse Props { get { return new TipoClasse("Props", new FactoryCodigoFonteDataProps(), "DataProps"); } }
    public static TipoClasse ActionDesigner { get { return new TipoClasse("Action.Designer", null, "ActionDesigner"); } }
    public static TipoClasse FormDesigner { get { return new TipoClasse("Form.Designer", null, "FormDesigner"); } }
    public static TipoClasse Modulo { get { return new TipoClasse("Mod", new FactoryCodigoFonteModulo(), "Módulo"); } }
    public static TipoClasse DataSet { get { return new TipoClasse("DataSet", new FactoryCodigoFonteDataSet(), "DataSet"); } }
    public static TipoClasse DataSetDesigner { get { return new TipoClasse("DataSet.Designer", null, "DataSetDesigner"); } }
    public static TipoClasse DataSetXsd { get { return new TipoClasse("DataSetXsd", null, "DataSetXsd"); } }
    public static TipoClasse RMSObject { get { return new TipoClasse("Obj", new FactoryCodigoFonteRmsObject(), "RMSObject"); } }
    public static TipoClasse ObjectItem { get { return new TipoClasse("ObjectItem", new FactoryCodigoFonteObjectItem(), "ObjectItem"); } }
    public static TipoClasse InterfaceMod { get { return new TipoClasse("InterfaceMod", null, "InterfaceModulo"); } }

    public override string ToString()
    {
      return Value;
    }
  }
}
