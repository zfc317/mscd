namespace MSCD.UI.EqptManager
{
    partial class DlgMaintainQuery
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
            this.commbox_QueryType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Keyword = new DevExpress.XtraEditors.LabelControl();
            this.txt_Keyword = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit_Start = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit_end = new DevExpress.XtraEditors.DateEdit();
            this.lbl_EndDate = new DevExpress.XtraEditors.LabelControl();
            this.lbl_StartDate = new DevExpress.XtraEditors.LabelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.commbox_QueryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Keyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_end.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_end.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // commbox_QueryType
            // 
            this.commbox_QueryType.EditValue = "按维护名称查询";
            this.commbox_QueryType.Location = new System.Drawing.Point(78, 12);
            this.commbox_QueryType.Name = "commbox_QueryType";
            this.commbox_QueryType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.commbox_QueryType.Properties.Items.AddRange(new object[] {
            "按维护名称查询",
            "按设施类型查询",
            "按维护部门查询",
            "按设施名称查询",
            "按维护类型查询",
            "按维护人员查询",
            "按验收人员查询",
            "按记录时间查询",
            "按维护时间查询",
            "按下次维护时间查询"});
            this.commbox_QueryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.commbox_QueryType.Size = new System.Drawing.Size(174, 20);
            this.commbox_QueryType.TabIndex = 0;
            this.commbox_QueryType.SelectedIndexChanged += new System.EventHandler(this.commbox_QueryType_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "查询类型：";
            // 
            // lbl_Keyword
            // 
            this.lbl_Keyword.Location = new System.Drawing.Point(24, 44);
            this.lbl_Keyword.Name = "lbl_Keyword";
            this.lbl_Keyword.Size = new System.Drawing.Size(48, 14);
            this.lbl_Keyword.TabIndex = 1;
            this.lbl_Keyword.Text = "关键字：";
            // 
            // txt_Keyword
            // 
            this.txt_Keyword.Location = new System.Drawing.Point(78, 41);
            this.txt_Keyword.Name = "txt_Keyword";
            this.txt_Keyword.Size = new System.Drawing.Size(174, 20);
            this.txt_Keyword.TabIndex = 2;
            // 
            // dateEdit_Start
            // 
            this.dateEdit_Start.EditValue = null;
            this.dateEdit_Start.Location = new System.Drawing.Point(78, 41);
            this.dateEdit_Start.Name = "dateEdit_Start";
            this.dateEdit_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Start.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit_Start.Size = new System.Drawing.Size(174, 20);
            this.dateEdit_Start.TabIndex = 3;
            this.dateEdit_Start.Visible = false;
            // 
            // dateEdit_end
            // 
            this.dateEdit_end.EditValue = null;
            this.dateEdit_end.Location = new System.Drawing.Point(78, 67);
            this.dateEdit_end.Name = "dateEdit_end";
            this.dateEdit_end.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_end.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit_end.Size = new System.Drawing.Size(174, 20);
            this.dateEdit_end.TabIndex = 3;
            this.dateEdit_end.Visible = false;
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.Location = new System.Drawing.Point(12, 70);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(60, 14);
            this.lbl_EndDate.TabIndex = 1;
            this.lbl_EndDate.Text = "终止时间：";
            this.lbl_EndDate.Visible = false;
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.Location = new System.Drawing.Point(12, 44);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(60, 14);
            this.lbl_StartDate.TabIndex = 1;
            this.lbl_StartDate.Text = "起始时间：";
            this.lbl_StartDate.Visible = false;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(161, 100);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(43, 23);
            this.btn_Query.TabIndex = 4;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(210, 99);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(43, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "取消";
            // 
            // DlgMaintainQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 134);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.dateEdit_end);
            this.Controls.Add(this.txt_Keyword);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.lbl_Keyword);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.commbox_QueryType);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.dateEdit_Start);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(281, 172);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(281, 172);
            this.Name = "DlgMaintainQuery";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设施维护查询";
            ((System.ComponentModel.ISupportInitialize)(this.commbox_QueryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Keyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_end.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_end.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit commbox_QueryType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_Keyword;
        private DevExpress.XtraEditors.TextEdit txt_Keyword;
        private DevExpress.XtraEditors.DateEdit dateEdit_Start;
        private DevExpress.XtraEditors.DateEdit dateEdit_end;
        private DevExpress.XtraEditors.LabelControl lbl_EndDate;
        private DevExpress.XtraEditors.LabelControl lbl_StartDate;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}