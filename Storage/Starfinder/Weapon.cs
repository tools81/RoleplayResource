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
    public class Weapon
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        public int Level { get; set; }
        public Enums.WeaponType Type { get; set; }
        public Enums.WeaponCategory Category { get; set; }
        public int Value { get; set; }        
        public string Damage { get; set; }
        public string Critical { get; set; }
        public string Range { get; set; }
        public string Ammo { get; set; }
        public string Bulk { get; set; }
        public List<Enums.WeaponSpecial> Specials { get; set; }
        public string Description { get; set; }
        [XmlIgnore()]
        public int Attack { get; set; }
        [XmlIgnore()]
        public int AttackBonus { get; set; }
        [XmlIgnore()]
        public int DamageBonus { get; set; }
    }
}
