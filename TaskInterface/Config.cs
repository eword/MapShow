using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskInterface
{
    /// <summary>
    /// 地图默认配置信息
    /// </summary>
   public class Config
    {
       /// <summary>
       /// ID：int
       /// </summary>
       public int ID { set; get; }
       /// <summary>
       /// GST地图集文件路径全名
       /// </summary>
       public string GstPath { set; get; }
       /// <summary>
       /// 地图中心点X坐标：经度
       /// </summary>
       public double CenterX { set; get; }
       /// <summary>
       /// 地图中心点Y坐标：纬度
       /// </summary>
       public double CenterY { set; get; }
       /// <summary>
       /// 地图缩放倍率
       /// </summary>
       public double Zoom { set; get; }
       /// <summary>
       /// 皮肤
       /// </summary>
       public string Skin { set; get; }
    }
}
