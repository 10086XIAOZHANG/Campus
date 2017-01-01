using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CP.DBUtility;//Please add references
namespace CP.Campus.DAL
{
	/// <summary>
	/// 数据访问类:UserInfo_DAL
	/// </summary>
	public partial class UserInfo_DAL
	{
		public UserInfo_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string userId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserInfo");
			strSql.Append(" where userId=@userId ");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Char,12)			};
			parameters[0].Value = userId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CP.Campus.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserInfo(");
            strSql.Append("userId,userName,sex,birthday,email,qq,phoneNumber,userType,hobby,motto,photoAddress)");
			strSql.Append(" values (");
            strSql.Append("@userId,@userName,@sex,@birthday,@email,@qq,@phoneNumber,@userType,@hobby,@motto,@photoAddress)");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Char,12),
					new SqlParameter("@userName", SqlDbType.Char,20),
					new SqlParameter("@sex", SqlDbType.Char,2),
					new SqlParameter("@birthday", SqlDbType.Char,15),
					new SqlParameter("@email", SqlDbType.Char,35),
					new SqlParameter("@qq", SqlDbType.Char,13),
					new SqlParameter("@phoneNumber", SqlDbType.Char,12),
					new SqlParameter("@userType", SqlDbType.Char,2),
					new SqlParameter("@hobby", SqlDbType.Char,280),
					new SqlParameter("@motto", SqlDbType.VarChar,150),
                    new SqlParameter("@photoAddress",SqlDbType.VarChar,50)};
			parameters[0].Value = model.userId;
			parameters[1].Value = model.userName;
			parameters[2].Value = model.sex;
			parameters[3].Value = model.birthday;
			parameters[4].Value = model.email;
			parameters[5].Value = model.qq;
			parameters[6].Value = model.phoneNumber;
			parameters[7].Value = model.userType;
			parameters[8].Value = model.hobby;
			parameters[9].Value = model.motto;
            parameters[10].Value = model.photoAddress;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(CP.Campus.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserInfo set ");
			strSql.Append("userName=@userName,");
			strSql.Append("sex=@sex,");
			strSql.Append("birthday=@birthday,");
			strSql.Append("email=@email,");
			strSql.Append("qq=@qq,");
			strSql.Append("phoneNumber=@phoneNumber,");
			strSql.Append("userType=@userType,");
			strSql.Append("hobby=@hobby,");
			strSql.Append("motto=@motto,");
            strSql.Append("photoAddress=@photoAddress");
			strSql.Append(" where userId=@userId ");
			SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.Char,20),
					new SqlParameter("@sex", SqlDbType.Char,2),
					new SqlParameter("@birthday", SqlDbType.Char,15),
					new SqlParameter("@email", SqlDbType.Char,35),
					new SqlParameter("@qq", SqlDbType.Char,13),
					new SqlParameter("@phoneNumber", SqlDbType.Char,12),
					new SqlParameter("@userType", SqlDbType.Char,2),
					new SqlParameter("@hobby", SqlDbType.Char,280),
					new SqlParameter("@motto", SqlDbType.Char,150),
                    new SqlParameter("@photoAddress",SqlDbType.VarChar,50),
					new SqlParameter("@userId", SqlDbType.Char,12)};
			parameters[0].Value = model.userName;
			parameters[1].Value = model.sex;
			parameters[2].Value = model.birthday;
			parameters[3].Value = model.email;
			parameters[4].Value = model.qq;
			parameters[5].Value = model.phoneNumber;
			parameters[6].Value = model.userType;
			parameters[7].Value = model.hobby;
			parameters[8].Value = model.motto;
            parameters[9].Value = model.photoAddress;
			parameters[10].Value = model.userId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where userId=@userId ");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Char,12)			};
			parameters[0].Value = userId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string userIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where userId in ("+userIdlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public CP.Campus.Model.UserInfo GetModel(string userId)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 userId,userName,sex,birthday,email,qq,phoneNumber,userType,hobby,motto,photoAddress from UserInfo ");
			strSql.Append(" where userId=@userId ");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Char,12)			};
			parameters[0].Value = userId;

			CP.Campus.Model.UserInfo model=new CP.Campus.Model.UserInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public CP.Campus.Model.UserInfo DataRowToModel(DataRow row)
		{
			CP.Campus.Model.UserInfo model=new CP.Campus.Model.UserInfo();
			if (row != null)
			{
				if(row["userId"]!=null)
				{
					model.userId=row["userId"].ToString();
				}
				if(row["userName"]!=null)
				{
					model.userName=row["userName"].ToString();
				}
				if(row["sex"]!=null)
				{
					model.sex=row["sex"].ToString();
				}
				if(row["birthday"]!=null)
				{
					model.birthday=row["birthday"].ToString();
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["qq"]!=null)
				{
					model.qq=row["qq"].ToString();
				}
				if(row["phoneNumber"]!=null)
				{
					model.phoneNumber=row["phoneNumber"].ToString();
				}
				if(row["userType"]!=null)
				{
					model.userType=row["userType"].ToString();
				}
				if(row["hobby"]!=null)
				{
					model.hobby=row["hobby"].ToString();
				}
				if(row["motto"]!=null)
				{
					model.motto=row["motto"].ToString();
				}
                if (row["photoAddress"] != null) 
                {
                    model.photoAddress = row["photoAddress"].ToString();
                }
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select userId,userName,sex,birthday,email,qq,phoneNumber,userType,hobby,motto,photoAddress ");
			strSql.Append(" FROM UserInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
            strSql.Append(" userId,userName,sex,birthday,email,qq,phoneNumber,userType,hobby,motto,photoAddress ");
			strSql.Append(" FROM UserInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM UserInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.userId desc");
			}
			strSql.Append(")AS Row, T.*  from UserInfo T ");
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
			parameters[0].Value = "UserInfo";
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

