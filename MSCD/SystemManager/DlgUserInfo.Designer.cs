namespace MSCD.UI.SystemManager
{
    partial class DlgUserInfo
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Username = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_PasswordConfirm = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Department = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Tel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Phone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.commbox_UserRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Ok = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PasswordConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Department.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commbox_UserRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用 户 名：";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(72, 14);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(167, 20);
            this.txt_Username.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "用户名不能为空！";
            this.dxValidationProvider1.SetValidationRule(this.txt_Username, conditionValidationRule2);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(254, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "确认密码：";
            // 
            // txt_PasswordConfirm
            // 
            this.txt_PasswordConfirm.Location = new System.Drawing.Point(323, 40);
            this.txt_PasswordConfirm.Name = "txt_PasswordConfirm";
            this.txt_PasswordConfirm.Properties.PasswordChar = '*';
            this.txt_PasswordConfirm.Size = new System.Drawing.Size(152, 20);
            this.txt_PasswordConfirm.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(254, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "姓      名：";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(323, 12);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(152, 20);
            this.txt_Name.TabIndex = 1;
            conditionValidationRule3.ErrorText = "用户姓名不能为空！";
            this.dxValidationProvider1.SetValidationRule(this.txt_Name, conditionValidationRule3);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "部     门：";
            // 
            // txt_Department
            // 
            this.txt_Department.Location = new System.Drawing.Point(72, 92);
            this.txt_Department.Name = "txt_Department";
            this.txt_Department.Size = new System.Drawing.Size(167, 20);
            this.txt_Department.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 69);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "电     话：";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(72, 66);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(167, 20);
            this.txt_Tel.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(254, 69);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "手      机：";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(323, 66);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(152, 20);
            this.txt_Phone.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(254, 95);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 14);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "角      色：";
            // 
            // commbox_UserRole
            // 
            this.commbox_UserRole.EditValue = "普通用户";
            this.commbox_UserRole.Location = new System.Drawing.Point(323, 92);
            this.commbox_UserRole.Name = "commbox_UserRole";
            this.commbox_UserRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.commbox_UserRole.Properties.Items.AddRange(new object[] {
            "普通用户",
            "管理员"});
            this.commbox_UserRole.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.commbox_UserRole.Size = new System.Drawing.Size(152, 20);
            this.commbox_UserRole.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 124);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 14);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "备     注：";
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(72, 122);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(403, 117);
            this.txt_Remark.TabIndex = 8;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(425, 245);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(50, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "取消";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(360, 245);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(50, 23);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.Text = "确定";
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(10, 43);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(56, 14);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "密     码：";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(72, 40);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(167, 20);
            this.txt_Password.TabIndex = 2;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule1.Control = this.txt_PasswordConfirm;
            compareAgainstControlValidationRule1.ErrorText = "两次密码不匹配！";
            this.dxValidationProvider1.SetValidationRule(this.txt_Password, compareAgainstControlValidationRule1);
            // 
            // DlgUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 273);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_Remark);
            this.Controls.Add(this.commbox_UserRole);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_Department);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txt_PasswordConfirm);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(503, 311);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(503, 311);
            this.Name = "DlgUserInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户信息";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PasswordConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Department.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commbox_UserRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Username;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_PasswordConfirm;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Department;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Tel;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_Phone;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit commbox_UserRole;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Ok;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}