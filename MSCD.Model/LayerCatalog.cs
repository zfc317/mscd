using System;
namespace MSCD.Model
{
    /// <summary>
    /// LayerCatalog:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class LayerCatalog
    {
        public LayerCatalog()
        { }
        #region Model
        private int _id;
        private int _typeid;
        private string _layername;
        private string _layercaption;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int typeId
        {
            set { _typeid = value; }
            get { return _typeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string layerName
        {
            set { _layername = value; }
            get { return _layername; }
        }

        public string layerCaption
        {
            set { _layercaption = value; }
            get { return _layercaption; }
        }
        #endregion Model

    }
}

