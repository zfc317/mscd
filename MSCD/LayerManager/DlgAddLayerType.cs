using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MSCD.Model;

namespace MSCD.UI.LayerManager
{
    public partial class DlgAddLayerType : DevExpress.XtraEditors.XtraForm
    {
        private readonly List<LayerType> _layerTypes;
        private readonly LayerTypeEditType _editType;
        private LayerType _layerType;

        public DlgAddLayerType(ref List<LayerType> layerTypes,LayerType layerType,LayerTypeEditType editType)
        {
            InitializeComponent();
            _layerTypes = layerTypes;
            _layerType = layerType;
            _editType = editType;

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            var layerTypeName = txt_LayerName.Text.Trim();
            if(string.IsNullOrEmpty(layerTypeName))
            {
                XtraMessageBox.Show("请输入图层类型名称！", "提示");
                return;
            }

            if(LayerNameExist(layerTypeName))
            {
                XtraMessageBox.Show("该图层类型名称已存在!", "提示");
                return;
            }

            var layerTypeBll = new BLL.LayerType();
            _layerType.Name = layerTypeName;

            switch (_editType)
            {
                case LayerTypeEditType.Add:
                    var layerTypeId = layerTypeBll.Add(_layerType);
                    if (layerTypeId > 0)
                    {
                        _layerType.id = layerTypeId;
                        _layerTypes.Add(_layerType);
                        XtraMessageBox.Show(string.Format("添加图层类型'{0}'成功！",layerTypeName), "提示");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        XtraMessageBox.Show(string.Format("添加'{0}'失败！", layerTypeName), "提示");
                    }
                    break;
                case LayerTypeEditType.Rename:
                    _layerType.Name = layerTypeName;
                    if(layerTypeBll.Update(_layerType))
                    {
                        _layerTypes.First(layerType => layerType.id == _layerType.id).Name = layerTypeName;
                        XtraMessageBox.Show(string.Format("重命名图层类型'{0}'成功！", layerTypeName), "提示");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        XtraMessageBox.Show(string.Format("重命名图层类型'{0}'成功！", layerTypeName), "提示");
                    }
                    break;
            }
            
            

        }

        private bool LayerNameExist(string layerTypeName)
        {
            return _layerTypes.Any(layerType => layerType.Name == layerTypeName);
        }
    }
}