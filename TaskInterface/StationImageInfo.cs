using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskInterface
{
    /// <summary>
    /// 站点图片信息
    /// </summary>
    public class StationImageInfo
    {
        /// <summary>
        /// ID:gudi
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 站点ID
        /// </summary>
        public Guid PID { get; set; }
        /// <summary>
        /// 图片标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 图片描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string ImagePath { get; set; }
    }
}
