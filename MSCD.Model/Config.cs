﻿using System;
namespace MSCD.Model
{
    /// <summary>
    /// Config:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Config
    {
        public Config()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _info;
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
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string info
        {
            set { _info = value; }
            get { return _info; }
        }
        #endregion Model

    }
}

