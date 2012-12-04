using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using MSCD.Common;
using MSCD.GIS;
using MSCD.Services;
using MSCD.UI.EqptManager;
using MSCD.UI.LayerManager;
using SuperMap.Data;
using NLog;
using SuperMap.Mapping;
using SuperMap.Realspace;
using SuperMap.UI;
using Action = SuperMap.UI.Action;
using Application = System.Windows.Forms.Application;

namespace MSCD.UI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private Workspace _workspace;
        private WaitDialogForm _waitForm;
        private MapControl _currentMapCtl;
        private Dictionary<string,List<Layer>> _stationLayers=new Dictionary<string, List<Layer>>(); 
        public MainForm()
        {
            InitializeComponent();
            Visible = false;
            InitWorkspace();
            InitStationLayerTree();
            _currentMapCtl = mapCtl_Station;
        }

        #region 视图控制
        private void barCheckItem_LayerControl_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dockPanel_LayerControl.Visible = barCheckItem_LayerControl.Checked;
        }

        private void dockPanel_LayerControl_ClosedPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            barCheckItem_LayerControl.Checked = dockPanel_LayerControl.Visible;
        }

        private void barCheckItem_QueryResult_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dockPanel_QueryResult.Visible = barCheckItem_QueryResult.Checked;
        }

        private void dockPanel_QueryResult_ClosedPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            barCheckItem_QueryResult.Checked = dockPanel_QueryResult.Visible;
        }
        #endregion

        /// <summary>
        /// 初始化工作空间
        /// </summary>
        private void InitWorkspace()
        {
            var openWorkspaceThread = new Thread((ThreadStart)delegate
                                                     {
                                                         _waitForm = new WaitDialogForm("正在加载工作空间,请稍候...", "加载工作空间");
                                                         Application.Run(_waitForm);
                                                     } ) {IsBackground = true};
            openWorkspaceThread.Start();
            _workspace = WorkspaceService.Instance.GetWorkspace();

            if (openWorkspaceThread.IsAlive)
            {
                openWorkspaceThread.Abort();
            }

            if(_workspace==null)
            {
                var dlgConfigWorkspace=new DlgConfigWorkspace();
                dlgConfigWorkspace.ShowDialog();
            }
            InitMap();
            Visible = true;
        }

        private void InitMap()
        {
            try
            {
                mapCtl_Station.Map.Workspace = _workspace;
                mapCtl_Site.Map.Workspace = _workspace;
                sceneCtl_Station.Scene.Workspace = _workspace;
                mapCtl_Station.Map.Open(ConfigHelper.GetConfig("StationMapName"));
                mapCtl_Site.Map.Open(ConfigHelper.GetConfig("SiteMapName"));
                InitStationLayers(mapCtl_Station.Map);

                sceneCtl_Station.Scene.Open(ConfigHelper.GetConfig("StationSceneName"));
                var layer3D = sceneCtl_Station.Scene.Layers.Add(@".\Data\台区场景\台区场景.scv", Layer3DType.VectorFile, true, "台区场景", "") as Layer3DVectorFile;
                layer3D.IsSelectable = false;
                //layer3D.IsQuickRender = true;
                //layer3D.IsAlwaysRender = false;
                //sceneCtl_Station.Action = Action3D.Pan2;

                //sceneCtl_Station.SetBounds((int)layer3D.Bounds.Left, (int)layer3D.Bounds.Bottom, (int)layer3D.Bounds.Width, (int)layer3D.Bounds.Height);
                //sceneCtl_Station.Scene.Refresh();
            }
            catch (Exception ex)
            {
                _logger.Error(string.Format("加载地图出错:{0}",ex));
            }
            
        }

        private void InitStationLayers(Map map)
        {
            var layers = map.Layers;
            foreach (Layer layer in layers)
            {
                var dtName = layer.Dataset.Name;
                if(_stationLayers.ContainsKey(dtName))
                {
                    _stationLayers[dtName].Add(layer);
                }
                else
                {
                    _stationLayers.Add(dtName, new List<Layer>() { layer });
                }
            }
        }

        private void barMgr_Main_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Tag == null)
                return;
            
            switch (e.Item.Tag.ToString())
            {
                case "layertype":
                    var dlgLayerType = new DlgLayerType();
                    dlgLayerType.ShowDialog();
                    break;
                case "layercatalog":
                    var dlgLayerCatalog = new DlgLayerCatalog();
                    dlgLayerCatalog.ShowDialog();
                    break;
                case "viewEntire":
                    if(_currentMapCtl!=null) _currentMapCtl.Map.ViewEntire();
                    break;
                case "pan":
                    if (_currentMapCtl != null) _currentMapCtl.Action = Action.Pan;
                    break;
                case "zoomIn":
                    if (_currentMapCtl != null) _currentMapCtl.Action = Action.ZoomIn;
                    break;
                case "zoomOut":
                    if (_currentMapCtl != null) _currentMapCtl.Action = Action.ZoomOut;
                    break;
                case "freeZoom":
                    if (_currentMapCtl != null) _currentMapCtl.Action = Action.ZoomFree;
                    break;
                case "refresh":
                    if (_currentMapCtl != null) _currentMapCtl.Map.Refresh();
                    break;
            }
        }

        private void InitStationLayerTree()
        {
            var layerTypes = LayerService.INSTANCE.GetStationLayerTypes();
            var layerCatalogs = LayerService.INSTANCE.GetStationLayerCatalogs();
            foreach (var layerType in layerTypes)
            {
                var catalogTn = treeList_StationLayer.AppendNode(new object[] {layerType.Name, layerType.Name, "catalog"},null);
                foreach (var layerCatalog in layerCatalogs.Where(layerCatalog => layerCatalog.typeId==layerType.id))
                {
                    var layerTn = treeList_StationLayer.AppendNode(
                        new object[] { layerCatalog.layerCaption, layerCatalog.layerName, "layer" }, catalogTn);
                    var layerName = layerTn["Name"].ToString();
                    if(_stationLayers.ContainsKey(layerName))
                    {
                        if(mapCtl_Station.Map.Layers[layerName+"@mscd"].IsVisible)
                        {
                            SetCheckedNode(treeList_StationLayer,mapCtl_Station.Map,_stationLayers,layerTn,CheckState.Checked);
                        }
                        else
                        {
                            SetCheckedNode(treeList_StationLayer, mapCtl_Station.Map, _stationLayers, layerTn, CheckState.Unchecked);
                        }
                    }
                }
            }
        }

        

        private void treeList_StationLayer_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            var checkState = GetCheckState(e.Node.Tag);
            switch (checkState)
            {
                case CheckState.Checked:
                    e.NodeImageIndex = 0;
                    break;
                case CheckState.Indeterminate:
                    e.NodeImageIndex = 1;
                    break;
                case CheckState.Unchecked:
                    e.NodeImageIndex = 2;
                    break;
            }
        }

        private CheckState GetCheckState(object obj)
        {
                return obj is CheckState ? (CheckState) obj : CheckState.Unchecked;
        }

        private void SetCheckedNode(TreeList treeList,Map map,IDictionary<string, List<Layer>> mapLayers ,TreeListNode node,CheckState checkState)
        {
            treeList.BeginUpdate();
            node.Tag = checkState;
            var layerName = node["Name"].ToString();
            if (mapLayers.ContainsKey(layerName))
            {
                var layers = mapLayers[layerName];
                foreach (var layer in layers)
                {
                    layer.IsVisible = checkState == CheckState.Checked;
                    var layerInfo = LayerService.INSTANCE.GetStationLayerInfos().First(l => l.LayerName == layerName);
                    layer.IsSelectable = layerInfo.Queryable;
                }
            }

            SetCheckedChildNodes(map,mapLayers,node, checkState);
            SetCheckedParentNodes(map, mapLayers, node, checkState);
            treeList.EndUpdate();
            map.Refresh();
        }

        private void SetCheckedChildNodes(Map map, IDictionary<string, List<Layer>> mapLayers, TreeListNode node, CheckState checkState)
        {
            foreach (TreeListNode childeNode in node.Nodes)
            {
                childeNode.Tag = checkState;
                var layerName = childeNode["Name"].ToString();
                if(mapLayers.ContainsKey(layerName))
                {
                    var layers = mapLayers[layerName];
                    foreach (var layer in layers)
                    {
                        layer.IsVisible = checkState == CheckState.Checked;
                        if (LayerService.INSTANCE.GetStationLayerInfos().First(layerInfo => layerInfo.LayerName == layerName).Queryable)
                        {
                            layer.IsSelectable = checkState == CheckState.Checked;
                        }
                    }
                }
                SetCheckedChildNodes(map, mapLayers, childeNode, checkState);
            }
            
            map.Refresh();
        }

        private void SetCheckedParentNodes(Map map, IDictionary<string, List<Layer>> mapLayers, TreeListNode node, CheckState checkState)
        {
            if(node.ParentNode!=null)
            {
                var b = false;
                CheckState state;
                foreach (TreeListNode parentNode in node.ParentNode.Nodes)
                {
                    if(parentNode.Tag==null)
                    {
                        state=CheckState.Unchecked;
                    }
                    else
                    {
                        state = (CheckState) parentNode.Tag;
                    }
                    if(!checkState.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                node.ParentNode.Tag = b ? CheckState.Indeterminate : checkState;
                SetCheckedParentNodes(map, mapLayers, node.ParentNode, checkState);
            }
        }

        private void treeList_StationLayer_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                var hInfo = treeList_StationLayer.CalcHitInfo(new Point(e.X, e.Y));
                if(hInfo.HitInfoType==HitInfoType.StateImage)
                {
                    var checkState = GetCheckState(hInfo.Node.Tag);
                    if(checkState == CheckState.Indeterminate||checkState == CheckState.Unchecked)
                    {
                        checkState = CheckState.Checked;
                    }
                    else
                    {
                        checkState = CheckState.Unchecked;
                    }
                    SetCheckedNode(treeList_StationLayer, mapCtl_Station.Map, _stationLayers, hInfo.Node, checkState);
                }
            }
        }

        private void mapCtl_Station_DoubleClick(object sender, EventArgs e)
        {
            var selections = mapCtl_Station.Map.FindSelection(true);
            if(selections.Count()>0)
            {
                var rs = selections[0].ToRecordset();
                if(rs.RecordCount>0)
                {
                    rs.MoveFirst();
                    var smId = rs.GetID();
                    var layerName = rs.Dataset.Name;
                    var values = GISUtility.RecordsetToDictionary(rs);
                    var eqptInfo = new DlgEqptInfo(smId, layerName, values);
                    eqptInfo.ShowDialog();
                    if(!rs.IsClosed)
                    {
                        rs.Close();
                    }
                }
            }
        }

        private void xtraTabCtl_Map_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch (xtraTabCtl_Map.SelectedTabPageIndex)
            {
                case 0:
                    _currentMapCtl = mapCtl_Station;
                    break;
                case 1:
                    _currentMapCtl = mapCtl_Site;
                    break;
            }
        }

    }
}