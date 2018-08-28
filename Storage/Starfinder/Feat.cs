using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Storage.Starfinder
{
    [Serializable()]
    public class Feat
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        public bool Combat { get; set; }
        public string Description { get; set; }
        public string Prereq { get; set; }
        public List<Bonus> Bonuses { get; set; }

        public Feat()
        {
            Bonuses = new List<Bonus>();
        }
    }
}
