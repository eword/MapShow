using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eulei.Map.Code
{
    public delegate void GetPointCloedEventHandler(object sender, EuleiPointEventArgs e);
    public class EuleiPointEventArgs
    {
        public double Lon { set; get; }
        public double Lat { set; get; }
    }
}
