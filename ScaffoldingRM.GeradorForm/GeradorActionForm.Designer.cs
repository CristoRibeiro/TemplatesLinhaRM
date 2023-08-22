namespace ScaffoldingRM.GeradorForm
{
  partial class GeradorActionForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeradorActionForm));
      this.txtNomeForm = new System.Windows.Forms.TextBox();
      this.nomeAction = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtSaidaAction = new System.Windows.Forms.TextBox();
      this.cbbTemplateAction = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.txtProject = new System.Windows.Forms.TextBox();
      this.txtProjectAction = new System.Windows.Forms.TextBox();
      this.gpbData = new System.Windows.Forms.GroupBox();
      this.ckbRmsObject = new System.Windows.Forms.CheckBox();
      this.ckbGerarObjectItem = new System.Windows.Forms.CheckBox();
      this.ckbGerarDataSet = new System.Windows.Forms.CheckBox();
      this.ckbGerarDataProps = new System.Windows.Forms.CheckBox();
      this.ckbGerarModulo = new System.Windows.Forms.CheckBox();
      this.lblTabela = new System.Windows.Forms.Label();
      this.txtTabela = new System.Windows.Forms.TextBox();
      this.lblProjData = new System.Windows.Forms.Label();
      this.txtProjectData = new System.Windows.Forms.TextBox();
      this.gpbAction = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.ckbGeraAction = new System.Windows.Forms.CheckBox();
      this.ckbGeraData = new System.Windows.Forms.CheckBox();
      this.gpbData.SuspendLayout();
      this.gpbAction.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtNomeForm
      // 
      resources.ApplyResources(this.txtNomeForm, "txtNomeForm");
      this.txtNomeForm.Name = "txtNomeForm";
      this.txtNomeForm.TextChanged += new System.EventHandler(this.txtNomeForm_TextChanged);
      // 
      // nomeAction
      // 
      resources.ApplyResources(this.nomeAction, "nomeAction");
      this.nomeAction.Name = "nomeAction";
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // txtSaidaAction
      // 
      resources.ApplyResources(this.txtSaidaAction, "txtSaidaAction");
      this.txtSaidaAction.Name = "txtSaidaAction";
      this.txtSaidaAction.ReadOnly = true;
      // 
      // cbbTemplateAction
      // 
      this.cbbTemplateAction.FormattingEnabled = true;
      resources.ApplyResources(this.cbbTemplateAction, "cbbTemplateAction");
      this.cbbTemplateAction.Name = "cbbTemplateAction";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // button1
      // 
      resources.ApplyResources(this.button1, "button1");
      this.button1.Name = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtProject
      // 
      resources.ApplyResources(this.txtProject, "txtProject");
      this.txtProject.Name = "txtProject";
      this.txtProject.ReadOnly = true;
      // 
      // txtProjectAction
      // 
      resources.ApplyResources(this.txtProjectAction, "txtProjectAction");
      this.txtProjectAction.Name = "txtProjectAction";
      // 
      // gpbData
      // 
      this.gpbData.Controls.Add(this.ckbRmsObject);
      this.gpbData.Controls.Add(this.ckbGerarObjectItem);
      this.gpbData.Controls.Add(this.ckbGerarDataSet);
      this.gpbData.Controls.Add(this.ckbGerarDataProps);
      this.gpbData.Controls.Add(this.ckbGerarModulo);
      this.gpbData.Controls.Add(this.lblTabela);
      this.gpbData.Controls.Add(this.txtTabela);
      this.gpbData.Controls.Add(this.lblProjData);
      this.gpbData.Controls.Add(this.txtProjectData);
      resources.ApplyResources(this.gpbData, "gpbData");
      this.gpbData.Name = "gpbData";
      this.gpbData.TabStop = false;
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
      // lblTabela
      // 
      resources.ApplyResources(this.lblTabela, "lblTabela");
      this.lblTabela.Name = "lblTabela";
      // 
      // txtTabela
      // 
      resources.ApplyResources(this.txtTabela, "txtTabela");
      this.txtTabela.Name = "txtTabela";
      // 
      // lblProjData
      // 
      resources.ApplyResources(this.lblProjData, "lblProjData");
      this.lblProjData.Name = "lblProjData";
      // 
      // txtProjectData
      // 
      resources.ApplyResources(this.txtProjectData, "txtProjectData");
      this.txtProjectData.Name = "txtProjectData";
      // 
      // gpbAction
      // 
      this.gpbAction.Controls.Add(this.label4);
      this.gpbAction.Controls.Add(this.txtProjectAction);
      resources.ApplyResources(this.gpbAction, "gpbAction");
      this.gpbAction.Name = "gpbAction";
      this.gpbAction.TabStop = false;
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // ckbGeraAction
      // 
      resources.ApplyResources(this.ckbGeraAction, "ckbGeraAction");
      this.ckbGeraAction.Name = "ckbGeraAction";
      this.ckbGeraAction.UseVisualStyleBackColor = true;
      this.ckbGeraAction.CheckedChanged += new System.EventHandler(this.ckbGeraAction_CheckedChanged);
      // 
      // ckbGeraData
      // 
      resources.ApplyResources(this.ckbGeraData, "ckbGeraData");
      this.ckbGeraData.Name = "ckbGeraData";
      this.ckbGeraData.UseVisualStyleBackColor = true;
      this.ckbGeraData.CheckedChanged += new System.EventHandler(this.ckbGeraData_CheckedChanged);
      // 
      // GeradorActionForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ckbGeraData);
      this.Controls.Add(this.ckbGeraAction);
      this.Controls.Add(this.gpbAction);
      this.Controls.Add(this.gpbData);
      this.Controls.Add(this.txtProject);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cbbTemplateAction);
      this.Controls.Add(this.txtSaidaAction);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.nomeAction);
      this.Controls.Add(this.txtNomeForm);
      this.Name = "GeradorActionForm";
      this.ShowIcon = false;
      this.Load += new System.EventHandler(this.GeradorActionForm_Load);
      this.gpbData.ResumeLayout(false);
      this.gpbData.PerformLayout();
      this.gpbAction.ResumeLayout(false);
      this.gpbAction.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtNomeForm;
    private System.Windows.Forms.Label nomeAction;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSaidaAction;
    private System.Windows.Forms.ComboBox cbbTemplateAction;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtProject;
    private System.Windows.Forms.TextBox txtProjectAction;
    private System.Windows.Forms.GroupBox gpbData;
    private System.Windows.Forms.CheckBox ckbGerarObjectItem;
    private System.Windows.Forms.CheckBox ckbGerarDataSet;
    private System.Windows.Forms.CheckBox ckbGerarDataProps;
    private System.Windows.Forms.CheckBox ckbGerarModulo;
    private System.Windows.Forms.Label lblTabela;
    private System.Windows.Forms.TextBox txtTabela;
    private System.Windows.Forms.Label lblProjData;
    private System.Windows.Forms.TextBox txtProjectData;
    private System.Windows.Forms.GroupBox gpbAction;
    private System.Windows.Forms.CheckBox ckbGeraAction;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox ckbGeraData;
    private System.Windows.Forms.CheckBox ckbRmsObject;
  }
}

