using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Storage.Starfinder
{
    [Serializable()]
    public class Armor
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        public int Level { get; set; }
        public Enums.ArmorType Type { get; set; }
        public int Value { get; set; }
        public int EAC { get; set; }
        public int KAC { get; set; }
        public int MaxDex { get; set; }
        public int Penalty { get; set; }
        public int SpeedAdjust { get; set; }
        public int UpgradeSlots { get; set; }
        public string Bulk { get; set; }
        public string Description { get; set; }
    }
}
