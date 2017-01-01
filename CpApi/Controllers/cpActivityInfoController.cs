using CP.Campus.BLL;
using CP.Campus.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace CpApi.Controllers
{
    /// <summary>
    /// 社团活动表(cpActivityInfo)接口
    /// </summary>
    [Authorize]
    public class cpActivityInfoController : ApiController
    {
        cpActivityInfo cpactivityInfo = new cpActivityInfo();
        cpActivityInfo_BLL cpactivityInfo_BLL = new cpActivityInfo_BLL();
        // GET api/cpactivityinfo
        /// <summary>
        /// 得到所有社团活动表信息数据列表
        /// </summary>
        /// <returns>返回数据类型为DataSet</returns>
        public DataSet Get()
        {
            return cpactivityInfo_BLL.GetList("");
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        /// <returns>记录总数</returns>
        public int GETRecordCount()
        {
            return cpactivityInfo_BLL.GetRecordCount("");
        }
        // GET 得到一个cpActivityInfo对象实体
        /// <summary>
        /// 根据社团(社联)编号cpId得到社团活动信息(一个对象实体)
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>cpActivityInfo对象实体</returns>
        public cpActivityInfo Get(string cpId)
        {
            return cpactivityInfo_BLL.GetModel(cpId);
        }
        public IList<cpActivityInfo> GetPageList(int pageIndex,int pageSize) 
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;
            return DataSetToList<cpActivityInfo>(cpactivityInfo_BLL.GetListByPage("", "cpId", start, end),0);//遍历ds的表
        }
       
        /// <summary>
        /// DataSetToList
        /// </summary>
        /// <typeparam name="T">转换类型</typeparam>
        /// <param name="ds">一个DataSet实例，也就是数据源</param>
        /// <param name="tableIndext">DataSet容器里table的下标，只有用于取得哪个table，也就是需要转换表的索引</param>
        /// <returns></returns>
        public IList<T> DataSetToList<T>(DataSet ds, int tableIndext)
        {
            //确认参数有效
            if (ds == null || ds.Tables.Count <= 0 || tableIndext < 0)
            {
                return null;
            }
            DataTable dt = ds.Tables[tableIndext]; //取得DataSet里的一个表dt

            IList<T> list = new List<T>(); //实例化一个list

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建泛型对象。为什么这里要创建一个泛型对象呢？是因为目前我不确定泛型的类型。
                T t = Activator.CreateInstance<T>();
                //或者写成这样，同样也是创建一个发泛型对象。
                //t = default(T);

                //获取t对象类型的所有公有属性
                PropertyInfo[] tMembersAll = t.GetType().GetProperties();


                for (int j = 0; j < dt.Columns.Count; j++)  // 1 2 3
                {
                    //遍历tMembersAll
                    foreach (PropertyInfo tMember in tMembersAll)
                    {
                        //取dt表中j列的名字，并把名字转换成大写的字母。整条代码的意思是：如果列名和属性名称相同时赋值
                        if (dt.Columns[j].ColumnName.ToUpper().Equals(tMember.Name.ToUpper()))
                        {
                            //dt.Rows[i][j]表示取dt表里的第i行的第j列；DBNull是指数据库中当一个字段没有被设置值的时候的值，相当于数据库中的“空值”。 
                            if (dt.Rows[i][j] != DBNull.Value)
                            {
                                //SetValue是指：将指定属性设置为指定值。 tMember是T泛型对象t的一个公有成员，整条代码的意思就是：将dt.Rows[i][j]赋值给t对象的tMember成员,参数详情请参照http://msdn.microsoft.com/zh-cn/library/3z2t396t(v=vs.100).aspx/html

                                tMember.SetValue(t, dt.Rows[i][j], null);


                            }
                            else
                            {
                                tMember.SetValue(t, null, null);
                            }
                            break;//注意这里的break是写在if语句里面的，意思就是说如果列名和属性名称相同并且已经赋值了，那么我就跳出foreach循环，进行j+1的下次循环
                        }
                    }
                }

                list.Add(t);
            }
            return list;

        }
        // POST api/cpactivityinfo
        /// <summary>
        /// 添加一条社团活动表信息
        /// </summary>
        /// <param name="addcpActivityInfoModel">cpActivityInfo对象实体</param>
        /// <returns>返回(1：表示添加成功,0:表示添加失败)</returns>
        public int Post([FromBody]cpActivityInfo addcpActivityInfoModel)
        {
            if (cpactivityInfo_BLL.Add(addcpActivityInfoModel))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //// PUT api/userinfo/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // PUT api/cpactivityinfo
        /// <summary>
        /// 根据输入一个cpActivityInfo实体修改社团活动表信息(必须含cpId)
        /// </summary>
        /// <param name="updatecpActivityInfoModel"></param>
        /// <returns>返回(1：表示修改成功,0:表示修改失败)</returns>
        public int Put([FromBody]cpActivityInfo updatecpActivityInfoModel)
        {
            if (cpactivityInfo_BLL.Update(updatecpActivityInfoModel))
            {
                return 1;//update success
            }
            else
            {
                return 0;//update fail
            }
        }
        // DELETE api/cpactivityinfo/5
        /// <summary>
        /// 根据cpId删除一条社团活动表对象实体
        /// </summary>
        /// <param name="cpId">社团(社联)编号</param>
        /// <returns>返回(1：表示删除成功,0:表示删除失败)</returns>
        public int Delete(string cpId)
        {
            if (cpactivityInfo_BLL.Delete(cpId))
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
