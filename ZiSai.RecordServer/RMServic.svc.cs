using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ZiSai.RecordServer
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“RECORD_MEMBERINFO”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 RECORD_MEMBERINFO.svc 或 RECORD_MEMBERINFO.svc.cs，然后开始调试。
    public class RecordMember : IRecordMember
    {
        string luanma = "B9A2266A6F774026BD411F15B41B5AAF";

        public string UserLogin(string timestamp, string sign, string uid, string pwd)
        {
            throw new NotImplementedException();
        }
    }
}
