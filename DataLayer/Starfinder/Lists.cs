using Storage.Starfinder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DataLayer.Starfinder
{
    public class Lists
    {
        public static List<Class> Classes
        {
            get
            {
                List<Class> classes = new List<Class>();

                using (XmlReader reader = XmlReader.Create($@"{Source.Path}Starfinder\Class.xml"))
                {                    
                    while (reader.ReadToFollowing("Class"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Class));
                        var obj = serializer.Deserialize(reader);
                        if (obj is Class)
                            classes.Add((Class)obj);
                    }                    
                }

                return classes;
            }
        }

        public static List<Race> Races
        {
            get
            {
                List<Race> races = new List<Race>();

                using (XmlReader reader = XmlReader.Create($@"{Source.Path}Starfinder\Race.xml"))
                {
                    while (reader.ReadToFollowing("Race"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Race));
                        var obj = serializer.Deserialize(reader);
                        if (obj is Race)
                            races.Add((Race)obj);
                    }
                }

                return races;
            }
        }

        public static List<Theme> Themes
        {
            get
            {
                List<Theme> themes = new List<Theme>();

                using (XmlReader reader = XmlReader.Create($@"{Source.Path}Starfinder\Theme.xml"))
                {
                    while (reader.ReadToFollowing("Theme"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Theme));
                        var obj = serializer.Deserialize(reader);
                        if (obj is Theme)
                            themes.Add((Theme)obj);
                    }
                }

                return themes;
            }
        }

        public static List<Deity> Deities
        {
            get
            {
                List<Deity> deities = new List<Deity>();

                using (XmlReader reader = XmlReader.Create($@"{Source.Path}Starfinder\Deity.xml"))
                {
                    while (reader.ReadToFollowing("Deity"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Deity));
                        var obj = serializer.Deserialize(reader);
                        if (obj is Deity)
                            deities.Add((Deity)obj);
                    }
                }

                return deities;
            }
        }

        public static List<Ability> Abilities
        {
            get
            {
                List<Ability> abilities = new List<Ability>();

                using (XmlReader reader = XmlReader.Create($@"{Source.Path}Starfinder\Ability.xml"))
                {
                    while (reader.ReadToFollowing("Ability"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Ability));
                        var obj = serializer.Deserialize(reader);
                        if (obj is Ability)
                            abilities.Add((Ability)obj);
                    }
                }

                return abilities;
            }
        }

        public static List<Feat> Feats
        {
            get
            {
                List<Feat> feats = new List<Feat>();

                using (XmlReader reader = XmlReader.Create($@"{Source.Path}Starfinder\Feat.xml"))
                {
                    while (reader.ReadToFollowing("Feat"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Feat));
                        var obj = serializer.Deserialize(reader);
                        if (obj is Feat)
                            feats.Add((Feat)obj);
                    }
                }

                return feats;
            }
        }

        public static List<Equipment> Equipments
        {
            get
            {
                List<Equipment> equipment = new List<Equipment>();

                using (XmlReader reader = XmlReader.Create($@"{Source.Path}Starfinder\Equipment.xml"))
                {
                    while (reader.ReadToFollowing("Equipment"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Equipment));
                        var obj = serializer.Deserialize(reader);
                        if (obj is Equipment)
                            equipment.Add((Equipment)obj);
                    }
                }

                return equipment;
            }
        }

        public static List<Weapon> Weapons
        {
            get
            {
                List<Weapon> weapons = new List<Weapon>();

                using (XmlReader reader = XmlReader.Create($@"{Source.Path}Starfinder\Weapon.xml"))
                {
                    while (reader.ReadToFollowing("Weapon"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Weapon));
                        var obj = serializer.Deserialize(reader);
                        if (obj is Weapon)
                            weapons.Add((Weapon)obj);
                    }
                }

                return weapons;
            }
        }

        public static List<Armor> Armors
        {
            get
            {
                List<Armor> armors = new List<Armor>();

                using (XmlReader reader = XmlReader.Create($@"{Source.Path}Starfinder\Armor.xml"))
                {
                    while (reader.ReadToFollowing("Armor"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Armor));
                        var obj = serializer.Deserialize(reader);
                        if (obj is Armor)
                            armors.Add((Armor)obj);
                    }
                }

                return armors;
            }
        }

        public static List<Spell> Spells
        {
            get
            {
                List<Spell> spells = new List<Spell>();

                using (XmlReader reader = XmlReader.Create($@"{Source.Path}Starfinder\Spell.xml"))
                {
                    while (reader.ReadToFollowing("Spell"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Spell));
                        var obj = serializer.Deserialize(reader);
                        if (obj is Spell)
                            spells.Add((Spell)obj);
                    }
                }

                return spells;
            }
        }

        public static List<string> Characters
        {
            get
            {
                List<string> characters = new List<string>();

                foreach (var filePath in Directory.GetFiles($@"{Source.Path}Starfinder\Characters"))
                {
                    if (!filePath.Contains(".xml"))
                        continue;
                    characters.Add(Path.GetFileNameWithoutExtension(filePath));
                }

                return characters;
            }
        }        
    }
}
