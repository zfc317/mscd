using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MSCD.Model;

namespace MSCD.UI.SystemManager
{
    public partial class DlgUserManager : DevExpress.XtraEditors.XtraForm
    {
        private List<User> _users;
        public DlgUserManager()
        {
            InitializeComponent();
            InitUserGrid();
        }

        private void InitUserGrid()
        {
            var userBll = new BLL.User();
            _users = userBll.GetModelList("");
            gc_User.DataSource = _users;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(gv_User.FocusedRowHandle<0)
            {
                XtraMessageBox.Show("请选择需要删除的用户！", "提示");
                return;
            }

            if(gv_User.GetFocusedRowCellValue("Username").ToString()=="admin")
            {
                XtraMessageBox.Show("管理员用户不能删除！", "提示");
                return;
            }

            var id =Convert.ToInt32(gv_User.GetFocusedRowCellValue("Id"));
            var userBll =new BLL.User();
            var userModel = _users.First(u => u.Id == id);
            if(userBll.Delete(id))
            {
                _users.Remove(userModel);
                gc_User.RefreshDataSource();
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var dlgUserInfo = new DlgUserInfo(null, "Add");
            if(dlgUserInfo.ShowDialog()==DialogResult.OK)
            {
                InitUserGrid();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if(gv_User.FocusedRowHandle<0)
            {
                XtraMessageBox.Show("请选择需要编辑的用户！", "提示");
                return;
            }
            var userId = Convert.ToInt32(gv_User.GetFocusedRowCellValue("Id"));
            var user = _users.First(u => u.Id == userId);

            var dlgUserInfo = new DlgUserInfo(user, "Edit");
            if (dlgUserInfo.ShowDialog() == DialogResult.OK)
            {
                InitUserGrid();
            }
        }
    }
}