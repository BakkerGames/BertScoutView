using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertScoutView
{
    class StandInfoItem
    {
        public int Match { get; set; }
        public string Alliance { get; set; }
        public int AutoHigh { get; set; }
        public int AutoLow { get; set; }
        public bool AutoBaseline { get; set; }
        public bool AutoPlaceGear { get; set; }
        public bool AutoOpenHopper { get; set; }

        public int TeleHigh { get; set; }
        public int TeleLow { get; set; }
        public int GearsReceived { get; set; }
        public int GearsPlaced { get; set; }
        public bool Climbed { get; set; }
        public bool Touchpad { get; set; }
        public int Penalties { get; set; }
        public string ScoutName { get; set; }
        public string Comment { get; set; }
    }
}
