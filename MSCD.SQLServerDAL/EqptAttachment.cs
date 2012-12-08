﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using MSCD.IDAL;
using MSCD.DBUtility;//Please add references
namespace MSCD.SQLServerDAL
{
    /// <summary>
    /// 数据访问类:EqptAttachment
    /// </summary>
    public partial class EqptAttachment : IEqptAttachment
    {
        public EqptAttachment()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from b_EqptAttachment");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(MSCD.Model.EqptAttachment model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into b_EqptAttachment(");
            strSql.Append("LayerName,SmId,Name,Attachment)");
            strSql.Append(" values (");
            strSql.Append("@LayerName,@SmId,@Name,@Attachment)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@LayerName", SqlDbType.VarChar,50),
					new SqlParameter("@SmId", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,255),
					new SqlParameter("@Attachment", SqlDbType.VarBinary)};
            parameters[0].Value = model.LayerName;
            parameters[1].Value = model.SmId;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.Attachment;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(MSCD.Model.EqptAttachment model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update b_EqptAttachment set ");
            strSql.Append("LayerName=@LayerName,");
            strSql.Append("SmId=@SmId,");
            strSql.Append("Name=@Name,");
            strSql.Append("Attachment=@Attachment");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@LayerName", SqlDbType.VarChar,50),
					new SqlParameter("@SmId", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,255),
					new SqlParameter("@Attachment", SqlDbType.VarBinary),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.LayerName;
            parameters[1].Value = model.SmId;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.Attachment;
            parameters[4].Value = model.Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from b_EqptAttachment ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from b_EqptAttachment ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MSCD.Model.EqptAttachment GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,LayerName,SmId,Name,Attachment from b_EqptAttachment ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            MSCD.Model.EqptAttachment model = new MSCD.Model.EqptAttachment();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MSCD.Model.EqptAttachment DataRowToModel(DataRow row)
        {
            MSCD.Model.EqptAttachment model = new MSCD.Model.EqptAttachment();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["LayerName"] != null)
                {
                    model.LayerName = row["LayerName"].ToString();
                }
                if (row["SmId"] != null && row["SmId"].ToString() != "")
                {
                    model.SmId = int.Parse(row["SmId"].ToString());
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["Attachment"] != null && row["Attachment"].ToString() != "")
                {
                    model.Attachment = (byte[])row["Attachment"];
                }
            }
            return model;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MSCD.Model.EqptAttachment DataRowToModelWithoutAttachment(DataRow row)
        {
            MSCD.Model.EqptAttachment model = new MSCD.Model.EqptAttachment();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["LayerName"] != null)
                {
                    model.LayerName = row["LayerName"].ToString();
                }
                if (row["SmId"] != null && row["SmId"].ToString() != "")
                {
                    model.SmId = int.Parse(row["SmId"].ToString());
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,LayerName,SmId,Name,Attachment ");
            strSql.Append(" FROM b_EqptAttachment ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListWithoutAttachment(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,LayerName,SmId,Name ");
            strSql.Append(" FROM b_EqptAttachment ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Id,LayerName,SmId,Name,Attachment ");
            strSql.Append(" FROM b_EqptAttachment ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM b_EqptAttachment ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from b_EqptAttachment T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "b_EqptAttachment";
            parameters[1].Value = "Id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

