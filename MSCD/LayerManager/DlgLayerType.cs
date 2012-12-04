using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MSCD.BLL;
using MSCD.Services;

namespace MSCD.UI.LayerManager
{
    public partial class DlgLayerType : DevExpress.XtraEditors.XtraForm
    {
        private List<Model.LayerType> _layerTypes;
        private LayerType _layerTypeBll = new LayerType();
        public DlgLayerType()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitLayerType();
        }

        private void InitLayerType()
        {

            _layerTypes = _layerTypeBll.GetModelList("");
            gc_LayerType.DataSource = _layerTypes;
            var layers = LayerService.INSTANCE.GetStationLayerInfos();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var dlgAddLayerType = new DlgAddLayerType(ref _layerTypes,new Model.LayerType(), LayerTypeEditType.Add);
            if(dlgAddLayerType.ShowDialog()==DialogResult.OK)
            {
                gc_LayerType.RefreshDataSource();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(gv_LayerType.GetFocusedRow()!=null)
            {
               var id= Convert.ToInt32(gv_LayerType.GetFocusedRowCellValue("id"));
                var deleteLayerType = _layerTypes.First(layertype => layertype.id == id);
               if (XtraMessageBox.Show("一旦删除后，归属改类型的图层也将删除，将不可恢复，您确定删除该图层类型？","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
               {
                   if (_layerTypeBll.Delete(id))
                   {
                       _layerTypes.Remove(deleteLayerType);
                       gc_LayerType.RefreshDataSource();
                       XtraMessageBox.Show("删除成功！", "提示");
                   }
                   else
                   {
                       XtraMessageBox.Show("删除失败！", "提示");
                   }
               }
            }
        }

        private void btn_Rename_Click(object sender, EventArgs e)
        {
            if(gv_LayerType.GetFocusedRow()==null)
            {
                XtraMessageBox.Show("请选择要重命名的数据！", "提示");
                return;
            }
            var id =Convert.ToInt32(gv_LayerType.GetFocusedRowCellValue("id"));
            var name = gv_LayerType.GetFocusedRowCellValue("Name").ToString();
            var updateModel =new Model.LayerType(){id = id,Name = name};
            var dlgAddLayerType = new DlgAddLayerType(ref _layerTypes, updateModel, LayerTypeEditType.Rename)
                                      {Text = "修改图层类型名称"};
            if (dlgAddLayerType.ShowDialog() == DialogResult.OK)
            {
                gc_LayerType.RefreshDataSource();
            }
        }
    }
}