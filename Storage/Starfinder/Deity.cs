using Storage.Interfaces;
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
    public class Deity
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
