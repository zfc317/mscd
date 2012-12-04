using System;
namespace MSCD.Model
{
    /// <summary>
    /// EqptImage:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class EqptImage
    {
        public EqptImage()
        { }
        #region Model
        private int _id;
        private int _smid;
        private string _layername;
        private string _imagename;
        private byte[] _image;
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
        public string ImageName
        {
            set { _imagename = value; }
            get { return _imagename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public byte[] Image
        {
            set { _image = value; }
            get { return _image; }
        }
        #endregion Model

    }
}

