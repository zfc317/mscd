using System;
using System.Collections.Generic;
using System.Linq;
using MSCD.Model;
using MSCD.Services;
using LayerCatalog = MSCD.BLL.LayerCatalog;
using LayerType = MSCD.BLL.LayerType;

namespace MSCD.UI.LayerManager
{
    public partial class DlgLayerCatalog : DevExpress.XtraEditors.XtraForm
    {
        private readonly LayerCatalog _bll=new LayerCatalog();
        private List<LayerInfo> unclassifiedLayer=new List<LayerInfo>();
        public DlgLayerCatalog()
        {
            InitializeComponent();
            InitUnclassified();
            InitClassified();
        }

        private void InitUnclassified()
        {
            var layerCatalogs = _bll.GetModelList("");
            var layerInfos = LayerService.INSTANCE.GetStationLayerInfos();
            foreach (var layerInfo in layerInfos.Where(layerInfo => layerCatalogs.All(layerCatalog => layerCatalog.layerName != layerInfo.LayerName)))
            {
                unclassifiedLayer.Add(layerInfo);
            }
            listBox_Unclassified.DataSource = unclassifiedLayer;
            listBox_Unclassified.DisplayMember = "LayerCaption";
            listBox_Unclassified.ValueMember = "LayerName";

        }

        private void InitClassified()
        {
            var layerTypeBll = new LayerType();
            var layerTypes = layerTypeBll.GetModelList("");
            lookUpEdit_LayerType.Properties.DataSource = layerTypes;
            lookUpEdit_LayerType.Properties.DisplayMember = "Name";
            lookUpEdit_LayerType.Properties.ValueMember = "id";
            if(layerTypes.Count>0)
            {
                lookUpEdit_LayerType.EditValue = layerTypes[0].id;
            }
        }

        private void lookUpEdit_LayerType_EditValueChanged(object sender, System.EventArgs e)
        {
            var editValue = lookUpEdit_LayerType.EditValue;
            if(editValue!=null)
            {
                var layerCatalogs = _bll.GetModelList(string.Format("typeId = {0}", editValue));
                listBox_Classified.DataSource = layerCatalogs;
                listBox_Classified.DisplayMember = "layerCaption";
                listBox_Classified.ValueMember = "layerName";
            }
        }

        private void btn_Add_Click(object sender, System.EventArgs e)
        {
            var checkItems = listBox_Unclassified.CheckedItems;
            var typeId = Convert.ToInt32(lookUpEdit_LayerType.EditValue);
            foreach (LayerInfo checkItem in checkItems)
            {
                if(checkItem!=null)
                {
                    var layerCatalog = new Model.LayerCatalog { typeId = typeId, layerName = checkItem.LayerName, layerCaption = checkItem.LayerCaption };
                    var layerCatalogId = _bll.Add(layerCatalog);
                    layerCatalog.id = layerCatalogId;
                    if (layerCatalogId > 0)
                    {
                        (listBox_Classified.DataSource as List<Model.LayerCatalog>).Add(layerCatalog);
                        (listBox_Unclassified.DataSource as List<LayerInfo>).Remove(checkItem);
                    }
                }
            }
            listBox_Classified.UnCheckAll();
            listBox_Unclassified.UnCheckAll();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            var checkItems = listBox_Classified.CheckedItems;
            foreach (Model.LayerCatalog checkItem in checkItems)
            {
                if(checkItem!=null)
                {
                    if (_bll.Delete(checkItem.id))
                    {
                        (listBox_Classified.DataSource as List<Model.LayerCatalog>).Remove(checkItem);
                        unclassifiedLayer.Add(new LayerInfo() { LayerCaption = checkItem.layerCaption, LayerName = checkItem.layerName });
                    }
                }
            }
            listBox_Classified.UnCheckAll();
            listBox_Unclassified.UnCheckAll();
        }
    }
}