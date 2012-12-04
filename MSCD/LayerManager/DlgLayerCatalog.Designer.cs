namespace MSCD.UI.LayerManager
{
    partial class DlgLayerCatalog
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
            this.lookUpEdit_LayerType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Remove = new DevExpress.XtraEditors.SimpleButton();
            this.listBox_Unclassified = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.listBox_Classified = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_LayerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_Unclassified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_Classified)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "未分类图层：";
            // 
            // lookUpEdit_LayerType
            // 
            this.lookUpEdit_LayerType.Location = new System.Drawing.Point(339, 6);
            this.lookUpEdit_LayerType.Name = "lookUpEdit_LayerType";
            this.lookUpEdit_LayerType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_LayerType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lookUpEdit_LayerType.Properties.ShowHeader = false;
            this.lookUpEdit_LayerType.Size = new System.Drawing.Size(119, 20);
            this.lookUpEdit_LayerType.TabIndex = 2;
            this.lookUpEdit_LayerType.EditValueChanged += new System.EventHandler(this.lookUpEdit_LayerType_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(273, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "图层分类：";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(215, 113);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(42, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = ">";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(215, 157);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(42, 23);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "<";
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // listBox_Unclassified
            // 
            this.listBox_Unclassified.CheckOnClick = true;
            this.listBox_Unclassified.Location = new System.Drawing.Point(12, 32);
            this.listBox_Unclassified.Name = "listBox_Unclassified";
            this.listBox_Unclassified.Size = new System.Drawing.Size(193, 239);
            this.listBox_Unclassified.TabIndex = 5;
            // 
            // listBox_Classified
            // 
            this.listBox_Classified.CheckOnClick = true;
            this.listBox_Classified.Location = new System.Drawing.Point(273, 32);
            this.listBox_Classified.Name = "listBox_Classified";
            this.listBox_Classified.Size = new System.Drawing.Size(185, 239);
            this.listBox_Classified.TabIndex = 5;
            // 
            // DlgLayerCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 283);
            this.Controls.Add(this.listBox_Classified);
            this.Controls.Add(this.listBox_Unclassified);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lookUpEdit_LayerType);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(486, 321);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(486, 321);
            this.Name = "DlgLayerCatalog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图层分类";
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_LayerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_Unclassified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_Classified)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_LayerType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Remove;
        private DevExpress.XtraEditors.CheckedListBoxControl listBox_Unclassified;
        private DevExpress.XtraEditors.CheckedListBoxControl listBox_Classified;
    }
}