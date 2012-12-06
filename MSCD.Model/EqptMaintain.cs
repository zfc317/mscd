using System;
namespace MSCD.Model
{
    /// <summary>
    /// EqptMaintain:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class EqptMaintain
    {
        public EqptMaintain()
        { }
        #region Model
        private int _id;
        private int _smid;
        private string _layername;
        private string _name;
        private string _department;
        private string _eqptname;
        private DateTime? _recorddate;
        private DateTime? _maintaindate;
        private DateTime? _nextmaintaindate;
        private int _maintaintype;
        private string _maintainer;
        private string _checker;
        private string _reason;
        private string _process;
        private string _result;
        private string _checkopinion;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SmId
        {
            set { _smid = value; }
            get { return _smid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LayerName
        {
            set { _layername = value; }
            get { return _layername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Department
        {
            set { _department = value; }
            get { return _department; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EqptName
        {
            set { _eqptname = value; }
            get { return _eqptname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? RecordDate
        {
            set { _recorddate = value; }
            get { return _recorddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? MaintainDate
        {
            set { _maintaindate = value; }
            get { return _maintaindate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? NextMaintainDate
        {
            set { _nextmaintaindate = value; }
            get { return _nextmaintaindate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MaintainType
        {
            set { _maintaintype = value; }
            get { return _maintaintype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Maintainer
        {
            set { _maintainer = value; }
            get { return _maintainer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Checker
        {
            set { _checker = value; }
            get { return _checker; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Reason
        {
            set { _reason = value; }
            get { return _reason; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Process
        {
            set { _process = value; }
            get { return _process; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Result
        {
            set { _result = value; }
            get { return _result; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CheckOpinion
        {
            set { _checkopinion = value; }
            get { return _checkopinion; }
        }
        #endregion Model

    }
}

