using CP.Campus.BLL;
using CP.Campus.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CpApi.Controllers
{
    /// <summary>
    /// 社团(社联)信息表(CpInfo)接口
    /// </summary>
   [Authorize]
    public class CpInfoController : ApiController
    {
        CpInfo cpInfo = new CpInfo();
        CpInfo_BLL cpInfo_BLL = new CpInfo_BLL();
        // GET api/cpinfo
        /// <summary>
        /// 得到所有社团(社联)信息表信息数据列表
        /// </summary>
        /// <returns>返回数据类型为DataSet</returns>
        public DataSet Get()
        {
            return cpInfo_BLL.GetList("");
        }

        
        /// <summary>
        /// 根据社团(社联)编号cpId得到社团(社联)信息表(一个对象实体)
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>CpInfo对象实体</returns>
        public CpInfo Get(string cpId)
        {
            return cpInfo_BLL.GetModel(cpId);
        }

        // POST api/cpinfo
        /// <summary>
        /// 添加一条社团(社联)信息表信息
        /// </summary>
        /// <param name="addCpInfoModel">CpInfo对象实体</param>
        /// <returns>返回(1：表示添加成功,0:表示添加失败)</returns>
        public int Post([FromBody]CpInfo addCpInfoModel)
        {
            if (cpInfo_BLL.Add(addCpInfoModel))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //// PUT api/cpinfo/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        /// <summary>
        /// 根据输入一个CpInfo实体修改社团(社联)信息表信息(必须含cpId)
        /// </summary>
        /// <param name="updateCpInfoModel">CpInfo</param>
        /// <returns>返回(1：表示修改成功,0:表示修改失败)</returns>
        public int Put([FromBody]CpInfo updateCpInfoModel)
        {
            if (cpInfo_BLL.Update(updateCpInfoModel))
            {
                return 1;//update success
            }
            else
            {
                return 0;//update fail
            }
        }
        // DELETE api/cpinfo/5
        /// <summary>
        /// 根据cpId删除一条社团(社联)信息表对象实体
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>返回(1：表示删除成功,0:表示删除失败)</returns>
        public int Delete(string cpId)
        {
            if (cpInfo_BLL.Delete(cpId))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
