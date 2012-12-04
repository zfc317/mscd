namespace MSCD.UI.LayerManager
{
    partial class DlgLayerType
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Rename = new DevExpress.XtraEditors.SimpleButton();
            this.gc_LayerType = new DevExpress.XtraGrid.GridControl();
            this.gv_LayerType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_LayerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_LayerType)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "已有图层类型：";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(198, 143);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(55, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(198, 172);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(55, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Rename
            // 
            this.btn_Rename.Location = new System.Drawing.Point(198, 201);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(55, 23);
            this.btn_Rename.TabIndex = 2;
            this.btn_Rename.Text = "重命名";
            this.btn_Rename.Click += new System.EventHandler(this.btn_Rename_Click);
            // 
            // gc_LayerType
            // 
            this.gc_LayerType.Location = new System.Drawing.Point(12, 26);
            this.gc_LayerType.MainView = this.gv_LayerType;
            this.gc_LayerType.Name = "gc_LayerType";
            this.gc_LayerType.Size = new System.Drawing.Size(180, 198);
            this.gc_LayerType.TabIndex = 3;
            this.gc_LayerType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_LayerType});
            // 
            // gv_LayerType
            // 
            this.gv_LayerType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.col_name});
            this.gv_LayerType.GridControl = this.gc_LayerType;
            this.gv_LayerType.Name = "gv_LayerType";
            this.gv_LayerType.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // col_name
            // 
            this.col_name.Caption = "类型名称";
            this.col_name.FieldName = "Name";
            this.col_name.Name = "col_name";
            this.col_name.OptionsColumn.AllowEdit = false;
            this.col_name.Visible = true;
            this.col_name.VisibleIndex = 0;
            // 
            // DlgLayerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 229);
            this.Controls.Add(this.gc_LayerType);
            this.Controls.Add(this.btn_Rename);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgLayerType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图层类型管理";
            ((System.ComponentModel.ISupportInitialize)(this.gc_LayerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_LayerType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Rename;
        private DevExpress.XtraGrid.GridControl gc_LayerType;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_LayerType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn col_name;
    }
}