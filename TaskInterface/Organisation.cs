using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskInterface
{
    /// <summary>
    /// 组织机构
    /// </summary>
    public class Organisation
    {
        /// <summary>
        /// ID：GUID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// FID：GUID
        /// </summary>
        public Guid FID { get; set; }
        /// <summary>
        /// 机构名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 中心名称
        /// </summary>
        public string CenterName { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public double lon { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public double lat { get; set; }

    }
}
