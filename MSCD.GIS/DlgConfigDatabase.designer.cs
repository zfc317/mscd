namespace MSCD.GIS
{
    partial class DlgConfigDatabase
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
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Test = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_WorkspaceServer = new DevExpress.XtraEditors.TextEdit();
            this.txt_WorkspacePassword = new DevExpress.XtraEditors.TextEdit();
            this.txt_WorkspaceUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_WorkspaceDatabase = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspacePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(233, 115);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(43, 23);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(184, 115);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(43, 23);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(135, 115);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(43, 23);
            this.btn_Test.TabIndex = 18;
            this.btn_Test.Text = "测试";
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 90);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "密      码：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "用  户 名：";
            // 
            // txt_WorkspaceServer
            // 
            this.txt_WorkspaceServer.Location = new System.Drawing.Point(85, 8);
            this.txt_WorkspaceServer.Name = "txt_WorkspaceServer";
            this.txt_WorkspaceServer.Size = new System.Drawing.Size(191, 20);
            this.txt_WorkspaceServer.TabIndex = 11;
            // 
            // txt_WorkspacePassword
            // 
            this.txt_WorkspacePassword.Location = new System.Drawing.Point(85, 87);
            this.txt_WorkspacePassword.Name = "txt_WorkspacePassword";
            this.txt_WorkspacePassword.Properties.PasswordChar = '*';
            this.txt_WorkspacePassword.Size = new System.Drawing.Size(191, 20);
            this.txt_WorkspacePassword.TabIndex = 17;
            // 
            // txt_WorkspaceUsername
            // 
            this.txt_WorkspaceUsername.Location = new System.Drawing.Point(85, 61);
            this.txt_WorkspaceUsername.Name = "txt_WorkspaceUsername";
            this.txt_WorkspaceUsername.Size = new System.Drawing.Size(191, 20);
            this.txt_WorkspaceUsername.TabIndex = 16;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "服  务 器：";
            // 
            // txt_WorkspaceDatabase
            // 
            this.txt_WorkspaceDatabase.Location = new System.Drawing.Point(85, 34);
            this.txt_WorkspaceDatabase.Name = "txt_WorkspaceDatabase";
            this.txt_WorkspaceDatabase.Size = new System.Drawing.Size(191, 20);
            this.txt_WorkspaceDatabase.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "数  据 库：";
            // 
            // DlgConfigDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 145);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_WorkspaceServer);
            this.Controls.Add(this.txt_WorkspacePassword);
            this.Controls.Add(this.txt_WorkspaceUsername);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_WorkspaceDatabase);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(293, 183);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(293, 183);
            this.Name = "DlgConfigDatabase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置数据库连接";
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspacePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WorkspaceDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Test;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_WorkspaceServer;
        private DevExpress.XtraEditors.TextEdit txt_WorkspacePassword;
        private DevExpress.XtraEditors.TextEdit txt_WorkspaceUsername;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_WorkspaceDatabase;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}