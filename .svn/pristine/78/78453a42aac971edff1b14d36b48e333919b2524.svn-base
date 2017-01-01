using System;
using System.Data;
using System.Collections.Generic;
using CP.Common;
using CP.Campus.Model;
namespace CP.Campus.BLL
{
	/// <summary>
	/// LoginInfo_BLL
	/// </summary>
	public partial class LoginInfo_BLL
	{
		private readonly CP.Campus.DAL.LoginInfo_DAL dal=new CP.Campus.DAL.LoginInfo_DAL();
		public LoginInfo_BLL()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string UserId)
		{
			return dal.Exists(UserId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CP.Campus.Model.LoginInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CP.Campus.Model.LoginInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string UserId)
		{
			
			return dal.Delete(UserId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string UserIdlist )
		{
			return dal.DeleteList(CP.Common.PageValidate.SafeLongFilter(UserIdlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CP.Campus.Model.LoginInfo GetModel(string UserId)
		{
			
			return dal.GetModel(UserId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public CP.Campus.Model.LoginInfo GetModelByCache(string UserId)
		{
			
			string CacheKey = "LoginInfoModel-" + UserId;
			object objModel = CP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(UserId);
					if (objModel != null)
					{
						int ModelCache = CP.Common.ConfigHelper.GetConfigInt("ModelCache");
						CP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (CP.Campus.Model.LoginInfo)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CP.Campus.Model.LoginInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CP.Campus.Model.LoginInfo> DataTableToList(DataTable dt)
		{
			List<CP.Campus.Model.LoginInfo> modelList = new List<CP.Campus.Model.LoginInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CP.Campus.Model.LoginInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

