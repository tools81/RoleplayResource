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
    public class SpellsPerDay
    {
        [XmlAttribute("First")]
        public int First { get; set; }
        [XmlAttribute("Second")]
        public int Second { get; set; }
        [XmlAttribute("Third")]
        public int Third { get; set; }
        [XmlAttribute("Fourth")]
        public int Fourth { get; set; }
        [XmlAttribute("Fifth")]
        public int Fifth { get; set; }
        [XmlAttribute("Sixth")]
        public int Sixth { get; set; }
    }
}
