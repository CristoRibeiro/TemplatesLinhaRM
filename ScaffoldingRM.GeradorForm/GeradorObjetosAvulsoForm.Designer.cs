namespace ScaffoldingRM.GeradorForm
{
  partial class GeradorObjetosAvulsoForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeradorObjetosAvulsoForm));
      this.btnGerarObj = new System.Windows.Forms.Button();
      this.tabData = new System.Windows.Forms.TabPage();
      this.ckbGerarModulo = new System.Windows.Forms.CheckBox();
      this.ckbGerarDataProps = new System.Windows.Forms.CheckBox();
      this.ckbGerarDataSet = new System.Windows.Forms.CheckBox();
      this.ckbGerarObjectItem = new System.Windows.Forms.CheckBox();
      this.ckbRmsObject = new System.Windows.Forms.CheckBox();
      this.tabTabela = new System.Windows.Forms.TabPage();
      this.txtNomeTabela = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tabGeral = new System.Windows.Forms.TabPage();
      this.txtNomeObj = new System.Windows.Forms.TextBox();
      this.nomeObj = new System.Windows.Forms.Label();
      this.cbbTipoObj = new System.Windows.Forms.ComboBox();
      this.tpObjjLabel = new System.Windows.Forms.Label();
      this.txtSaidaAction = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtProject = new System.Windows.Forms.TextBox();
      this.rmsTabControl1 = new RM.Lib.WinForms.RMSTabControl();
      this.tabData.SuspendLayout();
      this.tabTabela.SuspendLayout();
      this.tabGeral.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rmsTabControl1)).BeginInit();
      this.rmsTabControl1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnGerarObj
      // 
      resources.ApplyResources(this.btnGerarObj, "btnGerarObj");
      this.btnGerarObj.Name = "btnGerarObj";
      this.btnGerarObj.UseVisualStyleBackColor = true;
      this.btnGerarObj.Click += new System.EventHandler(this.btnGerarObj_Click);
      // 
      // tabData
      // 
      this.tabData.Controls.Add(this.ckbRmsObject);
      this.tabData.Controls.Add(this.ckbGerarObjectItem);
      this.tabData.Controls.Add(this.ckbGerarDataSet);
      this.tabData.Controls.Add(this.ckbGerarDataProps);
      this.tabData.Controls.Add(this.ckbGerarModulo);
      resources.ApplyResources(this.tabData, "tabData");
      this.tabData.Name = "tabData";
      this.tabData.UseVisualStyleBackColor = true;
      // 
      // ckbGerarModulo
      // 
      resources.ApplyResources(this.ckbGerarModulo, "ckbGerarModulo");
      this.ckbGerarModulo.Checked = true;
      this.ckbGerarModulo.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarModulo.Name = "ckbGerarModulo";
      this.ckbGerarModulo.UseVisualStyleBackColor = true;
      // 
      // ckbGerarDataProps
      // 
      resources.ApplyResources(this.ckbGerarDataProps, "ckbGerarDataProps");
      this.ckbGerarDataProps.Checked = true;
      this.ckbGerarDataProps.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarDataProps.Name = "ckbGerarDataProps";
      this.ckbGerarDataProps.UseVisualStyleBackColor = true;
      // 
      // ckbGerarDataSet
      // 
      resources.ApplyResources(this.ckbGerarDataSet, "ckbGerarDataSet");
      this.ckbGerarDataSet.Checked = true;
      this.ckbGerarDataSet.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarDataSet.Name = "ckbGerarDataSet";
      this.ckbGerarDataSet.UseVisualStyleBackColor = true;
      // 
      // ckbGerarObjectItem
      // 
      resources.ApplyResources(this.ckbGerarObjectItem, "ckbGerarObjectItem");
      this.ckbGerarObjectItem.Checked = true;
      this.ckbGerarObjectItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarObjectItem.Name = "ckbGerarObjectItem";
      this.ckbGerarObjectItem.UseVisualStyleBackColor = true;
      // 
      // ckbRmsObject
      // 
      resources.ApplyResources(this.ckbRmsObject, "ckbRmsObject");
      this.ckbRmsObject.Checked = true;
      this.ckbRmsObject.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbRmsObject.Name = "ckbRmsObject";
      this.ckbRmsObject.UseVisualStyleBackColor = true;
      // 
      // tabTabela
      // 
      this.tabTabela.Controls.Add(this.label2);
      this.tabTabela.Controls.Add(this.txtNomeTabela);
      resources.ApplyResources(this.tabTabela, "tabTabela");
      this.tabTabela.Name = "tabTabela";
      this.tabTabela.UseVisualStyleBackColor = true;
      // 
      // txtNomeTabela
      // 
      resources.ApplyResources(this.txtNomeTabela, "txtNomeTabela");
      this.txtNomeTabela.Name = "txtNomeTabela";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // tabGeral
      // 
      this.tabGeral.Controls.Add(this.txtProject);
      this.tabGeral.Controls.Add(this.txtSaidaAction);
      this.tabGeral.Controls.Add(this.txtNomeObj);
      this.tabGeral.Controls.Add(this.label3);
      this.tabGeral.Controls.Add(this.label1);
      this.tabGeral.Controls.Add(this.tpObjjLabel);
      this.tabGeral.Controls.Add(this.cbbTipoObj);
      this.tabGeral.Controls.Add(this.nomeObj);
      resources.ApplyResources(this.tabGeral, "tabGeral");
      this.tabGeral.Name = "tabGeral";
      this.tabGeral.UseVisualStyleBackColor = true;
      // 
      // txtNomeObj
      // 
      resources.ApplyResources(this.txtNomeObj, "txtNomeObj");
      this.txtNomeObj.Name = "txtNomeObj";
      // 
      // nomeObj
      // 
      resources.ApplyResources(this.nomeObj, "nomeObj");
      this.nomeObj.Name = "nomeObj";
      // 
      // cbbTipoObj
      // 
      this.cbbTipoObj.FormattingEnabled = true;
      resources.ApplyResources(this.cbbTipoObj, "cbbTipoObj");
      this.cbbTipoObj.Name = "cbbTipoObj";
      this.cbbTipoObj.SelectedIndexChanged += new System.EventHandler(this.cbbTipoObj_SelectedIndexChanged);
      // 
      // tpObjjLabel
      // 
      resources.ApplyResources(this.tpObjjLabel, "tpObjjLabel");
      this.tpObjjLabel.Name = "tpObjjLabel";
      // 
      // txtSaidaAction
      // 
      resources.ApplyResources(this.txtSaidaAction, "txtSaidaAction");
      this.txtSaidaAction.Name = "txtSaidaAction";
      this.txtSaidaAction.ReadOnly = true;
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // txtProject
      // 
      resources.ApplyResources(this.txtProject, "txtProject");
      this.txtProject.Name = "txtProject";
      this.txtProject.ReadOnly = true;
      // 
      // rmsTabControl1
      // 
      this.rmsTabControl1.Controls.Add(this.tabGeral);
      this.rmsTabControl1.Controls.Add(this.tabTabela);
      this.rmsTabControl1.Controls.Add(this.tabData);
      resources.ApplyResources(this.rmsTabControl1, "rmsTabControl1");
      this.rmsTabControl1.MasterBackColor = System.Drawing.Color.White;
      this.rmsTabControl1.MasterTabBackColor = System.Drawing.Color.White;
      this.rmsTabControl1.Name = "rmsTabControl1";
      this.rmsTabControl1.SelectedIndex = 0;
      this.rmsTabControl1.SelectedIndexChanged += new System.EventHandler(this.rmsTabControl1_SelectedIndexChanged);
      // 
      // GeradorObjetosAvulsoForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.rmsTabControl1);
      this.Controls.Add(this.btnGerarObj);
      this.Name = "GeradorObjetosAvulsoForm";
      this.tabData.ResumeLayout(false);
      this.tabData.PerformLayout();
      this.tabTabela.ResumeLayout(false);
      this.tabTabela.PerformLayout();
      this.tabGeral.ResumeLayout(false);
      this.tabGeral.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rmsTabControl1)).EndInit();
      this.rmsTabControl1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button btnGerarObj;
    private System.Windows.Forms.TabPage tabData;
    private System.Windows.Forms.CheckBox ckbRmsObject;
    private System.Windows.Forms.CheckBox ckbGerarObjectItem;
    private System.Windows.Forms.CheckBox ckbGerarDataSet;
    private System.Windows.Forms.CheckBox ckbGerarDataProps;
    private System.Windows.Forms.CheckBox ckbGerarModulo;
    private System.Windows.Forms.TabPage tabTabela;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNomeTabela;
    private System.Windows.Forms.TabPage tabGeral;
    private System.Windows.Forms.TextBox txtProject;
    private System.Windows.Forms.TextBox txtSaidaAction;
    private System.Windows.Forms.TextBox txtNomeObj;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label tpObjjLabel;
    private System.Windows.Forms.ComboBox cbbTipoObj;
    private System.Windows.Forms.Label nomeObj;
    private RM.Lib.WinForms.RMSTabControl rmsTabControl1;
  }
}