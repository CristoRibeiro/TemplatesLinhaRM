using ScaffoldingRM.GeradorNegocio.DTO;
using ScaffoldingRM.GeradorNegocio.Enum;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace ScaffoldingRM.GeradorForm
{
  public partial class GeradorObjetosAvulsoForm : Form
  {
    public bool ativouTabOpcoesData = false;
    public GeradorObjetosAvulsoForm(string project)
    {
      InitializeComponent();
      txtProject.Text = project;
      CarregarComboBox();
      rmsTabControl1.TabPages.Remove(tabTabela);
      rmsTabControl1.TabPages.Remove(tabData);
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
      };

      BindingSource bsCustomers = new BindingSource();
      bsCustomers.DataSource = tiposClasses;
      cbbTipoObj.DataSource = bsCustomers.DataSource;
      cbbTipoObj.DisplayMember = "Nome";
      cbbTipoObj.ValueMember = "TipoClasse";

    }

    private void btnGerarObj_Click(object sender, EventArgs e)
    {
      setNextTab();
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

      return retorno;
    }

    private bool EhDTOPadrao()
    {
      var tipoObj = cbbTipoObj.Text;
      return (tipoObj == TipoClasse.Modulo.Descricao ||
             tipoObj == TipoClasse.Action.Descricao ||
             tipoObj == TipoClasse.ObjectItem.Descricao ||
             tipoObj == TipoClasse.RMSObject.Descricao);
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

    private void rmsTabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (rmsTabControl1.SelectedTab == tabData)
      {
        ativouTabOpcoesData = true;
      }
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
    }

    private void AdicionarTabPage(TabPage tabData)
    {
      if (!rmsTabControl1.TabPages.Contains(tabData))
        rmsTabControl1.TabPages.Add(tabData);
    }
  }
}
