namespace MSCD.UI.SystemManager
{
    partial class DlgUserManager
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
            this.gc_User = new DevExpress.XtraGrid.GridControl();
            this.gv_User = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Department = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Tel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_User)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_User
            // 
            this.gc_User.Location = new System.Drawing.Point(5, 3);
            this.gc_User.MainView = this.gv_User;
            this.gc_User.Name = "gc_User";
            this.gc_User.Size = new System.Drawing.Size(594, 299);
            this.gc_User.TabIndex = 0;
            this.gc_User.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_User});
            // 
            // gv_User
            // 
            this.gv_User.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Id,
            this.col_UserName,
            this.col_Password,
            this.col_Name,
            this.col_Department,
            this.col_Tel,
            this.col_Phone,
            this.col_Remark});
            this.gv_User.GridControl = this.gc_User;
            this.gv_User.Name = "gv_User";
            this.gv_User.OptionsView.ShowGroupPanel = false;
            // 
            // col_Id
            // 
            this.col_Id.Caption = "gridColumn1";
            this.col_Id.FieldName = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.OptionsColumn.AllowEdit = false;
            // 
            // col_UserName
            // 
            this.col_UserName.Caption = "用户名";
            this.col_UserName.FieldName = "Username";
            this.col_UserName.Name = "col_UserName";
            this.col_UserName.OptionsColumn.AllowEdit = false;
            this.col_UserName.Visible = true;
            this.col_UserName.VisibleIndex = 0;
            // 
            // col_Password
            // 
            this.col_Password.Caption = "gridColumn3";
            this.col_Password.FieldName = "Password";
            this.col_Password.Name = "col_Password";
            this.col_Password.OptionsColumn.AllowEdit = false;
            // 
            // col_Name
            // 
            this.col_Name.Caption = "姓名";
            this.col_Name.FieldName = "Name";
            this.col_Name.Name = "col_Name";
            this.col_Name.OptionsColumn.AllowEdit = false;
            this.col_Name.Visible = true;
            this.col_Name.VisibleIndex = 1;
            // 
            // col_Department
            // 
            this.col_Department.Caption = "部门";
            this.col_Department.FieldName = "Department";
            this.col_Department.Name = "col_Department";
            this.col_Department.OptionsColumn.AllowEdit = false;
            this.col_Department.Visible = true;
            this.col_Department.VisibleIndex = 2;
            // 
            // col_Tel
            // 
            this.col_Tel.Caption = "电话";
            this.col_Tel.FieldName = "Tel";
            this.col_Tel.Name = "col_Tel";
            this.col_Tel.OptionsColumn.AllowEdit = false;
            this.col_Tel.Visible = true;
            this.col_Tel.VisibleIndex = 3;
            // 
            // col_Phone
            // 
            this.col_Phone.Caption = "手机";
            this.col_Phone.FieldName = "Phone";
            this.col_Phone.Name = "col_Phone";
            this.col_Phone.OptionsColumn.AllowEdit = false;
            this.col_Phone.Visible = true;
            this.col_Phone.VisibleIndex = 4;
            // 
            // col_Remark
            // 
            this.col_Remark.Caption = "备注";
            this.col_Remark.FieldName = "Remark";
            this.col_Remark.Name = "col_Remark";
            this.col_Remark.OptionsColumn.AllowEdit = false;
            this.col_Remark.Visible = true;
            this.col_Remark.VisibleIndex = 5;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(548, 309);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(51, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "取 消";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(491, 309);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(51, 23);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "删 除";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(434, 309);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(51, 23);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "修 改";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(377, 309);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(51, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "添 加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // DlgUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 341);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.gc_User);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgUserManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.gc_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_User;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_User;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraGrid.Columns.GridColumn col_Id;
        private DevExpress.XtraGrid.Columns.GridColumn col_UserName;
        private DevExpress.XtraGrid.Columns.GridColumn col_Password;
        private DevExpress.XtraGrid.Columns.GridColumn col_Name;
        private DevExpress.XtraGrid.Columns.GridColumn col_Department;
        private DevExpress.XtraGrid.Columns.GridColumn col_Tel;
        private DevExpress.XtraGrid.Columns.GridColumn col_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn col_Remark;
    }
}