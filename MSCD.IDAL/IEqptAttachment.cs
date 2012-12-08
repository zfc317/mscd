﻿using System;
using System.Data;
namespace MSCD.IDAL
{
    /// <summary>
    /// 接口层EqptAttachment
    /// </summary>
    public interface IEqptAttachment
    {
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int Id);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(MSCD.Model.EqptAttachment model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(MSCD.Model.EqptAttachment model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int Id);
        bool DeleteList(string Idlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        MSCD.Model.EqptAttachment GetModel(int Id);
        MSCD.Model.EqptAttachment DataRowToModel(DataRow row);
        MSCD.Model.EqptAttachment DataRowToModelWithoutAttachment(DataRow row);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        DataSet GetListWithoutAttachment(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);
        #endregion  成员方法
        #region  MethodEx

        #endregion  MethodEx
    }
}
