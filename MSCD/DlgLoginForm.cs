using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MSCD.BLL;
using MSCD.Common;
using MSCD.GIS;
using SuperMap.Data;

namespace MSCD.UI
{
    public partial class DlgLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public Workspace Workspace { get; private set; }

        public DlgLoginForm()
        {
            InitializeComponent();
            
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Hide();
            base.OnLoad(e);
            TestDatabaseConnect();
            this.Show();
        }

        private void TestDatabaseConnect()
        {
            SplashScreenManager.ShowForm(typeof(MyWaitForm), false, true);
            SplashScreenManager.Default.SetWaitFormCaption("系统初始化");
            SplashScreenManager.Default.SetWaitFormDescription("正在测试数据库连接,请稍候...");
            var connectionStr = ConfigHelper.GetConfig("ConnectionString");
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(connectionStr);
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                SplashScreenManager.CloseForm();
                if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                    sqlConnection.Dispose();
                    InitWorkspace();
                }
                else
                {
                    var dlgConfigDatabase = new DlgConfigDatabase();
                    if(dlgConfigDatabase.ShowDialog()==DialogResult.Cancel)
                    {
                        this.Close();
                    }
                    
                }
            }
        }

        /// <summary>
        /// 初始化工作空间
        /// </summary>
        private void InitWorkspace()
        {
            SplashScreenManager.ShowForm(typeof(MyWaitForm), false, true);
            SplashScreenManager.Default.SetWaitFormCaption("系统初始化");
            SplashScreenManager.Default.SetWaitFormDescription("正在初始化工作空间,请稍候...");

            Workspace = new Workspace();
            var workspaceConnectionInfo = new WorkspaceConnectionInfo
            {
                Type = WorkspaceType.SQL,
                Driver = ConfigHelper.GetConfig("WorkspaceDriver"),
                Server = ConfigHelper.GetConfig("WorkspaceServer"),
                Database = ConfigHelper.GetConfig("WorkspaceDatabase"),
                Name = ConfigHelper.GetConfig("WorkspaceName"),
                User = ConfigHelper.GetConfig("WorkspaceUser"),
                Password = ConfigHelper.GetConfig("WorkspacePassword")
            };
            var workspaceOpened = Workspace.Open(workspaceConnectionInfo);
            SplashScreenManager.CloseForm();
            if (workspaceOpened)
            {
                var datasoureName = ConfigHelper.GetConfig("StationDatasourceName");
                if (Workspace.Datasources.Contains(datasoureName))
                {
                    var datasource = Workspace.Datasources[datasoureName];
                    if (!datasource.IsConnected)
                    {
                        Workspace.Datasources.Close(datasoureName);
                        Workspace.Datasources.Open(CreateDatasourceConnectionInfo(datasoureName));
                        Workspace.Save();
                    }
                }
                else
                {
                    var datasource = Workspace.Datasources.Open(CreateDatasourceConnectionInfo(datasoureName));
                    Workspace.Save();
                }
            }
            else
            {
                var dlgConfigWorkspace = new DlgConfigWorkspace();
                if (dlgConfigWorkspace.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                }
            }

        }

        private DatasourceConnectionInfo CreateDatasourceConnectionInfo(string datasoureName)
        {
            var datasourceConnection = new DatasourceConnectionInfo()
            {
                EngineType = EngineType.SQLPlus,
                Driver = ConfigHelper.GetConfig("WorkspaceDriver"),
                Server = ConfigHelper.GetConfig("WorkspaceServer"),
                Database = ConfigHelper.GetConfig("WorkspaceDatabase"),
                User = ConfigHelper.GetConfig("WorkspaceUser"),
                Password = ConfigHelper.GetConfig("WorkspacePassword"),
                Alias = datasoureName
            };
            return datasourceConnection;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(dxValidationProvider1.Validate())
            {
                var userName = txt_UserName.Text.Trim();
                var password = txt_Password.Text.Trim();
                var userBll = new User();
                var userMdoel = userBll.GetModel(userName);
                if(userMdoel==null)
                {
                    XtraMessageBox.Show("用户名不存在！");
                }
                else
                {
                    if(Common.DEncrypt.DESEncrypt.Encrypt(password)==userMdoel.Password)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        XtraMessageBox.Show("密码错误！");
                    }
                }
                
                
            }
            
        }
    }
}