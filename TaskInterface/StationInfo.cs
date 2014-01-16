using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskInterface
{
    /// <summary>
    /// 站点详细信息
    /// </summary>
    public class StationInfo
    {
        /// <summary>
        /// ID：Guid
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// FID：Guid
        /// </summary>
        public Guid FID { get; set; }
        /// <summary>
        /// 责任人
        /// </summary>
        public string Principal { get; set; }
        /// <summary>
        /// 责任人电话
        /// </summary>
        public string PrincipalTEL { get; set; }
        /// <summary>
        /// 设置级别：例如鲤城、丰泽、洛江
        /// </summary>
        public string SetLevel { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// 经营模式
        /// </summary>
        public string BusinessModel { get; set; }
        /// <summary>
        /// 业务范围
        /// </summary>
        public string BusinessScope { get; set; }
        /// <summary>
        /// 营业时间（开始）
        /// </summary>
        public string OpeningHoursBegin { get; set; }
        /// <summary>
        /// 营业时间（结束）
        /// </summary>
        public string OpeningHoursEnd { get; set; }
    }
}
