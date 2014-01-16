using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
namespace Eulei.Web.Serialization
{
    public class JsonHelper
    {
        /// <summary>
        /// 类对像转换成json格式
        /// </summary> 
        /// <param name="t">T类型</param>
        /// <returns>json数据字符串</returns>


        public static string ToJson(object t)
        {
            return new JavaScriptSerializer().Serialize(t);
        }

        /// <summary>
        /// json格式转换
        /// </summary>
        /// <typeparam name="T">T类型</typeparam>
        /// <param name="strJson">json数据字符串</param>
        /// <returns>T对象</returns>
        public static T FromJson<T>(string strJson) where T : class
        {
            return new JavaScriptSerializer().Deserialize<T>(strJson);
        }
    }
}
