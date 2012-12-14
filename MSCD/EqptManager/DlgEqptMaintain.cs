using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using MSCD.Model;

namespace MSCD.UI.EqptManager
{
    public partial class DlgEqptMaintain : DevExpress.XtraEditors.XtraForm
    {
        private EqptMaintain _eqptMaintain;
        private readonly LayerInfo _layerInfo;
        private readonly int _smId;
        public DlgEqptMaintain(LayerInfo layerInfo,int smId,EqptMaintain eqptMaintain)
        {
            InitializeComponent();
            _eqptMaintain = eqptMaintain;
            _layerInfo = layerInfo;
            _smId = smId;
            InitForm();
        }

        private void InitForm()
        {
            if(_eqptMaintain==null)
            {
                var layoutItems = layoutCtlGp_MaintainInfo.Items;
                foreach (LayoutControlItem layoutItem in layoutItems)
                {
                    var control = layoutItem.Control;
                    var dateEdit = control as DateEdit;
                    if(dateEdit!=null)
                    {
                        dateEdit.EditValue = DateTime.Now;
                    }
                }
                btn_Edit.Enabled = false;
                btn_Cancel.Enabled = false;
            }
            else
            {
                txt_CheckOpinion.Text = _eqptMaintain.CheckOpinion;
                txt_CheckOpinion.Properties.ReadOnly = true;

                txt_Checker.Text = _eqptMaintain.Checker;
                txt_Checker.Properties.ReadOnly = true;

                txt_Department.Text = _eqptMaintain.Department;
                txt_Department.Properties.ReadOnly = true;

                txt_EqptName.Text = _eqptMaintain.EqptName;
                txt_EqptName.Properties.ReadOnly = true;

                txt_MaintainName.Text = _eqptMaintain.Name;
                txt_MaintainName.Properties.ReadOnly = true;

                txt_Maintainer.Text = _eqptMaintain.Maintainer;
                txt_Maintainer.Properties.ReadOnly = true;

                txt_Process.Text = _eqptMaintain.Process;
                txt_Process.Properties.ReadOnly = true;

                txt_Reason.Text = _eqptMaintain.Reason;
                txt_Reason.Properties.ReadOnly = true;

                txt_Result.Text = _eqptMaintain.Result;
                txt_Result.Properties.ReadOnly = true;

                dateEdit_NextMaintainDate.EditValue = _eqptMaintain.NextMaintainDate;
                dateEdit_NextMaintainDate.Properties.ReadOnly = true;

                dateEdit_RecordDate.EditValue = _eqptMaintain.RecordDate;
                dateEdit_RecordDate.Properties.ReadOnly = true;

                DateEdit_MaintianDate.EditValue = _eqptMaintain.MaintainDate;
                DateEdit_MaintianDate.Properties.ReadOnly = true;

                combox_MaintianType.Text = (_eqptMaintain.MaintainType == 0) ? "周期性维护" : "故障性维护";
                combox_MaintianType.Properties.ReadOnly = true;

                btn_Save.Enabled = false;
                btn_Cancel.Enabled = false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_MaintainName.Text.Trim()=="")
            {
                XtraMessageBox.Show("维护名称必须填写！", "提示");
                return;
            }
            var eqptMaintainBll = new BLL.EqptMaintain();
            if(_eqptMaintain==null)
            {
                _eqptMaintain = new EqptMaintain
                                    {
                                        CheckOpinion = txt_CheckOpinion.Text,
                                        Checker = txt_Checker.Text,
                                        Department = txt_Department.Text,
                                        EqptName = txt_EqptName.Text,
                                        LayerName = _layerInfo.LayerName,
                                        MaintainDate = DateEdit_MaintianDate.DateTime,
                                        MaintainType = combox_MaintianType.Text == "周期性维护" ? 0 : 1,
                                        Maintainer = txt_Maintainer.Text,
                                        Name = txt_MaintainName.Text,
                                        NextMaintainDate = dateEdit_NextMaintainDate.DateTime,
                                        Process = txt_Process.Text,
                                        Reason = txt_Reason.Text,
                                        RecordDate = dateEdit_RecordDate.DateTime,
                                        Result = txt_Result.Text,
                                        SmId = _smId
                                    };
                var eqptMaintainId = eqptMaintainBll.Add(_eqptMaintain);
                if(eqptMaintainId>0)
                {
                    _eqptMaintain.Id = eqptMaintainId;
                    XtraMessageBox.Show("提交成功！", "提示");
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                _eqptMaintain.CheckOpinion = txt_CheckOpinion.Text;
                _eqptMaintain.Checker = txt_Checker.Text;
                _eqptMaintain.Department = txt_Department.Text;
                _eqptMaintain.EqptName = txt_EqptName.Text;
                _eqptMaintain.MaintainDate = DateEdit_MaintianDate.DateTime;
                _eqptMaintain.MaintainType = combox_MaintianType.Text == "周期性维护" ? 0 : 1;
                _eqptMaintain.Maintainer = txt_Maintainer.Text;
                _eqptMaintain.Name = txt_MaintainName.Text;
                _eqptMaintain.NextMaintainDate = dateEdit_NextMaintainDate.DateTime;
                _eqptMaintain.Process = txt_Process.Text;
                _eqptMaintain.RecordDate = dateEdit_RecordDate.DateTime;
                _eqptMaintain.Reason = txt_Reason.Text;
                _eqptMaintain.Result = txt_Result.Text;
                if(eqptMaintainBll.Update(_eqptMaintain))
                {
                    XtraMessageBox.Show("提交成功！", "提示");
                    DialogResult = DialogResult.OK;
                }
            }
            

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            var layoutItems = layoutCtlGp_MaintainInfo.Items;
            foreach (LayoutControlItem layoutItem in layoutItems)
            {
                var control = layoutItem.Control as TextEdit;
                if (control != null)
                {
                    control.Properties.ReadOnly = false;
                }
            }
            btn_Edit.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            var layoutItems = layoutCtlGp_MaintainInfo.Items;
            foreach (LayoutControlItem layoutItem in layoutItems)
            {
                var control = layoutItem.Control as TextEdit;
                if (control != null)
                {
                    control.Properties.ReadOnly = true;
                }
            }
            btn_Edit.Enabled = true;
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}