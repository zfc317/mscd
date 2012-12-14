using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MSCD.Common;
using MSCD.GIS;
using MSCD.Model;
using MSCD.Services;
using SuperMap.Data;

namespace MSCD.UI.EqptManager
{
    public partial class DlgAttributeQuery : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _mapType ="station";
        List<LayerInfo> _layerList = new List<LayerInfo>();
        private readonly MainForm _mainForm;
        public DlgAttributeQuery(string mapType,MainForm mainForm)
        {
            InitializeComponent();
            _mapType = mapType;
            _mainForm = mainForm;
            InitLayer();
        }

        private void InitLayer()
        {
            
            switch (_mapType)
            {
                case "station":
                    _layerList = LayerService.INSTANCE.GetStationLayerInfos().Where(l => l.Queryable).ToList();
                    break;
                case "site":
                    _layerList = LayerService.INSTANCE.GetSiteLayerInfos().Where(l => l.Queryable).ToList();
                    break;
            }

            lookUpEdit_Layer.Properties.DataSource = _layerList;
        }

        private void lookUpEdit_Layer_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as LookUpEdit;
            if(lookUp.EditValue!=null)
            {
                var layerinfo = (LayerInfo) lookUpEdit_Layer.GetSelectedDataRow();
                lookUpEdit_Field.Properties.DataSource = layerinfo.FieldInfos;
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            if(lookUpEdit_Field.EditValue==null||lookUpEdit_Layer.EditValue==null)
            {
                XtraMessageBox.Show("请选择要查询的图层及字段！", "提示");
                return;
            }

            var layerName = lookUpEdit_Layer.EditValue.ToString();
            var fieldName = lookUpEdit_Field.EditValue.ToString();
            var dt = WorkspaceService.Instance.GetDataset(ConfigHelper.GetConfig("StationDatasourceName"),
                                                 layerName) as DatasetVector;
            string queryFilter = "";
            var keyword = txt_Keyword.Text.Trim();
            queryFilter = string.IsNullOrEmpty(keyword) ? "" : string.Format("{0} like '%{1}%'", fieldName, keyword);

            var rs = dt.Query(queryFilter, CursorType.Static);
            var selectedLayer = (LayerInfo) lookUpEdit_Layer.GetSelectedDataRow();
            var datatable = GISUtility.RecordsetToDataTable(rs, selectedLayer);
            rs.Close();
            rs.Dispose();
            dt.Close();
            _mainForm.ShowQueryResult();
            _mainForm.CreateQueryResultGrid(datatable, selectedLayer);
            this.Close();

        }
    }
}