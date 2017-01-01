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
    [Authorize]
    public class UserLoginStateController : ApiController
    {
        UserLoginState_BLL userLoginState_BLL = new UserLoginState_BLL();
        UserLoginState userLoginState = new UserLoginState();



        // GET 得到一个UserLoginState对象实体
        /// <summary>
        /// 根据用户编号userId得到用户信息表(UserLoginState)信息(一个对象实体)
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>UserLoginState对象实体</returns>
        public UserLoginState Get(string userId)
        {
            return userLoginState_BLL.GetModel(userId);
        }
        // GET api/userloginstate
        /// <summary>
        /// 得到所有用户信息表(UserLoginState)信息数据列表
        /// </summary>
        /// <returns>返回数据类型为DataSet</returns>
        public DataSet Get()
        {
            return userLoginState_BLL.GetList("");
        }
        // POST api/userloginstate
        /// <summary>
        /// 添加一条用户信息表(UserLoginState)信息
        /// </summary>
        /// <param name="addUserLoginStateModel">UserLoginState对象实体</param>
        /// <returns>返回(1：表示添加成功,0:表示添加失败)</returns>
        public int Post([FromBody]UserLoginState addUserLoginStateModel)
        {
            if (userLoginState_BLL.Add(addUserLoginStateModel))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //// PUT api/userloginstate/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // PUT api/userloginstate
        /// <summary>
        /// 根据输入一个UserLoginState实体修改登录信息表(UserLoginState)信息(必须含userId)
        /// </summary>
        /// <param name="updateUserLoginStateModel"></param>
        /// <returns>返回(1：表示修改成功,0:表示修改失败)</returns>
        public int Put([FromBody]UserLoginState updateUserLoginStateModel)
        {
            if (userLoginState_BLL.Update(updateUserLoginStateModel))
            {
                return 1;//update success
            }
            else
            {
                return 0;//update fail
            }
        }
        // DELETE api/userloginstate/5
        /// <summary>
        /// 根据userId删除一条登录信息表(UserLoginState)对象实体
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>返回(1：表示删除成功,0:表示删除失败)</returns>
        public int Delete(string userId)
        {
            if (userLoginState_BLL.Delete(userId))
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
