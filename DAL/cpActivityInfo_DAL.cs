using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CP.DBUtility;//Please add references
namespace CP.Campus.DAL
{
	/// <summary>
	/// 数据访问类:cpActivityInfo_DAL
	/// </summary>
	public partial class cpActivityInfo_DAL
	{
		public cpActivityInfo_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string cpId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from cpActivityInfo");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10)			};
			parameters[0].Value = cpId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CP.Campus.Model.cpActivityInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into cpActivityInfo(");
			strSql.Append("cpId,deptId,cpATitle,cpActivity,cpBudget,cpAStartTime,cpAEndTime,cpAPlace,cpType,attachment,remark)");
			strSql.Append(" values (");
			strSql.Append("@cpId,@deptId,@cpATitle,@cpActivity,@cpBudget,@cpAStartTime,@cpAEndTime,@cpAPlace,@cpType,@attachment,@remark)");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10),
					new SqlParameter("@deptId", SqlDbType.Char,10),
					new SqlParameter("@cpATitle", SqlDbType.Char,30),
					new SqlParameter("@cpActivity", SqlDbType.Text),
					new SqlParameter("@cpBudget", SqlDbType.Float,8),
					new SqlParameter("@cpAStartTime", SqlDbType.Char,12),
					new SqlParameter("@cpAEndTime", SqlDbType.Char,12),
					new SqlParameter("@cpAPlace", SqlDbType.Char,50),
					new SqlParameter("@cpType", SqlDbType.Char,2),
					new SqlParameter("@attachment", SqlDbType.Char,50),
					new SqlParameter("@remark", SqlDbType.Text)};
			parameters[0].Value = model.cpId;
			parameters[1].Value = model.deptId;
			parameters[2].Value = model.cpATitle;
			parameters[3].Value = model.cpActivity;
			parameters[4].Value = model.cpBudget;
			parameters[5].Value = model.cpAStartTime;
			parameters[6].Value = model.cpAEndTime;
			parameters[7].Value = model.cpAPlace;
			parameters[8].Value = model.cpType;
			parameters[9].Value = model.attachment;
			parameters[10].Value = model.remark;

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
		public bool Update(CP.Campus.Model.cpActivityInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update cpActivityInfo set ");
			strSql.Append("deptId=@deptId,");
			strSql.Append("cpATitle=@cpATitle,");
			strSql.Append("cpActivity=@cpActivity,");
			strSql.Append("cpBudget=@cpBudget,");
			strSql.Append("cpAStartTime=@cpAStartTime,");
			strSql.Append("cpAEndTime=@cpAEndTime,");
			strSql.Append("cpAPlace=@cpAPlace,");
			strSql.Append("cpType=@cpType,");
			strSql.Append("attachment=@attachment,");
			strSql.Append("remark=@remark");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@deptId", SqlDbType.Char,10),
					new SqlParameter("@cpATitle", SqlDbType.Char,30),
					new SqlParameter("@cpActivity", SqlDbType.Text),
					new SqlParameter("@cpBudget", SqlDbType.Float,8),
					new SqlParameter("@cpAStartTime", SqlDbType.Char,12),
					new SqlParameter("@cpAEndTime", SqlDbType.Char,12),
					new SqlParameter("@cpAPlace", SqlDbType.Char,50),
					new SqlParameter("@cpType", SqlDbType.Char,2),
					new SqlParameter("@attachment", SqlDbType.Char,50),
					new SqlParameter("@remark", SqlDbType.Text),
					new SqlParameter("@cpId", SqlDbType.Char,10)};
			parameters[0].Value = model.deptId;
			parameters[1].Value = model.cpATitle;
			parameters[2].Value = model.cpActivity;
			parameters[3].Value = model.cpBudget;
			parameters[4].Value = model.cpAStartTime;
			parameters[5].Value = model.cpAEndTime;
			parameters[6].Value = model.cpAPlace;
			parameters[7].Value = model.cpType;
			parameters[8].Value = model.attachment;
			parameters[9].Value = model.remark;
			parameters[10].Value = model.cpId;

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
			strSql.Append("delete from cpActivityInfo ");
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
			strSql.Append("delete from cpActivityInfo ");
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
		public CP.Campus.Model.cpActivityInfo GetModel(string cpId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 cpId,deptId,cpATitle,cpActivity,cpBudget,cpAStartTime,cpAEndTime,cpAPlace,cpType,attachment,remark from cpActivityInfo ");
			strSql.Append(" where cpId=@cpId ");
			SqlParameter[] parameters = {
					new SqlParameter("@cpId", SqlDbType.Char,10)			};
			parameters[0].Value = cpId;

			CP.Campus.Model.cpActivityInfo model=new CP.Campus.Model.cpActivityInfo();
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
		public CP.Campus.Model.cpActivityInfo DataRowToModel(DataRow row)
		{
			CP.Campus.Model.cpActivityInfo model=new CP.Campus.Model.cpActivityInfo();
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
				if(row["cpATitle"]!=null)
				{
					model.cpATitle=row["cpATitle"].ToString();
				}
				if(row["cpActivity"]!=null)
				{
					model.cpActivity=row["cpActivity"].ToString();
				}
				if(row["cpBudget"]!=null && row["cpBudget"].ToString()!="")
				{
					model.cpBudget=Convert.ToInt32(row["cpBudget"].ToString());
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
				if(row["cpType"]!=null)
				{
					model.cpType=row["cpType"].ToString();
				}
				if(row["attachment"]!=null)
				{
					model.attachment=row["attachment"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
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
			strSql.Append("select cpId,deptId,cpATitle,cpActivity,cpBudget,cpAStartTime,cpAEndTime,cpAPlace,cpType,attachment,remark ");
			strSql.Append(" FROM cpActivityInfo ");
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
			strSql.Append(" cpId,deptId,cpATitle,cpActivity,cpBudget,cpAStartTime,cpAEndTime,cpAPlace,cpType,attachment,remark ");
			strSql.Append(" FROM cpActivityInfo ");
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
			strSql.Append("select count(1) FROM cpActivityInfo ");
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
				strSql.Append("order by T.cpId asc");
			}
			strSql.Append(")AS Row, T.*  from cpActivityInfo T ");
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
			parameters[0].Value = "cpActivityInfo";
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

