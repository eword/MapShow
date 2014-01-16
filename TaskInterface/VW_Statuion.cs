using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskInterface
{
    public class VW_Statuion : Station
    {
        private Guid _stationInfoID = Guid.NewGuid();
        /// <summary>
        /// ID：Guid
        /// </summary>
        public Guid StationInfoID
        {
            get
            {
                return this._stationInfoID;
            }
            set
            {
                if (value != null)
                    this._stationInfoID = value;
            }
        }
        private Guid _stationInfoFID = Guid.NewGuid();
        /// <summary>
        /// ID：Guid
        /// </summary>
        public Guid StationInfoFID
        {
            get
            {
                return this._stationInfoFID;
            }
            set
            {
                if (value != null)
                    this._stationInfoFID = value;
            }
        }
        /// <summary>
        /// 责任人
        /// </summary>
        public string StationInfoPrincipal { get; set; }
        /// <summary>
        /// 责任人电话
        /// </summary>
        public string StationInfoPrincipalTEL { get; set; }
        /// <summary>
        /// 设置级别：例如鲤城、丰泽、洛江
        /// </summary>
        public string StationInfoSetLevel { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string StationInfoPostalCode { get; set; }
        /// <summary>
        /// 经营模式
        /// </summary>
        public string StationInfoBusinessModel { get; set; }
        /// <summary>
        /// 业务范围
        /// </summary>
        public string StationInfoBusinessScope { get; set; }
        /// <summary>
        /// 营业时间（开始）
        /// </summary>
        public string StationInfoOpeningHoursBegin { get; set; }
        /// <summary>
        /// 营业时间（结束）
        /// </summary>
        public string StationInfoOpeningHoursEnd { get; set; }
        private Guid _organisationFID = Guid.NewGuid();
        /// <summary>
        /// FID：GUID
        /// </summary>
        public Guid OrganisationFID
        {
            get
            {
                return this._organisationFID;
            }
            set
            {
                if (value != null)
                    this._organisationFID = value;
            }
        }
        /// <summary>
        /// 机构名
        /// </summary>
        public string OrganisationName { get; set; }
        /// <summary>
        /// 中心名称
        /// </summary>
        public string OrganisationCenterName { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public double Organisationlon { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public double Organisationlat { get; set; }
        ///// <summary>
        ///// ID:Guid
        ///// </summary>
        //public Guid AreaInfoFID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string AreaInfoName { get; set; }

        private double _areaInfolon = 0.0;
        /// <summary>
        /// 经度
        /// </summary>
        public double AreaInfolon
        {
            get
            {
                return this._areaInfolon;
            }
            set
            {
                //if (value != null)
                    this._areaInfolon = value;
            }
        }

        private double _areaInfolat = 0.0;
        /// <summary>
        /// 纬度
        /// </summary>
        public double AreaInfolat
        {
            get
            {
                return this._areaInfolat;
            }
            set
            {
                //if (value != null)
                    this._areaInfolat = value;
            }
        }

        /// <summary>
        /// 邮编
        /// </summary>
        public string AreaInfoPostalCode { get; set; }
        /// <summary>
        /// 简码
        /// </summary>
        public string AreaInfoEasyCode { get; set; }
    }
}
