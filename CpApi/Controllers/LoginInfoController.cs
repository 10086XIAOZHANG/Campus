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
    /// 登录信息表(LoginInfo)接口
    /// </summary>
    [RoutePrefix("api/LoginInfo")] 
    [Authorize]
    public class LoginInfoController : ApiController
    {
        LoginInfo logininfo = new LoginInfo();
        LoginInfo_BLL logininfo_BLL = new LoginInfo_BLL();
       

        /// <summary>
        /// 根据用户编号userId得到登录信息表(LoginInfo)信息(一个对象实体)
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>LoginInfo对象实体</returns>
        public LoginInfo Get(string userId)
        {
            return logininfo_BLL.GetModel(userId);
        }
        // GET api/logininfo
        /// <summary>
        /// 得到所有登录信息表(LoginInfo)信息数据列表
        /// </summary>
        /// <returns>返回数据类型为DataSet</returns>
        public DataSet Get()
        {
            return logininfo_BLL.GetList("");
        }
        // POST api/logininfo
        /// <summary>
        /// 添加一条登录信息表(LoginInfo)信息
        /// </summary>
        /// <param name="addLoginInfoModel">LoginInfo对象实体</param>
        /// <returns>返回(1：表示添加成功,0:表示添加失败)</returns>
        public int Post([FromBody]LoginInfo addLoginInfoModel)
        {
            if (logininfo_BLL.Add(addLoginInfoModel))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        // PUT api/logininfo
        /// <summary>
        /// 根据输入一个LoginInfo实体修改登录信息表(LoginInfo)信息(必须含userId)
        /// </summary>
        /// <param name="updateLoginInfoModel"></param>
        /// <returns>返回(1：表示修改成功,0:表示修改失败)</returns>
        public int Put([FromBody]LoginInfo updateLoginInfoModel)
        {
            if (logininfo_BLL.Update(updateLoginInfoModel))
            {
                return 1;//update success
            }
            else
            {
                return 0;//update fail
            }
        }
        // DELETE api/logininfo/5
        /// <summary>
        /// 根据userId删除一条登录信息表(LoginInfo)对象实体
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>返回(1：表示删除成功,0:表示删除失败)</returns>
        public int Delete(string userId)
        {
            if (logininfo_BLL.Delete(userId))
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
