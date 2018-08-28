using Custom_Controls;
using DataLayer.Starfinder;
using Storage.Starfinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.Starfinder
{
    public static class BonusHandler
    {
        public static void Handle(Character character)
        {
            ClearBonuses(character);
            RaceBonuses(character);
            FeatBonuses(character);
            AbilityBonuses(character);
            AbilityScoreBonuses(character);
            ThemeBonuses(character);
            ClassBonuses(character);
        }

        private static void ClearBonuses(Character character)
        {
            character.AbilityScores.ForEach(a => a.ScoreBonus = 0);

            //foreach (var skill in character.Skills)
            //{
            //    skill.MiscMod = 0;

            //    if (character.Class != null && !string.IsNullOrEmpty(character.Class.Name) && !character.Class.Skills.Contains(skill.Name.ToString()))
            //        skill.ClassSkill = false;
            //}

            foreach (var resistance in character.ArmorClass.Resistances)
            {
                if (character.Race != null && !string.IsNullOrEmpty(character.Race.Name) && !character.Race.Resistances.Contains(resistance))
                    character.ArmorClass.Resistances.Remove(resistance);
            }

            //character.Init.MiscMod = 0;
            //character.SavingThrow.MiscFortitudeMod = 0;
            //character.SavingThrow.MiscWillMod = 0;
            //character.SavingThrow.MiscReflexMod = 0;
            character.Health.StaminaBonus = 0;
            //character.ArmorClass.MiscDamageReductionMod = 0;
            //character.ArmorClass.MiscKineticMod = 0;
            //character.ArmorClass.MiscKineticMod = 0;
            //if (character.Class != null && !string.IsNullOrEmpty(character.Class.Name))
            //    character.Class.SkillRankBonus = 0;
            //if (character.Race != null && !string.IsNullOrEmpty(character.Race.Name))
            //{
            //    character.Race.SpeedBonus = 0;                
            //}                
        }

        private static void RaceBonuses(Character character)
        {
            if (character.Race != null && !string.IsNullOrEmpty(character.Race.Name))
            {
                AssignBonuses(character, character.Race.Bonuses);
            }
        }

        private static void FeatBonuses(Character character)
        {
            foreach (Feat feat in character.Feats)
            {
                if (feat != null && feat.Bonuses.Count > 0)
                {
                    AssignBonuses(character, feat.Bonuses);
                }
            }
        }

        private static void AbilityBonuses(Character character)
        {
            foreach (Ability ability in character.Abilities)
            {
                if (ability != null && ability.Bonuses.Count > 0)
                {
                    AssignBonuses(character, ability.Bonuses);
                }

                if (ability != null && ability.Levels.Count > 0)
                {
                    AssignBonuses(character, ability.Levels.FirstOrDefault(l => l.Value == character.Level).Bonuses);
                }
            }
        }

        private static void AbilityScoreBonuses(Character character)
        {
            foreach (var ability in character.Abilities)
            {
                if (ability != null && ability.Bonuses.Count > 0)
                {
                    AssignBonuses(character, ability.Bonuses);
                }
            }
        }

        private static void ThemeBonuses(Character character)
        {
            if (character.Theme != null && !string.IsNullOrEmpty(character.Theme.Name))
            {
                AssignBonuses(character, character.Theme.Bonuses);
            }
        }

        private static void ClassBonuses(Character character)
        {
            if (character.Class != null && !string.IsNullOrEmpty(character.Class.Name))
            {
                AssignBonuses(character, character.Class.Bonuses);
                AssignBonuses(character, character.Class.Levels.FirstOrDefault(l => l.Value == character.Level).Bonuses);
            }
        }

        private static void AssignBonuses(Character character, List<Bonus> bonuses)
        {
            foreach (var bonus in bonuses)
            {
                if (bonus.Name == "Any")
                    break;

                switch (bonus.Type)
                {
                    case Enums.BonusType.Ability:
                        var ability = character.Abilities.FirstOrDefault(f => f.Name == bonus.Name);
                        if (ability == null)
                            character.Abilities.Add(Lists.Abilities.FirstOrDefault(f => f.Name == bonus.Name));
                        break;
                    case Enums.BonusType.AbilityScore:                        
                        character.AbilityScores.FirstOrDefault(s => s.Name.ToString() == bonus.Name).ScoreBonus += bonus.Value;
                        break;
                    case Enums.BonusType.Armor:
                        if (character.Armor != null && !string.IsNullOrEmpty(character.Armor.Name))
                        {
                            //if (bonus.Name == "Kinetic")
                            //    character.ArmorClass.MiscKineticMod += bonus.Value;
                            //if (bonus.Name == "Energy")
                            //    character.ArmorClass.MiscEnergyMod += bonus.Value;
                            //if (Enum.GetNames(typeof(Enums.ResistanceType)).Contains(bonus.Name))
                            //{
                            //    Resistance resistance = new Resistance { Type = (Enums.ResistanceType)Enum.Parse(typeof(Enums.ResistanceType), bonus.Name), Value = bonus.Value };
                            //    if (character.ArmorClass.Resistances.FirstOrDefault(r => r.Type == resistance.Type) != null)
                            //        character.ArmorClass.Resistances.FirstOrDefault(r => r.Type == resistance.Type).Value += character.Attack.AttackBonus;
                            //    else
                            //        character.ArmorClass.Resistances.Add(resistance);
                            //}
                            //if (bonus.Name == "DamageReduction")
                            //    character.ArmorClass.MiscDamageReductionMod += character.Attack.AttackBonus;
                        }
                        break;
                    case Enums.BonusType.Attack:
                        break;
                    case Enums.BonusType.Base:
                        switch (bonus.Name)
                        {
                            case "Attack":
                                character.Attack.AttackBonus = bonus.Value;
                                break;
                            case "Fortitude":
                                character.SavingThrow.BaseFortitude = bonus.Value;
                                break;
                            case "Reflex":
                                character.SavingThrow.BaseReflex = bonus.Value;
                                break;
                            case "Will":
                                character.SavingThrow.BaseWill = bonus.Value;
                                break;
                            default:
                                break;
                        }
                        break;
                    case Enums.BonusType.ClassSkill:
                        //Skill skill = character.Skills.FirstOrDefault(s => s.Name.ToString() == bonus.Name);

                        //if (skill.ClassSkill && character.Class != null && !string.IsNullOrEmpty(character.Class.Name) && character.Class.Skills.Contains(skill.Name.ToString()))
                        //    skill.MiscMod += bonus.Value;
                        //else
                        //    skill.ClassSkill = true;                      
                        break;
                    case Enums.BonusType.Damage:
                        //if (bonus.Limitations.Count > 0 && character.Weapons.Count > 0)
                        //{
                        //    List<Weapon> filteredWeapons = character.Weapons;

                        //    foreach (var limitation in bonus.Limitations)
                        //    {
                        //        if (limitation.Type == "WeaponSpecial")
                        //        {
                        //            filteredWeapons.Remove(filteredWeapons.FirstOrDefault(w => !w.Specials.Contains((Enums.WeaponSpecial)Enum.Parse(typeof(Enums.WeaponSpecial), limitation.Name))));
                        //        }
                        //    }

                        //    filteredWeapons.ForEach(w => w.DamageBonus = bonus.Value);
                        //}
                        break;
                    case Enums.BonusType.Feat:
                        //TODO Fix this
                        if (bonus.Name != "Skill Focus")
                        {
                            var feat = character.Feats.FirstOrDefault(f => f.Name == bonus.Name);
                            if (feat == null)
                                character.Feats.Add(Lists.Feats.FirstOrDefault(f => f.Name == bonus.Name));
                        }
                        else
                        {
                            //CheckboxListSelect chkSelect = new CheckboxListSelect(Enum.GetNames(typeof(Enums.Skills)), bonus.Value, Enums.BonusType.Skill.ToString());
                            //chkSelect.Show();
                            //bonus.Name = chkSelect.SelectedItem;
                            //character.Feats.Add(Lists.Feats.FirstOrDefault(s => s.Name.ToString() == $"Skill Focus - {bonus.Name}"));
                        }
                        break;
                    case Enums.BonusType.Health:
                        if (bonus.Name == "Stamina")
                            character.Health.StaminaBonus += character.Level;
                        break;
                    case Enums.BonusType.Initiative:
                        //character.Init.MiscMod += bonus.Value;
                        break;
                    case Enums.BonusType.Resolve:
                        break;
                    case Enums.BonusType.SavingThrows:
                        //if (bonus.Name == "Fortitude")
                        //    character.SavingThrow.MiscFortitudeMod += bonus.Value;
                        //if (bonus.Name == "Will")
                        //    character.SavingThrow.MiscWillMod += bonus.Value;
                        //if (bonus.Name == "Reflex")
                        //    character.SavingThrow.MiscReflexMod += bonus.Value;
                        break;
                    case Enums.BonusType.Skill:
                        //character.Skills.FirstOrDefault(s => s.Name.ToString() == bonus.Name).MiscMod += bonus.Value;
                        break;
                    case Enums.BonusType.SkillRank:
                        //if (character.Class != null && !string.IsNullOrEmpty(character.Class.Name))
                        //    character.Class.SkillRankBonus += bonus.Value;
                        break;
                    case Enums.BonusType.Speed:
                        //if (character.Armor == null || (character.Armor != null && !string.IsNullOrEmpty(character.Armor.Name) && character.Armor.Type == Enums.ArmorType.Light))
                        //    character.Race.SpeedBonus += bonus.Value;
                        break;
                    case Enums.BonusType.Spell:
                        var spell = character.Spells.FirstOrDefault(f => f.Name == bonus.Name);
                        if (spell == null)
                            character.Spells.Add(Lists.Spells.FirstOrDefault(f => f.Name == bonus.Name));
                        //TODO
                        break;
                    default:
                        break;
                }
            }
        }

        public static void SetAnyBonusValue(Bonus bonus)
        {
            if (bonus.Name == "Any")
            {
                if (bonus.Type == Enums.BonusType.AbilityScore)
                {
                    CheckboxListSelect chkSelect = new CheckboxListSelect(Enum.GetNames(typeof(Enums.AbilityScores)), bonus.Value, Enums.BonusType.AbilityScore.ToString());
                    chkSelect.ShowDialog();
                    bonus.Name = chkSelect.SelectedItem;
                }
                if (bonus.Type == Enums.BonusType.ClassSkill)
                {
                    CheckboxListSelect chkSelect = new CheckboxListSelect(Enum.GetNames(typeof(Enums.Skills)), bonus.Value, Enums.BonusType.ClassSkill.ToString());
                    chkSelect.ShowDialog();
                    bonus.Name = chkSelect.SelectedItem;
                }
                if (bonus.Type == Enums.BonusType.Skill)
                {
                    CheckboxListSelect chkSelect = new CheckboxListSelect(Enum.GetNames(typeof(Enums.Skills)), bonus.Value, Enums.BonusType.Skill.ToString());
                    chkSelect.ShowDialog();
                    bonus.Name = chkSelect.SelectedItem;
                }
            }

            if (bonus.Name == "Skill Focus")
            {

            }
        }
    }
}
