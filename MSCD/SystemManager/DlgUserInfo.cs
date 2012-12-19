using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MSCD.Model;

namespace MSCD.UI.SystemManager
{
    public partial class DlgUserInfo : DevExpress.XtraEditors.XtraForm
    {
        private User _user;
        private readonly string _viewType;
        public DlgUserInfo(User user,string viewType)
        {
            InitializeComponent();
            _user = user;
            _viewType = viewType;
            InitForm();
        }

        private void InitForm()
        {
            if(_user!=null)
            {
                txt_Department.Text = _user.Department;
                txt_Name.Text = _user.Name;
                txt_Phone.Text = _user.Phone;
                txt_Remark.Text = _user.Remark;
                txt_Tel.Text = _user.Tel;
                txt_Username.Text = _user.Username;
                txt_Username.Properties.ReadOnly = true;
                commbox_UserRole.SelectedIndex = _user.Type;
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if(_viewType=="Add")
            {
                if(dxValidationProvider1.Validate())
                {
                    var userBll = new BLL.User();
                    _user=new User
                              {
                                  Department = txt_Department.Text.Trim(),
                                  Name = txt_Name.Text.Trim(),
                                  Password = Common.DEncrypt.DESEncrypt.Encrypt(txt_Password.Text.Trim()),
                                  Phone = txt_Phone.Text.Trim(),
                                  Remark = txt_Remark.Text,
                                  Tel = txt_Remark.Text.Trim(),
                                  Type = commbox_UserRole.SelectedIndex,
                                  Username = txt_Username.Text.Trim()
                              };
                    var userId = userBll.Add(_user);
                    if(userId>0)
                    {
                        _user.Id = userId;
                        XtraMessageBox.Show("添加成功！", "提示");
                        DialogResult = DialogResult.OK;
                    }
                    }
                    else
                    {
                        XtraMessageBox.Show("添加失败！", "提示");
                    }

                    
            }
            else if(_viewType=="Edit")
            {
                if (dxValidationProvider1.Validate())
                {
                    var userBll = new BLL.User();
                    _user.Department = txt_Department.Text.Trim();
                    if(txt_Password.Text.Trim()!="")
                    {
                        _user.Password = Common.DEncrypt.DESEncrypt.Encrypt(txt_Password.Text.Trim());    
                    }
                    _user.Phone = txt_Phone.Text.Trim();
                    _user.Remark = txt_Remark.Text;
                    _user.Tel = txt_Remark.Text.Trim();
                    _user.Type = commbox_UserRole.SelectedIndex;
                    _user.Username = txt_Username.Text.Trim();
                    if(userBll.Update(_user))
                    {
                        XtraMessageBox.Show("编辑成功！", "提示");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        XtraMessageBox.Show("编辑失败！", "提示");
                    }
                    
                }
            }
        }
    }
}