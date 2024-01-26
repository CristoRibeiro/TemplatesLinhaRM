using ScaffoldingRM.GeradorNegocio.CodigoFonte.Data;
using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace ScaffoldingRM.GeradorForm
{
  public partial class GeradorObjetosAvulsoForm : Form
  {
    public bool ativouTabOpcoesData = false;
    public bool ativouTabOpcoesProcess = false;

    public GeradorObjetosAvulsoForm(string project)
    {
      InitializeComponent();
      txtProject.Text = project;
      CarregarComboBox();
      rmsTabControl1.TabPages.Remove(tabTabela);
      rmsTabControl1.TabPages.Remove(tabData);
      rmsTabControl1.TabPages.Remove(tabProcess);
    }

    private void CarregarComboBox()
    {
      List<TipoClasseComboBox> tiposClasses = new List<TipoClasseComboBox>
      {
        new TipoClasseComboBox(TipoClasse.Action.Descricao, TipoClasse.Action),
        new TipoClasseComboBox(TipoClasse.Data.Descricao, TipoClasse.Data),
        new TipoClasseComboBox(TipoClasse.DataSet.Descricao, TipoClasse.DataSet),
        new TipoClasseComboBox(TipoClasse.Modulo.Descricao, TipoClasse.Modulo),
        new TipoClasseComboBox(TipoClasse.ObjectItem.Descricao, TipoClasse.ObjectItem),
        new TipoClasseComboBox(TipoClasse.Props.Descricao, TipoClasse.Props),
        new TipoClasseComboBox(TipoClasse.RMSObject.Descricao, TipoClasse.RMSObject),
        new TipoClasseComboBox(TipoClasse.ProcessAction.Descricao, TipoClasse.ProcessAction),
        new TipoClasseComboBox(TipoClasse.ProcessForm.Descricao, TipoClasse.ProcessForm),
        new TipoClasseComboBox(TipoClasse.ProcessServer.Descricao, TipoClasse.ProcessServer),
        new TipoClasseComboBox(TipoClasse.ProcessParamsProc.Descricao, TipoClasse.ProcessParamsProc),
        new TipoClasseComboBox(TipoClasse.RMSServer.Descricao, TipoClasse.RMSServer),
        new TipoClasseComboBox(TipoClasse.InterfaceRMSServer.Descricao, TipoClasse.InterfaceRMSServer),
      };

      BindingSource bsCustomers = new BindingSource();
      bsCustomers.DataSource = tiposClasses;
      cbbTipoObj.DataSource = bsCustomers.DataSource;
      cbbTipoObj.DisplayMember = "Nome";
      cbbTipoObj.ValueMember = "TipoClasse";
    }

    private void btnGerarObj_Click(object sender, EventArgs e)
    {
      try
      {
        setNextTab();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Ocorreu uma falha ao gerar os templates. " + ex.Message);
      }
    }

    private void setNextTab()
    {
      if (PossuiNomeTabela() && txtNomeTabela.Text == string.Empty)
      {
        tabTabela.Show();
        rmsTabControl1.SelectedTab = tabTabela;
        return;
      }

      if (!ativouTabOpcoesData && GerandoObjetoData())
      {
        tabData.Show();
        rmsTabControl1.SelectedTab = tabData;
        return;
      }

      if (!ativouTabOpcoesProcess && GerandoObjetoProcess())
      {
        tabProcess.Show();
        rmsTabControl1.SelectedTab = tabProcess;
        return;
      }

      var dtBase = CarregaDto();

      if (dtBase != null)
        GerarArquivo(dtBase);
    }

    private void GerarArquivo(IDTOFonteBase dtoBase)
    {
      var tipoClasse = ((TipoClasse)cbbTipoObj.SelectedValue);
      var comando = tipoClasse.FactoryCodigoFonte.ObterIntancia(dtoBase);
      comando.GerarCodigoFonte();
      Close();
    }

    private IDTOFonteBase CarregaDto()
    {
      IDTOFonteBase retorno = null;

      if (EhDTOPadrao())
        retorno = ObterDtoPadrao();

      if (PossuiNomeTabela())
        retorno = ObterDtoTabela();

      if (GerandoObjetoProcess())
        retorno = ObterDtoProcess();

      return retorno;
    }

    private bool EhDTOPadrao()
    {
      List<TipoClasse> tiposDtoPadrao = new List<TipoClasse>
      {
        TipoClasse.Modulo,
        TipoClasse.Action,
        TipoClasse.ObjectItem,
        TipoClasse.RMSObject,
        TipoClasse.Form,
        TipoClasse.ProcessServer,
        TipoClasse.ProcessParamsProc,
        TipoClasse.RMSServer,
        TipoClasse.InterfaceRMSServer,
      };
      var tipoObj = cbbTipoObj.Text;

      return tiposDtoPadrao.Any(x => x.Descricao == tipoObj);
    }

    private IDTOFonteBase ObterDtoPadrao()
    {
      return new DTOFonteBase
      {
        FullPathProjeto = txtProject.Text,
        NomeEntidade = txtNomeObj.Text
      };
    }

    private bool PossuiNomeTabela()
    {
      var tipoObj = cbbTipoObj.Text;
      return (GerandoObjetoData() ||
             tipoObj == TipoClasse.Props.Descricao ||
             tipoObj == TipoClasse.DataSet.Descricao);
    }

    private bool GerandoObjetoData() => TipoClasse.Data.Descricao == cbbTipoObj.Text;
    private bool GerandoObjetoProcess() => TipoClasse.ProcessAction.Descricao == cbbTipoObj.Text;

    private IDTOFonteBase ObterDtoTabela()
    {
      var tipoObj = cbbTipoObj.Text;

      if (tipoObj == TipoClasse.Props.Descricao)
      {
        return new DTOFonteDataProps
        {
          FullPathProjeto = txtProject.Text,
          NomeEntidade = txtNomeObj.Text,
          NomeTabela = txtNomeTabela.Text
        };
      }

      if (tipoObj == TipoClasse.DataSet.Descricao)
      {
        return new DTOFonteDataSet
        {
          FullPathProjeto = txtProject.Text,
          NomeEntidade = txtNomeObj.Text,
          NomeTabela = txtNomeTabela.Text
        };
      }

      if (tipoObj == TipoClasse.Data.Descricao)
      {
        return new DTOFonteData
        {
          FullPathProjeto = txtProject.Text,
          NomeEntidade = txtNomeObj.Text,
          NomeTabela = txtNomeTabela.Text,
          GerarDataProps = ckbGerarDataProps.Checked,
          GerarDataSet = ckbGerarDataSet.Checked,
          GerarModulo = ckbGerarModulo.Checked,
          GerarObjectItem = ckbGerarObjectItem.Checked,
          GerarRmsObject = ckbRmsObject.Checked,
        };
      }

      return null;
    }

    private IDTOFonteBase ObterDtoProcess()
    {
      return new DTOFonteProcessAction
      {
        FullPathProjeto = txtProject.Text,
        NomeEntidade = txtNomeObj.Text,
        GerarProcessForm = ckbGerarFormProcess.Checked,
        GerarModulo = ckbGerarModuloProcess.Checked,
        GerarDto = ckbGerarObjItemProcess.Checked,
        GerarProcessParmsProc = ckbGerarParamsProcProcess.Checked,
        GerarProcessServer = ckbGerarServerProcess.Checked,
        GerarProcessRmsObject = ckbGerarRmsObjectProcess.Checked,
        GerarProcessRmsServer = ckbGerarRmsServer.Checked
      };
    }

    private void rmsTabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (rmsTabControl1.SelectedTab == tabData)
        ativouTabOpcoesData = true;

      if (rmsTabControl1.SelectedTab == tabProcess)
        ativouTabOpcoesProcess = true;
    }

    private void cbbTipoObj_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (PossuiNomeTabela())
        AdicionarTabPage(tabTabela);
      else
        rmsTabControl1.TabPages.Remove(tabTabela);

      if (GerandoObjetoData())
        AdicionarTabPage(tabData);
      else
        rmsTabControl1.TabPages.Remove(tabData);

      if (GerandoObjetoProcess())
        AdicionarTabPage(tabProcess);
      else
        rmsTabControl1.TabPages.Remove(tabProcess);

      AlterarNomeObj();
    }

    private void AdicionarTabPage(TabPage tabData)
    {
      if (!rmsTabControl1.TabPages.Contains(tabData))
        rmsTabControl1.TabPages.Add(tabData);
    }

    private void txtNomeObj_TextChanged(object sender, EventArgs e)
    {
      AlterarNomeObj();
    }

    private void AlterarNomeObj()
    {
      if (!string.IsNullOrWhiteSpace(txtNomeObj.Text))
        txtSaidaAction.Text = Constantes.PrefixoSaude + txtNomeObj.Text + ((TipoClasse)cbbTipoObj.SelectedValue).Value;
      else
        txtSaidaAction.Text = string.Empty;
    }
  }
}
