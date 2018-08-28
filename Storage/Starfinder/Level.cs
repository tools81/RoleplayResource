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
    public class Level
    {
        [XmlAttribute("Value")]
        public int Value { get; set; }
        public List<Bonus> Bonuses { get; set; }
        public SpellsPerDay SpellsPerDay { get; set; }
    }
}
