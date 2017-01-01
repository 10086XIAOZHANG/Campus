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
    /// 用户信息表(UserInfo)接口
    /// </summary>
    [Authorize]
    public class UserInfoController : ApiController
    {
        UserInfo_BLL userinfo_BLL = new UserInfo_BLL();
        UserInfo userinfo = new UserInfo();
       
       

        // GET 得到一个UserInfo对象实体
        /// <summary>
        /// 根据用户编号userId得到用户信息表(UserInfo)信息(一个对象实体)
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>UserInfo对象实体</returns>
        public UserInfo Get(string userId)
        {
            return userinfo_BLL.GetModel(userId);
        }
        // GET api/userinfo
        /// <summary>
        /// 得到所有用户信息表(UserInfo)信息数据列表
        /// </summary>
        /// <returns>返回数据类型为DataSet</returns>
        public DataSet Get()
        {
            return userinfo_BLL.GetList("");
        }
        // POST api/userinfo
        /// <summary>
        /// 添加一条用户信息表(UserInfo)信息
        /// </summary>
        /// <param name="addUserinfoModel">UserInfo对象实体</param>
        /// <returns>返回(1：表示添加成功,0:表示添加失败)</returns>
        public int Post([FromBody]UserInfo addUserinfoModel)
        {
            if(userinfo_BLL.Add(addUserinfoModel))
            {
                return 1;
            }else
            {
                return 0;
            }
        }

        //// PUT api/userinfo/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // PUT api/userinfo
        /// <summary>
        /// 根据输入一个UserInfo实体修改登录信息表(UserInfo)信息(必须含userId)
        /// </summary>
        /// <param name="updateUserinfoModel"></param>
        /// <returns>返回(1：表示修改成功,0:表示修改失败)</returns>
        public int Put([FromBody]UserInfo updateUserinfoModel)
        {
            if (userinfo_BLL.Update(updateUserinfoModel))
            {
                return 1;//update success
            }
            else {
                return 0;//update fail
            }
        }
        // DELETE api/userinfo/5
        /// <summary>
        /// 根据userId删除一条登录信息表(UserInfo)对象实体
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>返回(1：表示删除成功,0:表示删除失败)</returns>
        public int Delete(string userId)
        {
            if (userinfo_BLL.Delete(userId))
            {
                return 1;
            }
            else {
                return 0;
            }
        }
    }
}
