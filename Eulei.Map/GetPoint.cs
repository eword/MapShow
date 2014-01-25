using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskInterface;
using MapXLib;
using AxMapXLib;
using Eulei.Map.Code;
using System.IO;
namespace Eulei.Map
{

    public partial class GetPoint : Form
    {
        #region 变量  
        string mapDefaultDirectory = AppDomain.CurrentDomain.BaseDirectory + "map\\";
        Task _task = Task.Init();
        Config _config;
        string _title;
        double x = 0;
        double y = 0;
        public event GetPointCloedEventHandler GetPointCloed;
        public void OnGetPointCloed(EuleiPointEventArgs e)
        {
            if (this.GetPointCloed != null)
            {
                this.GetPointCloed(this,e);
            }
        }
        #endregion
        public GetPoint()
        {
            InitializeComponent();
            this._title = this.Text = "坐标选择：";
            this._config = _task.TaskConfig.GetConfigInfo();
            //加载地图GST
            if (File.Exists(_config.GstPath))
            {
                axMap1.GeoSet = _config.GstPath;
            }
            else if (File.Exists(this.mapDefaultDirectory + _config.GstPath))
            {
                axMap1.GeoSet = this.mapDefaultDirectory + _config.GstPath;
            }
            else
            {
                if (MessageBox.Show("未选择地图或地图路径不正确，是否现在就选择地图？", "提醒", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    this.SetGST();
                }
            }
            //初始化地图位置
             this.SetMapxDefaultSite();
            //设置地图标题
            this.axMap1.TitleText = "泉州市";
            this.axMap1.CurrentTool = ToolConstants.miPanTool;
        }

        private void axMap1_DblClick(object sender, EventArgs e)
        {
            this.Close();
            this.OnGetPointCloed(new EuleiPointEventArgs() { Lon=x,Lat=y,Zoom=axMap1.Zoom});
        
          
        }
        /// <summary>
        /// 选择、更换GST文件
        /// </summary>
        private void SetGST()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "*.gst";

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


        private void axMap1_MouseMoveEvent(object sender, CMapXEvents_MouseMoveEvent e)
        {
            axMap1.ConvertCoord(ref e.x, ref  e.y, ref x, ref y, MapXLib.ConversionConstants.miScreenToMap);
            this.Text = this._title + "(" + string.Format("X:{0} Y:{1}", x, y) + ")";
        }
    }
}
