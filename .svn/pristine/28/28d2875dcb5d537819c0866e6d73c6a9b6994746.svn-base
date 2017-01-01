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
    /// 社团(社联)用户登录信息表(cpLoginInfo)接口
    /// </summary>
    [Authorize]
    public class cpLoginInfoController : ApiController
    {
        cpLoginInfo cploginInfo = new cpLoginInfo();
        cpLoginInfo_BLL cplogininfo_BLL = new cpLoginInfo_BLL();
        // GET api/cplogininfo
        /// <summary>
        /// 得到所有社团(社联)用户登录信息表(cpLoginInfo)信息数据列表
        /// </summary>
        /// <returns>返回数据类型为DataSet</returns>
        public DataSet Get()
        {
            return cplogininfo_BLL.GetList("");
        }

        // GET api/cplogininfo/userId
        /// <summary>
        /// 根据用户编号cpId得到社团(社联)用户登录信息表(cpLoginInfo)信息(一个对象实体)
        /// </summary>
        /// <param name="cpId">用户编号</param>
        /// <returns>LoginInfo对象实体</returns>
        public cpLoginInfo Get(string cpId)
        {
            return cplogininfo_BLL.GetModel(cpId);
        }

        // POST api/cplogininfo
        /// <summary>
        /// 添加一条社团(社联)用户登录信息表(cpLoginInfo)信息
        /// </summary>
        /// <param name="addcpLoginInfoModel">cpLoginInfo对象实体</param>
        /// <returns>返回(1：表示添加成功,0:表示添加失败)</returns>
        public int Post([FromBody]cpLoginInfo addcpLoginInfoModel)
        {
            if (cplogininfo_BLL.Add(addcpLoginInfoModel))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //// PUT api/cplogininfo/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // PUT api/cplogininfo
        /// <summary>
        /// 根据输入一个cpLoginInfo实体修改社团(社联)用户登录信息表(cpLoginInfo)信息(必须含cpId)
        /// </summary>
        /// <param name="updatecpLoginInfoModel"></param>
        /// <returns>返回(1：表示修改成功,0:表示修改失败)</returns>
        public int Put([FromBody]cpLoginInfo updatecpLoginInfoModel)
        {
            if (cplogininfo_BLL.Update(updatecpLoginInfoModel))
            {
                return 1;//update success
            }
            else
            {
                return 0;//update fail
            }
        }
        // DELETE api/cplogininfo/5
        /// <summary>
        /// 根据userId删除一条社团(社联)用户登录信息表(cpLoginInfo)对象实体
        /// </summary>
        /// <param name="cpId">用户编号</param>
        /// <returns>返回(1：表示删除成功,0:表示删除失败)</returns>
        public int Delete(string cpId)
        {
            if (cplogininfo_BLL.Delete(cpId))
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
