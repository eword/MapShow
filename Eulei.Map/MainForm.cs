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
using WHC.Pager.Entity;
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
        //皮肤路径
        string skinDirectory = AppDomain.CurrentDomain.BaseDirectory + "Skins\\";
        //初始化MEF操作类
        Task _task = Task.Init();
        List<VW_Statuion> _VWstationSource;
        List<AreaInfo> _areas;
        Config _config;
        ToolTip MapToolTip = new ToolTip();
        PagerInfo _pageInfo = new PagerInfo();
        string _sql = "1=1";
        ImageList il_main = new ImageList();
        string _ICOPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\ICO.png";
        object[] _params = new string[] { "" };
        List<ToolTip> _toolTips = new List<ToolTip>();
        bool _Init = true;
        bool _isFShowing = false;
        bool _isFullPlay = false;
        
        #endregion
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = false;
            this.Init();
            this.SetMenu();
        }
        #region Event
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

        private void axMap1_MouseMoveEvent(object sender, AxMapXLib.CMapXEvents_MouseMoveEvent e)
        {
            double x = 0;
            double y = 0;

            axMap1.ConvertCoord(ref e.x, ref  e.y, ref x, ref y, MapXLib.ConversionConstants.miScreenToMap);
            toolStripStatusLabel1.Text = string.Format("X:{0} Y:{1}(mouseX:{2} mouseY{3})", x, y, e.x, e.x, e.y);
        }
        private void axMap1_SelectionChanged(object sender, EventArgs e)
        {

            this.ShowToolTip();
        }



        private void tsmi_openGST_Click(object sender, EventArgs e)
        {
            this.SetGST();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyUp+=MainForm_KeyUp;            
            this.rv_main.RefreshReport();
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

        void _gp_GetPointCloed(object sender, EuleiPointEventArgs e)
        {
            MessageBox.Show(e.Lat.ToString() + "||" + e.Lon.ToString());
        }
        //private void dgv_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var _str = this.dgv_Main.SelectedCells[0].Value.ToString();
        //    var _item = this._VWstationSource.Where(m => m.Name.Equals(_str)).First();
        //    axMap1.ZoomTo(axMap1.Zoom, _item.lon, _item.lat);
        //}

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
        private void llb_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this._pageInfo.CurrenetPageIndex--;
            this.BindData();
        }

        private void llb_down_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this._pageInfo.CurrenetPageIndex++;
            this.BindData();
        }
        private void llb_first_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this._pageInfo.CurrenetPageIndex = 1;
            this.BindData();
        }

        private void llb_last_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int _i = this._pageInfo.RecordCount / this._pageInfo.PageSize + (this._pageInfo.RecordCount % this._pageInfo.PageSize > 0 ? 1 : 0);
            this._pageInfo.CurrenetPageIndex = _i;
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
                VW_Statuion _vws = info.Item.Tag as VW_Statuion;
                if (_vws == null)
                {
                    return;
                }
                MapXLib.Layer layer = axMap1.Layers[this.m_layerName];
                MapXLib.Features ftrs = layer.Search("Name=\"" + _vws.Name + "\"");
                axMap1.ZoomTo(axMap1.Zoom, _vws.lon, _vws.lat);
                layer.Selection.ClearSelection();
                if (ftrs != null)
                layer.Selection.Add(ftrs);
            }

        }

        private void lv_main_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {

            VW_Statuion _vws = e.Item.Tag as VW_Statuion;
            if (_vws != null)
            {
                ToolTip _tt = new ToolTip();
                _tt.IsBalloon = true;
                _tt.InitialDelay = 1000;
                string _str = "";
                _str += "网店名称:" + _vws.Name + "\r\n";
                _str += "所属机构:" + _vws.OrganisationName + "\r\n";
                _str += "所属区域:" + _vws.AreaInfoName + "\r\n";
                _str += "电    话:" + _vws.TEL + "\r\n";
                _str += "传    真:" + _vws.Fax + "\r\n";
                _str += "地    址:" + _vws.Address + "\r\n";
                _str += "负 责 人:" + _vws.StationInfoPrincipal + "\r\n";
                _str += "负责人电话:" + _vws.StationInfoPrincipalTEL;
                _tt.SetToolTip(this.lv_main, _str);
            }

        }
        #endregion
        #region 自定义函数
        #region 初始化
        private void SetToolTip(bool _select)
        {
           
               
                this.Enabled = false;
                MapXLib.Layer layer = axMap1.Layers[this.m_layerName];
                layer.Selection.ClearSelection();
                if (_select)
                {
                    if (this._VWstationSource.Count > 30)
                        if (MessageBox.Show("当前需要显示的网点数大于30个，显示便签可能会比较慢，是否继续？", "提醒", MessageBoxButtons.YesNo).Equals(DialogResult.No))
                            return;

                    MapXLib.Features ftrs = null;
                    foreach (var item in this._VWstationSource)
                    {
                        MapXLib.Features _ftr = layer.Search("Name=\"" + item.Name + "\"");
                        if (ftrs == null)
                        {
                            ftrs = _ftr;
                        }
                        else
                        {
                            foreach (var _item in _ftr)
                            {
                                ftrs.Add(_item);
                            }
                        }
                    }
                    if (ftrs!=null)
                    layer.Selection.Add(ftrs);
                    if( layer.Selection.Count>0)
                    this._isFShowing = true;
                }
                else
                {
                    this._isFShowing = false;
                }
                this.Enabled = true;
          
        }
        private void ShowToolTip()
        {
            MapXLib.Layer layer = axMap1.Layers[this.m_layerName];
            foreach (var item in this._toolTips)
            {
                item.Dispose();
            }
            this._toolTips.Clear();
            foreach (MapXLib.Feature ftr in layer.Selection)
            {

                var _stations = this._VWstationSource.Where(m => m.Name.Equals(ftr.Name));
                foreach (var item in _stations)
                {
                    float x = 0;
                    float y = 0;
                    double FX = item.lon;
                    double FY = item.lat;
                    axMap1.ConvertCoord(ref x, ref  y, ref FX, ref FY, MapXLib.ConversionConstants.miMapToScreen);

                    string _str = "";
                    _str += "网店名称:" + item.Name + "\r\n";
                    _str += "所属机构:" + item.OrganisationName + "\r\n";
                    _str += "所属区域:" + item.AreaInfoName + "\r\n";
                    _str += "电    话:" + item.TEL + "\r\n";
                    _str += "传    真:" + item.Fax + "\r\n";
                    _str += "地    址:" + item.Address + "\r\n";
                    _str += "负 责 人:" + item.StationInfoPrincipal + "\r\n";
                    _str += "负责人电话:" + item.StationInfoPrincipalTEL;
                    if ((x > 0) && (x <= this.axMap1.Width) && (y > 0) && (y <= this.axMap1.Height))
                    {
                        ToolTip _tip = new ToolTip();
                        _tip.Active = false;
                        _tip.IsBalloon = true;
                        _tip.ShowAlways = true;
                        _tip.SetToolTip(this.axMap1, _str);
                        _tip.Active = true;
                        _tip.Show(_str, this.axMap1, (int)x, (int)y);
                        //_tip.Active = false;
                        this._toolTips.Add(_tip);
                    }
                }
                if (layer.Selection.Count > 0)
                {
                    this._isFShowing = true;
                }
            }
        }
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

                            _pageInfo.CurrenetPageIndex = 1;
                            this.BindData();
                            this.SetToolTip(true);                    

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
            int _i3 = this._pageInfo.CurrenetPageIndex;
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
            this._pageInfo.PageSize = 50;
            this._pageInfo.RecordCount = _task.TaskStation.GetVW_StatuionList(_sql, this._params);
            this._VWstationSource = _task.TaskStation.GetVW_StatuionList(this._sql, this._params, (_pageInfo.PageSize * (_pageInfo.CurrenetPageIndex - 1)), _pageInfo.PageSize);
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
            this._config.GstPath = openFileDialog1.FileName;
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
            }
            else
            {
                if (MessageBox.Show("未选择地图或地图路径不正确，是否现在就选择地图？", "提醒", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    this.SetGST();
                }
            }
            //设置地图标题
            this.axMap1.TitleText = "泉州市";
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
            this._pageInfo.CurrenetPageIndex = 1;
            this.BindData();
            this._config = _task.TaskConfig.GetConfigInfo();
            string _skinFilePath = appDirectory + "Skins\\" + this._config.Skin;
            if (!string.IsNullOrEmpty(this._config.Skin) && File.Exists(_skinFilePath))
            {
                //this.skinEngine1.SkinFile = _skinFilePath;
            }
            //初始化Mapx
            this.InitMapx();
            this.NewUserLayer(this.m_layerName);
            this._Init = false;
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


                axMap1.DataSets.RemoveAll();
                ds = axMap1.DataSets.Add(MapXLib.DatasetTypeConstants.miDataSetLayer, layer);


                foreach (var item in this._VWstationSource)
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
                    ptNew.Set(item.lon, item.lat + 0.0001);
                    ftrNew = ff.CreateSymbol(ptNew);
                    ftrNew.Point.Set(item.lon, item.lat);
                    ftrNew.Style.SymbolType = SymbolTypeConstants.miSymbolTypeBitmap;
                    ftrNew.Style.SymbolBitmapSize = 18;
                    ftrNew.Style.SymbolBitmapTransparent = true;
                    ftrNew.Style.SymbolBitmapName = "myStation.bmp";
                    ftrNew = layer.AddFeature(ftrNew, rvs);

                }

                layer.LabelProperties.Dataset = ds;
                layer.LabelProperties.DataField = ds.Fields["Name"];
                layer.LabelProperties.Position = MapXLib.PositionConstants.miPositionBC;
                layer.LabelProperties.Style.TextFont.Size = 14;
                layer.LabelProperties.Style.TextFontColor = 255555;

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

        private void lv_main_DoubleClick(object sender, EventArgs e)
        {

        }


        #region 权限控制
        private void SetMenu()
        { 
            AuthortyControl _ac=AuthortyControl.Init();
            this.tsmi_infoManage.Visible = _ac.Control.GetAuthority("InfoManege");
            this.tsmi_organisationList.Visible = _ac.Control.GetAuthority("OrganisationInfoManege");
            this.tsmi_areas.Visible = _ac.Control.GetAuthority("AreaInfoManege");
            this.tsmi_stationList.Visible = _ac.Control.GetAuthority("StationInfoManege");
            _ac.Dispose();
        }
        #endregion





        #endregion

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

        private void axMap1_DblClick(object sender, EventArgs e)
        {

        }
    

        private void axMap1_MapViewChanged(object sender, EventArgs e)
        {

            if (!this._Init)
            {
                this.ShowToolTip();

            }
        }

        private void tsb_showAllTip_Click(object sender, EventArgs e)
        {
            this.SetToolTip(true);
        }

        private void tsb_hideAllTip_Click(object sender, EventArgs e)
        {
            this.SetToolTip(false);
        }

        private void axMap1_ToolUsed(object sender, CMapXEvents_ToolUsedEvent e)
        {
            if (this.axMap1.CurrentTool.Equals(ToolConstants.miArrowTool))
            {
                MapXLib.Layer layer = axMap1.Layers[this.m_layerName];               
                MapXLib.Point _point = new MapXLib.Point();
                _point.Set(e.x1, e.y1);
                Features ftrs = layer.SearchAtPoint(_point);
                if(ftrs!=null)
                layer.Selection.ClearSelection();
                if (ftrs != null)
                layer.Selection.Add(ftrs);
            }
        }

 

        private void SetMapFull()
        {
            if (!this._isFullPlay)
            {
                this.TopMost = true;
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
               // this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);             
               
                this.tsc_main.TopToolStripPanelVisible = false;
                this.tsb_fullShowMap.Text = "退出全屏";
                this.eP_siteList.Expand = false;
                this.Focus();
                this._isFullPlay = !this._isFullPlay;        
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.TopMost = false;
                this.tsc_main.TopToolStripPanelVisible = true;
                this.tsb_fullShowMap.Text = "地图全屏";
                this.eP_siteList.Expand = true;
                this.Focus();
                this._isFullPlay = !this._isFullPlay;
                //this.ShowInTaskbar = true;
            }                  
        }
        private void tsb_fullShowMap_Click(object sender, EventArgs e)
        {
            this.SetMapFull();
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

        //private void MainForm_Leave(object sender, EventArgs e)
        //{
        //    MessageBox.Show("leave");
        //    this.SetToolTip(false);
        //}

        private void MainForm_Activated(object sender, EventArgs e)
        {
            //this.SetToolTip(true);
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {            
            this.SetToolTip(false);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Deactivate -= MainForm_Deactivate;
        }

























    }
}
