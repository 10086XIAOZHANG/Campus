using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CP.DBUtility;//Please add references
namespace CP.Campus.DAL
{
	/// <summary>
	/// 数据访问类:CpInfo_DAL
	/// </summary>
	public partial class CpInfo_DAL
	{
		public CpInfo_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string cpId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CpInfo");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10)			};
			parameters[0].Value = cpId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CP.Campus.Model.CpInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CpInfo(");
			strSql.Append("cpId,cpName,cpFound,cpCulture,cpMotto,cpType)");
			strSql.Append(" values (");
			strSql.Append("@cpId,@cpName,@cpFound,@cpCulture,@cpMotto,@cpType)");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10),
					new SqlParameter("@cpName", SqlDbType.Char,30),
					new SqlParameter("@cpFound", SqlDbType.Char,12),
					new SqlParameter("@cpCulture", SqlDbType.Text),
					new SqlParameter("@cpMotto", SqlDbType.Char,280),
					new SqlParameter("@cpType", SqlDbType.Char,2)};
			parameters[0].Value = model.cpId;
			parameters[1].Value = model.cpName;
			parameters[2].Value = model.cpFound;
			parameters[3].Value = model.cpCulture;
			parameters[4].Value = model.cpMotto;
			parameters[5].Value = model.cpType;

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
		public bool Update(CP.Campus.Model.CpInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CpInfo set ");
			strSql.Append("cpName=@cpName,");
			strSql.Append("cpFound=@cpFound,");
			strSql.Append("cpCulture=@cpCulture,");
			strSql.Append("cpMotto=@cpMotto,");
			strSql.Append("cpType=@cpType");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@cpName", SqlDbType.Char,30),
					new SqlParameter("@cpFound", SqlDbType.Char,12),
					new SqlParameter("@cpCulture", SqlDbType.Text),
					new SqlParameter("@cpMotto", SqlDbType.Char,280),
					new SqlParameter("@cpType", SqlDbType.Char,2),
					new SqlParameter("@cpId", SqlDbType.Char,10)};
			parameters[0].Value = model.cpName;
			parameters[1].Value = model.cpFound;
			parameters[2].Value = model.cpCulture;
			parameters[3].Value = model.cpMotto;
			parameters[4].Value = model.cpType;
			parameters[5].Value = model.cpId;

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
		public bool Delete(string cpId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CpInfo ");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10)			};
			parameters[0].Value = cpId;

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
		public bool DeleteList(string cpIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CpInfo ");
			strSql.Append(" where cpId in ("+cpIdlist + ")  ");
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
		public CP.Campus.Model.CpInfo GetModel(string cpId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 cpId,cpName,cpFound,cpCulture,cpMotto,cpType from CpInfo ");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10)			};
			parameters[0].Value = cpId;

			CP.Campus.Model.CpInfo model=new CP.Campus.Model.CpInfo();
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
		public CP.Campus.Model.CpInfo DataRowToModel(DataRow row)
		{
			CP.Campus.Model.CpInfo model=new CP.Campus.Model.CpInfo();
			if (row != null)
			{
				if(row["cpId"]!=null)
				{
					model.cpId=row["cpId"].ToString();
				}
				if(row["cpName"]!=null)
				{
					model.cpName=row["cpName"].ToString();
				}
				if(row["cpFound"]!=null)
				{
					model.cpFound=row["cpFound"].ToString();
				}
				if(row["cpCulture"]!=null)
				{
					model.cpCulture=row["cpCulture"].ToString();
				}
				if(row["cpMotto"]!=null)
				{
					model.cpMotto=row["cpMotto"].ToString();
				}
				if(row["cpType"]!=null)
				{
					model.cpType=row["cpType"].ToString();
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
			strSql.Append("select cpId,cpName,cpFound,cpCulture,cpMotto,cpType ");
			strSql.Append(" FROM CpInfo ");
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
			strSql.Append(" cpId,cpName,cpFound,cpCulture,cpMotto,cpType ");
			strSql.Append(" FROM CpInfo ");
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
			strSql.Append("select count(1) FROM CpInfo ");
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
				strSql.Append("order by T.cpId desc");
			}
			strSql.Append(")AS Row, T.*  from CpInfo T ");
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
			parameters[0].Value = "CpInfo";
			parameters[1].Value = "cpId";
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

