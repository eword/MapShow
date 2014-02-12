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
        //动态层名称
        string m_layerName = "tempLayer";
        public event GetPointCloedEventHandler GetPointCloed;
        public void OnGetPointCloed(EuleiPointEventArgs e)
        {
            if (this.GetPointCloed != null)
            {
                this.GetPointCloed(this, e);
            }
        }
        #endregion
        public GetPoint(MapPosition mapPosition)
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
            if (mapPosition!=null)
            {
                this.SetMapxDefaultSite(mapPosition);
            }
            else
            {
                this.SetMapxDefaultSite(null);
            }
         
            //设置地图标题
            this.axMap1.TitleText = "泉州市";
            this.axMap1.CurrentTool = ToolConstants.miPanTool;
        }

        private void axMap1_DblClick(object sender, EventArgs e)
        {
            this.Close();
            this.OnGetPointCloed(new EuleiPointEventArgs() { Lon = x, Lat = y, Zoom = axMap1.Zoom });


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
        private bool SetMapxDefaultSite(MapPosition mapPosition)
        {

            try
            {
                if (mapPosition!=null)
                {
                    axMap1.ZoomTo(
                    mapPosition.Zoom,
                    mapPosition.X,
                    mapPosition.Y
                    );
                    this.NewUserLayer(this.m_layerName, mapPosition);
                }
                else
                {
                    axMap1.ZoomTo(
                    _config.Zoom,
                    _config.CenterX,
                    _config.CenterY
                    );
                }
            
            }
            catch
            {
                MessageBox.Show("未设置默认位置，请点击“系统设置”下的“保存默认位置”功能。");
                return false;
            }
            return true;
        }
        //新建自定义图层，若存在则添加到图层集中
        public bool NewUserLayer(string layerName, MapPosition mapPosition)
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



                foreach (MapXLib.Layer item in axMap1.Layers)
                {
                    if (item.Name.Equals(layerName))
                    {
                        axMap1.Layers.Remove(item);
                    }
                }
                layer = axMap1.Layers.Add(li, -1);
                layer.ZoomLayer = true;
                layer.ZoomMin = 0;
                layer.ZoomMax = 200;

                axMap1.DataSets.RemoveAll();
                ds = axMap1.DataSets.Add(MapXLib.DatasetTypeConstants.miDataSetLayer, layer);


               
                    rvs = ds.get_RowValues(0);
                    rvs._Item("ID").Value = Guid.NewGuid();
                    rvs._Item("Name").Value = "当前位置";
                    rvs._Item("Address").Value = "";
                    rvs._Item("Description").Value = "";
                    //rvs._Item("TEL").Value = item.TEL;
                    //rvs._Item("Fax").Value = item.Fax;
                    rvs._Item("lon").Value = mapPosition.X;
                    rvs._Item("lat").Value = mapPosition.Y;
                    ptNew.Set(mapPosition.X, mapPosition.Y + 0.00005);
                    ftrNew = ff.CreateSymbol(ptNew);
                    ftrNew.Point.Set(mapPosition.X, mapPosition.Y);
                    ftrNew.Style.SymbolType = SymbolTypeConstants.miSymbolTypeBitmap;
                    ftrNew.Style.SymbolBitmapSize = 18;
                    ftrNew.Style.SymbolBitmapTransparent = true;                   
                        ftrNew.Style.SymbolBitmapName = "ico.bmp";
                    ftrNew = layer.AddFeature(ftrNew, rvs);

               

                layer.LabelProperties.Dataset = ds;
                layer.LabelProperties.DataField = ds.Fields["Name"];
                layer.LabelProperties.Position = MapXLib.PositionConstants.miPositionBC;
                layer.LabelProperties.Overlap = true;
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

        private void axMap1_MouseMoveEvent(object sender, CMapXEvents_MouseMoveEvent e)
        {
            axMap1.ConvertCoord(ref e.x, ref  e.y, ref x, ref y, MapXLib.ConversionConstants.miScreenToMap);
            this.Text = this._title + "(" + string.Format("X:{0} Y:{1}", x, y) + ")";
        }
        public class MapPosition
        {
            public double X { set; get; }
            public double Y { set; get; }
            public double Zoom { set; get; }
        }
    }
}
