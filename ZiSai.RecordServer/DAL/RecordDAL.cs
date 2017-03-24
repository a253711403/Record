using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Security;
using ZiSai.RecordServer.Models;

namespace ZiSai.RecordServer.DAL
{
    public class RecordDAL
    {
        string luanma = "B9A2266A6F774026BD411F15B41B5AAF";//32
        public static RecordDAL dal { get; set; }
        private RecordEntities _db;
        public RecordEntities Db
        {
            set
            {
                _db = value;
            }
            get
            {
                if (_db == null)
                {
                    _db = new RecordEntities();
                }
                return _db;
            }
        }

        public static RecordDAL getDb()
        {
            if (dal == null)
            {
                dal = new DAL.RecordDAL();
            }
            return dal;
        }

        public string AddKeys(int count, string prefix, double days, string createSouse, DateTime effectiveDate)
        {
            string code = "0000";
            string msg = "调用成功";
            string info = "成功创建{0}条激活码";
            List<Record_key> list = new List<Record_key>();
            for (int i = 0; i < count; i++)
            {
                Record_key mod = new Models.Record_key();
                string g = Guid.NewGuid().ToString().Replace('-', new char()).ToUpper();
                mod.k_key = string.Format("{0}{1}", prefix, g.Substring(0, prefix.Length));
                mod.k_createDate = DateTime.Now;
                mod.k_createSource = createSouse;
                mod.k_days = days;
            }
            Db.Record_key.AddRange(list);
            Db.SaveChanges();
            var json = new
            {
                code = code,
                msg = msg,
                info = string.Format(info, list.Count)
            };

            return ToJsonByJsonConvert.ObjToJson(json);
        }

        public string ActivationMenber(string uid, string createSouse, double days)
        {
            string code = "0000";
            string msg = "调用成功";
            string info = "成功续费，到期时间{0}";

            Record_Memberinfo mod = Db.Record_Memberinfo.Where(m=>m.ME_NAME ==uid).First();
            mod.ME_Activation = createSouse;
            mod.ME_ENTTIME = DateTime.Now.AddDays(days);
            Db.SaveChanges();
            var json = new
            {
                code = code,
                msg = msg,
                info = string.Format(info,mod.ME_ENTTIME.Value.ToString("yyyy年MM月DD日 HH时mm分ss秒"))
            };

            return ToJsonByJsonConvert.ObjToJson(json);
        }

        public string UserLogin(string uid, string pwd)
        {
            string code = "0000";
            string msg = "调用成功";
            //
            var mod = Db.Record_Memberinfo.Where(m => m.ME_NAME == uid && m.ME_PWD == pwd).First();
            if (mod == null)
            {
                code = "1111";
                msg = "账号或者密码错误";
            }
            var json = new
            {
                code = code,
                msg = msg,
                info = mod
            };
            return ToJsonByJsonConvert.ObjToJson(json);
        }
        public string UserSignIn(string uid, string pwd)
        {
            string code = "0000";
            string msg = "调用成功";
            string info = "注册成功";

            Record_Memberinfo mod = new Models.Record_Memberinfo();
            mod.ME_NAME = uid;
            mod.ME_PWD =GetMD5(pwd);
            mod.ME_ADD_TIME = DateTime.Now;
            mod.ME_Activation = ClientIpAndPort();
            Db.Record_Memberinfo.Add(mod);
            Db.SaveChanges();
            var json = new
            {
                code = code,
                msg = msg,
                info = info
            };

            return ToJsonByJsonConvert.ObjToJson(json);
        }
        public static string GetMD5(string str)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5").ToUpper();
        }
        public string ClientIpAndPort()
        {
            OperationContext context = OperationContext.Current;
            MessageProperties properties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpoint = properties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            return endpoint.Address + ":" + endpoint.Port.ToString();
        }
    }
}