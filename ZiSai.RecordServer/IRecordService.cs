using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ZiSai.RecordServer
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IRecordService”。
    [ServiceContract]
    public interface IRecordService
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="uid">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        [OperationContract]
        string UserLogin(string uid, string pwd);
        [OperationContract]
        string SignIn(string uid, string pwd);
        /// <summary>
        /// 添加激活码
        /// </summary>
        /// <param name="count">数量</param>
        /// <param name="prefix">前缀</param>
        /// <param name="days">激活天数</param>
        /// <param name="createSouse">创建来源</param>
        /// <param name="effectiveDate">过期时间</param>
        /// <returns></returns>
        [OperationContract]
        string AddKeys(int count, string prefix, double days, string createSouse, DateTime effectiveDate);
        /// <summary>
        /// 开通会员
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="createSouse">激活方式</param>
        /// <param name="days">天数</param>
        /// <returns></returns>
        [OperationContract]
        string ActivationMenber(string uid, string createSouse, double days);
    }
}
