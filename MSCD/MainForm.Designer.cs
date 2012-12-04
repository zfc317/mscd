﻿namespace MSCD.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barMgr_Main = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.MainMenu = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barCheckItem_LayerControl = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem_QueryResult = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel_QueryResult = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel_LayerControl = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.treeList_StationLayer = new DevExpress.XtraTreeList.TreeList();
            this.treeCol_Caption = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeCol_Name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeCol_Type = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgColl_16 = new DevExpress.Utils.ImageCollection(this.components);
            this.xtraTabCtl_Map = new DevExpress.XtraTab.XtraTabControl();
            this.tabPage_StationMap = new DevExpress.XtraTab.XtraTabPage();
            this.mapCtl_Station = new SuperMap.UI.MapControl();
            this.tabPage_SiteMap = new DevExpress.XtraTab.XtraTabPage();
            this.mapCtl_Site = new SuperMap.UI.MapControl();
            this.tabPage_StationScene = new DevExpress.XtraTab.XtraTabPage();
            this.sceneCtl_Station = new SuperMap.UI.SceneControl();
            this.mapNav_Station = new SuperMap.UI.MapNavigationControl(this.components);
            this.mapNav_Site = new SuperMap.UI.MapNavigationControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barMgr_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel_QueryResult.SuspendLayout();
            this.dockPanel_LayerControl.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList_StationLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColl_16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCtl_Map)).BeginInit();
            this.xtraTabCtl_Map.SuspendLayout();
            this.tabPage_StationMap.SuspendLayout();
            this.tabPage_SiteMap.SuspendLayout();
            this.tabPage_StationScene.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // barMgr_Main
            // 
            this.barMgr_Main.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.MainMenu,
            this.bar3});
            this.barMgr_Main.DockControls.Add(this.barDockControlTop);
            this.barMgr_Main.DockControls.Add(this.barDockControlBottom);
            this.barMgr_Main.DockControls.Add(this.barDockControlLeft);
            this.barMgr_Main.DockControls.Add(this.barDockControlRight);
            this.barMgr_Main.DockManager = this.dockManager1;
            this.barMgr_Main.Form = this;
            this.barMgr_Main.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barCheckItem_LayerControl,
            this.barCheckItem_QueryResult,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barSubItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8});
            this.barMgr_Main.MainMenu = this.MainMenu;
            this.barMgr_Main.MaxItemId = 12;
            this.barMgr_Main.StatusBar = this.bar3;
            this.barMgr_Main.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMgr_Main_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8)});
            this.bar1.Text = " 工具条";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "全图";
            this.barButtonItem5.Id = 8;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.Tag = "viewEntire";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "漫游";
            this.barButtonItem6.Id = 9;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.Tag = "pan";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "放大";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Tag = "zoomIn";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "缩小";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.Tag = "zoomOut";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "自由缩放";
            this.barButtonItem7.Id = 10;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.Tag = "freeZoom";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "刷新";
            this.barButtonItem8.Id = 11;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.Tag = "refresh";
            // 
            // MainMenu
            // 
            this.MainMenu.BarName = "Main menu";
            this.MainMenu.DockCol = 0;
            this.MainMenu.DockRow = 0;
            this.MainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.MainMenu.OptionsBar.MultiLine = true;
            this.MainMenu.OptionsBar.UseWholeRow = true;
            this.MainMenu.Text = "菜单栏";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "视图";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem_LayerControl),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem_QueryResult)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barCheckItem_LayerControl
            // 
            this.barCheckItem_LayerControl.Caption = "图层控制";
            this.barCheckItem_LayerControl.Checked = true;
            this.barCheckItem_LayerControl.Id = 1;
            this.barCheckItem_LayerControl.Name = "barCheckItem_LayerControl";
            this.barCheckItem_LayerControl.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem_LayerControl_CheckedChanged);
            // 
            // barCheckItem_QueryResult
            // 
            this.barCheckItem_QueryResult.Caption = "查询结果";
            this.barCheckItem_QueryResult.Id = 2;
            this.barCheckItem_QueryResult.Name = "barCheckItem_QueryResult";
            this.barCheckItem_QueryResult.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem_QueryResult_CheckedChanged);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "系统管理";
            this.barSubItem2.Id = 5;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "图层类型";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.Tag = "layertype";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "图层分类";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.Tag = "layercatalog";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "状态栏";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(909, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 438);
            this.barDockControlBottom.Size = new System.Drawing.Size(909, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 385);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(909, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 385);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel_QueryResult});
            this.dockManager1.MenuManager = this.barMgr_Main;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel_LayerControl});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel_QueryResult
            // 
            this.dockPanel_QueryResult.Controls.Add(this.dockPanel2_Container);
            this.dockPanel_QueryResult.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel_QueryResult.ID = new System.Guid("305f86de-4ee1-4b21-9fff-065b3d9e6631");
            this.dockPanel_QueryResult.Location = new System.Drawing.Point(0, 0);
            this.dockPanel_QueryResult.Name = "dockPanel_QueryResult";
            this.dockPanel_QueryResult.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel_QueryResult.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel_QueryResult.SavedIndex = 1;
            this.dockPanel_QueryResult.Size = new System.Drawing.Size(912, 200);
            this.dockPanel_QueryResult.Text = "查询结果";
            this.dockPanel_QueryResult.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            this.dockPanel_QueryResult.ClosedPanel += new DevExpress.XtraBars.Docking.DockPanelEventHandler(this.dockPanel_QueryResult_ClosedPanel);
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(904, 171);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanel_LayerControl
            // 
            this.dockPanel_LayerControl.Controls.Add(this.dockPanel1_Container);
            this.dockPanel_LayerControl.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel_LayerControl.ID = new System.Guid("988e959d-c317-4a23-a92a-cb2b6b8abd31");
            this.dockPanel_LayerControl.Location = new System.Drawing.Point(0, 53);
            this.dockPanel_LayerControl.Name = "dockPanel_LayerControl";
            this.dockPanel_LayerControl.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel_LayerControl.Size = new System.Drawing.Size(200, 385);
            this.dockPanel_LayerControl.Text = "图层控制";
            this.dockPanel_LayerControl.ClosedPanel += new DevExpress.XtraBars.Docking.DockPanelEventHandler(this.dockPanel_LayerControl_ClosedPanel);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.treeList_StationLayer);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 356);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // treeList_StationLayer
            // 
            this.treeList_StationLayer.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeCol_Caption,
            this.treeCol_Name,
            this.treeCol_Type});
            this.treeList_StationLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList_StationLayer.Location = new System.Drawing.Point(0, 0);
            this.treeList_StationLayer.Name = "treeList_StationLayer";
            this.treeList_StationLayer.OptionsView.ShowColumns = false;
            this.treeList_StationLayer.OptionsView.ShowIndicator = false;
            this.treeList_StationLayer.Size = new System.Drawing.Size(192, 356);
            this.treeList_StationLayer.StateImageList = this.imgColl_16;
            this.treeList_StationLayer.TabIndex = 0;
            this.treeList_StationLayer.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeList_StationLayer_GetStateImage);
            this.treeList_StationLayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList_StationLayer_MouseDown);
            // 
            // treeCol_Caption
            // 
            this.treeCol_Caption.Caption = "标题";
            this.treeCol_Caption.FieldName = "Caption";
            this.treeCol_Caption.MinWidth = 33;
            this.treeCol_Caption.Name = "treeCol_Caption";
            this.treeCol_Caption.OptionsColumn.AllowEdit = false;
            this.treeCol_Caption.Visible = true;
            this.treeCol_Caption.VisibleIndex = 0;
            // 
            // treeCol_Name
            // 
            this.treeCol_Name.Caption = "名称";
            this.treeCol_Name.FieldName = "Name";
            this.treeCol_Name.Name = "treeCol_Name";
            this.treeCol_Name.OptionsColumn.AllowEdit = false;
            this.treeCol_Name.Width = 87;
            // 
            // treeCol_Type
            // 
            this.treeCol_Type.Caption = "类型";
            this.treeCol_Type.FieldName = "Type";
            this.treeCol_Type.Name = "treeCol_Type";
            this.treeCol_Type.OptionsColumn.AllowEdit = false;
            this.treeCol_Type.Width = 87;
            // 
            // imgColl_16
            // 
            this.imgColl_16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgColl_16.ImageStream")));
            this.imgColl_16.Images.SetKeyName(0, "checked.png");
            this.imgColl_16.Images.SetKeyName(1, "indeterminate.png");
            this.imgColl_16.Images.SetKeyName(2, "unchecked.png");
            // 
            // xtraTabCtl_Map
            // 
            this.xtraTabCtl_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabCtl_Map.Location = new System.Drawing.Point(200, 53);
            this.xtraTabCtl_Map.Name = "xtraTabCtl_Map";
            this.xtraTabCtl_Map.SelectedTabPage = this.tabPage_StationMap;
            this.xtraTabCtl_Map.Size = new System.Drawing.Size(709, 385);
            this.xtraTabCtl_Map.TabIndex = 14;
            this.xtraTabCtl_Map.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPage_StationMap,
            this.tabPage_SiteMap,
            this.tabPage_StationScene});
            this.xtraTabCtl_Map.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabCtl_Map_SelectedPageChanged);
            // 
            // tabPage_StationMap
            // 
            this.tabPage_StationMap.Controls.Add(this.mapCtl_Station);
            this.tabPage_StationMap.Name = "tabPage_StationMap";
            this.tabPage_StationMap.Size = new System.Drawing.Size(703, 356);
            this.tabPage_StationMap.Text = "台区地图";
            // 
            // mapCtl_Station
            // 
            this.mapCtl_Station.Action = SuperMap.UI.Action.Select2;
            this.mapCtl_Station.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mapCtl_Station.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapCtl_Station.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapCtl_Station.InteractionMode = SuperMap.UI.InteractionMode.Default;
            this.mapCtl_Station.IsCursorCustomized = false;
            this.mapCtl_Station.IsWaitCursorEnabled = true;
            this.mapCtl_Station.Location = new System.Drawing.Point(0, 0);
            this.mapCtl_Station.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.mapCtl_Station.MarginPanEnabled = true;
            this.mapCtl_Station.MarginPanPercent = 0.5D;
            this.mapCtl_Station.Name = "mapCtl_Station";
            this.mapCtl_Station.RefreshAtTracked = true;
            this.mapCtl_Station.RefreshInInvalidArea = false;
            this.mapCtl_Station.RollingWheelWithoutDelay = false;
            this.mapCtl_Station.SelectionMode = SuperMap.UI.SelectionMode.ContainInnerPoint;
            this.mapCtl_Station.SelectionPixelTolerance = 1;
            this.mapCtl_Station.Size = new System.Drawing.Size(703, 356);
            this.mapCtl_Station.TabIndex = 0;
            this.mapCtl_Station.TrackMode = SuperMap.UI.TrackMode.Edit;
            this.mapCtl_Station.DoubleClick += new System.EventHandler(this.mapCtl_Station_DoubleClick);
            this.mapCtl_Station.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mapCtl_Station_KeyDown);
            // 
            // tabPage_SiteMap
            // 
            this.tabPage_SiteMap.Controls.Add(this.mapCtl_Site);
            this.tabPage_SiteMap.Name = "tabPage_SiteMap";
            this.tabPage_SiteMap.Size = new System.Drawing.Size(703, 356);
            this.tabPage_SiteMap.Text = "站点分布图";
            // 
            // mapCtl_Site
            // 
            this.mapCtl_Site.Action = SuperMap.UI.Action.Select2;
            this.mapCtl_Site.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mapCtl_Site.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapCtl_Site.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapCtl_Site.InteractionMode = SuperMap.UI.InteractionMode.Default;
            this.mapCtl_Site.IsCursorCustomized = false;
            this.mapCtl_Site.IsWaitCursorEnabled = true;
            this.mapCtl_Site.Location = new System.Drawing.Point(0, 0);
            this.mapCtl_Site.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.mapCtl_Site.MarginPanEnabled = true;
            this.mapCtl_Site.MarginPanPercent = 0.5D;
            this.mapCtl_Site.Name = "mapCtl_Site";
            this.mapCtl_Site.RefreshAtTracked = true;
            this.mapCtl_Site.RefreshInInvalidArea = false;
            this.mapCtl_Site.RollingWheelWithoutDelay = false;
            this.mapCtl_Site.SelectionMode = SuperMap.UI.SelectionMode.ContainInnerPoint;
            this.mapCtl_Site.SelectionPixelTolerance = 1;
            this.mapCtl_Site.Size = new System.Drawing.Size(703, 356);
            this.mapCtl_Site.TabIndex = 0;
            this.mapCtl_Site.TrackMode = SuperMap.UI.TrackMode.Edit;
            // 
            // tabPage_StationScene
            // 
            this.tabPage_StationScene.Controls.Add(this.sceneCtl_Station);
            this.tabPage_StationScene.Name = "tabPage_StationScene";
            this.tabPage_StationScene.Size = new System.Drawing.Size(703, 356);
            this.tabPage_StationScene.Text = "台区三维";
            // 
            // sceneCtl_Station
            // 
            this.sceneCtl_Station.Action = SuperMap.UI.Action3D.Pan;
            this.sceneCtl_Station.BackColor = System.Drawing.Color.White;
            this.sceneCtl_Station.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sceneCtl_Station.InteractionMode = SuperMap.UI.InteractionMode3D.Default;
            this.sceneCtl_Station.IsAlwaysUpdate = false;
            this.sceneCtl_Station.IsCursorCustomized = false;
            this.sceneCtl_Station.IsKeyboardNavigationEnabled = false;
            this.sceneCtl_Station.IsMouseNavigationEnabled = true;
            this.sceneCtl_Station.IsStatusBarVisible = true;
            this.sceneCtl_Station.IsWaitCursorEnabled = false;
            this.sceneCtl_Station.Location = new System.Drawing.Point(0, 0);
            this.sceneCtl_Station.Name = "sceneCtl_Station";
            this.sceneCtl_Station.Size = new System.Drawing.Size(703, 356);
            this.sceneCtl_Station.TabIndex = 0;
            // 
            // mapNav_Station
            // 
            this.mapNav_Station.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.mapNav_Station.Location = new System.Drawing.Point(20, 20);
            this.mapNav_Station.MapControl = this.mapCtl_Station;
            this.mapNav_Station.MaxScale = 0D;
            this.mapNav_Station.MinScale = 0D;
            this.mapNav_Station.PanPercent = 25;
            this.mapNav_Station.Visible = true;
            // 
            // mapNav_Site
            // 
            this.mapNav_Site.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.mapNav_Site.Location = new System.Drawing.Point(20, 20);
            this.mapNav_Site.MapControl = this.mapCtl_Site;
            this.mapNav_Site.MaxScale = 0D;
            this.mapNav_Site.MinScale = 0D;
            this.mapNav_Site.PanPercent = 25;
            this.mapNav_Site.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 459);
            this.Controls.Add(this.xtraTabCtl_Map);
            this.Controls.Add(this.dockPanel_LayerControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barMgr_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel_QueryResult.ResumeLayout(false);
            this.dockPanel_LayerControl.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList_StationLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColl_16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCtl_Map)).EndInit();
            this.xtraTabCtl_Map.ResumeLayout(false);
            this.tabPage_StationMap.ResumeLayout(false);
            this.tabPage_SiteMap.ResumeLayout(false);
            this.tabPage_StationScene.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarManager barMgr_Main;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar MainMenu;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel_QueryResult;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel_LayerControl;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraTab.XtraTabControl xtraTabCtl_Map;
        private DevExpress.XtraTab.XtraTabPage tabPage_StationMap;
        private DevExpress.XtraTab.XtraTabPage tabPage_StationScene;
        private DevExpress.XtraBars.BarCheckItem barCheckItem_LayerControl;
        private DevExpress.XtraBars.BarCheckItem barCheckItem_QueryResult;
        private DevExpress.XtraTab.XtraTabPage tabPage_SiteMap;
        private SuperMap.UI.MapControl mapCtl_Station;
        private SuperMap.UI.MapControl mapCtl_Site;
        private SuperMap.UI.SceneControl sceneCtl_Station;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraTreeList.TreeList treeList_StationLayer;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeCol_Caption;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeCol_Name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeCol_Type;
        private DevExpress.Utils.ImageCollection imgColl_16;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private SuperMap.UI.MapNavigationControl mapNav_Station;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private SuperMap.UI.MapNavigationControl mapNav_Site;
    }
}