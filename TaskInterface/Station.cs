using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskInterface
{
    /// <summary>
    /// 站点基础信息
    /// </summary>
    public class Station
    {
        private Guid _id = Guid.NewGuid();
        /// <summary>
        /// ID：GUID
        /// </summary>
        public Guid ID
        {
            get
            {
                if (this._id == null)
                    throw new Exception("ID号不应为空！");
                return this._id;
            }
            set
            {
                if (value != null)
                    this._id = value;
            }
        }

        private string _num = string.Empty;
        /// <summary>
        /// 编号
        /// </summary>
        public string Num
        {
            get
            {
                return this._num;
            }
            set
            {
                if (value != null)
                    this._num = value;
            }
        }
        private string _name = string.Empty;
        /// <summary>
        /// 站点名
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (value != null)
                    this._name = value;
            }
        }
        private string _address = string.Empty;
        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                if (value != null)
                    this._address = value;
            }
        }
        private string _TEL = string.Empty;
        /// <summary>
        /// 电话
        /// </summary>
        public string TEL
        {
            get
            {
                return this._TEL;
            }
            set
            {
                if (value != null)
                    this._TEL = value;
            }
        }

        private string _fax = string.Empty;
        /// <summary>
        /// 传真
        /// </summary>
        public string Fax
        {
            get
            {
                return this._fax;
            }
            set
            {
                if (value != null)
                    this._fax = value;
            }
        }
        private string _description = string.Empty;
        /// <summary>
        /// 备注、标注
        /// </summary>
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                if (value != null)
                    this._description = value;
            }
        }
        private double _lon = 0.0;
        /// <summary>
        /// 经度
        /// </summary>
        public double lon
        {
            get
            {
                return this._lon;
            }
            set
            {
                // if (value!=null)
                this._lon = value;
            }
        }
        private double _lat = 0.0;
        /// <summary>
        /// 纬度
        /// </summary>
        public double lat
        {
            get
            {
                return this._lat;
            }
            set
            {
                //if (value != null)
                this._lat = value;
            }
        }
        private double _zoom = 0.0;
        /// <summary>
        /// 纬度
        /// </summary>
        public double Zoom
        {
            get
            {
                return this._zoom;
            }
            set
            {
                //if (value != null)
                this._zoom = value;
            }
        }
        private Guid _areaID = Guid.NewGuid();
        /// <summary>
        /// AreaID区域ID：GUID
        /// </summary>
        public Guid AreaID
        {
            get
            {
                if (this._areaID == null)
                    throw new Exception("AreaID号不应为空！");
                return this._areaID;
            }
            set
            {
                if (value != null)
                    this._areaID = value;
            }
        }
        private Guid _organisationID = Guid.NewGuid();
        /// <summary>
        /// OrganizationID机构ID：GUID
        /// </summary>
        public Guid OrganisationID
        {
            get
            {
                if (this._organisationID == null)
                    throw new Exception("OrganisationID号不应为空！");
                return this._organisationID;
            }
            set
            {
                if (value != null)
                    this._organisationID = value;
            }
        }

        private string _imageName = string.Empty;
        /// <summary>
        /// 图标信息
        /// </summary>
        public string ImageName
        {
            get
            {
                return this._imageName;
            }
            set
            {
                if (value != null)
                    this._imageName = value;
            }
        }
    }
}
