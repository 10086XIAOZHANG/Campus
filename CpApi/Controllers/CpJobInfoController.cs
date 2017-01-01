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
    /// 社团(社联)职务表(CpJobInfo)接口
    /// </summary>
    [Authorize]
    public class CpJobInfoController : ApiController
    {
       
        CpJobInfo cpJobInfo = new CpJobInfo();
        CpJobInfo_BLL cpJobInfo_BLL = new CpJobInfo_BLL();
        // GET api/cpjobinfo
        /// <summary>
        /// 得到所有社团(社联)职务表信息数据列表
        /// </summary>
        /// <returns>返回数据类型为DataSet</returns>
        public DataSet Get()
        {
            return cpJobInfo_BLL.GetList("");
        }

        // GET 得到一个cpjobinfo对象实体
        /// <summary>
        /// 根据社团(社联)编号cpId得到社团(社联)职务表信息(一个对象实体)
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>CpJobInfo对象实体</returns>
        public CpJobInfo Get(string cpId)
        {
            return cpJobInfo_BLL.GetModel(cpId);
        }

        // POST api/cpjobinfo
        /// <summary>
        /// 添加一条社团(社联)职务表信息
        /// </summary>
        /// <param name="addcpJobInfoModel">CpJobInfo对象实体</param>
        /// <returns>返回(1：表示添加成功,0:表示添加失败)</returns>
        public int Post([FromBody]CpJobInfo addcpJobInfoModel)
        {
            if (cpJobInfo_BLL.Add(addcpJobInfoModel))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //// PUT api/cpjobinfo/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //PUT api/cpjobinfo
        /// <summary>
        /// 修改一条社团职务表信息
        /// </summary>
        /// <param name="updatecpJobInfoModel">CpJobInfo对象实体</param>
        /// <returns>返回(1：表示添加成功,0:表示添加失败)</returns>
        public int Put([FromBody]CpJobInfo updatecpJobInfoModel)
        {
            if (cpJobInfo_BLL.Update(updatecpJobInfoModel))
            {
                return 1;//update success
            }
            else
            {
                return 0;//update fail
            }
        }
        // DELETE api/cpjobinfo/5
        /// <summary>
        /// 根据cpId删除一条社团(社联)职务表对象实体
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>返回(1：表示删除成功,0:表示删除失败)</returns>
        public int Delete(string cpId)
        {
            if (cpJobInfo_BLL.Delete(cpId))
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
