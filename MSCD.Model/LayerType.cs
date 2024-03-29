﻿using System;
namespace MSCD.Model
{
    /// <summary>
    /// LayerType:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class LayerType
    {
        public LayerType()
        { }
        #region Model
        private int _id;
        private string _name;
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
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        #endregion Model

    }
}

