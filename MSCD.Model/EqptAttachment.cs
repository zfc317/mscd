using System;
namespace MSCD.Model
{
    /// <summary>
    /// EqptAttachment:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class EqptAttachment
    {
        public EqptAttachment()
        { }
        #region Model
        private int _id;
        private string _layername;
        private int _smid;
        private string _name;
        private byte[] _attachment;
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
        public string LayerName
        {
            set { _layername = value; }
            get { return _layername; }
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
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public byte[] Attachment
        {
            set { _attachment = value; }
            get { return _attachment; }
        }
        #endregion Model

    }
}

