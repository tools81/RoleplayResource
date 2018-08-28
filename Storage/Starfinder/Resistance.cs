using System;
using System.Xml;
using System.Xml.Serialization;

namespace Storage.Starfinder
{
    [Serializable()]
    public class Resistance
    {
        [XmlAttribute("Type")]
        public Enums.ResistanceType Type { get; set; }
        [XmlAttribute("Value")]
        public int Value { get; set; }
    }
}
