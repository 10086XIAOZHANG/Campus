using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CP.DBUtility;//Please add references
namespace CP.Campus.DAL
{
	/// <summary>
	/// 数据访问类:CpDeptInfo_DAL
	/// </summary>
	public partial class CpDeptInfo_DAL
	{
		public CpDeptInfo_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string cpId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CpDeptInfo");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10)			};
			parameters[0].Value = cpId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CP.Campus.Model.CpDeptInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CpDeptInfo(");
			strSql.Append("cpId,deptId,deptName,deptMemberNum,deptDescription,cpType)");
			strSql.Append(" values (");
			strSql.Append("@cpId,@deptId,@deptName,@deptMemberNum,@deptDescription,@cpType)");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10),
					new SqlParameter("@deptId", SqlDbType.Char,10),
					new SqlParameter("@deptName", SqlDbType.Char,20),
					new SqlParameter("@deptMemberNum", SqlDbType.Int,4),
					new SqlParameter("@deptDescription", SqlDbType.Char,280),
					new SqlParameter("@cpType", SqlDbType.Char,2)};
			parameters[0].Value = model.cpId;
			parameters[1].Value = model.deptId;
			parameters[2].Value = model.deptName;
			parameters[3].Value = model.deptMemberNum;
			parameters[4].Value = model.deptDescription;
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
		public bool Update(CP.Campus.Model.CpDeptInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CpDeptInfo set ");
			strSql.Append("deptId=@deptId,");
			strSql.Append("deptName=@deptName,");
			strSql.Append("deptMemberNum=@deptMemberNum,");
			strSql.Append("deptDescription=@deptDescription,");
			strSql.Append("cpType=@cpType");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@deptId", SqlDbType.Char,10),
					new SqlParameter("@deptName", SqlDbType.Char,20),
					new SqlParameter("@deptMemberNum", SqlDbType.Int,4),
					new SqlParameter("@deptDescription", SqlDbType.Char,280),
					new SqlParameter("@cpType", SqlDbType.Char,2),
					new SqlParameter("@cpId", SqlDbType.Char,10)};
			parameters[0].Value = model.deptId;
			parameters[1].Value = model.deptName;
			parameters[2].Value = model.deptMemberNum;
			parameters[3].Value = model.deptDescription;
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
			strSql.Append("delete from CpDeptInfo ");
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
			strSql.Append("delete from CpDeptInfo ");
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
		public CP.Campus.Model.CpDeptInfo GetModel(string cpId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 cpId,deptId,deptName,deptMemberNum,deptDescription,cpType from CpDeptInfo ");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10)			};
			parameters[0].Value = cpId;

			CP.Campus.Model.CpDeptInfo model=new CP.Campus.Model.CpDeptInfo();
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
		public CP.Campus.Model.CpDeptInfo DataRowToModel(DataRow row)
		{
			CP.Campus.Model.CpDeptInfo model=new CP.Campus.Model.CpDeptInfo();
			if (row != null)
			{
				if(row["cpId"]!=null)
				{
					model.cpId=row["cpId"].ToString();
				}
				if(row["deptId"]!=null)
				{
					model.deptId=row["deptId"].ToString();
				}
				if(row["deptName"]!=null)
				{
					model.deptName=row["deptName"].ToString();
				}
				if(row["deptMemberNum"]!=null && row["deptMemberNum"].ToString()!="")
				{
					model.deptMemberNum=int.Parse(row["deptMemberNum"].ToString());
				}
				if(row["deptDescription"]!=null)
				{
					model.deptDescription=row["deptDescription"].ToString();
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
			strSql.Append("select cpId,deptId,deptName,deptMemberNum,deptDescription,cpType ");
			strSql.Append(" FROM CpDeptInfo ");
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
			strSql.Append(" cpId,deptId,deptName,deptMemberNum,deptDescription,cpType ");
			strSql.Append(" FROM CpDeptInfo ");
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
			strSql.Append("select count(1) FROM CpDeptInfo ");
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
			strSql.Append(")AS Row, T.*  from CpDeptInfo T ");
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
			parameters[0].Value = "CpDeptInfo";
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

