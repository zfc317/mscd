namespace MSCD.UI.EqptManager
{
    partial class DlgAttributeQuery
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
            this.lookUpEdit_Layer = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_Field = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Keyword = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Layer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Field.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Keyword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit_Layer
            // 
            this.lookUpEdit_Layer.Location = new System.Drawing.Point(73, 11);
            this.lookUpEdit_Layer.Name = "lookUpEdit_Layer";
            this.lookUpEdit_Layer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_Layer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LayerName", "图层名称", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LayerCaption", "图层标题"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FieldInfos", "字段", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lookUpEdit_Layer.Properties.DisplayMember = "LayerCaption";
            this.lookUpEdit_Layer.Properties.NullText = "[请选择图层]";
            this.lookUpEdit_Layer.Properties.ShowHeader = false;
            this.lookUpEdit_Layer.Properties.ValueMember = "LayerName";
            this.lookUpEdit_Layer.Size = new System.Drawing.Size(194, 20);
            this.lookUpEdit_Layer.TabIndex = 0;
            this.lookUpEdit_Layer.EditValueChanged += new System.EventHandler(this.lookUpEdit_Layer_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "图层：";
            // 
            // lookUpEdit_Field
            // 
            this.lookUpEdit_Field.Location = new System.Drawing.Point(73, 37);
            this.lookUpEdit_Field.Name = "lookUpEdit_Field";
            this.lookUpEdit_Field.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_Field.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FieldName", "字段名称", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FieldCaption", "字段标题")});
            this.lookUpEdit_Field.Properties.DisplayMember = "FieldCaption";
            this.lookUpEdit_Field.Properties.NullText = "[请选择字段]";
            this.lookUpEdit_Field.Properties.ShowHeader = false;
            this.lookUpEdit_Field.Properties.ValueMember = "FieldName";
            this.lookUpEdit_Field.Size = new System.Drawing.Size(194, 20);
            this.lookUpEdit_Field.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "字段：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "关键字：";
            // 
            // txt_Keyword
            // 
            this.txt_Keyword.Location = new System.Drawing.Point(73, 63);
            this.txt_Keyword.Name = "txt_Keyword";
            this.txt_Keyword.Size = new System.Drawing.Size(194, 20);
            this.txt_Keyword.TabIndex = 3;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(153, 89);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(54, 23);
            this.btn_Query.TabIndex = 4;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(213, 89);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(54, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "取消";
            // 
            // DlgAttributeQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 120);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.txt_Keyword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lookUpEdit_Field);
            this.Controls.Add(this.lookUpEdit_Layer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(293, 158);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(293, 158);
            this.Name = "DlgAttributeQuery";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "属性查询";
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Layer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Field.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Keyword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_Layer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_Field;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Keyword;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;

    }
}