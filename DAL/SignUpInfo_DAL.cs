using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CP.DBUtility;//Please add references
namespace CP.Campus.DAL
{
	/// <summary>
	/// 数据访问类:SignUpInfo_DAL
	/// </summary>
	public partial class SignUpInfo_DAL
	{
		public SignUpInfo_DAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string newSubmitId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SignUpInfo");
			strSql.Append(" where newSubmitId=@newSubmitId ");
			SqlParameter[] parameters = {
					new SqlParameter("@newSubmitId", SqlDbType.Char,40)			};
			parameters[0].Value = newSubmitId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CP.Campus.Model.SignUpInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SignUpInfo(");
			strSql.Append("newSubmitId,newUserName,newUserSex,newSchoolDepartment,newJoinCp,newSubmitTime,newPhoneNumber,newPhotoAddress,newMajor,newGrade,newClassWide,newRemark,newStatus)");
			strSql.Append(" values (");
			strSql.Append("@newSubmitId,@newUserName,@newUserSex,@newSchoolDepartment,@newJoinCp,@newSubmitTime,@newPhoneNumber,@newPhotoAddress,@newMajor,@newGrade,@newClassWide,@newRemark,@newStatus)");
			SqlParameter[] parameters = {
					new SqlParameter("@newSubmitId", SqlDbType.Char,40),
					new SqlParameter("@newUserName", SqlDbType.Char,20),
					new SqlParameter("@newUserSex", SqlDbType.Char,2),
					new SqlParameter("@newSchoolDepartment", SqlDbType.Char,25),
					new SqlParameter("@newJoinCp", SqlDbType.Char,20),
					new SqlParameter("@newSubmitTime", SqlDbType.Char,18),
					new SqlParameter("@newPhoneNumber", SqlDbType.Char,11),
					new SqlParameter("@newPhotoAddress", SqlDbType.Char,50),
					new SqlParameter("@newMajor", SqlDbType.Char,30),
					new SqlParameter("@newGrade", SqlDbType.Char,5),
					new SqlParameter("@newClassWide", SqlDbType.Char,20),
					new SqlParameter("@newRemark", SqlDbType.Text),
					new SqlParameter("@newStatus", SqlDbType.Char,10)};
			parameters[0].Value = model.newSubmitId;
			parameters[1].Value = model.newUserName;
			parameters[2].Value = model.newUserSex;
			parameters[3].Value = model.newSchoolDepartment;
			parameters[4].Value = model.newJoinCp;
			parameters[5].Value = model.newSubmitTime;
			parameters[6].Value = model.newPhoneNumber;
			parameters[7].Value = model.newPhotoAddress;
			parameters[8].Value = model.newMajor;
			parameters[9].Value = model.newGrade;
			parameters[10].Value = model.newClassWide;
			parameters[11].Value = model.newRemark;
			parameters[12].Value = model.newStatus;

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
		public bool Update(CP.Campus.Model.SignUpInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SignUpInfo set ");
			strSql.Append("newUserName=@newUserName,");
			strSql.Append("newUserSex=@newUserSex,");
			strSql.Append("newSchoolDepartment=@newSchoolDepartment,");
			strSql.Append("newJoinCp=@newJoinCp,");
			strSql.Append("newSubmitTime=@newSubmitTime,");
			strSql.Append("newPhoneNumber=@newPhoneNumber,");
			strSql.Append("newPhotoAddress=@newPhotoAddress,");
			strSql.Append("newMajor=@newMajor,");
			strSql.Append("newGrade=@newGrade,");
			strSql.Append("newClassWide=@newClassWide,");
			strSql.Append("newRemark=@newRemark,");
			strSql.Append("newStatus=@newStatus");
			strSql.Append(" where newSubmitId=@newSubmitId ");
			SqlParameter[] parameters = {
					new SqlParameter("@newUserName", SqlDbType.Char,20),
					new SqlParameter("@newUserSex", SqlDbType.Char,2),
					new SqlParameter("@newSchoolDepartment", SqlDbType.Char,25),
					new SqlParameter("@newJoinCp", SqlDbType.Char,20),
					new SqlParameter("@newSubmitTime", SqlDbType.Char,18),
					new SqlParameter("@newPhoneNumber", SqlDbType.Char,11),
					new SqlParameter("@newPhotoAddress", SqlDbType.Char,50),
					new SqlParameter("@newMajor", SqlDbType.Char,30),
					new SqlParameter("@newGrade", SqlDbType.Char,5),
					new SqlParameter("@newClassWide", SqlDbType.Char,20),
					new SqlParameter("@newRemark", SqlDbType.Text),
					new SqlParameter("@newStatus", SqlDbType.Char,10),
					new SqlParameter("@newSubmitId", SqlDbType.Char,40)};
			parameters[0].Value = model.newUserName;
			parameters[1].Value = model.newUserSex;
			parameters[2].Value = model.newSchoolDepartment;
			parameters[3].Value = model.newJoinCp;
			parameters[4].Value = model.newSubmitTime;
			parameters[5].Value = model.newPhoneNumber;
			parameters[6].Value = model.newPhotoAddress;
			parameters[7].Value = model.newMajor;
			parameters[8].Value = model.newGrade;
			parameters[9].Value = model.newClassWide;
			parameters[10].Value = model.newRemark;
			parameters[11].Value = model.newStatus;
			parameters[12].Value = model.newSubmitId;

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
		public bool Delete(string newSubmitId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SignUpInfo ");
			strSql.Append(" where newSubmitId=@newSubmitId ");
			SqlParameter[] parameters = {
					new SqlParameter("@newSubmitId", SqlDbType.Char,40)			};
			parameters[0].Value = newSubmitId;

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
		public bool DeleteList(string newSubmitIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SignUpInfo ");
			strSql.Append(" where newSubmitId in ("+newSubmitIdlist + ")  ");
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
		public CP.Campus.Model.SignUpInfo GetModel(string newSubmitId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 newSubmitId,newUserName,newUserSex,newSchoolDepartment,newJoinCp,newSubmitTime,newPhoneNumber,newPhotoAddress,newMajor,newGrade,newClassWide,newRemark,newStatus from SignUpInfo ");
			strSql.Append(" where newSubmitId=@newSubmitId ");
			SqlParameter[] parameters = {
					new SqlParameter("@newSubmitId", SqlDbType.Char,40)			};
			parameters[0].Value = newSubmitId;

			CP.Campus.Model.SignUpInfo model=new CP.Campus.Model.SignUpInfo();
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
		public CP.Campus.Model.SignUpInfo DataRowToModel(DataRow row)
		{
			CP.Campus.Model.SignUpInfo model=new CP.Campus.Model.SignUpInfo();
			if (row != null)
			{
				if(row["newSubmitId"]!=null)
				{
					model.newSubmitId=row["newSubmitId"].ToString();
				}
				if(row["newUserName"]!=null)
				{
					model.newUserName=row["newUserName"].ToString();
				}
				if(row["newUserSex"]!=null)
				{
					model.newUserSex=row["newUserSex"].ToString();
				}
				if(row["newSchoolDepartment"]!=null)
				{
					model.newSchoolDepartment=row["newSchoolDepartment"].ToString();
				}
				if(row["newJoinCp"]!=null)
				{
					model.newJoinCp=row["newJoinCp"].ToString();
				}
				if(row["newSubmitTime"]!=null)
				{
					model.newSubmitTime=row["newSubmitTime"].ToString();
				}
				if(row["newPhoneNumber"]!=null)
				{
					model.newPhoneNumber=row["newPhoneNumber"].ToString();
				}
				if(row["newPhotoAddress"]!=null)
				{
					model.newPhotoAddress=row["newPhotoAddress"].ToString();
				}
				if(row["newMajor"]!=null)
				{
					model.newMajor=row["newMajor"].ToString();
				}
				if(row["newGrade"]!=null)
				{
					model.newGrade=row["newGrade"].ToString();
				}
				if(row["newClassWide"]!=null)
				{
					model.newClassWide=row["newClassWide"].ToString();
				}
				if(row["newRemark"]!=null)
				{
					model.newRemark=row["newRemark"].ToString();
				}
				if(row["newStatus"]!=null)
				{
					model.newStatus=row["newStatus"].ToString();
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
			strSql.Append("select newSubmitId,newUserName,newUserSex,newSchoolDepartment,newJoinCp,newSubmitTime,newPhoneNumber,newPhotoAddress,newMajor,newGrade,newClassWide,newRemark,newStatus ");
			strSql.Append(" FROM SignUpInfo ");
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
			strSql.Append(" newSubmitId,newUserName,newUserSex,newSchoolDepartment,newJoinCp,newSubmitTime,newPhoneNumber,newPhotoAddress,newMajor,newGrade,newClassWide,newRemark,newStatus ");
			strSql.Append(" FROM SignUpInfo ");
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
			strSql.Append("select count(1) FROM SignUpInfo ");
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
				strSql.Append("order by T.newSubmitId desc");
			}
			strSql.Append(")AS Row, T.*  from SignUpInfo T ");
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
			parameters[0].Value = "SignUpInfo";
			parameters[1].Value = "newSubmitId";
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

