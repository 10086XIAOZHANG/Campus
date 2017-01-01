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
    /// 社团(社联)部门表(CpDeptInfo)接口
    /// </summary>
    [Authorize]
    public class CpDeptInfoController : ApiController
    {
        CpDeptInfo cpdeptInfo = new CpDeptInfo();
        CpDeptInfo_BLL cpDeptInfo_BLL = new CpDeptInfo_BLL();
        // GET api/CpdeptInfo
        /// <summary>
        /// 得到所有社团(社联)部门表信息数据列表
        /// </summary>
        /// <returns>返回数据类型为DataSet</returns>
        public DataSet Get()
        {
            return cpDeptInfo_BLL.GetList("");
        }

        // GET 得到一个CpDeptInfo对象实体
       
        /// <summary>
        /// 根据社团(社联)编号cpId得到社团(社联)部门表信息(一个对象实体)
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>CpDeptInfo对象实体</returns>
        public CpDeptInfo Get(string cpId)
        {
            return cpDeptInfo_BLL.GetModel(cpId);
        }

        // POST api/CpdeptInfo
        /// <summary>
        /// 添加一条社团(社联)部门表信息
        /// </summary>
        /// <param name="addCpDeptInfoModel">CpDeptInfo对象实体</param>
        /// <returns>返回(1：表示添加成功,0:表示添加失败)</returns>
        public int Post([FromBody]CpDeptInfo addCpDeptInfoModel)
        {
            if (cpDeptInfo_BLL.Add(addCpDeptInfoModel))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //// PUT api/CpdeptInfo/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // PUT api/CpdeptInfo
        /// <summary>
        /// 根据输入一个CpDeptInfo实体修改社团(社联)部门表信息(必须含cpId)
        /// </summary>
        /// <param name="updateCpDeptInfoModel"></param>
        /// <returns>返回(1：表示修改成功,0:表示修改失败)</returns>
        public int Put([FromBody]CpDeptInfo updateCpDeptInfoModel)
        {
            if (cpDeptInfo_BLL.Update(updateCpDeptInfoModel))
            {
                return 1;//update success
            }
            else
            {
                return 0;//update fail
            }
        }
        // DELETE api/CpdeptInfo/5
        /// <summary>
        /// 根据cpId删除一条社团(社联)部门表对象实体
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>返回(1：表示删除成功,0:表示删除失败)</returns>
        public int Delete(string cpId)
        {
            if (cpDeptInfo_BLL.Delete(cpId))
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
