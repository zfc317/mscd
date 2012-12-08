using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using MSCD.IDAL;
using MSCD.DBUtility;//Please add references
namespace MSCD.SQLServerDAL
{
    /// <summary>
    /// 数据访问类:EqptMaintain
    /// </summary>
    public partial class EqptMaintain : IEqptMaintain
    {
        public EqptMaintain()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from b_EqptMaintain");
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
        public int Add(MSCD.Model.EqptMaintain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into b_EqptMaintain(");
            strSql.Append("SmId,LayerName,Name,Department,EqptName,RecordDate,MaintainDate,NextMaintainDate,MaintainType,Maintainer,Checker,Reason,Process,Result,CheckOpinion)");
            strSql.Append(" values (");
            strSql.Append("@SmId,@LayerName,@Name,@Department,@EqptName,@RecordDate,@MaintainDate,@NextMaintainDate,@MaintainType,@Maintainer,@Checker,@Reason,@Process,@Result,@CheckOpinion)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@SmId", SqlDbType.Int,4),
					new SqlParameter("@LayerName", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@Department", SqlDbType.VarChar,200),
					new SqlParameter("@EqptName", SqlDbType.VarChar,200),
					new SqlParameter("@RecordDate", SqlDbType.Date,3),
					new SqlParameter("@MaintainDate", SqlDbType.Date,3),
					new SqlParameter("@NextMaintainDate", SqlDbType.Date,3),
					new SqlParameter("@MaintainType", SqlDbType.Int,4),
					new SqlParameter("@Maintainer", SqlDbType.VarChar,200),
					new SqlParameter("@Checker", SqlDbType.VarChar,200),
					new SqlParameter("@Reason", SqlDbType.VarChar,500),
					new SqlParameter("@Process", SqlDbType.VarChar,500),
					new SqlParameter("@Result", SqlDbType.VarChar,500),
					new SqlParameter("@CheckOpinion", SqlDbType.VarChar,500)};
            parameters[0].Value = model.SmId;
            parameters[1].Value = model.LayerName;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.Department;
            parameters[4].Value = model.EqptName;
            parameters[5].Value = model.RecordDate;
            parameters[6].Value = model.MaintainDate;
            parameters[7].Value = model.NextMaintainDate;
            parameters[8].Value = model.MaintainType;
            parameters[9].Value = model.Maintainer;
            parameters[10].Value = model.Checker;
            parameters[11].Value = model.Reason;
            parameters[12].Value = model.Process;
            parameters[13].Value = model.Result;
            parameters[14].Value = model.CheckOpinion;

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
        public bool Update(MSCD.Model.EqptMaintain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update b_EqptMaintain set ");
            strSql.Append("SmId=@SmId,");
            strSql.Append("LayerName=@LayerName,");
            strSql.Append("Name=@Name,");
            strSql.Append("Department=@Department,");
            strSql.Append("EqptName=@EqptName,");
            strSql.Append("RecordDate=@RecordDate,");
            strSql.Append("MaintainDate=@MaintainDate,");
            strSql.Append("NextMaintainDate=@NextMaintainDate,");
            strSql.Append("MaintainType=@MaintainType,");
            strSql.Append("Maintainer=@Maintainer,");
            strSql.Append("Checker=@Checker,");
            strSql.Append("Reason=@Reason,");
            strSql.Append("Process=@Process,");
            strSql.Append("Result=@Result,");
            strSql.Append("CheckOpinion=@CheckOpinion");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@SmId", SqlDbType.Int,4),
					new SqlParameter("@LayerName", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@Department", SqlDbType.VarChar,200),
					new SqlParameter("@EqptName", SqlDbType.VarChar,200),
					new SqlParameter("@RecordDate", SqlDbType.Date,3),
					new SqlParameter("@MaintainDate", SqlDbType.Date,3),
					new SqlParameter("@NextMaintainDate", SqlDbType.Date,3),
					new SqlParameter("@MaintainType", SqlDbType.Int,4),
					new SqlParameter("@Maintainer", SqlDbType.VarChar,200),
					new SqlParameter("@Checker", SqlDbType.VarChar,200),
					new SqlParameter("@Reason", SqlDbType.VarChar,500),
					new SqlParameter("@Process", SqlDbType.VarChar,500),
					new SqlParameter("@Result", SqlDbType.VarChar,500),
					new SqlParameter("@CheckOpinion", SqlDbType.VarChar,500),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.SmId;
            parameters[1].Value = model.LayerName;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.Department;
            parameters[4].Value = model.EqptName;
            parameters[5].Value = model.RecordDate;
            parameters[6].Value = model.MaintainDate;
            parameters[7].Value = model.NextMaintainDate;
            parameters[8].Value = model.MaintainType;
            parameters[9].Value = model.Maintainer;
            parameters[10].Value = model.Checker;
            parameters[11].Value = model.Reason;
            parameters[12].Value = model.Process;
            parameters[13].Value = model.Result;
            parameters[14].Value = model.CheckOpinion;
            parameters[15].Value = model.Id;

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
            strSql.Append("delete from b_EqptMaintain ");
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
            strSql.Append("delete from b_EqptMaintain ");
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
        public MSCD.Model.EqptMaintain GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,SmId,LayerName,Name,Department,EqptName,RecordDate,MaintainDate,NextMaintainDate,MaintainType,Maintainer,Checker,Reason,Process,Result,CheckOpinion from b_EqptMaintain ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            MSCD.Model.EqptMaintain model = new MSCD.Model.EqptMaintain();
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
        public MSCD.Model.EqptMaintain DataRowToModel(DataRow row)
        {
            MSCD.Model.EqptMaintain model = new MSCD.Model.EqptMaintain();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["SmId"] != null && row["SmId"].ToString() != "")
                {
                    model.SmId = int.Parse(row["SmId"].ToString());
                }
                if (row["LayerName"] != null)
                {
                    model.LayerName = row["LayerName"].ToString();
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["Department"] != null)
                {
                    model.Department = row["Department"].ToString();
                }
                if (row["EqptName"] != null)
                {
                    model.EqptName = row["EqptName"].ToString();
                }
                if (row["RecordDate"] != null && row["RecordDate"].ToString() != "")
                {
                    model.RecordDate = DateTime.Parse(row["RecordDate"].ToString());
                }
                if (row["MaintainDate"] != null && row["MaintainDate"].ToString() != "")
                {
                    model.MaintainDate = DateTime.Parse(row["MaintainDate"].ToString());
                }
                if (row["NextMaintainDate"] != null && row["NextMaintainDate"].ToString() != "")
                {
                    model.NextMaintainDate = DateTime.Parse(row["NextMaintainDate"].ToString());
                }
                if (row["MaintainType"] != null && row["MaintainType"].ToString() != "")
                {
                    model.MaintainType = int.Parse(row["MaintainType"].ToString());
                }
                if (row["Maintainer"] != null)
                {
                    model.Maintainer = row["Maintainer"].ToString();
                }
                if (row["Checker"] != null)
                {
                    model.Checker = row["Checker"].ToString();
                }
                if (row["Reason"] != null)
                {
                    model.Reason = row["Reason"].ToString();
                }
                if (row["Process"] != null)
                {
                    model.Process = row["Process"].ToString();
                }
                if (row["Result"] != null)
                {
                    model.Result = row["Result"].ToString();
                }
                if (row["CheckOpinion"] != null)
                {
                    model.CheckOpinion = row["CheckOpinion"].ToString();
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
            strSql.Append("select Id,SmId,LayerName,Name,Department,EqptName,RecordDate,MaintainDate,NextMaintainDate,MaintainType,Maintainer,Checker,Reason,Process,Result,CheckOpinion ");
            strSql.Append(" FROM b_EqptMaintain ");
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
            strSql.Append(" Id,SmId,LayerName,Name,Department,EqptName,RecordDate,MaintainDate,NextMaintainDate,MaintainType,Maintainer,Checker,Reason,Process,Result,CheckOpinion ");
            strSql.Append(" FROM b_EqptMaintain ");
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
            strSql.Append("select count(1) FROM b_EqptMaintain ");
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
            strSql.Append(")AS Row, T.*  from b_EqptMaintain T ");
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
            parameters[0].Value = "b_EqptMaintain";
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

