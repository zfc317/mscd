namespace MSCD.UI.LayerManager
{
    partial class DlgLayerFilter
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
            this.lookUpEdit_Field = new DevExpress.XtraEditors.LookUpEdit();
            this.commbox_Condition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_Keyword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Ok = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Field.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commbox_Condition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Keyword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit_Field
            // 
            this.lookUpEdit_Field.Location = new System.Drawing.Point(93, 12);
            this.lookUpEdit_Field.Name = "lookUpEdit_Field";
            this.lookUpEdit_Field.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_Field.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FieldCaption", "Name1"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FieldName", "Name2", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lookUpEdit_Field.Properties.DisplayMember = "FieldCaption";
            this.lookUpEdit_Field.Properties.ShowHeader = false;
            this.lookUpEdit_Field.Properties.ValueMember = "FieldName";
            this.lookUpEdit_Field.Size = new System.Drawing.Size(189, 20);
            this.lookUpEdit_Field.TabIndex = 0;
            // 
            // commbox_Condition
            // 
            this.commbox_Condition.EditValue = "包含";
            this.commbox_Condition.Location = new System.Drawing.Point(93, 49);
            this.commbox_Condition.Name = "commbox_Condition";
            this.commbox_Condition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.commbox_Condition.Properties.Items.AddRange(new object[] {
            "包含",
            "等于",
            "不包含"});
            this.commbox_Condition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.commbox_Condition.Size = new System.Drawing.Size(189, 20);
            this.commbox_Condition.TabIndex = 1;
            // 
            // txt_Keyword
            // 
            this.txt_Keyword.Location = new System.Drawing.Point(93, 85);
            this.txt_Keyword.Name = "txt_Keyword";
            this.txt_Keyword.Size = new System.Drawing.Size(189, 20);
            this.txt_Keyword.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "筛选字段：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "筛选条件：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 14);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "筛选关键字：";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.Location = new System.Drawing.Point(230, 111);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(52, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "取消";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(172, 111);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(52, 23);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.Text = "确定";
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // DlgLayerFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 144);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_Keyword);
            this.Controls.Add(this.commbox_Condition);
            this.Controls.Add(this.lookUpEdit_Field);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(312, 182);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(312, 182);
            this.Name = "DlgLayerFilter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图层显示筛选";
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Field.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commbox_Condition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Keyword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_Field;
        private DevExpress.XtraEditors.ComboBoxEdit commbox_Condition;
        private DevExpress.XtraEditors.TextEdit txt_Keyword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_Ok;
    }
}