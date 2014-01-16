using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using TaskInterface;
using DBTask.DB.StationDataSetTableAdapters;
using DBTask.DB;
using System.Data;
using Eulei.Linq;
namespace DBTask
{
    [Export(typeof(IStation))]
    [Export(typeof(IConfig))]
    public class Task : IStation, IConfig
    {
        #region Station
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="id">站点ID</param>
        /// <returns>站点信息</returns>
        public VW_Statuion GetVW_Station(Guid id)
        {
            VW_Statuion _listItem = new VW_Statuion();
            using (VW_baseStationTableAdapter _myTA = new VW_baseStationTableAdapter())
            {
                var item = _myTA.GetData().Where(m => m.StationID.Equals(id)).First();
                _listItem.ID = item.StationID;
                if (!item.IsStationNumNull())
                    _listItem.Num = item.StationNum;
                if (!item.IsStationNameNull())
                    _listItem.Name = item.StationName;
                if (!item.IsStationAddressNull())
                    _listItem.Address = item.StationAddress;
                if (!item.IsStationTELNull())
                    _listItem.TEL = item.StationTEL;
                if (!item.IsStationFaxNull())
                    _listItem.Fax = item.StationFax;
                if (!item.IsStationDescriptionNull())
                    _listItem.Description = item.StationDescription;
                if (!item.IsStationYNull())
                    _listItem.lat = double.Parse(item.StationY);
                if (!item.IsStationXNull())
                    _listItem.lon = double.Parse(item.StationX);
                //if (!item.IsStationAreaIDNull())
                _listItem.AreaID = item.StationAreaID;
                //if (!item.IsStationOrganisationIDNull())
                _listItem.OrganisationID = item.StationOrganisationID;
                if (!item.IsStationInfoIDNull())
                    _listItem.StationInfoID = item.StationInfoID;
                if (!item.IsStationInfoIDNull())
                    _listItem.StationInfoFID = item.StationInfoID;
                if (!item.IsStationInfoPrincipalNull())
                    _listItem.StationInfoPrincipal = item.StationInfoPrincipal;
                if (!item.IsStationInfoPrincipalTELNull())
                    _listItem.StationInfoPrincipalTEL = item.StationInfoPrincipalTEL;
                if (!item.IsStationInfoSetLevelNull())
                    _listItem.StationInfoSetLevel = item.StationInfoSetLevel;
                if (!item.IsStationInfoPostalCodeNull())
                    _listItem.StationInfoPostalCode = item.StationInfoPostalCode;
                if (!item.IsStationInfoBusinessModelNull())
                    _listItem.StationInfoBusinessModel = item.StationInfoBusinessModel;
                if (!item.IsStationInfoBusinessScopeNull())
                    _listItem.StationInfoBusinessScope = item.StationInfoBusinessScope;
                if (!item.IsStationInfoOpeningHoursBeginNull())
                    _listItem.StationInfoOpeningHoursBegin = item.StationInfoOpeningHoursBegin;
                if (!item.IsStationInfoOpeningHoursEndNull())
                    _listItem.StationInfoOpeningHoursEnd = item.StationInfoOpeningHoursEnd;
                if (!item.IsOrganisationIDNull())
                    _listItem.OrganisationID = item.OrganisationID;
                if (!item.IsOrganisationFIDNull())
                    _listItem.OrganisationFID = item.OrganisationFID;
                if (!item.IsOrganisationNameNull())
                    _listItem.OrganisationName = item.OrganisationName;
                if (!item.IsOrganisationCenterNameNull())
                    _listItem.OrganisationCenterName = item.OrganisationCenterName;
                if (!item.IsOrganisationCenterXNull())
                    _listItem.Organisationlon = double.Parse(item.OrganisationCenterX);
                if (!item.IsOrganisationCenterYNull())
                    _listItem.Organisationlat = double.Parse(item.OrganisationCenterY);
                if (!item.IsAreaNameNull())
                    _listItem.AreaInfoName = item.AreaName;
                if (!item.IsAreaCenterXNull())
                    _listItem.AreaInfolon = double.Parse(item.AreaCenterX);
                if (!item.IsAreaCenterYNull())
                    _listItem.AreaInfolat = double.Parse(item.AreaCenterY);
                if (!item.IsAreaEasyCodeNull())
                    _listItem.AreaInfoEasyCode = item.AreaEasyCode;
                if (!item.IsAreaPostalCodeNull())
                    _listItem.AreaInfoPostalCode = item.AreaPostalCode;

            }
            return _listItem;
        }
        /// <summary>
        /// 获取详细网点信息列表记录总数
        /// </summary>
        /// <param name="sql">linq查询语句</param>
        /// <param name="_params">变量集合</param>
        /// <returns>详细网点信息列表记录总数</returns>
        public int GetVW_StatuionList(string sql, object[] _params)
        {
            int _return = 0;
            using (VW_baseStationTableAdapter _myTA = new VW_baseStationTableAdapter())
            {
                _return = _myTA.GetData().AsQueryable().Where(sql, _params).Count();

            }
            return _return;
        }
        /// <summary>
        /// 获取详细网点信息列表
        /// </summary>
        /// <param name="sql">linq查询语句</param>
        /// <param name="_params">变量集合</param>
        /// <param name="skin">页前数据量</param>
        /// <param name="pageSize">每页数据量</param>
        /// <returns>详细网点信息列表</returns>
        public List<VW_Statuion> GetVW_StatuionList(string sql, object[] _params, int skip, int pageSize)
        {
            List<VW_Statuion> _lists = new List<VW_Statuion>();
            using (VW_baseStationTableAdapter _myTA = new VW_baseStationTableAdapter())
            {
                foreach (var item in _myTA.GetData().AsQueryable().Where(sql, _params).Skip(skip).Take(pageSize).OrderBy(m => m.StationName))
                {
                    VW_Statuion _listItem = new VW_Statuion();
                    _listItem.ID = item.StationID;
                    if (!item.IsStationNumNull())
                        _listItem.Num = item.StationNum;
                    if (!item.IsStationNameNull())
                        _listItem.Name = item.StationName;
                    if (!item.IsStationAddressNull())
                        _listItem.Address = item.StationAddress;
                    if (!item.IsStationTELNull())
                        _listItem.TEL = item.StationTEL;
                    if (!item.IsStationFaxNull())
                        _listItem.Fax = item.StationFax;
                    if (!item.IsStationDescriptionNull())
                        _listItem.Description = item.StationDescription;
                    if (!item.IsStationYNull())
                        _listItem.lat = double.Parse(item.StationY);
                    if (!item.IsStationXNull())
                        _listItem.lon = double.Parse(item.StationX);
                    //if (!item.IsStationAreaIDNull())
                    _listItem.AreaID = item.StationAreaID;
                    //if (!item.IsStationOrganisationIDNull())
                    _listItem.OrganisationID = item.StationOrganisationID;
                    if (!item.IsStationInfoIDNull())
                        _listItem.StationInfoID = item.StationInfoID;
                    if (!item.IsStationInfoIDNull())
                        _listItem.StationInfoFID = item.StationInfoID;
                    if (!item.IsStationInfoPrincipalNull())
                        _listItem.StationInfoPrincipal = item.StationInfoPrincipal;
                    if (!item.IsStationInfoPrincipalTELNull())
                        _listItem.StationInfoPrincipalTEL = item.StationInfoPrincipalTEL;
                    if (!item.IsStationInfoSetLevelNull())
                        _listItem.StationInfoSetLevel = item.StationInfoSetLevel;
                    if (!item.IsStationInfoPostalCodeNull())
                        _listItem.StationInfoPostalCode = item.StationInfoPostalCode;
                    if (!item.IsStationInfoBusinessModelNull())
                        _listItem.StationInfoBusinessModel = item.StationInfoBusinessModel;
                    if (!item.IsStationInfoBusinessScopeNull())
                        _listItem.StationInfoBusinessScope = item.StationInfoBusinessScope;
                    if (!item.IsStationInfoOpeningHoursBeginNull())
                        _listItem.StationInfoOpeningHoursBegin = item.StationInfoOpeningHoursBegin;
                    if (!item.IsStationInfoOpeningHoursEndNull())
                        _listItem.StationInfoOpeningHoursEnd = item.StationInfoOpeningHoursEnd;
                    if (!item.IsOrganisationIDNull())
                        _listItem.OrganisationID = item.OrganisationID;
                    if (!item.IsOrganisationFIDNull())
                        _listItem.OrganisationFID = item.OrganisationFID;
                    if (!item.IsOrganisationNameNull())
                        _listItem.OrganisationName = item.OrganisationName;
                    if (!item.IsOrganisationCenterNameNull())
                        _listItem.OrganisationCenterName = item.OrganisationCenterName;
                    if (!item.IsOrganisationCenterXNull())
                        _listItem.Organisationlon = double.Parse(item.OrganisationCenterX);
                    if (!item.IsOrganisationCenterYNull())
                        _listItem.Organisationlat = double.Parse(item.OrganisationCenterY);
                    if (!item.IsAreaNameNull())
                        _listItem.AreaInfoName = item.AreaName;
                    if (!item.IsAreaCenterXNull())
                        _listItem.AreaInfolon = double.Parse(item.AreaCenterX);
                    if (!item.IsAreaCenterYNull())
                        _listItem.AreaInfolat = double.Parse(item.AreaCenterY);
                    if (!item.IsAreaEasyCodeNull())
                        _listItem.AreaInfoEasyCode = item.AreaEasyCode;
                    if (!item.IsAreaPostalCodeNull())
                        _listItem.AreaInfoPostalCode = item.AreaPostalCode;



                    _lists.Add(_listItem);
                }
            }
            return _lists;
        }
        /// <summary>
        /// 获取站点信息列表
        /// </summary>
        /// <returns>站点信息列表</returns>
        public List<Station> GetStationList()
        {
            List<Station> _lists = new List<Station>();
            using (baseStationTableAdapter _myTA = new baseStationTableAdapter())
            {
                foreach (var item in _myTA.GetData().OrderBy(m=>m.StationName))
                {
                    Station _listItem = new Station();
                    _listItem.ID = item.StationID;
                    if (!item.IsStationNumNull())
                        _listItem.Num = item.StationNum;
                    if (!item.IsStationNameNull())
                        _listItem.Name = item.StationName;
                    if (!item.IsStationAddressNull())
                        _listItem.Address = item.StationAddress;
                    if (!item.IsStationTELNull())
                        _listItem.TEL = item.StationTEL;
                    if (!item.IsStationFaxNull())
                        _listItem.Fax = item.StationFax;
                    if (!item.IsStationDescriptionNull())
                        _listItem.Description = item.StationDescription;
                    if (!item.IsStationYNull())
                        _listItem.lat = double.Parse(item.StationY);
                    if (!item.IsStationXNull())
                        _listItem.lon = double.Parse(item.StationX);
                    if (!item.IsStationAreaIDNull())
                        _listItem.AreaID = item.StationAreaID;
                    if (!item.IsStationOrganisationIDNull())
                        _listItem.OrganisationID = item.StationOrganisationID;
                    _lists.Add(_listItem);
                }
            }
            return _lists;
        }
        /// <summary>
        /// 获取站点信息列表
        /// </summary>
        /// <param name="skip">页前数据</param>
        /// <param name="pageSize">页面大小</param>
        /// <returns></returns>
        public DataTable GetStationList(int skip, int pageSize)
        {
            DataTable _dataTable = new DataTable();
            using (baseStationTableAdapter _myTA = new baseStationTableAdapter())
            {
                _dataTable = _myTA.GetData().Skip(skip).Take(pageSize) as DataTable;
            }
            return _dataTable;
        }
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="name">站定名称</param>
        /// <returns>站点信息</returns>
        public Station GetStation(string name)
        {
            Station _listItem = new Station();
            try
            {
                using (baseStationTableAdapter _myTA = new baseStationTableAdapter())
                {
                    var item = _myTA.GetData().Single(m => m.StationName.Equals(name));
                    _listItem.ID = item.StationID;
                    if (!item.IsStationNumNull())
                        _listItem.Num = item.StationNum;
                    if (!item.IsStationNameNull())
                        _listItem.Name = item.StationName;
                    if (!item.IsStationAddressNull())
                        _listItem.Address = item.StationAddress;
                    if (!item.IsStationTELNull())
                        _listItem.TEL = item.StationTEL;
                    if (!item.IsStationFaxNull())
                        _listItem.Fax = item.StationFax;
                    if (!item.IsStationDescriptionNull())
                        _listItem.Description = item.StationDescription;
                    if (!item.IsStationYNull())
                        _listItem.lat = double.Parse(item.StationY);
                    if (!item.IsStationXNull())
                        _listItem.lon = double.Parse(item.StationX);
                    if (!item.IsStationAreaIDNull())
                        _listItem.AreaID = item.StationAreaID;
                    if (!item.IsStationOrganisationIDNull())
                        _listItem.OrganisationID = item.StationOrganisationID;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _listItem;
        }
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="id">站点ID</param>
        /// <returns>站点信息</returns>
        public Station GetStation(Guid id)
        {
            Station _listItem = new Station();
            try
            {
                using (baseStationTableAdapter _myTA = new baseStationTableAdapter())
                {
                    var item = _myTA.GetData().Single(m => m.StationID.Equals(id));
                    _listItem.ID = item.StationID;
                    if (!item.IsStationNumNull())
                        _listItem.Num = item.StationNum;
                    if (!item.IsStationNameNull())
                        _listItem.Name = item.StationName;
                    if (!item.IsStationAddressNull())
                        _listItem.Address = item.StationAddress;
                    if (!item.IsStationTELNull())
                        _listItem.TEL = item.StationTEL;
                    if (!item.IsStationFaxNull())
                        _listItem.Fax = item.StationFax;
                    if (!item.IsStationDescriptionNull())
                        _listItem.Description = item.StationDescription;
                    if (!item.IsStationYNull())
                        _listItem.lat = double.Parse(item.StationY);
                    if (!item.IsStationXNull())
                        _listItem.lon = double.Parse(item.StationX);
                    if (!item.IsStationAreaIDNull())
                        _listItem.AreaID = item.StationAreaID;
                    if (!item.IsStationOrganisationIDNull())
                        _listItem.OrganisationID = item.StationOrganisationID;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _listItem;
        }
        /// <summary>
        /// 添加区域信息
        /// </summary>
        /// <param name="station">区域信息</param>
        /// <returns>是否添加成功</returns>
        public bool AddStation(Station station)
        {
            try
            {
                using (baseStationTableAdapter _myTA = new baseStationTableAdapter())
                {
                    _myTA.Insert(
                        station.ID
                        , station.Num
                        , station.Name
                        , station.Address
                        , station.TEL
                        , station.Fax
                        , station.Description
                        , station.lon.ToString()
                        , station.lat.ToString()
                        , station.AreaID
                        , station.OrganisationID
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }
        /// <summary>
        /// 编辑区域信息
        /// </summary>
        /// <param name="station">区域信息</param>
        /// <returns>是否编辑成功</returns>
        public bool EditStation(Station station)
        {
            try
            {
                using (baseStationTableAdapter _myTA = new baseStationTableAdapter())
                {
                    var _item = _myTA.GetData().Single(m => m.StationID.Equals(station.ID));
                    _item.StationID = station.ID;
                    _item.StationNum = station.Num;
                    _item.StationName = station.Name;
                    _item.StationAddress = station.Address;
                    _item.StationTEL = station.TEL;
                    _item.StationFax = station.Fax;
                    _item.StationDescription = station.Description;
                    _item.StationX = station.lon.ToString();
                    _item.StationY = station.lat.ToString();
                    _item.StationAreaID = station.AreaID;
                    _item.StationOrganisationID = station.OrganisationID;
                    _myTA.Update(_item);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }
        /// <summary>
        /// 删除区域信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>是否成功删除</returns>
        public bool DeleteStation(Guid id)
        {
            try
            {
                using (baseStationTableAdapter _myTA = new baseStationTableAdapter())
                {

                    _myTA.DeleteQuery(id);

                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }

        #endregion
        #region config
        /// <summary>
        /// 获取地图默认配置信息
        /// </summary>
        /// <returns>地图默认配置信息</returns>
        public Config GetConfigInfo()
        {
            Config _config = new Config();
            using (configTableAdapter _myTA = new configTableAdapter())
            {
                StationDataSet _myDataSet = new StationDataSet();
                _myTA.Fill(_myDataSet.config);

                var _item = _myDataSet.config.First();

                _config.CenterX = double.Parse(_item.centerX);
                _config.CenterY = double.Parse(_item.centerY);
                _config.GstPath = _item.gstPath;
                _config.ID = _item.ID;
                _config.Zoom = double.Parse(_item.zoom);
                _config.Skin = _item.skin;
            }
            return _config;
        }
        /// <summary>
        /// 设置地图默认配置信息
        /// </summary>
        /// <param name="config">地图默认配置信息</param>
        /// <returns>地图默认配置信息设置是否成功</returns>
        public bool SetConfig(Config config)
        {
            try
            {
                using (configTableAdapter _myTA = new configTableAdapter())
                {
                    StationDataSet _myDataSet = new StationDataSet();
                    _myTA.Fill(_myDataSet.config);
                    var _item = _myDataSet.config.First();
                    _item.centerX = config.CenterX.ToString();
                    _item.centerY = config.CenterY.ToString();
                    _item.gstPath = config.GstPath;
                    _item.zoom = config.Zoom.ToString();
                    _item.skin = config.Skin;
                    _myTA.Update(_myDataSet);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        #endregion
        #region Area
        /// <summary>
        /// 获取区域信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>返回区域信息</returns>
        public AreaInfo GetAreaInfo(Guid id)
        {
            AreaInfo _return = new AreaInfo();
            try
            {
                using (AreaInfoTableAdapter _myTA = new AreaInfoTableAdapter())
                {
                    var _item = _myTA.GetData().Single(m => m.AreaID.Equals(id));
                    _return.ID = Guid.Parse(_item["AreaID"].ToString());
                    _return.Name = _item["AreaName"].ToString();
                    _return.lon = double.Parse(_item["AreaCenterX"].ToString());
                    _return.lat = double.Parse(_item["AreaCenterY"].ToString());
                    _return.PostalCode = _item["AreaPostalCode"].ToString();
                    _return.EasyCode = _item["AreaEasyCode"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _return;
        }
        /// <summary>
        /// 添加区域信息
        /// </summary>
        /// <param name="areaInfo">区域信息</param>
        /// <returns>是否添加成功</returns>
        public bool AddAreaInfo(AreaInfo areaInfo)
        {
            try
            {
                using (AreaInfoTableAdapter _myTA = new AreaInfoTableAdapter())
                {
                    _myTA.Insert(
                        areaInfo.ID
                        , areaInfo.Name
                        , areaInfo.lon.ToString()
                        , areaInfo.lat.ToString()
                        , areaInfo.PostalCode
                        , areaInfo.EasyCode
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }
        /// <summary>
        /// 编辑区域信息
        /// </summary>
        /// <param name="areaInfo">区域信息</param>
        /// <returns>是否编辑成功</returns>
        public bool EditAreaInfo(AreaInfo areaInfo)
        {
            try
            {
                using (AreaInfoTableAdapter _myTA = new AreaInfoTableAdapter())
                {
                    var _item = _myTA.GetData().Single(m => m.AreaID.Equals(areaInfo.ID));
                    _item["AreaID"] = areaInfo.ID;
                    _item["AreaName"] = areaInfo.Name;
                    _item["AreaCenterX"] = areaInfo.lon.ToString();
                    _item["AreaCenterY"] = areaInfo.lat.ToString();
                    _item["AreaPostalCode"] = areaInfo.PostalCode;
                    _item["AreaEasyCode"] = areaInfo.EasyCode;
                    _myTA.Update(_item);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }
        /// <summary>
        /// 删除区域信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>是否成功删除</returns>
        public bool DeleteAreaInfo(Guid id)
        {
            try
            {
                using (AreaInfoTableAdapter _myTA = new AreaInfoTableAdapter())
                {

                    _myTA.DeleteQuery(id);

                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }

        /// <summary>
        /// 获取区域列表
        /// </summary>
        /// <returns>区域列表</returns>
        public List<AreaInfo> GetAreaList()
        {
            List<AreaInfo> _lists = new List<AreaInfo>();
            using (AreaInfoTableAdapter _myTA = new AreaInfoTableAdapter())
            {
                var _areaList=_myTA.GetData().OrderBy(m=>m.AreaName);
                foreach (var item in _areaList)
                {
                    AreaInfo _listItem = new AreaInfo();
                    _listItem.ID = item.AreaID;
                    _listItem.Name = item.AreaName;
                    _listItem.EasyCode = item.AreaEasyCode;
                    _listItem.lon = double.Parse(item.AreaCenterX);
                    _listItem.lat = double.Parse(item.AreaCenterY);
                    _listItem.PostalCode = item.AreaPostalCode;
                    _lists.Add(_listItem);
                }
            }
            return _lists;
        }
        #endregion
        #region Organisation
        /// <summary>
        /// 获取组织机构信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>返回组织机构信息</returns>
        public Organisation GetOrganisation(Guid id)
        {
            Organisation _return = new Organisation();
            try
            {
                using (OrganisationTableAdapter _myTA = new OrganisationTableAdapter())
                {
                    var _item = _myTA.GetData().Single(m => m.OrganisationID.Equals(id));
                    _return.ID = _item.OrganisationID;
                    _return.Name = _item.OrganisationName;
                    _return.FID = _item.OrganisationFID;
                    _return.CenterName = _item.OrganisationCenterName;
                    _return.lon = double.Parse(_item.OrganisationCenterX);
                    _return.lat = double.Parse(_item.OrganisationCenterY);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _return;
        }
        /// <summary>
        /// 添加组织机构信息
        /// </summary>
        /// <param name="organisation">组织机构信息</param>
        /// <returns>是否添加成功</returns>
        public bool AddOrganisation(Organisation organisation)
        {
            try
            {
                using (OrganisationTableAdapter _myTA = new OrganisationTableAdapter())
                {
                    _myTA.Insert(
                        organisation.ID
                        , organisation.Name
                          , organisation.FID
                        , organisation.lon.ToString()
                        , organisation.lat.ToString()
                        , organisation.CenterName
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }
        /// <summary>
        /// 编辑组织机构信息
        /// </summary>
        /// <param name="organisation">组织机构信息</param>
        /// <returns>是否编辑成功</returns>
        public bool EditOrganisation(Organisation organisation)
        {
            try
            {
                using (OrganisationTableAdapter _myTA = new OrganisationTableAdapter())
                {
                    var _item = _myTA.GetData().Single(m => m.OrganisationID.Equals(organisation.ID));
                    _item.OrganisationID = organisation.ID;
                    _item.OrganisationName = organisation.Name;
                    _item.OrganisationFID = organisation.FID;
                    _item.OrganisationCenterName = organisation.CenterName;
                    _item.OrganisationCenterX = organisation.lon.ToString();
                    _item.OrganisationCenterY = organisation.lat.ToString();
                    _myTA.Update(_item);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }
        /// <summary>
        /// 删除组织机构信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>是否成功删除</returns>
        public bool DeleteOrganisation(Guid id)
        {
            try
            {
                using (OrganisationTableAdapter _myTA = new OrganisationTableAdapter())
                {

                    _myTA.DeleteQuery(id);

                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }

        /// <summary>
        /// 获取组织机构列表
        /// </summary>
        /// <returns>组织机构列表</returns>
        public List<Organisation> GetOrganisationList()
        {
            List<Organisation> _lists = new List<Organisation>();
            using (OrganisationTableAdapter _myTA = new OrganisationTableAdapter())
            {
                foreach (var item in _myTA.GetData().OrderBy(m=>m.OrganisationName))
                {
                    Organisation _listItem = new Organisation();
                    _listItem.ID = item.OrganisationID;
                    _listItem.Name = item.OrganisationName;
                    _listItem.FID = item.OrganisationFID;
                    _listItem.CenterName = item.OrganisationCenterName;
                    _listItem.lon = double.Parse(item.OrganisationCenterX);
                    _listItem.lat = double.Parse(item.OrganisationCenterY);
                    _lists.Add(_listItem);
                }
            }
            return _lists;
        }
        #endregion
        #region StationInfo
        /// <summary>
        /// 获取网点详细信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>返回网点详细信息</returns>
        public StationInfo GetStationInfo(Guid id)
        {
            StationInfo _return = new StationInfo();
            try
            {
                using (stationInfoTableAdapter _myTA = new stationInfoTableAdapter())
                {
                    var item = _myTA.GetData().Single(m => m.StationInfoFID.Equals(id));
                    _return.ID = item.StationInfoID;
                    //if (!item.IsStationInfoFIDNull())
                    _return.FID = item.StationInfoFID;
                    if (!item.IsStationInfoPrincipalNull())
                        _return.Principal = item.StationInfoPrincipal;
                    if (!item.IsStationInfoPrincipalTELNull())
                        _return.PrincipalTEL = item.StationInfoPrincipalTEL;
                    if (!item.IsStationInfoSetLevelNull())
                        _return.SetLevel = item.StationInfoSetLevel;
                    if (!item.IsStationInfoPostalCodeNull())
                        _return.PostalCode = item.StationInfoPostalCode;
                    if (!item.IsStationInfoBusinessModelNull())
                        _return.BusinessModel = item.StationInfoBusinessModel;

                    if (!item.IsStationInfoBusinessScopeNull())
                        _return.BusinessScope = item.StationInfoBusinessScope;

                    if (!item.IsStationInfoOpeningHoursBeginNull())
                        _return.OpeningHoursBegin = item.StationInfoOpeningHoursBegin;

                    if (!item.IsStationInfoOpeningHoursEndNull())
                        _return.OpeningHoursEnd = item.StationInfoOpeningHoursEnd;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _return;
        }
        /// <summary>
        /// 添加网点详细信息
        /// </summary>
        /// <param name="StationInfo">网点详细信息</param>
        /// <returns>是否添加成功</returns>
        public bool AddStationInfo(StationInfo StationInfo)
        {
            try
            {
                using (stationInfoTableAdapter _myTA = new stationInfoTableAdapter())
                {
                    _myTA.Insert(
                        StationInfo.ID
                        , StationInfo.FID
                       , StationInfo.Principal
                       , StationInfo.PrincipalTEL
                       , StationInfo.SetLevel
                       , StationInfo.PostalCode
                       , StationInfo.BusinessModel
                       , StationInfo.BusinessScope
                       , StationInfo.OpeningHoursBegin
                       , StationInfo.OpeningHoursEnd
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }
        /// <summary>
        /// 编辑网点详细信息
        /// </summary>
        /// <param name="StationInfo">网点详细信息</param>
        /// <returns>是否编辑成功</returns>
        public bool EditStationInfo(StationInfo StationInfo)
        {
            try
            {
                using (stationInfoTableAdapter _myTA = new stationInfoTableAdapter())
                {
                    var _item = _myTA.GetData().Single(m => m.StationInfoID.Equals(StationInfo.ID));
                    if (!StationInfo.ID.Equals(null))
                        _item.StationInfoID = StationInfo.ID;
                    if (!StationInfo.FID.Equals(null))
                        _item.StationInfoFID = StationInfo.FID;

                    _item.StationInfoPrincipal = StationInfo.Principal;
                    _item.StationInfoPrincipalTEL = StationInfo.PrincipalTEL;
                    _item.StationInfoSetLevel = StationInfo.SetLevel;
                    _item.StationInfoPostalCode = StationInfo.PostalCode;
                    _item.StationInfoBusinessModel = StationInfo.BusinessModel;
                    _item.StationInfoBusinessScope = StationInfo.BusinessScope;
                    _item.StationInfoOpeningHoursBegin = StationInfo.OpeningHoursBegin;
                    _item.StationInfoOpeningHoursEnd = StationInfo.OpeningHoursEnd;
                    _myTA.Update(_item);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }
        /// <summary>
        /// 删除网点详细信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>是否成功删除</returns>
        public bool DeleteStationInfo(Guid id)
        {
            try
            {
                using (stationInfoTableAdapter _myTA = new stationInfoTableAdapter())
                {

                    _myTA.DeleteQuery(id);

                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }

        /// <summary>
        /// 获取网点详细信息列表
        /// </summary>
        /// <returns>网点详细信息列表</returns>
        public List<StationInfo> GetStationInfoList()
        {
            List<StationInfo> _lists = new List<StationInfo>();
            using (stationInfoTableAdapter _myTA = new stationInfoTableAdapter())
            {
                foreach (var item in _myTA.GetData())
                {
                    StationInfo _listItem = new StationInfo();
                    _listItem.ID = item.StationInfoID;
                    // if (!item.IsStationInfoFIDNull())
                    _listItem.FID = item.StationInfoFID;
                    if (!item.IsStationInfoPrincipalNull())
                        _listItem.Principal = item.StationInfoPrincipal;
                    if (!item.IsStationInfoPrincipalTELNull())
                        _listItem.PrincipalTEL = item.StationInfoPrincipalTEL;
                    if (!item.IsStationInfoSetLevelNull())
                        _listItem.SetLevel = item.StationInfoSetLevel;
                    if (!item.IsStationInfoPostalCodeNull())
                        _listItem.PostalCode = item.StationInfoPostalCode;
                    if (!item.IsStationInfoBusinessModelNull())
                        _listItem.BusinessModel = item.StationInfoBusinessModel;

                    if (!item.IsStationInfoBusinessScopeNull())
                        _listItem.BusinessScope = item.StationInfoBusinessScope;

                    if (!item.IsStationInfoOpeningHoursBeginNull())
                        _listItem.OpeningHoursBegin = item.StationInfoOpeningHoursBegin;

                    if (!item.IsStationInfoOpeningHoursEndNull())
                        _listItem.OpeningHoursEnd = item.StationInfoOpeningHoursEnd;
                    _lists.Add(_listItem);
                }
            }
            return _lists;
        }
        /// <summary>
        /// 判断网点详细信息是否存在
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>网点信息是否存在</returns>
        public int ExistsStationInfo(Guid id)
        {
            int _return = 0;
            try
            {
                using (stationInfoTableAdapter _myTA = new stationInfoTableAdapter())
                {

                    _return = _myTA.GetExistsQuery(id).Rows.Count;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _return;
        }
        #endregion
        #region StationImageInfo
        /// <summary>
        /// 获取网点图片信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>返回网点图片信息</returns>
        public StationImageInfo GetStationImageInfo(Guid id)
        {
            StationImageInfo _return = new StationImageInfo();
            try
            {
                using (stationImageInfoTableAdapter _myTA = new stationImageInfoTableAdapter())
                {
                    var item = _myTA.GetData().Single(m => m.StationImageInfoID.Equals(id));
                    _return.ID = item.StationImageInfoID;
                    if (!item.IsStationImageInfoPIDNull())
                        _return.PID = item.StationImageInfoPID;
                    if (!item.IsStationImageInfoTitleNull())
                        _return.Title = item.StationImageInfoTitle;
                    if (!item.IsStationImageInfoDescriptionNull())
                        _return.Description = item.StationImageInfoDescription;
                    if (!item.IsStationImagePathNull())
                        _return.ImagePath = item.StationImagePath;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _return;
        }
        /// <summary>
        /// 添加网点图片信息
        /// </summary>
        /// <param name="StationImageInfo">网点图片信息</param>
        /// <returns>是否添加成功</returns>
        public bool AddStationImageInfo(StationImageInfo StationImageInfo)
        {
            try
            {
                using (stationImageInfoTableAdapter _myTA = new stationImageInfoTableAdapter())
                {
                    _myTA.Insert(
                        StationImageInfo.ID
                    , StationImageInfo.PID
                    , StationImageInfo.Title
                    , StationImageInfo.Description
                    , StationImageInfo.ImagePath
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }
        /// <summary>
        /// 编辑网点图片信息
        /// </summary>
        /// <param name="StationImageInfo">网点图片信息</param>
        /// <returns>是否编辑成功</returns>
        public bool EditStationImageInfo(StationImageInfo StationImageInfo)
        {
            try
            {
                using (stationImageInfoTableAdapter _myTA = new stationImageInfoTableAdapter())
                {
                    var _item = _myTA.GetData().Single(m => m.StationImageInfoID.Equals(StationImageInfo.ID));
                    if (!StationImageInfo.ID.Equals(null))
                        _item.StationImageInfoID = StationImageInfo.ID;
                    if (!StationImageInfo.PID.Equals(null))
                        _item.StationImageInfoPID = StationImageInfo.PID;
                    _item.StationImageInfoTitle = StationImageInfo.Title;
                    _item.StationImageInfoDescription = StationImageInfo.Description;
                    _item.StationImagePath = StationImageInfo.ImagePath;
                    _myTA.Update(_item);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }
        /// <summary>
        /// 删除网点图片信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>是否成功删除</returns>
        public bool DeleteStationImageInfo(Guid id)
        {
            try
            {
                using (stationImageInfoTableAdapter _myTA = new stationImageInfoTableAdapter())
                {

                    _myTA.DeleteQuery(id);

                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return true;
        }

        /// <summary>
        /// 获取网点图片信息列表
        /// </summary>
        /// <returns>网点图片信息列表</returns>
        public List<StationImageInfo> GetStationImageInfoList()
        {
            List<StationImageInfo> _lists = new List<StationImageInfo>();
            using (stationImageInfoTableAdapter _myTA = new stationImageInfoTableAdapter())
            {
                foreach (var item in _myTA.GetData().OrderBy(m => m.StationImageInfoTitle))
                {
                    StationImageInfo _listItem = new StationImageInfo();
                    _listItem.ID = item.StationImageInfoID;
                    if (!item.IsStationImageInfoPIDNull())
                        _listItem.PID = item.StationImageInfoPID;
                    if (!item.IsStationImageInfoTitleNull())
                        _listItem.Title = item.StationImageInfoTitle;
                    if (!item.IsStationImageInfoDescriptionNull())
                        _listItem.Description = item.StationImageInfoDescription;
                    if (!item.IsStationImagePathNull())
                        _listItem.ImagePath = item.StationImagePath;
                    _lists.Add(_listItem);
                }
            }
            return _lists;
        }
        public List<StationImageInfo> GetStationImageInfoList(Guid fid)
        {
            List<StationImageInfo> _lists = new List<StationImageInfo>();
            using (stationImageInfoTableAdapter _myTA = new stationImageInfoTableAdapter())
            {
                foreach (var item in _myTA.GetData().Where(m => m.StationImageInfoPID.Equals(fid)).OrderBy(m => m.StationImageInfoTitle))
                {
                    StationImageInfo _listItem = new StationImageInfo();
                    _listItem.ID = item.StationImageInfoID;
                    if (!item.IsStationImageInfoPIDNull())
                        _listItem.PID = item.StationImageInfoPID;
                    if (!item.IsStationImageInfoTitleNull())
                        _listItem.Title = item.StationImageInfoTitle;
                    if (!item.IsStationImageInfoDescriptionNull())
                        _listItem.Description = item.StationImageInfoDescription;
                    if (!item.IsStationImagePathNull())
                        _listItem.ImagePath = item.StationImagePath;
                    _lists.Add(_listItem);
                }
            }
            return _lists;
        }
        #endregion








    }
}
