using System;
using System.Linq;
using Storage.Starfinder;
using Rules.Events;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using DataLayer;

namespace Rules.Starfinder
{
    public class CreateCharacter
    {
        public static event UpdateCharacterDelegate _characterUpdateHandler;
        public static UpdateCharacterListener _updateCharacterListener;
        private static Character _character = new Character();

        public CreateCharacter()
        {
            _updateCharacterListener = new UpdateCharacterListener();
            _characterUpdateHandler += new UpdateCharacterDelegate(_updateCharacterListener.Handle);
        }

        public static Character GetNewCharacter()
        {           
            _character.Name = String.Empty;
            _character.PlayerName = String.Empty;
            _character.Level = 1;
            _character.SkillPointsPerLevel = 0;
            _character.Credits = 1000;
            _character.Alignment = Enums.Alignment.Neutral;
            _character.Size = Enums.CharacterSize.Medium;

            _character.AbilityScores.Add(new AbilityScore { Name = Enums.AbilityScores.Strength, Abbreviation = "STR", Score = 10 });
            _character.AbilityScores.Add(new AbilityScore { Name = Enums.AbilityScores.Dexterity, Abbreviation = "DEX", Score = 10 });
            _character.AbilityScores.Add(new AbilityScore { Name = Enums.AbilityScores.Constitution, Abbreviation = "CON", Score = 10 });
            _character.AbilityScores.Add(new AbilityScore { Name = Enums.AbilityScores.Intelligence, Abbreviation = "INT", Score = 10 });
            _character.AbilityScores.Add(new AbilityScore { Name = Enums.AbilityScores.Wisdom, Abbreviation = "WIS", Score = 10 });
            _character.AbilityScores.Add(new AbilityScore { Name = Enums.AbilityScores.Charisma, Abbreviation = "CHA", Score = 10 });

            _character.Skills.Add(new Skill { Name = Enums.Skills.Acrobatics, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Dexterity });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Athletics, Rank = 0, ClassBonus = 0,  MiscMod = 0, Ability = Enums.AbilityScores.Strength });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Bluff, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Charisma });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Computers, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Intelligence });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Culture, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Intelligence });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Diplomacy, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Charisma });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Disguise, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Charisma });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Engineering, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Intelligence });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Intimidate, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Charisma });
            _character.Skills.Add(new Skill { Name = Enums.Skills.LifeScience, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Intelligence });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Medicine, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Intelligence });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Mysticism, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Wisdom });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Perception, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Wisdom });
            _character.Skills.Add(new Skill { Name = Enums.Skills.PhysicalScience, Rank = 0, ClassBonus = 0,  MiscMod = 0, Ability = Enums.AbilityScores.Intelligence });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Piloting, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Dexterity });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Profession1, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Intelligence });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Profession2, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Intelligence });
            _character.Skills.Add(new Skill { Name = Enums.Skills.SenseMotive, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Wisdom });
            _character.Skills.Add(new Skill { Name = Enums.Skills.SleightOfHand, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Dexterity });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Stealth, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Dexterity });
            _character.Skills.Add(new Skill { Name = Enums.Skills.Survival, Rank = 0, ClassBonus = 0, MiscMod = 0, Ability = Enums.AbilityScores.Wisdom });

            _character.Weapons.Add(new Weapon { Name = null });
            _character.Weapons.Add(new Weapon { Name = null });
            _character.Weapons.Add(new Weapon { Name = null });
            _character.Weapons.Add(new Weapon { Name = null });

            _character.Armor.Name = null;

            _character.Init.MiscMod = 0;

            FulfillAbilityScoreRequirements(_character);
            
            return _character;
        }

        private static void FulfillAbilityScoreRequirements(Character character)
        {
            character.Init.DexMod = character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault();
            character.ArmorClass.DexMod = character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault();
            character.Attack.DexMod = character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault();
            character.Attack.StrengthMod = character.AbilityScores.Where(x => x.Abbreviation == "STR").Select(x => x.Mod).FirstOrDefault();
            character.SavingThrow.ConMod = character.AbilityScores.Where(x => x.Abbreviation == "CON").Select(x => x.Mod).FirstOrDefault();
            character.SavingThrow.DexMod = character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault();
            character.SavingThrow.WisMod = character.AbilityScores.Where(x => x.Abbreviation == "WIS").Select(x => x.Mod).FirstOrDefault();
        }

        private static void SetSkillDetails(Character character)
        {
            if (character.Class != null && !string.IsNullOrEmpty(character.Class.Name))
            {
                var classSkills = character.Skills.Where(s => character.Class.Skills.Split('|').Contains(s.Name.ToString())).ToList();
                classSkills.Select(c => { c.ClassSkill = true; return c; }).ToList();
                character.SkillPointsPerLevel = (character.Class != null ? character.Class.SkillRanks + character.Class.SkillRankBonus : 0) 
                    + character.AbilityScores.Where(a => a.Abbreviation == "INT").Select(a => a.Mod).FirstOrDefault();
            }

            foreach (var skill in character.Skills)
            {
                skill.Total = skill.Rank + skill.ClassBonus + skill.MiscMod + character.AbilityScores.Where(x => x.Name == skill.Ability).Select(x => x.Mod).FirstOrDefault();
            }
        }
        private static void SetHealthDetails(Character character)
        {
            if (character.Class != null && character.Race != null)
            {
                character.Health.HitPoints = character.Class.HitPoints + character.Race.HitPoints;
                character.Health.Stamina = character.Class.StaminaPoints + character.Health.StaminaBonus + character.AbilityScores.Where(a => a.Abbreviation == "CON").Select(a => a.Mod).FirstOrDefault();
            }
        }

        public static void UpdateCharacter(Character character)
        {
            if (character != null)
            {
                BonusHandler.Handle(character);
                SetSkillDetails(character);
                FulfillAbilityScoreRequirements(character);
                SetHealthDetails(character);
                UpdateCharacterArgs e = new UpdateCharacterArgs(Storage.Enums.Ruleset.Starfinder, character);
                OnCharacterUpdate(e);
            }
        }

        private static void OnCharacterUpdate(UpdateCharacterArgs e)
        {
            _characterUpdateHandler?.Invoke(e);
        }

        public static Character LoadCharacter(string characterName)
        {
            using (XmlReader reader = XmlReader.Create($"{Source.Path}Starfinder/Characters/{characterName}.xml"))
            {
                while (reader.ReadToFollowing("Character"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Character));
                    var obj = serializer.Deserialize(reader);
                    if (obj is Character)
                        _character = (Character)obj;
                }
            }

            return _character;
        }

        public static void SaveCharacter()
        {
            if (!string.IsNullOrWhiteSpace(_character.Name))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Character));
                using (TextWriter writer = new StreamWriter($"{Source.Path}Starfinder/Characters/{_character.Name}.xml"))
                {
                    serializer.Serialize(writer, _character);
                }
            }
            else
            {
                DisplayValidationMessage("Please add a character name before saving.");
            }
        }

        private static void DisplayValidationMessage(string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK);
        }

        public static void Print(Storage.Enums.Ruleset ruleset)
        {
            PrintCharacter.Print(_character, ruleset);
        }
    }
}
