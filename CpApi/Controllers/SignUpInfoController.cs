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
    /// 报名表(SignUpInfo)接口
    /// </summary>
    [Authorize]
    public class SignUpInfoController : ApiController
    {
        private readonly SignUpInfo signUpInfo = new SignUpInfo();
        private readonly SignUpInfo_BLL signUpInfo_BLL = new SignUpInfo_BLL();
        // GET api/signupinfo
        /// <summary>
        /// 得到所有报名表信息数据列表
        /// </summary>
        /// <returns>返回数据类型为DataSet</returns>
        public DataSet Get()
        {
            return signUpInfo_BLL.GetList("");
        }

        // GET 得到一个signupinfo对象实体
        /// <summary>
        /// 根据社团(社联)编号cpId得到报名活动信息(一个对象实体)
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>SignUpInfo对象实体</returns>
        public SignUpInfo Get(string cpId)
        {
            return signUpInfo_BLL.GetModel(cpId);
        }

        // POST api/signupinfo
        /// <summary>
        /// 添加一条报名表信息
        /// </summary>
        /// <param name="addSignUpInfomodel">SignUpInfo对象实体</param>
        /// <returns>返回(1：表示添加成功,0:表示添加失败)</returns>
        public int Post([FromBody]SignUpInfo addSignUpInfomodel)
        {
            if (signUpInfo_BLL.Add(addSignUpInfomodel))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //// PUT api/signupinfo/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // PUT api/signupinfo
        /// <summary>
        /// 根据输入一个SignUpInfo实体修改报名表信息(必须含newSubmitId)
        /// </summary>
        /// <param name="updateSignUpInfoModel"></param>
        /// <returns>返回(1：表示修改成功,0:表示修改失败)</returns>
        public int Put([FromBody]SignUpInfo updateSignUpInfoModel)
        {
            if (signUpInfo_BLL.Update(updateSignUpInfoModel))
            {
                return 1;//update success
            }
            else
            {
                return 0;//update fail
            }
        }
        // DELETE api/signupinfo/5
        /// <summary>
        /// 根据cpId删除一条报名表对象实体
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>返回(1：表示删除成功,0:表示删除失败)</returns>
        public int Delete(string cpId)
        {
            if (signUpInfo_BLL.Delete(cpId))
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
