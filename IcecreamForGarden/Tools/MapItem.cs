using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcecreamForGarden.Tools
{
    public class MapItem
    {
        public string name { get; set; }

        public List<MapPoint> points { get; set; }
    }

    public class MapPoint
    {
        public int screenX { get; set; }

        public int screenY { get; set; }

        public int timeStamp { get; set; }

        public int timeBefore { get; set; }
    }
}
