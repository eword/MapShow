using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TaskInterface;
using MapXLib;
using AxMapXLib;
using Eulei.Map.Code;
using System.Runtime.InteropServices;
namespace Eulei.Map
{
    public partial class MainForm : Form
    {
        #region Field
        //动态层名称
        string m_layerName = "siteLayer";
        //程序路径
        string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string mapDefaultDirectory = AppDomain.CurrentDomain.BaseDirectory + "map\\";
        //皮肤路径
        string skinDirectory = AppDomain.CurrentDomain.BaseDirectory + "Skins\\";
        //初始化MEF操作类
        Task _task = Task.Init();
        //站点列表数据源对象
        List<VW_Statuion> _VWstationSource;
        List<VW_Statuion> _VWstationSourceAll;
        //区域列表数据源对象
        List<AreaInfo> _areas;
        /// <summary>
        /// 配置文件
        /// </summary>
        Config _config;
        ToolTip MapToolTip = new ToolTip();
        /// <summary>
        /// 分页信息
        /// </summary>
        PageInfo _pageInfo = new PageInfo();
        string _sql = "1=1";

        ImageList il_main = new ImageList();
        bool _isRemoveToolTip = true;
        string _ICOPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\ICO.png";
        /// <summary>
        /// 区级图标
        /// </summary>
        string _QbmgPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Qico.bmp";
        /// <summary>
        /// 市级图标
        /// </summary>
        string _SbmgPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Sico.bmp";
        /// <summary>
        /// 县级图标
        /// </summary>
        string _XbmgPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Xico.bmp";
        /// <summary>
        /// SQL linq 参数
        /// </summary>
        object[] _params = new string[] { "" };
        // List<ToolTip> _toolTips = new List<ToolTip>();

        // bool _Init = true;
        bool _isFullPlay = false;

