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
    public class Theme
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Bonus> Bonuses { get; set; }

        public Theme()
        {
            Bonuses = new List<Bonus>();
        }
    }
}
