using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MSCD.Common;

namespace MSCD.GIS
{
    public partial class DlgConfigDatabase : DevExpress.XtraEditors.XtraForm
    {
        private string _server;
        private string _database;
        private string _user;
        private string _password;
        public DlgConfigDatabase()
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
             _user = txt_WorkspaceUsername.Text.Trim();
             _password = txt_WorkspacePassword.Text.Trim();

            var connectionStr = string.Format("Server={0};database={1};uid={2};pwd={3}", _server, _database, _user,
                                              _password);
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();
                XtraMessageBox.Show("测试成功,请保存!", "提示");
                btn_Save.Enabled = true;
                btn_Test.Enabled = false;
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("配置不正确,请重新填写。", "提示");
                btn_Save.Enabled = false;
            }finally
            {
                if (connection!=null&&connection.State==ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ConfigHelper.SetConfig("ConnectionString", string.Format("Server={0};database={1};uid={2};pwd={3}", _server, _database, _user,
                                              _password));
            XtraMessageBox.Show("设置参数完成，需要重新打开软件启用新设置！");
            DialogResult=DialogResult.OK;
            Application.Restart();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}