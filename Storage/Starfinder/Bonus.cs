using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Storage.Starfinder
{
    [Serializable()]
    public class Bonus
    {
        [XmlAttribute("Type")]
        public Enums.BonusType Type { get; set; }
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Value")]
        public int Value { get; set; }
        public List<BonusLimitation> Limitations { get; set; }

        public Bonus()
        {
            Limitations = new List<BonusLimitation>();
        }
    }

    [Serializable()]
    public class BonusLimitation
    {
        [XmlAttribute("Type")]
        public string Type { get; set; }
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Value")]
        public int Value { get; set; }
    }
}
