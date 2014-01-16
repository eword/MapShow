using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace TaskInterface
{
    public interface IStation : IDisposable
    {
        #region
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="id">站点ID</param>
        /// <returns>站点信息</returns>
        VW_Statuion GetVW_Station(Guid id);
        /// <summary>
        /// 获取详细网点信息列表
        /// </summary>
        /// <param name="sql">linq查询语句</param>
        /// <param name="_params">变量集合</param>
        /// <param name="skin">页前数据量</param>
        /// <param name="pageSize">每页数据量</param>
        /// <returns>详细网点信息列表</returns>
        List<VW_Statuion> GetVW_StatuionList(string sql, object[] _params, int skip, int pageSize);
        /// <summary>
        /// 获取详细网点信息列表记录总数
        /// </summary>
        /// <param name="sql">linq查询语句</param>
        /// <param name="_params">变量集合</param>
        /// <returns>详细网点信息列表记录总数</returns>
        int GetVW_StatuionList(string sql, object[] _params);
        /// <summary>
        /// 获取站点信息列表
        /// </summary>
        /// <returns>站点信息列表</returns>
        List<Station> GetStationList();
        /// <summary>
        /// 获取站点信息列表
        /// </summary>
        /// <param name="skip">页前数据</param>
        /// <param name="pageSize">页面大小</param>
        /// <returns></returns>
        DataTable GetStationList(int skip, int pageSize);
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="name">站定名称</param>
        /// <returns>站点信息</returns>
        Station GetStation(string name);
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="id">站点ID</param>
        /// <returns>站点信息</returns>
        Station GetStation(Guid id);
        /// <summary>
        /// 添加区域信息
        /// </summary>
        /// <param name="Station">区域信息</param>
        /// <returns>是否添加成功</returns>
        bool AddStation(Station station);
        /// <summary>
        /// 编辑区域信息
        /// </summary>
        /// <param name="Station">区域信息</param>
        /// <returns>是否编辑成功</returns>
        bool EditStation(Station station);
        /// <summary>
        /// 删除区域信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>是否成功删除</returns>
        bool DeleteStation(Guid id);


        #endregion
        #region Area
        /// <summary>
        /// 获取区域列表
        /// </summary>
        /// <returns>区域列表</returns>
        List<AreaInfo> GetAreaList();
        /// <summary>
        /// 获取区域信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>返回区域信息</returns>
        AreaInfo GetAreaInfo(Guid id);
        /// <summary>
        /// 添加区域信息
        /// </summary>
        /// <param name="areaInfo">区域信息</param>
        /// <returns>是否添加成功</returns>
        bool AddAreaInfo(AreaInfo areaInfo);
        /// <summary>
        /// 编辑区域信息
        /// </summary>
        /// <param name="areaInfo">区域信息</param>
        /// <returns>是否编辑成功</returns>
        bool EditAreaInfo(AreaInfo areaInfo);
        /// <summary>
        /// 删除区域信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>是否成功删除</returns>
        bool DeleteAreaInfo(Guid id);
        #endregion
        #region Organisation
        /// <summary>
        /// 获取组织机构列表
        /// </summary>
        /// <returns>组织机构列表</returns>
        List<Organisation> GetOrganisationList();
        /// <summary>
        /// 获取组织机构信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>返回组织机构信息</returns>
        Organisation GetOrganisation(Guid id);
        /// <summary>
        /// 添加组织机构信息
        /// </summary>
        /// <param name="Organisation">组织机构信息</param>
        /// <returns>是否添加成功</returns>
        bool AddOrganisation(Organisation organisation);
        /// <summary>
        /// 编辑组织机构信息
        /// </summary>
        /// <param name="Organisation">组织机构信息</param>
        /// <returns>是否编辑成功</returns>
        bool EditOrganisation(Organisation organisation);
        /// <summary>
        /// 删除组织机构信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>是否成功删除</returns>
        bool DeleteOrganisation(Guid id);
        #endregion

        #region StationInfo
        /// <summary>
        /// 获取网点详细信息列表
        /// </summary>
        /// <returns>网点详细信息列表</returns>
        List<StationInfo> GetStationInfoList();
        /// <summary>
        /// 获取网点详细信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>返回网点详细信息</returns>
        StationInfo GetStationInfo(Guid id);
        /// <summary>
        /// 添加网点详细信息
        /// </summary>
        /// <param name="StationInfo">网点详细信息</param>
        /// <returns>是否添加成功</returns>
        bool AddStationInfo(StationInfo StationInfo);
        /// <summary>
        /// 编辑网点详细信息
        /// </summary>
        /// <param name="StationInfo">网点详细信息</param>
        /// <returns>是否编辑成功</returns>
        bool EditStationInfo(StationInfo StationInfo);
        /// <summary>
        /// 删除网点详细信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>是否成功删除</returns>
        bool DeleteStationInfo(Guid id);
        /// <summary>
        /// 判断网点详细信息是否存在
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>网点信息是否存在</returns>
        int ExistsStationInfo(Guid id);
        #endregion


        #region StationImageInfo
        /// <summary>
        /// 获取网点图片信息列表
        /// </summary>
        /// <returns>网点图片信息列表</returns>
        List<StationImageInfo> GetStationImageInfoList();
        /// <summary>
        /// 获取网点图片信息列表
        /// </summary>
        /// /// <param name="fid">FID:GUID</param>
        /// <returns>网点图片信息列表</returns>
        List<StationImageInfo> GetStationImageInfoList(Guid fid);
        /// <summary>
        /// 获取网点图片信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>返回网点图片信息</returns>
        StationImageInfo GetStationImageInfo(Guid id);
        /// <summary>
        /// 添加网点图片信息
        /// </summary>
        /// <param name="StationImageInfo">网点图片信息</param>
        /// <returns>是否添加成功</returns>
        bool AddStationImageInfo(StationImageInfo StationImageInfo);
        /// <summary>
        /// 编辑网点图片信息
        /// </summary>
        /// <param name="StationImageInfo">网点图片信息</param>
        /// <returns>是否编辑成功</returns>
        bool EditStationImageInfo(StationImageInfo StationImageInfo);
        /// <summary>
        /// 删除网点图片信息
        /// </summary>
        /// <param name="id">ID：GUID</param>
        /// <returns>是否成功删除</returns>
        bool DeleteStationImageInfo(Guid id);
        #endregion
    }
    /// <summary>
    /// 地图默认配置信息操作
    /// </summary>
    public interface IConfig : IDisposable
    {
        /// <summary>
        /// 获取地图默认配置信息
        /// </summary>
        /// <returns>地图默认配置信息</returns>
        Config GetConfigInfo();
        /// <summary>
        /// 设置地图默认配置信息
        /// </summary>
        /// <param name="config">地图默认配置信息</param>
        /// <returns>地图默认配置信息设置是否成功</returns>
        bool SetConfig(Config config);
    }
}
