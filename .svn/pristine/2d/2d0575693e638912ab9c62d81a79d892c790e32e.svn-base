using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CP.Campus.BLL
{
    /// <summary>
    /// UserLoginState_BLL
    /// </summary>
    public partial class UserLoginState_BLL
    {
        private readonly CP.Campus.DAL.UserLoginState_DAL dal = new CP.Campus.DAL.UserLoginState_DAL();
        public UserLoginState_BLL()
        { }
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
        public bool Add(CP.Campus.Model.UserLoginState model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CP.Campus.Model.UserLoginState model)
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
        /// 得到一个对象实体
        /// </summary>
        public CP.Campus.Model.UserLoginState GetModel(string userId)
        {
            return dal.GetModel(userId);
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<CP.Campus.Model.UserLoginState> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<CP.Campus.Model.UserLoginState> DataTableToList(DataTable dt)
        {
            List<CP.Campus.Model.UserLoginState> modelList = new List<CP.Campus.Model.UserLoginState>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                CP.Campus.Model.UserLoginState model;
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
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
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
