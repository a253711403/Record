using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.ComponentModel;

namespace ZiSai.RecordServer
{
    public class ToJsonByJsonConvert
    {

        /// <summary>
        /// 实体转换成Json 可以传List 
        /// </summary>
        /// <typeparam name="T">类</typeparam>
        /// <param name="data">实体对象</param>
        /// <returns></returns>
        public static string ObjToJson<T>(T data)
        {
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                //防止循环应用,设置忽略(如Linq自动生成的实体类,需要设置序列化模式为单向)
                settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                //格式化日期输出,变为常用的日期形式,方便前台处理
                settings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                settings.DateFormatString = "yyyy'-'MM'-'dd' 'HH':'mm':'ss";
                return JsonConvert.SerializeObject(data, Formatting.Indented, settings);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// DataTable转换成Json
        /// </summary>
        /// <param name="dt">DataTable对象</param>
        /// <returns></returns>
        public static string DataTableToJson(DataTable dt)
        {
            try
            {
                //格式化日期输出,变为常用的日期形式,方便前台处理
                IsoDateTimeConverter timeConverter = new IsoDateTimeConverter();
                timeConverter.DateTimeFormat = "yyyy'-'MM'-'dd' 'HH':'mm':'ss";
                return JsonConvert.SerializeObject(dt, Newtonsoft.Json.Formatting.Indented, timeConverter, new DataTableConverter());
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 字符串转换成实体对象
        /// </summary>
        /// <typeparam name="T">类</typeparam>
        /// <param name="jsonStr">Json字符串</param>
        /// <returns></returns>
        public static T JsonToObj<T>(string jsonStr)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(jsonStr);

            }
            catch (Exception)
            {

                return default(T);
            }
        }

        public static Dictionary<string, object> JsonToDictionary(string jsonStr)
        {
            try
            {
                return JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonStr);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static List<Dictionary<string, object>> JsonToDictionaryList(string jsonStr)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonStr);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static Dictionary<string, object> ModelToDictionary<T>(T data)
        {
            var _dictionary = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(data))
            {
                object obj2 = descriptor.GetValue(data);
                _dictionary.Add(descriptor.Name, obj2);
            }
            return _dictionary;
        }


    }
}
