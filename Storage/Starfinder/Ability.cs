using Storage.Interfaces;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Storage.Starfinder
{
    [Serializable()]
    public class Ability
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Class")]
        public string Class { get; set; }
        public string Description { get; set; }
        public List<Bonus> Bonuses { get; set; }
        public List<Level> Levels { get; set; }

        public Ability()
        {
            Bonuses = new List<Bonus>();
            Levels = new List<Level>();
        }
    }
}
