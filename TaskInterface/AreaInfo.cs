using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskInterface
{
    /// <summary>
    /// 区域信息
    /// </summary>
    public class AreaInfo
    {
        /// <summary>
        /// ID:Guid
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public double lon { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public double lat { get; set; }
        double _zoom = 1;
        /// <summary>
        /// 地图缩放倍率
        /// </summary>
        public double Zoom
        {
            set
            {
                if (value != null)
                    this._zoom = value;
            }
            get
            {
                return _zoom;
            }
        }
        /// <summary>
        /// 邮编
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// 简码
        /// </summary>
        public string EasyCode { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        public int Order { get; set; }
    }
}
