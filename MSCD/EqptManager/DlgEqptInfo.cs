using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using MSCD.BLL;
using MSCD.Common;
using MSCD.GIS;
using MSCD.Services;
using SuperMap.Data;
using Padding = DevExpress.XtraLayout.Utils.Padding;

namespace MSCD.UI.EqptManager
{
    public partial class DlgEqptInfo : XtraForm
    {
        private Dictionary<string, string> _eqptValues;
        private List<Model.EqptImage> _eqptImages = new List<Model.EqptImage>(); 
        private readonly string _layerName;
        private readonly int _smId;
        public DlgEqptInfo(int smId, string layerName, Dictionary<string, string> values)
        {
            _eqptValues = values;
            _layerName = layerName;
            _smId = smId;
            InitializeComponent();
            InitEqptInfo();
            InitImageGrid();

            Text = layerName + "属性信息";
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void InitEqptInfo()
        {
            var eqptLayer = LayerService.INSTANCE.GetStationLayerInfos().First(layerInfo => layerInfo.LayerName == _layerName);
            if(eqptLayer==null) return;
            var fieldInfos = eqptLayer.FieldInfos;
            foreach (var fieldInfo in fieldInfos)
            {
                if (!_eqptValues.ContainsKey(fieldInfo.FieldName)) continue;
                var txtValue = _eqptValues[fieldInfo.FieldName];
                var txt = new TextEdit {Text = txtValue, Name = "txt_" + fieldInfo.FieldName};
                txt.Properties.ReadOnly = true;
                var layoutItem = layoutControl_EqptInfo.AddItem(fieldInfo.FieldCaption + ":", txt);
                layoutItem.AppearanceItemCaption.TextOptions.HAlignment=HorzAlignment.Far;
                layoutItem.Padding = new Padding(4);
                
                
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            SetTextEidtReadOnly(false);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var stationDatasourceName = ConfigHelper.GetConfig("StationDatasourceName");
            var datasetName = _layerName;
            var dataset = WorkspaceService.Instance.GetDataset(stationDatasourceName, datasetName) as DatasetVector;
            if (dataset == null) return;
            var rs = dataset.Query(new[] {_smId}, CursorType.Dynamic);
            if (rs.IsEmpty) return;
            var values = GetEditValues();
            rs.MoveFirst();
            rs.Edit();
            rs.SetValues(values);
            XtraMessageBox.Show(rs.Update() ? "编辑成功" : "编辑失败", "提示");
            SetTextEidtReadOnly(true);
            rs.Close();
        }

        private Dictionary<string,object> GetEditValues()
        {
            var values = new Dictionary<string, object>();
            var layoutItems = layoutControlGroup1.Items;
            foreach (LayoutControlItem layoutItem in layoutItems)
            {
                var txtEdit = layoutItem.Control as TextEdit;
                if (txtEdit == null) continue;
                var fieldName = txtEdit.Name.Replace("txt_","");
                values.Add(fieldName, txtEdit.Text);
            }
            return values;
        } 

        private void SetTextEidtReadOnly(bool isReadOnly)
        {
            var layoutItems = layoutControlGroup1.Items;
            foreach (LayoutControlItem layoutItem in layoutItems)
            {
                var txtEdit = layoutItem.Control as TextEdit;
                if (txtEdit != null)
                {
                    txtEdit.Properties.ReadOnly = isReadOnly;
                }
            }
            btn_Save.Enabled = !isReadOnly;
            btn_Cancel.Enabled = !isReadOnly;
            btn_Edit.Enabled = isReadOnly;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            SetTextEidtReadOnly(true);
        }

        private void btn_AddPicture_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog() { Filter = "*.JPG;*.PNG;*.GIF;*.EMF|*.JPG;*.PNG;*.GIF;*.EMF" };
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var fs = File.OpenRead(fileName);
                var imgeByte = new byte[fs.Length];
                fs.Read(imgeByte, 0, imgeByte.Length);
                fs.Close();

                var eqptImageBll=new EqptImage();
                var eqptImageModel = new Model.EqptImage();
                eqptImageModel.Image = imgeByte;
                eqptImageModel.ImageName = Path.GetFileName(fileName);
                eqptImageModel.LayerName = _layerName;
                eqptImageModel.SmId = _smId;
                var imageId = eqptImageBll.Add(eqptImageModel);
                if(imageId>0)
                {
                    eqptImageModel.Id = imageId;
                    var ms = new MemoryStream(imgeByte);
                    pictureEdit_EqptImage.Image = Image.FromStream(ms);
                    _eqptImages.Add(eqptImageModel);
                    gc_Image.RefreshDataSource();
                    gv_Image.FocusedRowHandle = gv_Image.RowCount - 1;
                    ms.Close();
                    GC.Collect();
                }
            }
        }

