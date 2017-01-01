using CP.Campus.Model;
using CP.Campus.BLL;
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
    /// 社团活动申请信息表(ActivityApplicationInfo)接口
    /// </summary>
    [Authorize]
    public class ActivityApplicationInfoController : ApiController
    {
        ActivityApplicationInfo activityApplicationInfo = new ActivityApplicationInfo();
        ActivityApplicationInfo_BLL activityApplicationInfo_BLL = new ActivityApplicationInfo_BLL();
       
        //得到所有社团活动申请信息表信息数据列表
        /// <summary>
        /// 得到所有社团活动申请信息表信息数据列表
        /// </summary>
        /// <returns>返回数据类型为DataSet</returns>
        //   GET api/activityapplicationinfo 
        public DataSet Get()
        {
            return activityApplicationInfo_BLL.GetList("");
        }

        // GET api/activityapplicationinfo/cpId
        /// <summary>
        /// 根据社团(社联)编号cpId得到社团活动申请信息表(一个对象实体)
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>ActivityApplicationInfo对象实体</returns>
        public ActivityApplicationInfo Get(string cpId)
        {
            return activityApplicationInfo_BLL.GetModel(cpId);
        }

        // POST api/activityapplicationinfo
        /// <summary>
        /// 添加一条社团活动申请信息表信息
        /// </summary>
        /// <param name="addcpActivityInfoModel">cpActivityInfo对象实体</param>
        /// <returns>返回(1：表示添加成功,0:表示添加失败)</returns>
        public int Post([FromBody]ActivityApplicationInfo addLoginInfoModel)
        {
            if (activityApplicationInfo_BLL.Add(addLoginInfoModel))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //// PUT api/activityapplicationinfo/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // PUT api/activityapplicationinfo
        /// <summary>
        /// 根据输入一个ActivityApplicationInfo实体修改社团活动申请信息表信息(必须含cpId)
        /// </summary>
        /// <param name="updateLoginInfoModel"></param>
        /// <returns>返回(1：表示修改成功,0:表示修改失败)</returns>
        public int Put([FromBody]ActivityApplicationInfo updateLoginInfoModel)
        {
            if (activityApplicationInfo_BLL.Update(updateLoginInfoModel))
            {
                return 1;//update success
            }
            else
            {
                return 0;//update fail
            }
        }
        // DELETE api/activityapplicationinfo/5
        /// <summary>
        /// 根据cpId删除一条社团活动申请信息表对象实体
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>返回(1：表示删除成功,0:表示删除失败)</returns>
        public int Delete(string userId)
        {
            if (activityApplicationInfo_BLL.Delete(userId))
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
