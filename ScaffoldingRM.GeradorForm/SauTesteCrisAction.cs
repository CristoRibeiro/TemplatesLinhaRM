
namespace ScaffoldingRM.Form
{
    [ActionInfo(typeof(Properties.Resources), nameof(Properties.Resources.SSCaptionTesteCris), CodSistema.Sau, 0)]
    public partial class SauTesteCrisAction : RMSActionView
    {
	    public SauTesteCrisAction(){
	        InitializeComponent();
	    }

        public SauTesteCrisAction(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }
}