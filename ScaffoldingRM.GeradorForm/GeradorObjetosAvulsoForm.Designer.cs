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
      this.ckbRmsObject = new System.Windows.Forms.CheckBox();
      this.ckbGerarObjectItem = new System.Windows.Forms.CheckBox();
      this.ckbGerarDataSet = new System.Windows.Forms.CheckBox();
      this.ckbGerarDataProps = new System.Windows.Forms.CheckBox();
      this.ckbGerarModulo = new System.Windows.Forms.CheckBox();
      this.tabTabela = new System.Windows.Forms.TabPage();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNomeTabela = new System.Windows.Forms.TextBox();
      this.tabGeral = new System.Windows.Forms.TabPage();
      this.txtProject = new System.Windows.Forms.TextBox();
      this.txtSaidaAction = new System.Windows.Forms.TextBox();
      this.txtNomeObj = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tpObjjLabel = new System.Windows.Forms.Label();
      this.cbbTipoObj = new System.Windows.Forms.ComboBox();
      this.nomeObj = new System.Windows.Forms.Label();
      this.rmsTabControl1 = new RM.Lib.WinForms.RMSTabControl();
      this.tabProcess = new System.Windows.Forms.TabPage();
      this.ckbGerarRmsServer = new System.Windows.Forms.CheckBox();
      this.ckbGerarRmsObjectProcess = new System.Windows.Forms.CheckBox();
      this.ckbGerarFormProcess = new System.Windows.Forms.CheckBox();
      this.ckbGerarObjItemProcess = new System.Windows.Forms.CheckBox();
      this.ckbGerarParamsProcProcess = new System.Windows.Forms.CheckBox();
      this.ckbGerarServerProcess = new System.Windows.Forms.CheckBox();
      this.ckbGerarModuloProcess = new System.Windows.Forms.CheckBox();
      this.tabData.SuspendLayout();
      this.tabTabela.SuspendLayout();
      this.tabGeral.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rmsTabControl1)).BeginInit();
      this.rmsTabControl1.SuspendLayout();
      this.tabProcess.SuspendLayout();
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
      // ckbRmsObject
      // 
      resources.ApplyResources(this.ckbRmsObject, "ckbRmsObject");
      this.ckbRmsObject.Checked = true;
      this.ckbRmsObject.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbRmsObject.Name = "ckbRmsObject";
      this.ckbRmsObject.UseVisualStyleBackColor = true;
      // 
      // ckbGerarObjectItem
      // 
      resources.ApplyResources(this.ckbGerarObjectItem, "ckbGerarObjectItem");
      this.ckbGerarObjectItem.Checked = true;
      this.ckbGerarObjectItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarObjectItem.Name = "ckbGerarObjectItem";
      this.ckbGerarObjectItem.UseVisualStyleBackColor = true;
      // 
      // ckbGerarDataSet
      // 
      resources.ApplyResources(this.ckbGerarDataSet, "ckbGerarDataSet");
      this.ckbGerarDataSet.Checked = true;
      this.ckbGerarDataSet.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarDataSet.Name = "ckbGerarDataSet";
      this.ckbGerarDataSet.UseVisualStyleBackColor = true;
      // 
      // ckbGerarDataProps
      // 
      resources.ApplyResources(this.ckbGerarDataProps, "ckbGerarDataProps");
      this.ckbGerarDataProps.Checked = true;
      this.ckbGerarDataProps.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarDataProps.Name = "ckbGerarDataProps";
      this.ckbGerarDataProps.UseVisualStyleBackColor = true;
      // 
      // ckbGerarModulo
      // 
      resources.ApplyResources(this.ckbGerarModulo, "ckbGerarModulo");
      this.ckbGerarModulo.Checked = true;
      this.ckbGerarModulo.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarModulo.Name = "ckbGerarModulo";
      this.ckbGerarModulo.UseVisualStyleBackColor = true;
      // 
      // tabTabela
      // 
      this.tabTabela.Controls.Add(this.label2);
      this.tabTabela.Controls.Add(this.txtNomeTabela);
      resources.ApplyResources(this.tabTabela, "tabTabela");
      this.tabTabela.Name = "tabTabela";
      this.tabTabela.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // txtNomeTabela
      // 
      resources.ApplyResources(this.txtNomeTabela, "txtNomeTabela");
      this.txtNomeTabela.Name = "txtNomeTabela";
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
      // txtProject
      // 
      resources.ApplyResources(this.txtProject, "txtProject");
      this.txtProject.Name = "txtProject";
      this.txtProject.ReadOnly = true;
      // 
      // txtSaidaAction
      // 
      resources.ApplyResources(this.txtSaidaAction, "txtSaidaAction");
      this.txtSaidaAction.Name = "txtSaidaAction";
      this.txtSaidaAction.ReadOnly = true;
      // 
      // txtNomeObj
      // 
      resources.ApplyResources(this.txtNomeObj, "txtNomeObj");
      this.txtNomeObj.Name = "txtNomeObj";
      this.txtNomeObj.TextChanged += new System.EventHandler(this.txtNomeObj_TextChanged);
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // tpObjjLabel
      // 
      resources.ApplyResources(this.tpObjjLabel, "tpObjjLabel");
      this.tpObjjLabel.Name = "tpObjjLabel";
      // 
      // cbbTipoObj
      // 
      this.cbbTipoObj.FormattingEnabled = true;
      resources.ApplyResources(this.cbbTipoObj, "cbbTipoObj");
      this.cbbTipoObj.Name = "cbbTipoObj";
      this.cbbTipoObj.SelectedIndexChanged += new System.EventHandler(this.cbbTipoObj_SelectedIndexChanged);
      // 
      // nomeObj
      // 
      resources.ApplyResources(this.nomeObj, "nomeObj");
      this.nomeObj.Name = "nomeObj";
      // 
      // rmsTabControl1
      // 
      this.rmsTabControl1.Controls.Add(this.tabGeral);
      this.rmsTabControl1.Controls.Add(this.tabTabela);
      this.rmsTabControl1.Controls.Add(this.tabData);
      this.rmsTabControl1.Controls.Add(this.tabProcess);
      resources.ApplyResources(this.rmsTabControl1, "rmsTabControl1");
      this.rmsTabControl1.MasterBackColor = System.Drawing.Color.White;
      this.rmsTabControl1.MasterTabBackColor = System.Drawing.Color.White;
      this.rmsTabControl1.Name = "rmsTabControl1";
      this.rmsTabControl1.SelectedIndex = 0;
      this.rmsTabControl1.SelectedIndexChanged += new System.EventHandler(this.rmsTabControl1_SelectedIndexChanged);
      // 
      // tabProcess
      // 
      this.tabProcess.Controls.Add(this.ckbGerarRmsServer);
      this.tabProcess.Controls.Add(this.ckbGerarRmsObjectProcess);
      this.tabProcess.Controls.Add(this.ckbGerarFormProcess);
      this.tabProcess.Controls.Add(this.ckbGerarObjItemProcess);
      this.tabProcess.Controls.Add(this.ckbGerarParamsProcProcess);
      this.tabProcess.Controls.Add(this.ckbGerarServerProcess);
      this.tabProcess.Controls.Add(this.ckbGerarModuloProcess);
      resources.ApplyResources(this.tabProcess, "tabProcess");
      this.tabProcess.Name = "tabProcess";
      this.tabProcess.UseVisualStyleBackColor = true;
      // 
      // ckbGerarRmsServer
      // 
      resources.ApplyResources(this.ckbGerarRmsServer, "ckbGerarRmsServer");
      this.ckbGerarRmsServer.Checked = true;
      this.ckbGerarRmsServer.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarRmsServer.Name = "ckbGerarRmsServer";
      this.ckbGerarRmsServer.UseVisualStyleBackColor = true;
      // 
      // ckbGerarRmsObjectProcess
      // 
      resources.ApplyResources(this.ckbGerarRmsObjectProcess, "ckbGerarRmsObjectProcess");
      this.ckbGerarRmsObjectProcess.Checked = true;
      this.ckbGerarRmsObjectProcess.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarRmsObjectProcess.Name = "ckbGerarRmsObjectProcess";
      this.ckbGerarRmsObjectProcess.UseVisualStyleBackColor = true;
      // 
      // ckbGerarFormProcess
      // 
      resources.ApplyResources(this.ckbGerarFormProcess, "ckbGerarFormProcess");
      this.ckbGerarFormProcess.Checked = true;
      this.ckbGerarFormProcess.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarFormProcess.Name = "ckbGerarFormProcess";
      this.ckbGerarFormProcess.UseVisualStyleBackColor = true;
      // 
      // ckbGerarObjItemProcess
      // 
      resources.ApplyResources(this.ckbGerarObjItemProcess, "ckbGerarObjItemProcess");
      this.ckbGerarObjItemProcess.Checked = true;
      this.ckbGerarObjItemProcess.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarObjItemProcess.Name = "ckbGerarObjItemProcess";
      this.ckbGerarObjItemProcess.UseVisualStyleBackColor = true;
      // 
      // ckbGerarParamsProcProcess
      // 
      resources.ApplyResources(this.ckbGerarParamsProcProcess, "ckbGerarParamsProcProcess");
      this.ckbGerarParamsProcProcess.Checked = true;
      this.ckbGerarParamsProcProcess.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarParamsProcProcess.Name = "ckbGerarParamsProcProcess";
      this.ckbGerarParamsProcProcess.UseVisualStyleBackColor = true;
      // 
      // ckbGerarServerProcess
      // 
      resources.ApplyResources(this.ckbGerarServerProcess, "ckbGerarServerProcess");
      this.ckbGerarServerProcess.Checked = true;
      this.ckbGerarServerProcess.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarServerProcess.Name = "ckbGerarServerProcess";
      this.ckbGerarServerProcess.UseVisualStyleBackColor = true;
      // 
      // ckbGerarModuloProcess
      // 
      resources.ApplyResources(this.ckbGerarModuloProcess, "ckbGerarModuloProcess");
      this.ckbGerarModuloProcess.Checked = true;
      this.ckbGerarModuloProcess.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckbGerarModuloProcess.Name = "ckbGerarModuloProcess";
      this.ckbGerarModuloProcess.UseVisualStyleBackColor = true;
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
      this.tabProcess.ResumeLayout(false);
      this.tabProcess.PerformLayout();
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
    private System.Windows.Forms.TabPage tabProcess;
    private System.Windows.Forms.CheckBox ckbGerarModuloProcess;
    private System.Windows.Forms.CheckBox ckbGerarParamsProcProcess;
    private System.Windows.Forms.CheckBox ckbGerarServerProcess;
    private System.Windows.Forms.CheckBox ckbGerarObjItemProcess;
    private System.Windows.Forms.CheckBox ckbGerarFormProcess;
    private System.Windows.Forms.CheckBox ckbGerarRmsObjectProcess;
    private System.Windows.Forms.CheckBox ckbGerarRmsServer;
  }
}