using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MSCD.Common;
using SuperMap.Data;

namespace MSCD.GIS
{
    public partial class DlgConfigWorkspace : DevExpress.XtraEditors.XtraForm
    {
        private string _server;
        private string _database;
        private string _name;
        private string _user;
        private string _password;
        public DlgConfigWorkspace()
        {
            InitializeComponent();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            if(!dxValidationProvider1.Validate())
            {
                XtraMessageBox.Show("请填写完整信息！", "提示");
                return;
            }

             _server = txt_WorkspaceServer.Text.Trim();
             _database = txt_WorkspaceDatabase.Text.Trim();
             _name = txt_WorkspaceName.Text.Trim();
             _user = txt_WorkspaceUsername.Text.Trim();
             _password = txt_WorkspacePassword.Text.Trim();

            var workspaceConnectionInfo = new WorkspaceConnectionInfo()
                                              {
                                                  Driver = "SQL Server",
                                                  Server = _server,
                                                  Database = _database,
                                                  Name = _name,
                                                  User = _user,
                                                  Password = _password,
                                                  Type = WorkspaceType.SQL
                                              };
            var workspace = new Workspace();
            if(workspace.Open(workspaceConnectionInfo))
            {
                XtraMessageBox.Show("测试成功,请保存!","提示");
                btn_Save.Enabled = true;
                btn_Test.Enabled = false;
            }else
            {
                XtraMessageBox.Show("配置不正确,请重新填写。","提示");
                btn_Save.Enabled = false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ConfigHelper.SetConfig("WorkspaceServer", _server);
            ConfigHelper.SetConfig("WorkspaceDatabase", _database);
            ConfigHelper.SetConfig("WorkspaceName", _name);
            ConfigHelper.SetConfig("WorkspaceUser", _user);
            ConfigHelper.SetConfig("WorkspacePassword", _password);

            XtraMessageBox.Show("设置参数完成，需要重新打开软件启用新设置！");
            Application.Restart();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}