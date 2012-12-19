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
using EqptMaintain = MSCD.BLL.EqptMaintain;

namespace MSCD.UI.EqptManager
{
    public partial class DlgMaintainQuery : DevExpress.XtraEditors.XtraForm
    {
        private MainForm _mainForm;
        public DlgMaintainQuery(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            dateEdit_Start.DateTime = DateTime.Now.AddDays(-30);
            dateEdit_end.DateTime = DateTime.Now;
        }



        private void btn_Query_Click(object sender, EventArgs e)
        {
            if (commbox_QueryType.SelectedIndex < 6)
            {
                if (txt_Keyword.Text.Trim() == "")
                {
                    XtraMessageBox.Show("请输入查询关键字!");
                    return;
                }

            }
            else
            {
                if (dateEdit_Start.DateTime > dateEdit_end.DateTime)
                {
                    XtraMessageBox.Show("起始时间不能的大于终止时间!");
                    return;
                }
            }

            var searchStr = "";
            switch (commbox_QueryType.SelectedIndex)
            {
                case 0:
                    searchStr = string.Format("Name like '%{0}%'", txt_Keyword.Text);
                    break;
                case 1:
                    searchStr = string.Format("LayerName like '%{0}%'", txt_Keyword.Text);
                    break;
                case 2:
                    searchStr = string.Format("Department like '%{0}%'", txt_Keyword.Text);
                    break;
                case 3:
                    searchStr = string.Format("Maintainer like '%{0}%'", txt_Keyword.Text);
                    break;
                case 4:
                    searchStr = string.Format("EqptName like '%{0}%'", txt_Keyword.Text);
                    break;
                case 5:
                    searchStr = string.Format("Checker like '%{0}%'", txt_Keyword.Text);
                    break;
                case 6:
                    searchStr = string.Format("RecordDate between '{0}' and '{1}'", dateEdit_Start.DateTime,dateEdit_end.DateTime);
                    break;
                case 7:
                    searchStr = string.Format("MaintainDate between '{0}' and '{1}'", dateEdit_Start.DateTime, dateEdit_end.DateTime);
                    break;
                case 8:
                    searchStr = string.Format("NextMaintainDate between '{0}' and '{1}'", dateEdit_Start.DateTime, dateEdit_end.DateTime);
                    break;
            }

            if(searchStr!="")
            {
                var maintainBll = new EqptMaintain();
                var maintains = maintainBll.GetModelList(searchStr);
                var layerEqpts = new Dictionary<string, List<int>>();
                foreach (var eqptMaintain in maintains)
                {
                    if(layerEqpts.ContainsKey(eqptMaintain.LayerName))
                    {
                        layerEqpts[eqptMaintain.LayerName].Add(eqptMaintain.SmId);
                    }
                    else
                    {
                        layerEqpts.Add(eqptMaintain.LayerName, new List<int>() { eqptMaintain.SmId });
                    }
                }

                if(layerEqpts.Count<0) return;
                _mainForm.ShowQueryResult();
                foreach (var layerEqpt in layerEqpts)
                {
                    var layerinfo = LayerService.INSTANCE.GetStationLayerInfos().Any(l=>l.LayerName==layerEqpt.Key) ? LayerService.INSTANCE.GetStationLayerInfos().First(l => l.LayerName == layerEqpt.Key) : LayerService.INSTANCE.GetSiteLayerInfos().First(l => l.LayerName == layerEqpt.Key);

                    if(layerinfo!=null)
                    {
                        var dt = WorkspaceService.Instance.GetDataset(ConfigHelper.GetConfig("StationDatasourceName"), layerEqpt.Key) as DatasetVector;
                        if (dt != null)
                        {
                            var rs = dt.Query(layerEqpt.Value.ToArray(), CursorType.Static);
                            var datatable = GISUtility.RecordsetToDataTable(rs, layerinfo);
                            rs.Close();
                            rs.Dispose();
                            dt.Close();

                            _mainForm.CreateQueryResultGrid(datatable, layerinfo);
                        }
                    }
                }
            }
        }

        private void commbox_QueryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (commbox_QueryType.SelectedIndex < 6)
            {
                lbl_Keyword.Visible = true;
                txt_Keyword.Visible = true;
                dateEdit_Start.Visible = false;
                dateEdit_end.Visible = false;
                lbl_StartDate.Visible = false;
                lbl_EndDate.Visible = false;

                if (txt_Keyword.Text.Trim() == "")
                {
                    XtraMessageBox.Show("请输入查询关键字!");
                    return;
                }

            }
            else
            {
                lbl_Keyword.Visible = false;
                txt_Keyword.Visible = false;
                dateEdit_Start.Visible = true;
                dateEdit_end.Visible = true;
                lbl_StartDate.Visible = true;
                lbl_EndDate.Visible = true;

                if (dateEdit_Start.DateTime > dateEdit_end.DateTime)
                {
                    XtraMessageBox.Show("起始时间不能的大于终止时间!");
                    return;
                }
            }
        }
    }
}