        #endregion
        public MainForm()
        {
            InitializeComponent();
            this._VWstationSourceAll = Task.Init().TaskStation.GetVW_StatuionList();
            this.Init();
            this.SetMenu();
            this._isFullPlay = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyUp += MainForm_KeyUp;
            this.rv_main.RefreshReport();
        }
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                this.SetMapFull();
            }
            else
            {
                e.Handled = true;
            }
        }
        #region Event
        #region 地图工具、副工具栏 及 地图操作
        private void tsb_NoSelected_Click(object sender, EventArgs e)
        {
            try
            {
                (sender as ToolStripButton).Checked = true;
                this.axMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool;
                (sender as ToolStripButton).DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
            catch (Exception ex)
            {
                Log.FileOperation.WriteErrorLog(ex.Message);
                MessageBox.Show("地图指针工具操作异常！");
            }
        }

        void toolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in this.MainToolStrip.Items)
            {
                if (item is ToolStripButton)
                {
                    //判断是不是生成的area按钮，如果是着取消操作直接返回
                    if ((item as ToolStripButton).Tag != null)
                    {
                        if ((item as ToolStripButton).Tag.ToString().Equals("area"))
                            return;
                        if ((item as ToolStripButton).Tag.ToString().Equals("notChange"))
                            return;
                    }

                    if (
                        !(item as ToolStripButton).Name.Equals((sender as ToolStripButton).Name)
                        )
                    {
                        (item as ToolStripButton).Checked = false;
                        (item as ToolStripButton).DisplayStyle = ToolStripItemDisplayStyle.Image; ;
                    }
                }
            }
        }

        private void tsb_zoomIn_Click(object sender, EventArgs e)
        {
            (sender as ToolStripButton).Checked = true;
            this.axMap1.CurrentTool = MapXLib.ToolConstants.miZoomInTool;
            (sender as ToolStripButton).DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        }

        private void tsb_zoomOut_Click(object sender, EventArgs e)
        {
            (sender as ToolStripButton).Checked = true;
            this.axMap1.CurrentTool = MapXLib.ToolConstants.miZoomOutTool;
            (sender as ToolStripButton).DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        }

        private void tsb_Pan_Click(object sender, EventArgs e)
        {
            (sender as ToolStripButton).Checked = true;
            this.axMap1.CurrentTool = MapXLib.ToolConstants.miPanTool;
            (sender as ToolStripButton).DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        }




        private void tsb_fullShowMap_Click(object sender, EventArgs e)
        {
            this.SetMapFull();
        }

        double currentMapx = 0;
        double currentMapy = 0;
        float currentMousex = 0;
        float currentMousey = 0;
        private void axMap1_MouseMoveEvent(object sender, AxMapXLib.CMapXEvents_MouseMoveEvent e)
        {

            this.currentMousex = e.x;
            this.currentMousey = e.y;
            axMap1.ConvertCoord(ref e.x, ref  e.y, ref this.currentMapx, ref this.currentMapy, MapXLib.ConversionConstants.miScreenToMap);
            toolStripStatusLabel1.Text = string.Format("X:{0} Y:{1}(mouseX:{2} mouseY{3})Zoom{4}", currentMapx, currentMapy, e.x, e.y, this.axMap1.Zoom);
        }



        #endregion
        #region 主菜单
        private void tsmi_openGST_Click(object sender, EventArgs e)
        {
            this.SetGST();
        }
        private void tsmi_skin_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.DefaultExt = "*.ssk";
                openFileDialog1.InitialDirectory = this.skinDirectory;
                openFileDialog1.Filter = "skin file (*.ssk)|*.ssk";

                openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName == "")

                    return;
                this.skinEngine1.SkinFile = this.skinDirectory + openFileDialog1.SafeFileName;
                this._config.Skin = openFileDialog1.SafeFileName;
                _task.TaskConfig.SetConfig(this._config);
            }
            catch (Exception ex)
            {
                Log.FileOperation.WriteErrorLog(ex.Message);
                MessageBox.Show("设置皮肤失败，详情请查看日志！");
            }
        }
        private void tsmi_saveCurrent_Click(object sender, EventArgs e)
        {
            this._config.CenterX = axMap1.CenterX;
            this._config.CenterY = axMap1.CenterY;
            this._config.Zoom = axMap1.Zoom;
            _task.TaskConfig.SetConfig(this._config);
        }

        private void tsmi_default_Click(object sender, EventArgs e)
        {
            this.SetMapxDefaultSite();
        }
        private void tsmi_logOut_Click(object sender, EventArgs e)
        {
            var _userRoot = UserHistory.Init().UserRoot;
            _userRoot.RememberMe = false;
            _userRoot.HistoryUser = null;
            UserHistory.Init().Save(_userRoot);
            UserHistory.Init().Dispose();
            Application.Exit();
        }
        private void tsmi_areas_Click(object sender, EventArgs e)
        {
            AreaList _al = new AreaList();
            _al.FormClosed += new FormClosedEventHandler((sender1, e1) =>
            {

            });

            _al.ShowDialog();

        }
        private void tsmi_showSatationForListView_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.lv_main.SelectedItems)
            {
                VW_Statuion _vws = item.Tag as VW_Statuion;
                if (_vws != null)
                {
                    StationInfoBrowse _sib = StationInfoBrowse.Init(_vws.ID);
                    _sib.ShowDialog();
                }
            }
        }
        private void tsmi_organisationList_Click(object sender, EventArgs e)
        {
            OrganisationList _ol = OrganisationList.Init();
            _ol.FormClosed += new FormClosedEventHandler((sender1, e1) =>
            {

            });

            _ol.ShowDialog();
        }
        private void tsmi_stationList_Click(object sender, EventArgs e)
        {
            StationList _sl = StationList.Init();
            _sl.FormClosed += new FormClosedEventHandler((sender1, e1) =>
            {

            });

            _sl.ShowDialog();
        }
        #endregion
        #region 控件事件


        #region
        private void llb_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this._pageInfo.CurrentPageIndex--;
            this.BindData();
        }

        private void llb_down_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this._pageInfo.CurrentPageIndex++;
            this.BindData();
        }
        private void llb_first_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this._pageInfo.CurrentPageIndex = 1;
            this.BindData();
        }

        private void llb_last_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int _i = this._pageInfo.RecordCount / this._pageInfo.PageSize + (this._pageInfo.RecordCount % this._pageInfo.PageSize > 0 ? 1 : 0);
            this._pageInfo.CurrentPageIndex = _i;
            this.BindData();
        }
        private void bt_reset_Click(object sender, EventArgs e)
        {
            this._sql = "1=1";
            this._params = null;
            this._params = new string[] { "" };
            this.BindData();
        }

        private void bt_serch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_searchText.Text))
            {
                MessageBox.Show("请先输入查询内容！");
                return;
            }
            string m_searchText = string.IsNullOrWhiteSpace(this.tb_searchText.Text) ? "" : this.tb_searchText.Text.Trim();
            this._params = null;
            this._params = new object[] { m_searchText };
            //生成查询语句
            _sql = "";
            //网点名称     

            if (_sql.Equals(""))
            {
                _sql = _sql
                    + " ("
                    + "StationName.Contains(@0)"
                    + ")";
            }
            else
            {
                _sql = _sql
                    + "  or  "
                    + "  ("
                    + "StationName.Contains(@0)"
                    + ")";
            }

            //网点编号

            if (_sql.Equals(""))
            {
                _sql = _sql
                    + " ("
                    + "StationNum.Contains(@0)"
                    + ") ";
            }
            else
            {
                _sql = _sql
                   + "  or  "
                    + "  ("
                    + "StationNum.Contains(@0)"
                    + ") ";
            }

            //网点电话
            if (_sql.Equals(""))
            {
                _sql = _sql
                    + " ("
                    + "StationTEL.Contains(@0)"
                    + ")";
            }
            else
            {
                _sql = _sql
                  + "  or "
                    + "  ("
                    + "StationTEL.Contains(@0)"
                    + ")";
            }

            //网点区域
            if (_sql.Equals(""))
            {
                _sql = _sql
                    + " ("
                    + "AreaName.Contains(@0)"
                    + ")";
            }
            else
            {
                _sql = _sql
                  + " or "
                    + "  ("
                    + "AreaName.Contains(@0)"
                    + ")";
            }

            //网点机构


            if (_sql.Equals(""))
            {
                _sql = _sql
                    + " ("
                    + "OrganisationName.Contains(@0)"
                    + ")";
            }
            else
            {
                _sql = _sql
                  + " or "
                    + "  ("
                    + "OrganisationName.Contains(@0)"
                    + ")";
            }

            this.BindData();
        }
        private void lv_main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = this.lv_main.HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                this._isRemoveToolTip = false;
                VW_Statuion _vws = info.Item.Tag as VW_Statuion;
                if (_vws == null)
                {
                    return;
                }
                axMap1.ZoomTo(axMap1.Zoom, _vws.lon, _vws.lat);
                string _str = "";
                if (!string.IsNullOrEmpty(_vws.Name))
                    _str += "网店名称:" + _vws.Name + "\r\n";
                if (!string.IsNullOrEmpty(_vws.OrganisationName))
                    _str += "所属机构:" + _vws.OrganisationName + "\r\n";
                if (!string.IsNullOrEmpty(_vws.AreaInfoName))
                    _str += "所属区域:" + _vws.AreaInfoName + "\r\n";
                if (!string.IsNullOrEmpty(_vws.TEL))
                    _str += "电    话:" + _vws.TEL + "\r\n";
                if (!string.IsNullOrEmpty(_vws.Fax))
                    _str += "传    真:" + _vws.Fax + "\r\n";
                if (!string.IsNullOrEmpty(_vws.Address))
                    _str += "地    址:" + _vws.Address + "\r\n";
                if (!string.IsNullOrEmpty(_vws.StationInfoPrincipal))
                    _str += "负 责 人:" + _vws.StationInfoPrincipal + "\r\n";
                if (!string.IsNullOrEmpty(_vws.StationInfoPrincipalTEL))
                    _str += "负责人电话:" + _vws.StationInfoPrincipalTEL;

                this.MapToolTip.Active = false;
                this.MapToolTip.IsBalloon = true;
                this.MapToolTip.SetToolTip(this.axMap1, _str);
                this.MapToolTip.Active = true;
                this.MapToolTip.Show(_str, this.axMap1, this.axMap1.Width / 2, (int)this.axMap1.Height / 2);


            }

        }

        #endregion

        #endregion
        #endregion
        #region 自定义函数
        #region 初始化

        private void SetAreaLink()
        {
            this._areas = _task.TaskStation.GetAreaList();
            foreach (var item in this._areas)
            {
                ToolStripButton _tsbItem = new ToolStripButton();
                _tsbItem.Click += new EventHandler(
                    (sender1, e1) =>
                    {

                        this.axMap1.ZoomTo(this.axMap1.Zoom, item.lon, item.lat);
                        //生成查询语句
                        _sql = " 1=1 ";
                        this._params = null;
                        this._params = new object[] { item.ID };
                        //网点区域ID
                        if (_sql.Equals(""))
                        {
                            _sql = _sql
                                + " ("
                                + "StationAreaID.Equals(@0)"
                                + ")";
                        }
                        else
                        {
                            _sql = _sql
                              + " and "
                                + "  ("
                               + "StationAreaID.Equals(@0)"
                                + ")";
                        }

                        _pageInfo.CurrentPageIndex = 1;
                        this.BindData();
                        //this.SetToolTip(true);

                    }
                    );
                _tsbItem.Text = item.Name;
                _tsbItem.Tag = "area";
                this.MainToolStrip.Items.Add(_tsbItem);
            }
        }
        private void SetOrganisationGroup()
        {
            List<Organisation> _organisations = _task.TaskStation.GetOrganisationList();
            foreach (var item in _organisations)
            {
                ListViewGroup _lvg = new ListViewGroup(item.ID.ToString(), item.Name);
                this.lv_main.Groups.Add(_lvg);

            }
        }
        /// <summary>
        /// 设置页数、记录数、当前页等信息
        /// </summary>
        private void SetPageLabel()
        {
            int _i0 = this._pageInfo.RecordCount;
            int _i1 = this._pageInfo.PageSize;
            int _i2 = this._pageInfo.RecordCount / this._pageInfo.PageSize + (this._pageInfo.RecordCount % this._pageInfo.PageSize > 0 ? 1 : 0);
            int _i3 = this._pageInfo.CurrentPageIndex;
            this.lb_pageInfo.Text = string.Format("共{0}项，每页{1}项，共{2}页，当前第{3}页", _i0, _i1, _i2, _i3);
            if (_i3.Equals(1))
            {
                this.llb_first.Enabled = false;
                this.llb_up.Enabled = false;
            }
            else
            {
                this.llb_first.Enabled = true;
                this.llb_up.Enabled = true;
            }
            if (_i3.Equals(_i2))
            {
                this.llb_last.Enabled = false;
                this.llb_down.Enabled = false;
            }
            else
            {
                this.llb_last.Enabled = true;
                this.llb_down.Enabled = true;
            }
        }
        private void BindData()
        {
            this._pageInfo.PageSize = 200;
            this._pageInfo.RecordCount = _task.TaskStation.GetVW_StatuionList(_sql, this._params);
            this._VWstationSource = _task.TaskStation.GetVW_StatuionList(this._sql, this._params, (_pageInfo.PageSize * (_pageInfo.CurrentPageIndex - 1)), _pageInfo.PageSize);
            this.SetPageLabel();
            this.lv_main.Items.Clear();
            this.il_main.Images.Clear();
            this.lv_main.View = View.Tile;
            this.lv_main.TileSize = new Size(200, 40);
            this.lv_main.LargeImageList = this.il_main;
            this.lv_main.BeginUpdate();
            if (File.Exists(_ICOPath))
            {
                Image _im = Image.FromFile(_ICOPath);
                this.il_main.Images.Add("ICO", _im);
                this.il_main.ImageSize = new Size(22, 32);
            }
            else
            {
                MessageBox.Show("图标缺失！");
            }
            foreach (var item in this._VWstationSource)
            {
                ListViewItem _lvi = new ListViewItem();
                _lvi.ImageKey = "ICO";
                _lvi.Tag = item;
                _lvi.Text = item.Name;
                _lvi.SubItems.Add(item.AreaInfoName);
                _lvi.SubItems.Add(item.OrganisationName);
                _lvi.Group = this.lv_main.Groups[item.OrganisationID.ToString()];
                this.lv_main.Items.Add(_lvi);
            }
            this.lv_main.EndUpdate();
            this.lv_main.ShowGroups = true;
            this.VW_StatuionBindingSource.DataSource = this._VWstationSource;
            this.rv_main.RefreshReport();
        }
        /// <summary>
        /// 选择、更换GST文件
        /// </summary>
        private void SetGST()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "*.gst";
            openFileDialog1.InitialDirectory = appDirectory;
            openFileDialog1.Filter = "geoset file (*.gst)|*.gst";

            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == "")
                return;
            axMap1.GeoSet = openFileDialog1.FileName;
            this.axMap1.TitleText = "";
            this.NewUserLayer(this.m_layerName);
            this._config.GstPath = openFileDialog1.FileName.Replace(this.mapDefaultDirectory, "");
            _task.TaskConfig.SetConfig(this._config);
        }
        /// <summary>
        /// 初始化地图位置
        /// </summary>
        /// <returns></returns>
        private bool SetMapxDefaultSite()
        {

            try
            {
                axMap1.ZoomTo(
                    _config.Zoom,
                    _config.CenterX,
                   _config.CenterY
                    );
            }
            catch
            {
                MessageBox.Show("未设置默认位置，请点击“系统设置”下的“保存默认位置”功能。");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 初始化Mapx
        /// </summary>
        /// <returns></returns>
        private bool InitMapx()
        {
            bool _return = false;
            this.tsb_NoSelected.CheckOnClick = true;
            this.tsb_NoSelected.CheckedChanged += new EventHandler(toolStripButton_CheckedChanged);
            this.tsb_NoSelected.Checked = true;
            this.tsb_NoSelected.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;

            this.tsb_zoomIn.CheckOnClick = true;
            this.tsb_zoomIn.CheckedChanged += new EventHandler(toolStripButton_CheckedChanged);
            this.tsb_zoomOut.CheckOnClick = true;
            this.tsb_zoomOut.CheckedChanged += new EventHandler(toolStripButton_CheckedChanged);
            this.tsb_Pan.CheckOnClick = true;
            this.tsb_Pan.CheckedChanged += new EventHandler(toolStripButton_CheckedChanged);
            //加载地图GST
            if (File.Exists(_config.GstPath))
            {
                axMap1.GeoSet = _config.GstPath;
                this.NewUserLayer(this.m_layerName);
            }
            else if (File.Exists(this.mapDefaultDirectory + _config.GstPath))
            {
                axMap1.GeoSet = this.mapDefaultDirectory + _config.GstPath;
                this.NewUserLayer(this.m_layerName);
            }
            else
            {
                if (MessageBox.Show("未选择地图或地图路径不正确，是否现在就选择地图？", "提醒", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    this.SetGST();
                }
            }
            //设置地图标题
            this.axMap1.TitleText = "";
            //初始化地图位置
            _return = this.SetMapxDefaultSite();
            return _return;
        }
        /// <summary>
        /// 界面初始化
        /// </summary>
        public void Init()
        {
            this.SetAreaLink();
            this.SetOrganisationGroup();
            this._pageInfo.CurrentPageIndex = 1;
            this.BindData();
            this._config = _task.TaskConfig.GetConfigInfo();
            string _skinFilePath = appDirectory + "Skins\\" + this._config.Skin;
            if (!string.IsNullOrEmpty(this._config.Skin) && File.Exists(_skinFilePath))
            {
                //this.skinEngine1.SkinFile = _skinFilePath;
            }
            //初始化Mapx
            this.InitMapx();

            // this._Init = false;
        }
        #endregion
        #region Mapx 绘制
        //新建自定义图层，若存在则添加到图层集中
        public bool NewUserLayer(string layerName)
        {
            try
            {
                MapXLib.Layer layer;
                MapXLib.Fields flds = new MapXLib.FieldsClass();

                MapXLib.Point ptNew = new MapXLib.Point();
                MapXLib.Feature ftrNew = new MapXLib.Feature();
                MapXLib.FeatureFactory ff = axMap1.FeatureFactory;
                MapXLib.LayerInfo li = new MapXLib.LayerInfo();
                MapXLib.RowValues rvs = new MapXLib.RowValuesClass();
                MapXLib.Dataset ds;

                flds.AddIntegerField("ID", false);
                flds.AddStringField("Name", 50, true);
                flds.AddStringField("Address", 50, false);
                flds.AddStringField("Description", 50, false);
                flds.AddStringField("TEL", 50, false);
                flds.AddStringField("Fax", 50, false);
                flds.AddFloatField("lon", false);
                flds.AddFloatField("lat", false);

                li.Type = MapXLib.LayerInfoTypeConstants.miLayerInfoTypeTemp;
                li.AddParameter("Name", layerName);
                li.AddParameter("Fields", flds);





                layer = axMap1.Layers.Add(li);
                layer.ZoomLayer = true;
                layer.ZoomMin = 0;
                layer.ZoomMax = 200;

                axMap1.DataSets.RemoveAll();
                ds = axMap1.DataSets.Add(MapXLib.DatasetTypeConstants.miDataSetLayer, layer);


                foreach (var item in this._VWstationSourceAll)
                {
                    rvs = ds.get_RowValues(0);
                    rvs._Item("ID").Value = item.ID.ToString();
                    rvs._Item("Name").Value = item.Name;
                    rvs._Item("Address").Value = item.Address;
                    rvs._Item("Description").Value = item.Description;
                    rvs._Item("TEL").Value = item.TEL;
                    rvs._Item("Fax").Value = item.Fax;
                    rvs._Item("lon").Value = item.lon;
                    rvs._Item("lat").Value = item.lat;
                    ptNew.Set(item.lon, item.lat + 0.00005);
                    ftrNew = ff.CreateSymbol(ptNew);
                    ftrNew.Point.Set(item.lon, item.lat);
                    ftrNew.Style.SymbolType = SymbolTypeConstants.miSymbolTypeBitmap;
                    ftrNew.Style.SymbolBitmapSize = 18;
                    ftrNew.Style.SymbolBitmapTransparent = true;
                    if (!string.IsNullOrEmpty(item.ImageName))
                        ftrNew.Style.SymbolBitmapName = item.ImageName + ".bmp";
                    ftrNew = layer.AddFeature(ftrNew, rvs);

                }

                layer.LabelProperties.Dataset = ds;
                layer.LabelProperties.DataField = ds.Fields["Name"];
                layer.LabelProperties.Position = MapXLib.PositionConstants.miPositionBC;
                layer.LabelProperties.Style.TextFont.Size = 10;
                layer.LabelProperties.LabelZoom = true;
                layer.LabelProperties.LabelZoomMax = 200;
                layer.LabelProperties.LabelZoomMin = 0;
                layer.LabelProperties.Style.TextFontColor = (uint)ColorConstants.miColorBlue;
                layer.LabelProperties.Style.TextFontBackColor = (uint)ColorConstants.miColorWhite;
                layer.LabelProperties.Style.TextFontShadow = true;
                layer.LabelProperties.Style.TextFontHalo = true;
                layer.LabelProperties.Offset = 16;
                layer.AutoLabel = true;
                axMap1.Refresh();
                return true;
            }
            catch (Exception ex)
            {
                Log.FileOperation.WriteErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion
        private void SetMapFull()
        {
            MainForm _fullForm = this;
            if (!this._isFullPlay)
            {
                this.Visible = false;

                _fullForm.TopMost = true;
                _fullForm.WindowState = FormWindowState.Maximized;
                _fullForm.FormBorderStyle = FormBorderStyle.None;
                _fullForm.tsc_main.TopToolStripPanelVisible = false;
                _fullForm.tsb_fullShowMap.Text = "退出全屏";
                _fullForm.eP_siteList.Expand = false;
                _fullForm.FormClosed += new FormClosedEventHandler(
                    (sender1, e1) =>
                    {
                        this.Visible = true;
                    }
                    );
                _fullForm.Show();
                _fullForm.Focus();
                this._isFullPlay = true;
            }
            else
            {
                _fullForm.TopMost = false;
                _fullForm.FormBorderStyle = FormBorderStyle.Sizable;
                _fullForm.tsb_fullShowMap.Text = "地图全屏";
                this.Visible = true;
                this._isFullPlay = false;
                _fullForm = null;
            }
        }
        #region 权限控制
        private void SetMenu()
        {
            AuthortyControl _ac = AuthortyControl.Init();
            this.tsmi_infoManage.Visible = _ac.Control.GetAuthority("InfoManege");
            this.tsmi_organisationList.Visible = _ac.Control.GetAuthority("OrganisationInfoManege");
            this.tsmi_areas.Visible = _ac.Control.GetAuthority("AreaInfoManege");
            this.tsmi_stationList.Visible = _ac.Control.GetAuthority("StationInfoManege");
            _ac.Dispose();
        }
        #endregion

        private void axMap1_DblClick(object sender, EventArgs e)
        {
            if (this.axMap1.CurrentTool.Equals(ToolConstants.miArrowTool))
            {
                MapXLib.Layer layer = axMap1.Layers[this.m_layerName];
                MapXLib.Point _point = new MapXLib.Point();
                _point.Set(this.currentMapx, this.currentMapy);
                Features ftrs = layer.SearchAtPoint(_point);
                if (ftrs != null)
                {
                    foreach (MapXLib.Feature ftr in ftrs)
                    {

                        var _stations = this._VWstationSource.Where(m => m.Name.Equals(ftr.Name));
                        foreach (var item in _stations)
                        {
                            //float x = 0;
                            //float y = 0;
                            //double FX = item.lon;
                            //double FY = item.lat;
                            //axMap1.ConvertCoord(ref x, ref  y, ref FX, ref FY, MapXLib.ConversionConstants.miMapToScreen);

                            string _str = "";
                            if (!string.IsNullOrEmpty(item.Name))
                                _str += "网店名称:" + item.Name + "\r\n";
                            if (!string.IsNullOrEmpty(item.OrganisationName))
                                _str += "所属机构:" + item.OrganisationName + "\r\n";
                            if (!string.IsNullOrEmpty(item.AreaInfoName))
                                _str += "所属区域:" + item.AreaInfoName + "\r\n";
                            if (!string.IsNullOrEmpty(item.TEL))
                                _str += "电    话:" + item.TEL + "\r\n";
                            if (!string.IsNullOrEmpty(item.Fax))
                                _str += "传    真:" + item.Fax + "\r\n";
                            if (!string.IsNullOrEmpty(item.Address))
                                _str += "地    址:" + item.Address + "\r\n";
                            if (!string.IsNullOrEmpty(item.StationInfoPrincipal))
                                _str += "负 责 人:" + item.StationInfoPrincipal + "\r\n";
                            if (!string.IsNullOrEmpty(item.StationInfoPrincipalTEL))
                                _str += "负责人电话:" + item.StationInfoPrincipalTEL;
                            if ((this.currentMousex > 0) && (this.currentMousex <= this.axMap1.Width) && (this.currentMousey > 0) && (this.currentMousey <= this.axMap1.Height))
                            {

                                this.MapToolTip.Active = false;
                                this.MapToolTip.IsBalloon = true;
                                this.MapToolTip.SetToolTip(this.axMap1, _str);
                                this.MapToolTip.Active = true;
                                this.MapToolTip.Show(_str, this.axMap1, (int)this.currentMousex, (int)this.currentMousey);

                            }
                        }

                    }

                }
            }
        }


        #endregion

        private void axMap1_MapViewChanged(object sender, EventArgs e)
        {
            if (!this._isRemoveToolTip)
            {
                this._isRemoveToolTip = true;
                return;
            }
            if (this.MapToolTip.Active)
            {
                this.MapToolTip.Active = false;
            }
        }



        private void lv_main_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {

        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (this.MapToolTip.Active)
            {
                this.MapToolTip.Active = false;
            }
        }

        private void 树形测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree _tr = new tree();
            _tr.Show();
        }
        #region 备份代码

        //private void lv_main_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        //{

        //    VW_Statuion _vws = e.Item.Tag as VW_Statuion;
        //    if (_vws != null)
        //    {
        //        ToolTip _tt = new ToolTip();
        //        _tt.IsBalloon = true;
        //        _tt.InitialDelay = 1000;
        //        string _str = "";
        //        _str += "网店名称:" + _vws.Name + "\r\n";
        //        _str += "所属机构:" + _vws.OrganisationName + "\r\n";
        //        _str += "所属区域:" + _vws.AreaInfoName + "\r\n";
        //        _str += "电    话:" + _vws.TEL + "\r\n";
        //        _str += "传    真:" + _vws.Fax + "\r\n";
        //        _str += "地    址:" + _vws.Address + "\r\n";
        //        _str += "负 责 人:" + _vws.StationInfoPrincipal + "\r\n";
        //        _str += "负责人电话:" + _vws.StationInfoPrincipalTEL;
        //        _tt.SetToolTip(this.lv_main, _str);
        //    }


        //}
        //private void SetToolTip(bool _select)
        //{


        //    this.Enabled = false;
        //    MapXLib.Layer layer = axMap1.Layers[this.m_layerName];
        //    layer.Selection.ClearSelection();
        //    if (_select)
        //    {
        //        if (this._VWstationSource.Count > 30)
        //            if (MessageBox.Show("当前需要显示的网点数大于30个，显示便签可能会比较慢，是否继续？", "提醒", MessageBoxButtons.YesNo).Equals(DialogResult.No))
        //                return;

        //        MapXLib.Features ftrs = null;
        //        foreach (var item in this._VWstationSource)
        //        {
        //            MapXLib.Features _ftr = layer.Search("Name=\"" + item.Name + "\"");
        //            if (ftrs == null)
        //            {
        //                ftrs = _ftr;
        //            }
        //            else
        //            {
        //                foreach (var _item in _ftr)
        //                {
        //                    ftrs.Add(_item);
        //                }
        //            }
        //        }
        //        if (ftrs != null)
        //            layer.Selection.Add(ftrs);
        //        // if (layer.Selection.Count > 0)
        //        // this._isFShowing = true;
        //    }
        //    else
        //    {
        //        //this._isFShowing = false;
        //    }
        //    this.Enabled = true;

        //}
        //private void ShowToolTip()
        //{
        //    MapXLib.Layer layer = axMap1.Layers[this.m_layerName];
        //    foreach (var item in this._toolTips)
        //    {
        //        item.Dispose();
        //    }
        //    this._toolTips.Clear();
        //    foreach (MapXLib.Feature ftr in layer.Selection)
        //    {

        //        var _stations = this._VWstationSource.Where(m => m.Name.Equals(ftr.Name));
        //        foreach (var item in _stations)
        //        {
        //            float x = 0;
        //            float y = 0;
        //            double FX = item.lon;
        //            double FY = item.lat;
        //            axMap1.ConvertCoord(ref x, ref  y, ref FX, ref FY, MapXLib.ConversionConstants.miMapToScreen);

        //            string _str = "";
        //            _str += "网店名称:" + item.Name + "\r\n";
        //            _str += "所属机构:" + item.OrganisationName + "\r\n";
        //            _str += "所属区域:" + item.AreaInfoName + "\r\n";
        //            _str += "电    话:" + item.TEL + "\r\n";
        //            _str += "传    真:" + item.Fax + "\r\n";
        //            _str += "地    址:" + item.Address + "\r\n";
        //            _str += "负 责 人:" + item.StationInfoPrincipal + "\r\n";
        //            _str += "负责人电话:" + item.StationInfoPrincipalTEL;
        //            if ((x > 0) && (x <= this.axMap1.Width) && (y > 0) && (y <= this.axMap1.Height))
        //            {
        //                ToolTip _tip = new ToolTip();
        //                _tip.Active = false;
        //                _tip.IsBalloon = true;
        //                _tip.ShowAlways = true;
        //                _tip.SetToolTip(this.axMap1, _str);
        //                _tip.Active = true;
        //                _tip.Show(_str, this.axMap1, (int)x, (int)y);
        //                //_tip.Active = false;
        //                this._toolTips.Add(_tip);
        //            }
        //        }
        //        if (layer.Selection.Count > 0)
        //        {
        //            // this._isFShowing = true;
        //        }
        //    }
        //}
        #endregion
    }
}
