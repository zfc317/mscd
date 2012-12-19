namespace MSCD.UI.SystemManager
{
    partial class DlgConfigWorkspace
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_WorkspaceDatabase = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_WorkspaceServer = new DevExpress.XtraEditors.TextEdit();
            this.txt_WorkspaceUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_WorkspaceName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_WorkspacePassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Test = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspacePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "数  据 库：";
            // 
            // txt_WorkspaceDatabase
            // 
            this.txt_WorkspaceDatabase.Location = new System.Drawing.Point(91, 37);
            this.txt_WorkspaceDatabase.Name = "txt_WorkspaceDatabase";
            this.txt_WorkspaceDatabase.Size = new System.Drawing.Size(191, 20);
            this.txt_WorkspaceDatabase.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "该值不能为空！";
            this.dxValidationProvider1.SetValidationRule(this.txt_WorkspaceDatabase, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "服  务 器：";
            // 
            // txt_WorkspaceServer
            // 
            this.txt_WorkspaceServer.Location = new System.Drawing.Point(91, 11);
            this.txt_WorkspaceServer.Name = "txt_WorkspaceServer";
            this.txt_WorkspaceServer.Size = new System.Drawing.Size(191, 20);
            this.txt_WorkspaceServer.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "该值不能为空！";
            this.dxValidationProvider1.SetValidationRule(this.txt_WorkspaceServer, conditionValidationRule2);
            // 
            // txt_WorkspaceUsername
            // 
            this.txt_WorkspaceUsername.Location = new System.Drawing.Point(91, 89);
            this.txt_WorkspaceUsername.Name = "txt_WorkspaceUsername";
            this.txt_WorkspaceUsername.Size = new System.Drawing.Size(191, 20);
            this.txt_WorkspaceUsername.TabIndex = 3;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "该值不能为空！";
            this.dxValidationProvider1.SetValidationRule(this.txt_WorkspaceUsername, conditionValidationRule3);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "工作空间：";
            // 
            // txt_WorkspaceName
            // 
            this.txt_WorkspaceName.Location = new System.Drawing.Point(91, 63);
            this.txt_WorkspaceName.Name = "txt_WorkspaceName";
            this.txt_WorkspaceName.Size = new System.Drawing.Size(191, 20);
            this.txt_WorkspaceName.TabIndex = 2;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "该值不能为空！";
            this.dxValidationProvider1.SetValidationRule(this.txt_WorkspaceName, conditionValidationRule4);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 92);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "用  户 名：";
            // 
            // txt_WorkspacePassword
            // 
            this.txt_WorkspacePassword.Location = new System.Drawing.Point(91, 115);
            this.txt_WorkspacePassword.Name = "txt_WorkspacePassword";
            this.txt_WorkspacePassword.Properties.PasswordChar = '*';
            this.txt_WorkspacePassword.Size = new System.Drawing.Size(191, 20);
            this.txt_WorkspacePassword.TabIndex = 4;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "该值不能为空！";
            this.dxValidationProvider1.SetValidationRule(this.txt_WorkspacePassword, conditionValidationRule5);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "密      码：";
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(141, 143);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(43, 23);
            this.btn_Test.TabIndex = 5;
            this.btn_Test.Text = "测试";
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(190, 143);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(43, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(239, 143);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(43, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // DlgConfigWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 174);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.txt_WorkspaceName);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_WorkspaceServer);
            this.Controls.Add(this.txt_WorkspacePassword);
            this.Controls.Add(this.txt_WorkspaceUsername);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_WorkspaceDatabase);
            this.Controls.Add(this.labelControl1);
            this.Name = "DlgConfigWorkspace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置工作空间";
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspacePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_WorkspaceDatabase;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_WorkspaceServer;
        private DevExpress.XtraEditors.TextEdit txt_WorkspaceUsername;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_WorkspaceName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_WorkspacePassword;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_Test;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}