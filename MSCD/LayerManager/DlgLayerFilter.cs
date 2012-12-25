using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MSCD.Model;

namespace MSCD.UI.LayerManager
{
    public partial class DlgLayerFilter : DevExpress.XtraEditors.XtraForm
    {
        public String Condition { get; private set; }
        public DlgLayerFilter(List<FieldInfo> fields)
        {
            InitializeComponent();
            lookUpEdit_Field.Properties.DisplayMember = "FieldCaption";
            lookUpEdit_Field.Properties.ValueMember = "FieldName";
            lookUpEdit_Field.Properties.DataSource = fields;
            lookUpEdit_Field.EditValue = "SMID";
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            var keyword = txt_Keyword.Text.Trim();
            if(keyword=="")
            {
                XtraMessageBox.Show("请输入筛选的关键字!", "提示");
                return;
            }

            var fieldName = lookUpEdit_Field.EditValue.ToString();

            switch (commbox_Condition.Text)
            {
                case "包含":
                    Condition = string.Format("{0} like '%{1}%'", fieldName, keyword);
                    break;
                case "等于":
                    Condition = string.Format("{0} = '{1}'", fieldName, keyword);
                    break;
                case "不包含":
                    Condition = string.Format("{0} not like '%{1}%'", fieldName, keyword);
                    break;
            }
            DialogResult = DialogResult.OK;
        }
    }
}