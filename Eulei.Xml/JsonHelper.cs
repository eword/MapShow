using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
namespace Eulei.Serialization
{
    public class JSONHelper
    {
        /// <summary>
        /// 类对像转换成json格式
        /// </summary> 
        /// <param name="T">T类型</param>
        /// <returns>json数据字符串</returns>
        public static string ToJson<T>(T objectToSerialize)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(objectToSerialize.GetType());
                serializer.WriteObject(ms, objectToSerialize);
                ms.Position = 0;
                using (StreamReader reader = new StreamReader(ms))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        /// <summary>
        /// json格式转换
        /// </summary>
        /// <typeparam name="T">T类型</typeparam>
        /// <param name="strJson">json数据字符串</param>
        /// <returns>T对象</returns>
        public static T FromJson<T>(string SerializeToObject)
        {
            T _return;
            DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(T));

            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(SerializeToObject)))
            {
                _return = (T)ds.ReadObject(ms);
            }

            return _return;
        }

    }
}
