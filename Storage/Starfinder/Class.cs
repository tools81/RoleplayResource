using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Storage.Starfinder
{
    [Serializable()]
    public class Class
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int HitPoints { get; set; }
        public int StaminaPoints { get; set; }
        public int SkillRanks { get; set; }
        public int SkillRankBonus { get; set; }
        public string Skills { get; set; }
        public List<Bonus> Bonuses { get; set; }
        public List<Level> Levels { get; set; }

        public Class()
        {
            Bonuses = new List<Bonus>();
            Levels = new List<Level>();
        }
    }
}
