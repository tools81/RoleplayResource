using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Storage.Starfinder
{
    [Serializable()]
    public class Race
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int HitPoints { get; set; }
        public int Speed { get; set; }
        public Enums.CharacterSize Size { get; set; }
        public List<Bonus> Bonuses { get; set; }
        public List<Resistance> Resistances { get; set; }
        [XmlIgnore()]
        public int SpeedBonus { get; set; }

        public Race()
        {
            Bonuses = new List<Bonus>();
            Resistances = new List<Resistance>();
        }
    }
}
