using System;
using System.Data;
using System.Collections.Generic;
using CP.Common;
using CP.Campus.Model;
namespace CP.Campus.BLL
{
	/// <summary>
	/// UserInfo_BLL
	/// </summary>
	public partial class UserInfo_BLL
	{
		private readonly CP.Campus.DAL.UserInfo_DAL dal=new CP.Campus.DAL.UserInfo_DAL();
		public UserInfo_BLL()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string userId)
		{
			return dal.Exists(userId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CP.Campus.Model.UserInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CP.Campus.Model.UserInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string userId)
		{
			
			return dal.Delete(userId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string userIdlist )
		{
			return dal.DeleteList(CP.Common.PageValidate.SafeLongFilter(userIdlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CP.Campus.Model.UserInfo GetModel(string userId)
		{
			
			return dal.GetModel(userId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public CP.Campus.Model.UserInfo GetModelByCache(string userId)
		{
			
			string CacheKey = "UserInfoModel-" + userId;
			object objModel = CP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(userId);
					if (objModel != null)
					{
						int ModelCache = CP.Common.ConfigHelper.GetConfigInt("ModelCache");
						CP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (CP.Campus.Model.UserInfo)objModel;
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
		public List<CP.Campus.Model.UserInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CP.Campus.Model.UserInfo> DataTableToList(DataTable dt)
		{
			List<CP.Campus.Model.UserInfo> modelList = new List<CP.Campus.Model.UserInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CP.Campus.Model.UserInfo model;
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

