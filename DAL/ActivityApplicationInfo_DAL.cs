using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CP.DBUtility;//Please add references
namespace CP.Campus.DAL
{
	/// <summary>
	/// 数据访问类:ActivityApplicationInfo_DAL
	/// </summary>
	public partial class ActivityApplicationInfo_DAL
	{
		public ActivityApplicationInfo_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string cpId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ActivityApplicationInfo");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10)			};
			parameters[0].Value = cpId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CP.Campus.Model.ActivityApplicationInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ActivityApplicationInfo(");
			strSql.Append("cpId,deptId,cpTitle,cpBudget,cpActivity,cpAStartTime,cpAEndTime,cpAPlace,attachment,status)");
			strSql.Append(" values (");
			strSql.Append("@cpId,@deptId,@cpTitle,@cpBudget,@cpActivity,@cpAStartTime,@cpAEndTime,@cpAPlace,@attachment,@status)");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10),
					new SqlParameter("@deptId", SqlDbType.Char,10),
					new SqlParameter("@cpTitle", SqlDbType.Char,50),
					new SqlParameter("@cpBudget", SqlDbType.Float,8),
					new SqlParameter("@cpActivity", SqlDbType.Text),
					new SqlParameter("@cpAStartTime", SqlDbType.Char,15),
					new SqlParameter("@cpAEndTime", SqlDbType.Char,15),
					new SqlParameter("@cpAPlace", SqlDbType.Char,50),
					new SqlParameter("@attachment", SqlDbType.Char,50),
					new SqlParameter("@status", SqlDbType.Char,10)};
			parameters[0].Value = model.cpId;
			parameters[1].Value = model.deptId;
			parameters[2].Value = model.cpTitle;
			parameters[3].Value = model.cpBudget;
			parameters[4].Value = model.cpActivity;
			parameters[5].Value = model.cpAStartTime;
			parameters[6].Value = model.cpAEndTime;
			parameters[7].Value = model.cpAPlace;
			parameters[8].Value = model.attachment;
			parameters[9].Value = model.status;

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
		public bool Update(CP.Campus.Model.ActivityApplicationInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ActivityApplicationInfo set ");
			strSql.Append("deptId=@deptId,");
			strSql.Append("cpTitle=@cpTitle,");
			strSql.Append("cpBudget=@cpBudget,");
			strSql.Append("cpActivity=@cpActivity,");
			strSql.Append("cpAStartTime=@cpAStartTime,");
			strSql.Append("cpAEndTime=@cpAEndTime,");
			strSql.Append("cpAPlace=@cpAPlace,");
			strSql.Append("attachment=@attachment,");
			strSql.Append("status=@status");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@deptId", SqlDbType.Char,10),
					new SqlParameter("@cpTitle", SqlDbType.Char,50),
					new SqlParameter("@cpBudget", SqlDbType.Float,8),
					new SqlParameter("@cpActivity", SqlDbType.Text),
					new SqlParameter("@cpAStartTime", SqlDbType.Char,15),
					new SqlParameter("@cpAEndTime", SqlDbType.Char,15),
					new SqlParameter("@cpAPlace", SqlDbType.Char,50),
					new SqlParameter("@attachment", SqlDbType.Char,50),
					new SqlParameter("@status", SqlDbType.Char,10),
					new SqlParameter("@cpId", SqlDbType.Char,10)};
			parameters[0].Value = model.deptId;
			parameters[1].Value = model.cpTitle;
			parameters[2].Value = model.cpBudget;
			parameters[3].Value = model.cpActivity;
			parameters[4].Value = model.cpAStartTime;
			parameters[5].Value = model.cpAEndTime;
			parameters[6].Value = model.cpAPlace;
			parameters[7].Value = model.attachment;
			parameters[8].Value = model.status;
			parameters[9].Value = model.cpId;

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
			strSql.Append("delete from ActivityApplicationInfo ");
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
			strSql.Append("delete from ActivityApplicationInfo ");
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
		public CP.Campus.Model.ActivityApplicationInfo GetModel(string cpId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 cpId,deptId,cpTitle,cpBudget,cpActivity,cpAStartTime,cpAEndTime,cpAPlace,attachment,status from ActivityApplicationInfo ");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10)			};
			parameters[0].Value = cpId;

			CP.Campus.Model.ActivityApplicationInfo model=new CP.Campus.Model.ActivityApplicationInfo();
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
		public CP.Campus.Model.ActivityApplicationInfo DataRowToModel(DataRow row)
		{
			CP.Campus.Model.ActivityApplicationInfo model=new CP.Campus.Model.ActivityApplicationInfo();
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
				if(row["cpTitle"]!=null)
				{
					model.cpTitle=row["cpTitle"].ToString();
				}
				if(row["cpBudget"]!=null && row["cpBudget"].ToString()!="")
				{
					model.cpBudget=decimal.Parse(row["cpBudget"].ToString());
				}
				if(row["cpActivity"]!=null)
				{
					model.cpActivity=row["cpActivity"].ToString();
				}
				if(row["cpAStartTime"]!=null)
				{
					model.cpAStartTime=row["cpAStartTime"].ToString();
				}
				if(row["cpAEndTime"]!=null)
				{
					model.cpAEndTime=row["cpAEndTime"].ToString();
				}
				if(row["cpAPlace"]!=null)
				{
					model.cpAPlace=row["cpAPlace"].ToString();
				}
				if(row["attachment"]!=null)
				{
					model.attachment=row["attachment"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
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
			strSql.Append("select cpId,deptId,cpTitle,cpBudget,cpActivity,cpAStartTime,cpAEndTime,cpAPlace,attachment,status ");
			strSql.Append(" FROM ActivityApplicationInfo ");
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
			strSql.Append(" cpId,deptId,cpTitle,cpBudget,cpActivity,cpAStartTime,cpAEndTime,cpAPlace,attachment,status ");
			strSql.Append(" FROM ActivityApplicationInfo ");
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
			strSql.Append("select count(1) FROM ActivityApplicationInfo ");
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
			strSql.Append(")AS Row, T.*  from ActivityApplicationInfo T ");
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
			parameters[0].Value = "ActivityApplicationInfo";
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