        private void InitImageGrid()
        {
            var eqptImageBll = new EqptImage();
            _eqptImages =
                eqptImageBll.GetModelList(String.Format("SmId = {0} and LayerName = '{1}'", _smId, _layerName));
            gc_Image.DataSource = _eqptImages;
        }

        private void gv_Image_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_Image.FocusedRowHandle < 0)
            {
                pictureEdit_EqptImage.Image = null;
                return;
            }
            var imageId = Convert.ToInt32(gv_Image.GetFocusedRowCellValue("Id"));
            var eqptImage = _eqptImages.First(image => image.Id == imageId);
            var ms = new MemoryStream(eqptImage.Image);
            pictureEdit_EqptImage.Image = null;
            pictureEdit_EqptImage.Image = Image.FromStream(ms, true);
            ms.Close();
            GC.Collect();
        }

        private void NextImage()
        {
            if (gv_Image.RowCount <= 0) return;
            var currentHandle = gv_Image.FocusedRowHandle + 1;
            gv_Image.FocusedRowHandle = currentHandle >= gv_Image.RowCount ? 0 : currentHandle;
        }

        private void PreImage()
        {
            if (gv_Image.RowCount <= 0) return;
            var currentHandle = gv_Image.FocusedRowHandle - 1;
            if (currentHandle < 0)
            {
                gv_Image.FocusedRowHandle = gv_Image.RowCount-1;
            }
            else
            {
                gv_Image.FocusedRowHandle = currentHandle;
            }
        }

        private void btn_DeletePicture_Click(object sender, EventArgs e)
        {
            if (gv_Image.FocusedRowHandle < 0) return;
            var eqptImageBll = new EqptImage();
            var imageId = Convert.ToInt32(gv_Image.GetFocusedRowCellValue("Id"));
            if(XtraMessageBox.Show("删除后不可恢复，您确定要删除？","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if (eqptImageBll.Delete(imageId))
                {
                    var eqptImage = _eqptImages.First(image => image.Id == imageId);
                    NextImage();
                    _eqptImages.Remove(eqptImage);
                    gc_Image.RefreshDataSource();
                    XtraMessageBox.Show("删除成功！", "提示");
                }
                else
                {
                    XtraMessageBox.Show("删除失败！", "提示");
                }
            }
            
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            if(gv_Image.FocusedRowHandle<0) return;
            var imageId = Convert.ToInt32(gv_Image.GetFocusedRowCellValue("Id"));
            var eqptImage = _eqptImages.First(image => image.Id == imageId);
            var fileExtension = Path.GetExtension(eqptImage.ImageName);
            var saveFileDilag = new SaveFileDialog(){Filter =string.Format("*{0}|*{0}",fileExtension),FileName = eqptImage.ImageName};
            if(saveFileDilag.ShowDialog()==DialogResult.OK)
            {
                var fs = File.Create(saveFileDilag.FileName);
                fs.Write(eqptImage.Image, 0, eqptImage.Image.Length);
                fs.Close();
                XtraMessageBox.Show("保存成功！", "提示");
            }
        }

    }
}