using System;
using System.Data;
using System.Collections.Generic;
using CP.Common;
using CP.Campus.Model;
namespace CP.Campus.BLL
{
	/// <summary>
	/// SignUpInfo_BLL
	/// </summary>
	public partial class SignUpInfo_BLL
	{
		private readonly CP.Campus.DAL.SignUpInfo_DAL dal=new CP.Campus.DAL.SignUpInfo_DAL();
		public SignUpInfo_BLL()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string newSubmitId)
		{
			return dal.Exists(newSubmitId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CP.Campus.Model.SignUpInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CP.Campus.Model.SignUpInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string newSubmitId)
		{
			
			return dal.Delete(newSubmitId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string newSubmitIdlist )
		{
			return dal.DeleteList(CP.Common.PageValidate.SafeLongFilter(newSubmitIdlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CP.Campus.Model.SignUpInfo GetModel(string newSubmitId)
		{
			
			return dal.GetModel(newSubmitId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public CP.Campus.Model.SignUpInfo GetModelByCache(string newSubmitId)
		{
			
			string CacheKey = "SignUpInfoModel-" + newSubmitId;
			object objModel = CP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(newSubmitId);
					if (objModel != null)
					{
						int ModelCache = CP.Common.ConfigHelper.GetConfigInt("ModelCache");
						CP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (CP.Campus.Model.SignUpInfo)objModel;
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
		public List<CP.Campus.Model.SignUpInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CP.Campus.Model.SignUpInfo> DataTableToList(DataTable dt)
		{
			List<CP.Campus.Model.SignUpInfo> modelList = new List<CP.Campus.Model.SignUpInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CP.Campus.Model.SignUpInfo model;
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

