using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ZiSai.RecordServer.DAL;

namespace ZiSai.RecordServer
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“RecordService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 RecordService.svc 或 RecordService.svc.cs，然后开始调试。
    public class RecordService : IRecordService
    {
        RecordDAL dal = RecordDAL.getDb();
        public string AddKeys(int count, string prefix, double days, string createSouse, DateTime effectiveDate)
        {
            return dal.AddKeys(count, prefix, days, createSouse, effectiveDate);
        }

        public string UserLogin(string uid, string pwd)
        {
            return dal.UserLogin(uid, pwd);
        }
        public string ActivationMenber(string uid, string createSouse, double days)
        {
            return dal.ActivationMenber(uid, createSouse, days);
        }

        public string SignIn(string uid, string pwd)
        {
            return dal.UserSignIn(uid,pwd);
        }
    }
}
