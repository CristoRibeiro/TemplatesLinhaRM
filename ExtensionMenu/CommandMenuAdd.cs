using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using ScaffoldingRM.GeradorForm;
using ScaffoldingRM.GeradorNegocio.CodigoFonte.Form;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Task = System.Threading.Tasks.Task;

namespace ExtensionMenu
{
  /// <summary>
  /// Command handler
  /// </summary>
  internal sealed class CommandMenuAdd
  {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 0x0100;
    //public const int CommandIdSec = 0x0101; 
    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("b7917b4f-00ee-4e90-ada8-64f279a56190");

    /// <summary>
    /// VS Package that provides this command, not null.
    /// </summary>
    private readonly AsyncPackage package;

    /// <summary>
    /// Initializes a new instance of the <see cref="CommandMenuAdd"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="package">Owner package, not null.</param>
    /// <param name="commandService">Command service to add command to, not null.</param>
    private CommandMenuAdd(AsyncPackage package, OleMenuCommandService commandService)
    {
      this.package = package ?? throw new ArgumentNullException(nameof(package));
      commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

      var menuCommandID = new CommandID(CommandSet, CommandId);
      var menuItem = new MenuCommand(this.Execute, menuCommandID);

      //var menuCommandIDSec = new CommandID(CommandSet, CommandIdSec);
      //var menuItemSec = new MenuCommand(this.Execute, menuCommandIDSec);

      commandService.AddCommand(menuItem);
      //commandService.AddCommand(menuItemSec);
    }


    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public static CommandMenuAdd Instance
    {
      get;
      private set;
    }

    /// <summary>
    /// Gets the service provider from the owner package.
    /// </summary>
    private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider
    {
      get
      {
        return this.package;
      }
    }

    /// <summary>
    /// Initializes the singleton instance of the command.
    /// </summary>
    /// <param name="package">Owner package, not null.</param>
    public static async Task InitializeAsync(AsyncPackage package)
    {
      // Switch to the main thread - the call to AddCommand in CommandMenuAdd's constructor requires
      // the UI thread.
      await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

      OleMenuCommandService commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
      Instance = new CommandMenuAdd(package, commandService);
    }

    /// <summary>
    /// This function is the callback used to execute the command when the menu item is clicked.
    /// See the constructor to see how the menu item is associated with this function using
    /// OleMenuCommandService service and MenuCommand class.
    /// </summary>
    /// <param name="sender">Event sender.</param>
    /// <param name="e">Event args.</param>
    private void Execute(object sender, EventArgs e)
    {
      var item = GetSelectedSolutionExplorerItem();

      var assemblyName = item.FullName;

      ThreadHelper.ThrowIfNotOnUIThread();
      
      var form = new GeradorActionForm(assemblyName);
      

      form.Show();
    }

    private EnvDTE.Project GetSelectedSolutionExplorerItem()
    {
      ThreadHelper.ThrowIfNotOnUIThread();
      var dte = ServiceProvider.GetServiceAsync(typeof(DTE)).Result as DTE2;
      if (dte == null) return null;
      UIHierarchy solutionExplorer = dte.ToolWindows.SolutionExplorer;
      object[] items = solutionExplorer.SelectedItems as object[];
      if (items.Length != 1)
        return null;

      return items.Cast<UIHierarchyItem>().FirstOrDefault().Object as Project;

    }

  }
}
