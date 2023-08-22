using ScaffoldingRM.GeradorNegocio.CodigoFonte.Form;
using ScaffoldingRM.GeradorNegocio.DTO;
using System;
using System.Windows.Forms;

namespace ScaffoldingRM.GeradorForm
{
  public partial class GeradorActionForm : Form
  {
    const string PREFIXOSAUDE = "Sau";
    const string SUFIXOFORM = "Form";

    public GeradorActionForm(string project)
    {
      InitializeComponent();
      txtProject.Text = project;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        DTOFonteForm dtoForm = new DTOFonteForm()
        {
          NomeEntidade = txtNomeForm.Text,
          FullPathProjeto = txtProject.Text,
          GerarAction = ckbGeraAction.Checked,
          GerarData = ckbGeraData.Checked,
          FullPathProjetoAction = txtProjectAction.Text,
          DtoData = new DTOFonteData
          {
            NomeEntidade = txtNomeForm.Text,
            FullPathProjeto = txtProjectData.Text,
            GerarDataProps = ckbGerarDataProps.Checked,
            GerarDataSet = ckbGerarDataSet.Checked,
            GerarModulo = ckbGerarModulo.Checked,
            GerarObjectItem = ckbGerarObjectItem.Checked,
            NomeTabela = txtTabela.Text,
            GerarRmsObject = ckbRmsObject.Checked
          }

        };

        var comando = FactoryCodigoFonteForm.ObterIntancia(dtoForm);
        comando.GerarCodigoFonte();
        Close();

      }
      catch (Exception ex)
      {
        MessageBox.Show("Ocorreu uma falha ao gerar o scaffolding. " + ex.Message);
      }
    }

    private void ckbGeraData_CheckedChanged(object sender, EventArgs e) => HabilitaGerarData();

    private void ckbGeraAction_CheckedChanged(object sender, EventArgs e) => HabilitaGerarAction();

    private void HabilitaGerarData()
    {
      gpbData.Enabled = ckbGeraData.Checked;

      foreach (Control item in gpbData.Controls)
      {
        item.Enabled = ckbGeraData.Checked;

        if (item.GetType().Equals(typeof(TextBox)))
          item.Text = ckbGeraData.Checked ? item.Text : string.Empty;
      }

      if (ckbGeraData.Checked)
      {
        txtProjectData.Text = txtProject.Text.Replace(".Form.", ".Data.");
        txtProjectData.Text = txtProjectData.Text.Replace(".Form\\", ".Data\\");
      }
    }

    private void HabilitaGerarAction()
    {
      gpbAction.Enabled = ckbGeraAction.Checked;

      foreach (Control item in gpbAction.Controls)
      {
        item.Enabled = ckbGeraAction.Checked;

        if (item.GetType().Equals(typeof(TextBox)))
          item.Text = ckbGeraAction.Checked ? item.Text : string.Empty;
      }

      if (ckbGeraAction.Checked)
        txtProjectAction.Text = txtProject.Text;
    }

    private void txtNomeForm_TextChanged(object sender, EventArgs e)
    {
      if (!string.IsNullOrWhiteSpace(txtNomeForm.Text))
        txtSaidaAction.Text = PREFIXOSAUDE + txtNomeForm.Text + SUFIXOFORM;
      else
        txtSaidaAction.Text = string.Empty;
    }

    private void GeradorActionForm_Load(object sender, EventArgs e)
    {
      ckbGeraAction.Checked = true;
      ckbGeraData.Checked = true;
    }
  }
}