using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using MSCD.Common;
using MSCD.GIS;
using MSCD.Model;
using MSCD.Services;
using MSCD.UI.EqptManager;
using MSCD.UI.LayerManager;
using MSCD.UI.SystemManager;
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
        private readonly Workspace _workspace;
        private MapControl _currentMapCtl;
        private Recordset _blinkRs;
        private int _blinkCount;
        private bool _isBlink;
        private string _blinkLayerName;
        private LayerInfo _blinkLayerInfo;
        private readonly Dictionary<string,List<Layer>> _stationLayers=new Dictionary<string, List<Layer>>();
        private readonly Dictionary<String, List<Layer>> _siteLayers = new Dictionary<string, List<Layer>>(); 
        public MainForm(Workspace workspace)
        {
            this.Visible = false;
            InitializeComponent();
            _workspace = workspace;

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

        protected override void OnLoad(EventArgs e)
        {
            this.Visible = true;
            this.Show();
            InitMap();
            InitStationLayerTree();
            InitSiteLayerTree();
            _currentMapCtl = mapCtl_Station;

            RegisterHotkey();
        }

        private void RegisterHotkey()
        {
            //注册热键Shift+S，Id号为100。HotKey.KeyModifiers.Shift也可以直接使用数字4来表示。
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.Shift, Keys.W);//全图显示
            //注册热键Ctrl+B，Id号为101。HotKey.KeyModifiers.Ctrl也可以直接使用数字2来表示。
            HotKey.RegisterHotKey(Handle, 101, HotKey.KeyModifiers.Shift, Keys.A);//地图平移
            //注册热键Alt+D，Id号为102。HotKey.KeyModifiers.Alt也可以直接使用数字1来表示。
            HotKey.RegisterHotKey(Handle, 102, HotKey.KeyModifiers.Shift, Keys.S);//地图放大
            HotKey.RegisterHotKey(Handle, 103, HotKey.KeyModifiers.Shift, Keys.D);//地图缩小
            HotKey.RegisterHotKey(Handle, 104, HotKey.KeyModifiers.Shift, Keys.Z);//点选查询
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
                InitSiteLayers(mapCtl_Site.Map);


                sceneCtl_Station.Scene.Open(ConfigHelper.GetConfig("StationSceneName"));
                sceneCtl_Station.Scene.Refresh();
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
                layer.IsEditable = false;
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

        private void InitSiteLayers(Map map)
        {
            var layers = map.Layers;
            foreach (Layer layer in layers)
            {
                layer.IsEditable = false;
                var dtName = layer.Dataset.Name;
                if (_siteLayers.ContainsKey(dtName))
                {
                    _siteLayers[dtName].Add(layer);
                }
                else
                {
                    _siteLayers.Add(dtName, new List<Layer>() { layer });
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
                case "clear":
                    if (_currentMapCtl != null)
                    {
                        var selections = _currentMapCtl.Map.FindSelection(true);
                        foreach (var selection in selections)
                        {
                            selection.Clear();
                        }
                        _currentMapCtl.Refresh();
                    }
                    break;
                case "distance":
                    if (_currentMapCtl != null) 
                    {
                        _currentMapCtl.TrackMode=TrackMode.Track;
                        _currentMapCtl.Action = Action.CreatePolyline;
                    }
                    break;
                case "area":
                    if (_currentMapCtl != null)
                    {
                        _currentMapCtl.TrackMode = TrackMode.Track;
                        _currentMapCtl.Action = Action.CreatePolygon;
                    }
                    break;
                case "pointQuery":
                    if (_currentMapCtl != null) _currentMapCtl.Action=Action.Select;
                    break;
                case "lineQuery":
                    if (_currentMapCtl != null) _currentMapCtl.Action = Action.SelectLine;
                    break;
                case "polygonQuery":
                    if (_currentMapCtl != null) _currentMapCtl.Action = Action.SelectRegion;
                    break;
                case "userManager":
                    var dlgUserManager = new DlgUserManager();
                    dlgUserManager.ShowDialog();
                    break;
                case "stationAttributeQuery":
                    xtraTabCtl_Map.SelectedTabPageIndex = 0;
                    var dlgStationAttributeQuyer = new DlgAttributeQuery("station", this);
                    dlgStationAttributeQuyer.ShowDialog();
                    break;
                case "siteAttributeQuery":
                    xtraTabCtl_Map.SelectedTabPageIndex = 1;
                    var dlgSiteAttributeQuyer = new DlgAttributeQuery("site", this);
                    dlgSiteAttributeQuyer.ShowDialog();
                    break;
                case "maintianQuery":
                    var dlgMaintianQuery =new DlgMaintainQuery(this);
                    dlgMaintianQuery.ShowDialog();
                    break;
                case "viewAllAttribute":
                    ViewAllAttribute();
                    break;
                case "blinkLayer":
                    BlinkLayer();
                    break;
            }
        }

        private void BlinkLayer()
        {
            var dt = WorkspaceService.Instance.GetDataset(ConfigHelper.GetConfig("StationDatasourceName"), _blinkLayerName) as DatasetVector;
            if (dt == null) return;
            var rs = dt.GetRecordset(false, CursorType.Static);

            _blinkRs = rs;
            timer_Blink.Enabled = true;
            timer_Blink.Interval = 500;
            _blinkCount = 1;
            timer_Blink.Start();

        }

        private void ViewAllAttribute()
        {
            var dt = WorkspaceService.Instance.GetDataset(ConfigHelper.GetConfig("StationDatasourceName"), _blinkLayerName) as DatasetVector;
            if (dt == null) return;

            var rs = dt.GetRecordset(false, CursorType.Static);
            var table = GISUtility.RecordsetToDataTable(rs, _blinkLayerInfo);
            rs.Close();
            rs.Dispose();
            dt.Close();
            ShowQueryResult();
            CreateQueryResultGrid(table, _blinkLayerInfo);
        }

        private void InitStationLayerTree()
        {
            var layerTypes = LayerService.INSTANCE.GetStationLayerTypes();
            var layerCatalogs = LayerService.INSTANCE.GetStationLayerCatalogs();
            var stationLayerInfos = LayerService.INSTANCE.GetStationLayerInfos();
            var layers = mapCtl_Station.Map.Layers;
            
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
                        if (mapCtl_Station.Map.Layers[layerName + "@" + ConfigHelper.GetConfig("StationDatasourceName")].IsVisible)
                        {
                            SetCheckedNode(treeList_StationLayer, mapCtl_Station.Map, _stationLayers, stationLayerInfos,layerTn, CheckState.Checked);
                        }
                        else
                        {
                            SetCheckedNode(treeList_StationLayer, mapCtl_Station.Map, _stationLayers,stationLayerInfos,layerTn, CheckState.Unchecked);
                        }
                    }
                }
            }
            foreach (var layer in layers.Cast<Layer>().Where(layer => layerCatalogs.Count(layerCatalog => layerCatalog.layerName == layer.Dataset.Name)<1))
            {
                layer.IsVisible = false;
            }
        }

        private void InitSiteLayerTree()
        {
            var siteLayerInfos = LayerService.INSTANCE.GetSiteLayerInfos();
            var layers = mapCtl_Site.Map.Layers;

            foreach (var siteLayerInfo in siteLayerInfos)
            {
                var layerTn =
                    treeList_SiteLayer.AppendNode(new object[] {siteLayerInfo.LayerCaption, siteLayerInfo.LayerName},
                                                  null);
                var layerName = siteLayerInfo.LayerName;
                if(_siteLayers.ContainsKey(layerName))
                {
                    if (mapCtl_Site.Map.Layers[layerName + "@" + ConfigHelper.GetConfig("StationDatasourceName")].IsVisible)
                    {
                        SetCheckedNode(treeList_SiteLayer, mapCtl_Site.Map, _siteLayers, siteLayerInfos, layerTn, CheckState.Checked);
                    }
                    else
                    {
                        SetCheckedNode(treeList_SiteLayer, mapCtl_Site.Map, _siteLayers, siteLayerInfos, layerTn, CheckState.Unchecked);
                    }
                }
            }

            foreach (var layer in layers.Cast<Layer>().Where(layer => siteLayerInfos.Count(layerInfo => layerInfo.LayerName == layer.Dataset.Name) < 1))
            {
                layer.IsVisible = false;
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

        private void treeList_SiteLayer_GetStateImage(object sender, GetStateImageEventArgs e)
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

        private void SetCheckedNode(TreeList treeList,Map map,IDictionary<string, List<Layer>> mapLayers ,List<LayerInfo> layerInfos,TreeListNode node,CheckState checkState)
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
                    var layerInfo = layerInfos.First(l => l.LayerName == layerName);
                    layer.IsSelectable = layerInfo.Queryable;
                }
            }

            SetCheckedChildNodes(mapLayers,node, checkState);
            SetCheckedParentNodes(mapLayers, node, checkState);
            treeList.EndUpdate();
            map.Refresh();
        }

        private void SetCheckedChildNodes(IDictionary<string, List<Layer>> mapLayers, TreeListNode node, CheckState checkState)
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
                        layer.IsSnapable= checkState==CheckState.Checked;
                        if (LayerService.INSTANCE.GetStationLayerInfos().First(layerInfo => layerInfo.LayerName == layerName).Queryable)
                        {
                            layer.IsSelectable = checkState == CheckState.Checked;
                        }
                    }
                }
                SetCheckedChildNodes(mapLayers, childeNode, checkState);
            }
            
        }

        private void SetCheckedParentNodes(IDictionary<string, List<Layer>> mapLayers, TreeListNode node, CheckState checkState)
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
                SetCheckedParentNodes(mapLayers, node.ParentNode, checkState);
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
                    var stationLayerInfos = LayerService.INSTANCE.GetStationLayerInfos();
                    SetCheckedNode(treeList_StationLayer, mapCtl_Station.Map, _stationLayers,stationLayerInfos, hInfo.Node, checkState);
                }
            }else if(e.Button==MouseButtons.Right)
            {
                var hInfo = treeList_StationLayer.CalcHitInfo(new Point(e.X, e.Y));
                if(hInfo.Node!=null)
                {
                    if(hInfo.Node["Type"].ToString()=="layer")
                    {
                        _blinkLayerName = hInfo.Node["Name"].ToString();
                        var selectedLayer  =
                            LayerService.INSTANCE.GetStationLayerInfos().First(l => l.LayerName == _blinkLayerName);
                        if (selectedLayer.Queryable)
                        {
                            _blinkLayerInfo = selectedLayer;
                            popupMenu_StationTree.ShowPopup(MousePosition);
                        }
                    }
                }
            }
        }

        private void treeList_SiteLayer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var hInfo = treeList_SiteLayer.CalcHitInfo(new Point(e.X, e.Y));
                if (hInfo.HitInfoType == HitInfoType.StateImage)
                {
                    var checkState = GetCheckState(hInfo.Node.Tag);
                    if (checkState == CheckState.Indeterminate || checkState == CheckState.Unchecked)
                    {
                        checkState = CheckState.Checked;
                    }
                    else
                    {
                        checkState = CheckState.Unchecked;
                    }
                    var siteLayerInfos = LayerService.INSTANCE.GetSiteLayerInfos();
                    SetCheckedNode(treeList_SiteLayer, mapCtl_Site.Map, _siteLayers, siteLayerInfos, hInfo.Node, checkState);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                var hInfo = treeList_SiteLayer.CalcHitInfo(new Point(e.X, e.Y));
                if (hInfo.Node != null)
                {
                    if (hInfo.Node["Name"].ToString().Contains("遥控站"))
                    {
                        _blinkLayerName = hInfo.Node["Name"].ToString();
                        var selectedLayer =
                            LayerService.INSTANCE.GetSiteLayerInfos().First(l => l.LayerName == _blinkLayerName);
                        if (selectedLayer.Queryable)
                        {
                            _blinkLayerInfo = selectedLayer;
                            popupMenu_StationTree.ShowPopup(MousePosition);
                        }
                        
                    }
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
                    var layerInfo = LayerService.INSTANCE.GetStationLayerInfos().First(l => l.LayerName == layerName);
                    var dt = GISUtility.RecordsetToDataTable(rs, layerInfo);
                    if (!rs.IsClosed)
                    {
                        rs.Close();
                        rs.Dispose();
                    }
                    var selectedRow = dt.Select(string.Format("SMID = '{0}'", smId))[0];
                    var eqptInfo = new DlgEqptInfo(smId, layerInfo, ref selectedRow);
                    eqptInfo.ShowDialog();
                }
            }
        }

        private void xtraTabCtl_Map_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch (xtraTabCtl_Map.SelectedTabPageIndex)
            {
                case 0:
                    _currentMapCtl = mapCtl_Station;
                    toolBar_Map2D.Visible = true;
                    dockPanel_LayerControl.Visible = true;
                    treeList_StationLayer.Visible = true;
                    treeList_SiteLayer.Visible = false;
                    barCheckItem_LayerControl.Enabled = true;
                    barCheckItem_QueryResult.Enabled = true;
                    break;
                case 1:
                    _currentMapCtl = mapCtl_Site;
                    toolBar_Map2D.Visible = true;
                    dockPanel_LayerControl.Visible = true;
                    treeList_StationLayer.Visible = false;
                    treeList_SiteLayer.Visible = true;
                    barCheckItem_LayerControl.Enabled = true;
                    barCheckItem_QueryResult.Enabled = true;
                    break;
                case 2:
                    toolBar_Map2D.Visible = false;
                    dockPanel_LayerControl.Visible = false;
                    dockPanel_QueryResult.Visible = false;
                    barCheckItem_LayerControl.Enabled = false;
                    barCheckItem_QueryResult.Enabled = false;
                    break;
            }
        }

        private void mapCtl_Station_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                mapCtl_Station.Action = Action.Pan;
            }
        }

        private void mapCtl_Site_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                mapCtl_Site.Action=Action.Pan;
            }
        }

        private void mapCtl_Station_Tracked(object sender, TrackedEventArgs e)
        {
            if(mapCtl_Station.Action==Action.CreatePolyline)
            {
                XtraMessageBox.Show(string.Format("量算距离为：{0:.00}米", e.Length), "距离量算");
            }
            else if(mapCtl_Station.Action==Action.CreatePolygon)
            {
                XtraMessageBox.Show(string.Format("量算距离为：{0:.00}平方米", e.Area), "面积量算");
            }
        }

        private void mapCtl_Station_GeometrySelectChanged(object sender, GeometrySelectChangedEventArgs e)
        {
            xtraTabCtl_QueryResult.TabPages.Clear();
            var selections = mapCtl_Station.Map.FindSelection(true);
            dockPanel_QueryResult.Visible = selections.Length>0;
            foreach (var selection in selections)
            {
                var rs = selection.ToRecordset();
                var datasetName = rs.Dataset.Name;
                var selectedLayer = LayerService.INSTANCE.GetStationLayerInfos().First(l => l.LayerName == datasetName);
                var dt = GISUtility.RecordsetToDataTable(rs, selectedLayer);
                rs.Close();
                rs.Dispose();

                CreateQueryResultGrid(dt, selectedLayer);
            }
        }

        public void ShowQueryResult()
        {
            dockPanel_QueryResult.Visible = true;
            xtraTabCtl_QueryResult.TabPages.Clear();
        }

        public void CreateQueryResultGrid(DataTable dt,LayerInfo layerInfo)
        {
            var gc = new GridControl();
            var gv = new GridView();
            gc.Dock = DockStyle.Fill;
            gc.MainView = gv;
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsBehavior.Editable = false;
            gc.ViewCollection.Add(gv);
            gv.GridControl = gc;
            gc.DataSource = dt;
            gv.RowClick += new RowClickEventHandler(gv_RowClick);
            gv.DoubleClick += new EventHandler(gv_DoubleClick);
            gv.CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(gv_CustomDrawRowIndicator);
            gv.IndicatorWidth = 50;
            gv.Tag = layerInfo;

            var tab = new XtraTabPage() { Text = layerInfo.LayerCaption };
            tab.Controls.Add(gc);
            xtraTabCtl_QueryResult.TabPages.Add(tab);
        }

        void gv_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if(e.Info.IsRowIndicator&&e.RowHandle>=0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        void gv_DoubleClick(object sender, EventArgs e)
        {
            var gv = sender as GridView;
            if(gv.FocusedRowHandle<0) return;
            var smId = Convert.ToInt32(gv.GetFocusedRowCellValue("SMID"));
            var selectedRow = (gv.GridControl.DataSource as DataTable).Select(string.Format("SMID = '{0}'", smId))[0];
            var eqptInfo = new DlgEqptInfo(smId, (LayerInfo) gv.Tag, ref selectedRow);
            eqptInfo.ShowDialog();
            gv.GridControl.RefreshDataSource();
        }

        void gv_RowClick(object sender, RowClickEventArgs e)
        {
            var gv = sender as GridView;
            var rowHandle = e.RowHandle;
            var smId = Convert.ToInt32(gv.GetRowCellValue(rowHandle, "SMID"));
            var layerInfo = gv.Tag as LayerInfo;
            var dataset = WorkspaceService.Instance.GetDataset(ConfigHelper.GetConfig("StationDatasourceName"), layerInfo.LayerName) as DatasetVector;
            var rs = dataset.Query(new[] {smId}, CursorType.Static);
            var centerPt = rs.GetGeometry().InnerPoint;
            _currentMapCtl.Map.Center = centerPt;
            _currentMapCtl.Map.Pan(0, 0);
            _blinkRs = rs;
            timer_Blink.Enabled = true;
            timer_Blink.Interval = 500;
            _blinkCount = 1;
            timer_Blink.Start();
        }

        private void xtraTabCtl_QueryResult_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (e.Page != null)
            {
                var gridControl = e.Page.Controls[0] as GridControl;
                if (gridControl != null)
                {
                    var gridView = gridControl.MainView as GridView;
                    if (gridView != null)
                    {
                        gridView.Columns["SMID"].Visible = false;
                        var layerInfo = gridView.Tag as LayerInfo;
                        if (LayerService.INSTANCE.GetStationLayerInfos().Contains(layerInfo))
                        {
                            xtraTabCtl_Map.SelectedTabPageIndex = 0;
                        }
                        else
                        {
                            xtraTabCtl_Map.SelectedTabPageIndex = 1;
                        }
                    }

                }
            }
            
        }

        private void timer_Blink_Tick(object sender, EventArgs e)
        {
            if(_blinkCount>3)
            {
                _currentMapCtl.Map.TrackingLayer.Clear();
                _currentMapCtl.Map.RefreshTrackingLayer();
                _blinkCount = 0;
                timer_Blink.Stop();
                _blinkRs.Close();
                _blinkRs.Dispose();
            }
            else
            {
                if(_isBlink)
                {
                    _blinkRs.MoveFirst();
                    while (!_blinkRs.IsEOF)
                    {
                        var geo = _blinkRs.GetGeometry();
                        var blinkStyle = new GeoStyle
                                             {FillForeColor = Color.Red,FillOpaqueRate = 60, LineColor = Color.Red,LineWidth = 2,MarkerSize = new Size2D(10,10)};
                        geo.Style = blinkStyle;
                        _currentMapCtl.Map.TrackingLayer.Add(geo,"blink");
                        _currentMapCtl.Map.RefreshTrackingLayer();
                        _blinkRs.MoveNext();
                    }
                    _blinkCount++;
                }
                else
                {
                    _currentMapCtl.Map.TrackingLayer.Clear();
                    _currentMapCtl.Map.RefreshTrackingLayer();
                }
            }
            _isBlink = !_isBlink;
        }

        private void mapCtl_Site_DoubleClick(object sender, EventArgs e)
        {
            var selections = mapCtl_Site.Map.FindSelection(true);
            if (selections.Count() > 0)
            {
                var rs = selections[0].ToRecordset();
                if (rs.RecordCount > 0)
                {
                    rs.MoveFirst();
                    var smId = rs.GetID();
                    var layerName = rs.Dataset.Name;
                    var layerInfo = LayerService.INSTANCE.GetSiteLayerInfos().First(l => l.LayerName == layerName);
                    var dt = GISUtility.RecordsetToDataTable(rs, layerInfo);
                    if (!rs.IsClosed)
                    {
                        rs.Close();
                        rs.Dispose();
                    }
                    var selectedRow = dt.Select(string.Format("SMID = '{0}'", smId))[0];
                    var eqptInfo = new DlgEqptInfo(smId, layerInfo, ref selectedRow);
                    eqptInfo.ShowDialog();
                }
            }
        }

        private void mapCtl_Site_GeometrySelectChanged(object sender, GeometrySelectChangedEventArgs e)
        {
            xtraTabCtl_QueryResult.TabPages.Clear();
            var selections = mapCtl_Site.Map.FindSelection(true);
            dockPanel_QueryResult.Visible = selections.Length > 0;
            foreach (var selection in selections)
            {
                var rs = selection.ToRecordset();
                var datasetName = rs.Dataset.Name;
                var selectedLayer = LayerService.INSTANCE.GetSiteLayerInfos().First(l => l.LayerName == datasetName);
                var dt = GISUtility.RecordsetToDataTable(rs, selectedLayer);
                rs.Close();
                rs.Dispose();

                CreateQueryResultGrid(dt, selectedLayer);
            }
        }

        protected override void WndProc(ref Message m)
        {
            
            const int WM_HOTKEY = 0x0312;
            //按快捷键 
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:    //按下的是Shift+W，全图显示
                            _currentMapCtl.Map.ViewEntire();
                            _currentMapCtl.Refresh();
                            break;
                        case 101:    //按下的是Shift+A，平移地图
                            _currentMapCtl.Action = Action.Pan;
                            _currentMapCtl.Refresh();
                            break;
                        case 102:    //按下的是Shift+S，缩小地图
                            _currentMapCtl.Action = Action.ZoomOut;
                            _currentMapCtl.Refresh();
                            break;
                        case 103://按下的是Shift+D，放大地图
                            _currentMapCtl.Action = Action.ZoomIn;
                            _currentMapCtl.Refresh();
                            break;
                        case 104://按下的是Shift+Z,点选查询
                            _currentMapCtl.Action = Action.Select;
                            _currentMapCtl.Refresh();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);

        }       
    }
}