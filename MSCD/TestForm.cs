using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSCD.GIS;

namespace MSCD.UI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            var workspace = WorkspaceService.Instance.GetWorkspace();
            mapControl1.Map.Workspace = workspace;
            mapControl1.GeometrySelectChanged += new SuperMap.UI.GeometrySelectChangedEventHandler(mapControl1_GeometrySelectChanged);
            mapControl1.Map.Open("台区地图");
            mapControl1.Refresh();
        }

        void mapControl1_GeometrySelectChanged(object sender, SuperMap.UI.GeometrySelectChangedEventArgs e)
        {
        }
    }
}
