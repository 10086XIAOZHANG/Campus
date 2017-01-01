using CP.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CP.Campus.DAL
{
    /// <summary>
    /// 数据访问类:UserLoginState_DAL
    /// </summary>
    public partial class UserLoginState_DAL
    {
        public UserLoginState_DAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string userId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from UserLoginState");
            strSql.Append(" where userId=@userId ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.VarChar,12)			};
            parameters[0].Value = userId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(CP.Campus.Model.UserLoginState model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserLoginState(");
            strSql.Append("userId,ipNum,lastLoginTime,loginPlace,loginNum)");
            strSql.Append(" values (");
            strSql.Append("@userId,@ipNum,@lastLoginTime,@loginPlace,@loginNum)");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Char,12),
					new SqlParameter("@ipNum", SqlDbType.Char,20),
					new SqlParameter("@lastLoginTime", SqlDbType.Char,25),
					new SqlParameter("@loginPlace", SqlDbType.Char,10),
					new SqlParameter("@loginNum", SqlDbType.Char,10)};
            parameters[0].Value = model.userId;
            parameters[1].Value = model.ipNum;
            parameters[2].Value = model.lastLoginTime;
            parameters[3].Value = model.loginPlace;
            parameters[4].Value = model.loginNum;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(CP.Campus.Model.UserLoginState model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update UserLoginState set ");
            strSql.Append("ipNum=@ipNum,");
            strSql.Append("lastLoginTime=@lastLoginTime,");
            strSql.Append("loginPlace=@loginPlace,");
            strSql.Append("loginNum=@loginNum");
            strSql.Append(" where userId=@userId ");
            SqlParameter[] parameters = {
					new SqlParameter("@ipNum", SqlDbType.VarChar,20),
					new SqlParameter("@lastLoginTime", SqlDbType.VarChar,25),
					new SqlParameter("@loginPlace", SqlDbType.VarChar,10),
					new SqlParameter("@loginNum", SqlDbType.VarChar,10),
					new SqlParameter("@userId", SqlDbType.VarChar,12)};
            parameters[0].Value = model.ipNum;
            parameters[1].Value = model.lastLoginTime;
            parameters[2].Value = model.loginPlace;
            parameters[3].Value = model.loginNum;
            parameters[4].Value = model.userId;

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
        public bool Delete(string userId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserLoginState ");
            strSql.Append(" where userId=@userId ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.VarChar,12)			};
            parameters[0].Value = userId;

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
        public bool DeleteList(string userIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserLoginState ");
            strSql.Append(" where userId in (" + userIdlist + ")  ");
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
        public CP.Campus.Model.UserLoginState GetModel(string userId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 userId,ipNum,lastLoginTime,loginPlace,loginNum from UserLoginState ");
            strSql.Append(" where userId=@userId ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.VarChar,12)			};
            parameters[0].Value = userId;

            CP.Campus.Model.UserLoginState model = new CP.Campus.Model.UserLoginState();
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
        public CP.Campus.Model.UserLoginState DataRowToModel(DataRow row)
        {
            CP.Campus.Model.UserLoginState model = new CP.Campus.Model.UserLoginState();
            if (row != null)
            {
                if (row["userId"] != null)
                {
                    model.userId = row["userId"].ToString();
                }
                if (row["ipNum"] != null)
                {
                    model.ipNum = row["ipNum"].ToString();
                }
                if (row["lastLoginTime"] != null)
                {
                    model.lastLoginTime = row["lastLoginTime"].ToString();
                }
                if (row["loginPlace"] != null)
                {
                    model.loginPlace = row["loginPlace"].ToString();
                }
                if (row["loginNum"] != null)
                {
                    model.loginNum = row["loginNum"].ToString();
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
            strSql.Append("select userId,ipNum,lastLoginTime,loginPlace,loginNum ");
            strSql.Append(" FROM UserLoginState ");
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
            strSql.Append(" userId,ipNum,lastLoginTime,loginPlace,loginNum ");
            strSql.Append(" FROM UserLoginState ");
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
            strSql.Append("select count(1) FROM UserLoginState ");
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
                strSql.Append("order by T.userId desc");
            }
            strSql.Append(")AS Row, T.*  from UserLoginState T ");
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
            parameters[0].Value = "UserLoginState";
            parameters[1].Value = "userId";
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
