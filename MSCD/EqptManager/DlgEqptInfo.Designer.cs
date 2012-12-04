namespace MSCD.UI.EqptManager
{
    partial class DlgEqptInfo
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabPage_Picture = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pictureEdit_EqptImage = new DevExpress.XtraEditors.PictureEdit();
            this.btn_DeletePicture = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddPicture = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Image = new DevExpress.XtraGrid.GridControl();
            this.gv_Image = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ImageId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ImageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.tabPage_Attachment = new DevExpress.XtraTab.XtraTabPage();
            this.tabPage_Maintain = new DevExpress.XtraTab.XtraTabPage();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl_EqptInfo = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btn_Download = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabPage_Picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_EqptImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_EqptInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(230, 393);
            this.panelControl1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabPage_Picture;
            this.xtraTabControl1.Size = new System.Drawing.Size(226, 389);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPage_Picture,
            this.tabPage_Attachment,
            this.tabPage_Maintain});
            // 
            // tabPage_Picture
            // 
            this.tabPage_Picture.Controls.Add(this.splitContainerControl1);
            this.tabPage_Picture.Name = "tabPage_Picture";
            this.tabPage_Picture.Size = new System.Drawing.Size(220, 360);
            this.tabPage_Picture.Text = "图片";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.pictureEdit_EqptImage);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_DeletePicture);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Download);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_AddPicture);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gc_Image);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(220, 360);
            this.splitContainerControl1.SplitterPosition = 210;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // pictureEdit_EqptImage
            // 
            this.pictureEdit_EqptImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit_EqptImage.Location = new System.Drawing.Point(7, 3);
            this.pictureEdit_EqptImage.Name = "pictureEdit_EqptImage";
            this.pictureEdit_EqptImage.Properties.ShowMenu = false;
            this.pictureEdit_EqptImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit_EqptImage.Size = new System.Drawing.Size(210, 169);
            this.pictureEdit_EqptImage.TabIndex = 0;
            // 
            // btn_DeletePicture
            // 
            this.btn_DeletePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeletePicture.Location = new System.Drawing.Point(172, 180);
            this.btn_DeletePicture.Name = "btn_DeletePicture";
            this.btn_DeletePicture.Size = new System.Drawing.Size(45, 22);
            this.btn_DeletePicture.TabIndex = 4;
            this.btn_DeletePicture.Text = "删除";
            this.btn_DeletePicture.Click += new System.EventHandler(this.btn_DeletePicture_Click);
            // 
            // btn_AddPicture
            // 
            this.btn_AddPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddPicture.Location = new System.Drawing.Point(64, 180);
            this.btn_AddPicture.Name = "btn_AddPicture";
            this.btn_AddPicture.Size = new System.Drawing.Size(48, 22);
            this.btn_AddPicture.TabIndex = 7;
            this.btn_AddPicture.Text = "添加";
            this.btn_AddPicture.Click += new System.EventHandler(this.btn_AddPicture_Click);
            // 
            // gc_Image
            // 
            this.gc_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Image.Location = new System.Drawing.Point(0, 0);
            this.gc_Image.MainView = this.gv_Image;
            this.gc_Image.Name = "gc_Image";
            this.gc_Image.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2});
            this.gc_Image.Size = new System.Drawing.Size(220, 144);
            this.gc_Image.TabIndex = 0;
            this.gc_Image.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Image});
            // 
            // gv_Image
            // 
            this.gv_Image.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gv_Image.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gv_Image.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gv_Image.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gv_Image.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ImageId,
            this.col_ImageName});
            this.gv_Image.GridControl = this.gc_Image;
            this.gv_Image.Name = "gv_Image";
            this.gv_Image.OptionsView.ShowGroupPanel = false;
            this.gv_Image.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Image_FocusedRowChanged);
            // 
            // col_ImageId
            // 
            this.col_ImageId.Caption = "gridColumn1";
            this.col_ImageId.FieldName = "Id";
            this.col_ImageId.Name = "col_ImageId";
            // 
            // col_ImageName
            // 
            this.col_ImageName.Caption = "名称";
            this.col_ImageName.FieldName = "ImageName";
            this.col_ImageName.Name = "col_ImageName";
            this.col_ImageName.OptionsColumn.AllowEdit = false;
            this.col_ImageName.Visible = true;
            this.col_ImageName.VisibleIndex = 0;
            this.col_ImageName.Width = 101;
            // 
            // repositoryItemHyperLinkEdit2
            // 
            this.repositoryItemHyperLinkEdit2.AutoHeight = false;
            this.repositoryItemHyperLinkEdit2.Caption = "下载";
            this.repositoryItemHyperLinkEdit2.Name = "repositoryItemHyperLinkEdit2";
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // tabPage_Attachment
            // 
            this.tabPage_Attachment.Name = "tabPage_Attachment";
            this.tabPage_Attachment.Size = new System.Drawing.Size(220, 360);
            this.tabPage_Attachment.Text = "附件";
            // 
            // tabPage_Maintain
            // 
            this.tabPage_Maintain.Name = "tabPage_Maintain";
            this.tabPage_Maintain.Size = new System.Drawing.Size(220, 360);
            this.tabPage_Maintain.Text = "维护";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(585, 367);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(46, 23);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "关闭";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Enabled = false;
            this.btn_Cancel.Location = new System.Drawing.Point(533, 367);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(46, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(481, 367);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(46, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "提交";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.Location = new System.Drawing.Point(429, 367);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(46, 23);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "编辑";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // layoutControl_EqptInfo
            // 
            this.layoutControl_EqptInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl_EqptInfo.Location = new System.Drawing.Point(236, 2);
            this.layoutControl_EqptInfo.Name = "layoutControl_EqptInfo";
            this.layoutControl_EqptInfo.Root = this.layoutControlGroup1;
            this.layoutControl_EqptInfo.Size = new System.Drawing.Size(402, 348);
            this.layoutControl_EqptInfo.TabIndex = 3;
            this.layoutControl_EqptInfo.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(402, 348);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // btn_Download
            // 
            this.btn_Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Download.Location = new System.Drawing.Point(118, 180);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(48, 22);
            this.btn_Download.TabIndex = 7;
            this.btn_Download.Text = "下载";
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // DlgEqptInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 393);
            this.Controls.Add(this.layoutControl_EqptInfo);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgEqptInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EqptInfo";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabPage_Picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_EqptImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_EqptInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraLayout.LayoutControl layoutControl_EqptInfo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabPage_Picture;
        private DevExpress.XtraTab.XtraTabPage tabPage_Attachment;
        private DevExpress.XtraTab.XtraTabPage tabPage_Maintain;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_EqptImage;
        private DevExpress.XtraGrid.GridControl gc_Image;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Image;
        private DevExpress.XtraEditors.SimpleButton btn_AddPicture;
        private DevExpress.XtraEditors.SimpleButton btn_DeletePicture;
        private DevExpress.XtraGrid.Columns.GridColumn col_ImageId;
        private DevExpress.XtraGrid.Columns.GridColumn col_ImageName;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_Download;
    }
}