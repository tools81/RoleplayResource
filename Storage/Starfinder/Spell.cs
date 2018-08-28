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
    public class Spell
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("MysticLevel")]
        public int MysticLevel { get; set; }
        [XmlAttribute("TechnoLevel")]
        public int TechnoLevel { get; set; }
        public string School { get; set; }
        public string Time { get; set; }
        public string Range { get; set; }
        public string Target { get; set; }
        public string Duration { get; set; }
        public string SavingThrow { get; set; }
        public bool Resistance { get; set; }
        public string Description { get; set; }
    }
}
