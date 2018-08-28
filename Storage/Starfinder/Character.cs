using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Interfaces;
using Rules.Events;
using System.Xml;
using System.Xml.Serialization;

namespace Storage.Starfinder
{
    [Serializable()]
    public class Character : ICharacter
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("PlayerName")]
        public string PlayerName { get; set; }
        [XmlAttribute("Level")]
        public int Level { get; set; }
        public int SkillPointsPerLevel { get; set; }
        public int Credits { get; set; }
        public Initiative Init { get; set; }
        public Health Health { get; set; }
        public ArmorClass ArmorClass { get; set; }
        public Attack Attack { get; set; }
        public SavingThrow SavingThrow { get; set; }
        public Class Class { get; set; }
        public Race Race { get; set; }
        public Theme Theme { get; set; }
        public string HomeWorld { get; set; }
        public Enums.Alignment Alignment { get; set; }
        public Deity Deity { get; set; }
        public Armor Armor { get; set; }
        public List<AbilityScore> AbilityScores { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<Feat> Feats { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Equipment> Equipments { get; set; }
        public List<Spell> Spells { get; set; }
        public Enums.Gender Gender { get; set; }
        public Enums.CharacterSize Size { get; set; }


        public Character()
        {
            Init = new Initiative();
            Health = new Health();
            ArmorClass = new ArmorClass();
            Attack = new Attack();
            SavingThrow = new SavingThrow();
            Class = new Class();
            Race = new Race();
            Theme = new Theme();
            Deity = new Deity();
            Armor = new Armor();
            AbilityScores = new List<AbilityScore>();
            Skills = new List<Skill>();
            Abilities = new List<Ability>();
            Feats = new List<Feat>();
            Weapons = new List<Weapon>();
            Equipments = new List<Equipment>();
            Spells = new List<Spell>();            
        }

        public static void UpdateCharacter(UpdateCharacterArgs e)
        {
            Character character = (Character)e._character;
            character.Name = character.Name;
        }
    }
}
