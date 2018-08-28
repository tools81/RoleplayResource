using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using Storage.Starfinder;
using Storage.Interfaces;
using System.Reflection;
using DataLayer;

namespace Rules.Starfinder
{
    public static class PrintCharacter
    {
        public static void Print(Character character, Storage.Enums.Ruleset ruleset)
        {
            string characterFile = $"{Source.Path}Starfinder/Characters/{character.Name}.pdf";
            string templateDirectory = @"Starfinder/Templates/CharacterSheet.pdf";

            PdfReader reader = new PdfReader(Path.Combine(
            Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
                , templateDirectory));

            using (PdfStamper stamper = new PdfStamper(reader, new FileStream(characterFile, FileMode.Create)))
            {
                AcroFields fields = stamper.AcroFields;

                //Description
                fields.SetField("CharName", character.Name);
                fields.SetField("CLASS/LEVEL", character.Class.Name);
                fields.SetField("RACE", character.Race.Name);
                fields.SetField("THEME", character.Theme.Name);
                fields.SetField("SIZE", character.Size.ToString());
                fields.SetField("BaseMovement", character.Race.Speed.ToString());
                fields.SetField("AdjustedMovement", character.Race.SpeedBonus.ToString());
                fields.SetField("GENDER", character.Gender.ToString());
                fields.SetField("HOME WORLD", character.HomeWorld);
                fields.SetField("ALIGNMENT", character.Alignment.ToString());
                fields.SetField("DEITY", character.Deity.Name);
                fields.SetField("PLAYER", character.PlayerName);

                //Initiative
                fields.SetField("Initiative Bonus", character.Init.Total.ToString());
                fields.SetField("DEXMOD", character.Init.DexMod.ToString());
                fields.SetField("INITMISC", character.Init.MiscMod.ToString());

                //Ability Scores
                fields.SetField("STR", character.AbilityScores.Where(x => x.Abbreviation == "STR").Select(x => x.Score + x.ScoreBonus).FirstOrDefault().ToString());
                fields.SetField("STRMOD", character.AbilityScores.Where(x => x.Abbreviation == "STR").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("UPSTRMOD", "");
                fields.SetField("DEX", character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Score + x.ScoreBonus).FirstOrDefault().ToString());
                fields.SetField("DEXMOD", character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("UPDEXMOD", "");
                fields.SetField("CON", character.AbilityScores.Where(x => x.Abbreviation == "CON").Select(x => x.Score + x.ScoreBonus).FirstOrDefault().ToString());
                fields.SetField("CONMOD", character.AbilityScores.Where(x => x.Abbreviation == "CON").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("UPCONMOD", "");
                fields.SetField("INT", character.AbilityScores.Where(x => x.Abbreviation == "INT").Select(x => x.Score + x.ScoreBonus).FirstOrDefault().ToString());
                fields.SetField("INTMOD", character.AbilityScores.Where(x => x.Abbreviation == "INT").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("UPINTMOD", "");
                fields.SetField("WIS", character.AbilityScores.Where(x => x.Abbreviation == "WIS").Select(x => x.Score + x.ScoreBonus).FirstOrDefault().ToString());
                fields.SetField("WISMOD", character.AbilityScores.Where(x => x.Abbreviation == "WIS").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("UPWISMOD", "");
                fields.SetField("CHA", character.AbilityScores.Where(x => x.Abbreviation == "CHA").Select(x => x.Score + x.ScoreBonus).FirstOrDefault().ToString());
                fields.SetField("CHAMOD", character.AbilityScores.Where(x => x.Abbreviation == "CHA").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("UPCHAMOD", "");

                //Health
                fields.SetField("TOTAL STAMINA", character.Health.Stamina.ToString());
                fields.SetField("TOTAL HIT POINTS", character.Health.HitPoints.ToString());
                fields.SetField("TOTAL RESOLVE", character.Health.Resolve.ToString());

                //Skills
                fields.SetField("SKILL RANKS", (character.Class.SkillRanks + character.Class.SkillRankBonus).ToString());
                fields.SetField("ACROCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Acrobatics).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("ACROTOT", character.Skills.Where(s => s.Name == Enums.Skills.Acrobatics).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("ACRO", character.Skills.Where(s => s.Name == Enums.Skills.Acrobatics).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("ACROTRAINED", character.Skills.Where(s => s.Name == Enums.Skills.Acrobatics).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled139", character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("ACROMISC", character.Skills.Where(s => s.Name == Enums.Skills.Acrobatics).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("ATHLCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Athletics).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("ATHLTOT", character.Skills.Where(s => s.Name == Enums.Skills.Athletics).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("ATHL", character.Skills.Where(s => s.Name == Enums.Skills.Athletics).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("ATHLCB", character.Skills.Where(s => s.Name == Enums.Skills.Athletics).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled140", character.AbilityScores.Where(x => x.Abbreviation == "STR").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("ATHLMISC", character.Skills.Where(s => s.Name == Enums.Skills.Athletics).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("BLUFCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Bluff).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("BLUFFTOT", character.Skills.Where(s => s.Name == Enums.Skills.Bluff).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("BLUF", character.Skills.Where(s => s.Name == Enums.Skills.Bluff).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("BLUFCB", character.Skills.Where(s => s.Name == Enums.Skills.Bluff).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled141", character.AbilityScores.Where(x => x.Abbreviation == "CHA").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("BLUFMISC", character.Skills.Where(s => s.Name == Enums.Skills.Bluff).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("COMPCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Computers).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("COMPTOT", character.Skills.Where(s => s.Name == Enums.Skills.Computers).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("COMP", character.Skills.Where(s => s.Name == Enums.Skills.Computers).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("COMPCB", character.Skills.Where(s => s.Name == Enums.Skills.Computers).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled142", character.AbilityScores.Where(x => x.Abbreviation == "INT").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("COMPMISC", character.Skills.Where(s => s.Name == Enums.Skills.Computers).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("CULTCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Culture).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("CULTTOT", character.Skills.Where(s => s.Name == Enums.Skills.Culture).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("CULT", character.Skills.Where(s => s.Name == Enums.Skills.Culture).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("CULTCB", character.Skills.Where(s => s.Name == Enums.Skills.Culture).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled143", character.AbilityScores.Where(x => x.Abbreviation == "INT").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("CULTMISC", character.Skills.Where(s => s.Name == Enums.Skills.Culture).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("DIPLCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Diplomacy).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("DIPLOTOT", character.Skills.Where(s => s.Name == Enums.Skills.Diplomacy).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("DIPL", character.Skills.Where(s => s.Name == Enums.Skills.Diplomacy).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("DIPLCB", character.Skills.Where(s => s.Name == Enums.Skills.Diplomacy).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled144", character.AbilityScores.Where(x => x.Abbreviation == "CHA").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("DIPLOMISC", character.Skills.Where(s => s.Name == Enums.Skills.Diplomacy).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("DISGCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Disguise).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("DISGTOT", character.Skills.Where(s => s.Name == Enums.Skills.Disguise).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("DISG", character.Skills.Where(s => s.Name == Enums.Skills.Disguise).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("DISGCB", character.Skills.Where(s => s.Name == Enums.Skills.Disguise).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled145", character.AbilityScores.Where(x => x.Abbreviation == "CHA").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("DISGMISC", character.Skills.Where(s => s.Name == Enums.Skills.Disguise).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("ENGICHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Engineering).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("ENGITOT", character.Skills.Where(s => s.Name == Enums.Skills.Engineering).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("ENGI", character.Skills.Where(s => s.Name == Enums.Skills.Engineering).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("ENGICB", character.Skills.Where(s => s.Name == Enums.Skills.Engineering).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled146", character.AbilityScores.Where(x => x.Abbreviation == "INT").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("ENGIMISC", character.Skills.Where(s => s.Name == Enums.Skills.Engineering).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("INTICHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Intimidate).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("INTITOT", character.Skills.Where(s => s.Name == Enums.Skills.Intimidate).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("INTI", character.Skills.Where(s => s.Name == Enums.Skills.Intimidate).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("INTIMIDATECB", character.Skills.Where(s => s.Name == Enums.Skills.Intimidate).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("Text4", character.AbilityScores.Where(x => x.Abbreviation == "CHA").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("INTIMISC", character.Skills.Where(s => s.Name == Enums.Skills.Intimidate).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("LIFECHK_1", character.Skills.Where(s => s.Name == Enums.Skills.LifeScience).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("LIFETOT", character.Skills.Where(s => s.Name == Enums.Skills.LifeScience).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("LIFE", character.Skills.Where(s => s.Name == Enums.Skills.LifeScience).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("LIFECB", character.Skills.Where(s => s.Name == Enums.Skills.LifeScience).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("Text7", character.AbilityScores.Where(x => x.Abbreviation == "INT").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("LIFEMISC", character.Skills.Where(s => s.Name == Enums.Skills.LifeScience).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("MEDICHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Medicine).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("MEDTOT", character.Skills.Where(s => s.Name == Enums.Skills.Medicine).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("MEDI", character.Skills.Where(s => s.Name == Enums.Skills.Medicine).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("MEDICB", character.Skills.Where(s => s.Name == Enums.Skills.Medicine).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled149", character.AbilityScores.Where(x => x.Abbreviation == "INT").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("MEDIMISC", character.Skills.Where(s => s.Name == Enums.Skills.Medicine).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("MYSTCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Mysticism).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("MYSTTOT", character.Skills.Where(s => s.Name == Enums.Skills.Mysticism).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("MYST", character.Skills.Where(s => s.Name == Enums.Skills.Mysticism).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("MYSTCB", character.Skills.Where(s => s.Name == Enums.Skills.Mysticism).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled150", character.AbilityScores.Where(x => x.Abbreviation == "WIS").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("MYSTMISC", character.Skills.Where(s => s.Name == Enums.Skills.Mysticism).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("PERCCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Perception).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("PERCTOT", character.Skills.Where(s => s.Name == Enums.Skills.Perception).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("PERC", character.Skills.Where(s => s.Name == Enums.Skills.Perception).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("PERCCB", character.Skills.Where(s => s.Name == Enums.Skills.Perception).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled151", character.AbilityScores.Where(x => x.Abbreviation == "WIS").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("PERCMISC", character.Skills.Where(s => s.Name == Enums.Skills.Perception).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("PHYSCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.PhysicalScience).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("PHYSTOT", character.Skills.Where(s => s.Name == Enums.Skills.PhysicalScience).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("PHYS", character.Skills.Where(s => s.Name == Enums.Skills.PhysicalScience).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("PHYSCB", character.Skills.Where(s => s.Name == Enums.Skills.PhysicalScience).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled152", character.AbilityScores.Where(x => x.Abbreviation == "INT").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("PHYSMISC", character.Skills.Where(s => s.Name == Enums.Skills.PhysicalScience).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("PILOCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Piloting).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("PILOTOT", character.Skills.Where(s => s.Name == Enums.Skills.Piloting).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("PILO", character.Skills.Where(s => s.Name == Enums.Skills.Piloting).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("PILOCB", character.Skills.Where(s => s.Name == Enums.Skills.Piloting).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled153", character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("PILOMISC", character.Skills.Where(s => s.Name == Enums.Skills.Piloting).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("Skill_Custom1_lsclass_1", character.Skills.Where(s => s.Name == Enums.Skills.Profession1).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("Skill_Custom1_Total", character.Skills.Where(s => s.Name == Enums.Skills.Profession1).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("Skill_Custom1_Ranks", character.Skills.Where(s => s.Name == Enums.Skills.Profession1).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("Skill_Custom1_Trained", character.Skills.Where(s => s.Name == Enums.Skills.Profession1).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("Skill_Custom1_Ability", character.AbilityScores.Where(x => x.Name == character.Skills.Where(s => s.Name == Enums.Skills.Profession1).Select(s => s.Ability).FirstOrDefault()).Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("Skill_Custom1_Misc", character.Skills.Where(s => s.Name == Enums.Skills.Profession1).Select(s => s.MiscMod).FirstOrDefault().ToString());
                fields.SetField("Skill_Custom1_Option", character.AbilityScores.Where(a => a.Name == character.Skills.Where(s => s.Name == Enums.Skills.Profession1).Select(s => s.Ability).FirstOrDefault()).Select(a => a.Abbreviation).FirstOrDefault());

                fields.SetField("Skill_Custom2_lsclass_1", character.Skills.Where(s => s.Name == Enums.Skills.Profession2).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("Skill_Custom2_Total", character.Skills.Where(s => s.Name == Enums.Skills.Profession2).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("Skill_Custom2_Ranks", character.Skills.Where(s => s.Name == Enums.Skills.Profession2).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("Skill_Custom2_Trained", character.Skills.Where(s => s.Name == Enums.Skills.Profession2).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("Skill_Custom2_Ability", character.AbilityScores.Where(x => x.Name == character.Skills.Where(s => s.Name == Enums.Skills.Profession2).Select(s => s.Ability).FirstOrDefault()).Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("Skill_Custom2_Misc", character.Skills.Where(s => s.Name == Enums.Skills.Profession2).Select(s => s.MiscMod).FirstOrDefault().ToString());
                fields.SetField("Skill_Custom2_Option", character.AbilityScores.Where(a => a.Name == character.Skills.Where(s => s.Name == Enums.Skills.Profession2).Select(s => s.Ability).FirstOrDefault()).Select(a => a.Abbreviation).FirstOrDefault());

                fields.SetField("SENSCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.SenseMotive).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("SENSTOT", character.Skills.Where(s => s.Name == Enums.Skills.SenseMotive).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("SENS", character.Skills.Where(s => s.Name == Enums.Skills.SenseMotive).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("SENSCB", character.Skills.Where(s => s.Name == Enums.Skills.SenseMotive).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled156", character.AbilityScores.Where(x => x.Abbreviation == "WIS").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("SENSMISC", character.Skills.Where(s => s.Name == Enums.Skills.SenseMotive).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("SENSCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.SenseMotive).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("SENSTOT", character.Skills.Where(s => s.Name == Enums.Skills.SenseMotive).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("SENS", character.Skills.Where(s => s.Name == Enums.Skills.SenseMotive).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("SENSCB", character.Skills.Where(s => s.Name == Enums.Skills.SenseMotive).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled156", character.AbilityScores.Where(x => x.Abbreviation == "WIS").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("SENSMISC", character.Skills.Where(s => s.Name == Enums.Skills.SenseMotive).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("SOHCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.SleightOfHand).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("SOHTOT", character.Skills.Where(s => s.Name == Enums.Skills.SleightOfHand).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("SOH", character.Skills.Where(s => s.Name == Enums.Skills.SleightOfHand).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("SOHCB", character.Skills.Where(s => s.Name == Enums.Skills.SleightOfHand).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled157", character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("SOHMISC", character.Skills.Where(s => s.Name == Enums.Skills.SleightOfHand).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("STEACHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Stealth).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("STEATOT", character.Skills.Where(s => s.Name == Enums.Skills.Stealth).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("STEA", character.Skills.Where(s => s.Name == Enums.Skills.Stealth).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("STEACB", character.Skills.Where(s => s.Name == Enums.Skills.Stealth).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled158", character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("STEAMISC", character.Skills.Where(s => s.Name == Enums.Skills.Stealth).Select(s => s.MiscMod).FirstOrDefault().ToString());

                fields.SetField("SURVCHK_1", character.Skills.Where(s => s.Name == Enums.Skills.Survival).Select(s => s.ClassSkill).FirstOrDefault() == true ? "On" : "Off");
                fields.SetField("SURVTOT", character.Skills.Where(s => s.Name == Enums.Skills.Survival).Select(s => s.Total).FirstOrDefault().ToString());
                fields.SetField("SURV", character.Skills.Where(s => s.Name == Enums.Skills.Survival).Select(s => s.Rank).FirstOrDefault().ToString());
                fields.SetField("SURVCB", character.Skills.Where(s => s.Name == Enums.Skills.Survival).Select(s => s.ClassBonus).FirstOrDefault().ToString());
                fields.SetField("untitled159", character.AbilityScores.Where(x => x.Abbreviation == "WIS").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("SURVMISC", character.Skills.Where(s => s.Name == Enums.Skills.Survival).Select(s => s.MiscMod).FirstOrDefault().ToString());

                //Armor Class
                fields.SetField("DR", character.ArmorClass.DamageReduction.ToString());
                fields.SetField("Armor Check", character.Armor.Penalty.ToString());
                fields.SetField("AS - Armor 1 - Max Dex", character.Armor.MaxDex.ToString());
                fields.SetField("Armor Speed", character.Armor.SpeedAdjust.ToString());
                fields.SetField("EAC", character.ArmorClass.EnergyArmorClass.ToString());
                fields.SetField("KAC", character.ArmorClass.KineticArmorClass.ToString());
                fields.SetField("AC Vs CM", character.ArmorClass.ManeuversArmorClass.ToString());
                fields.SetField("EAC Armor", character.Armor.EAC.ToString());
                fields.SetField("KAC Armor", character.Armor.KAC.ToString());
                fields.SetField("AC - Dexterity Modifier", character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("EAC Misc Mod", character.ArmorClass.MiscEnergyMod.ToString());
                fields.SetField("KAC Misc Mod", character.ArmorClass.MiscKineticMod.ToString());
                fields.SetField("RESISTANCES", String.Join(";", character.ArmorClass.Resistances));

                //Saving Throws
                fields.SetField("FORTSAVE", character.SavingThrow.FortitudeSave.ToString());
                fields.SetField("FORTBASE", character.SavingThrow.BaseFortitude.ToString());
                fields.SetField("FORTABIL", character.AbilityScores.Where(x => x.Abbreviation == "CON").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("FORTMISC", character.SavingThrow.MiscFortitudeMod.ToString());
                fields.SetField("REFSAVE", character.SavingThrow.ReflexSave.ToString());
                fields.SetField("REFBASE", character.SavingThrow.BaseReflex.ToString());
                fields.SetField("REFABIL", character.AbilityScores.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("REFMISC", character.SavingThrow.MiscReflexMod.ToString());
                fields.SetField("WILSAVE", character.SavingThrow.WillSave.ToString());
                fields.SetField("WILLBASE", character.SavingThrow.BaseWill.ToString());
                fields.SetField("WILLABIL", character.AbilityScores.Where(x => x.Abbreviation == "WIS").Select(x => x.Mod).FirstOrDefault().ToString());
                fields.SetField("WILLMISC", character.SavingThrow.MiscWillMod.ToString());

                //Attack Bonus
                fields.SetField("MELEEBONUS", character.Attack.MeleeAttackBonus.ToString());
                fields.SetField("BABM", character.Attack.AttackBonus.ToString());
                fields.SetField("MELMISC", character.Attack.MiscMeleeMod.ToString());
                fields.SetField("RANGEBONUS", character.Attack.RangedAttackBonus.ToString());
                fields.SetField("BABR", character.Attack.AttackBonus.ToString());
                fields.SetField("RANGEMISC", character.Attack.MiscRangedMod.ToString());
                fields.SetField("THROWNBONUS", character.Attack.ThrownAttackBonus.ToString());
                fields.SetField("BABT", character.Attack.AttackBonus.ToString());
                fields.SetField("THROWNMISC", character.Attack.MiscThrownMod.ToString());

                //Weapons
                int weaponIndex = 1;
                foreach (var weapon in character.Weapons)
                {
                    if (weapon.Name == null)
                        break;

                    fields.SetField($"WEAPON{weaponIndex}", weapon.Name);
                    fields.SetField($"WEAPON LEVEL{weaponIndex}", weapon.Level.ToString());
                    fields.SetField($"AB{weaponIndex}", weapon.AttackBonus.ToString());
                    fields.SetField($"DAMAGE{weaponIndex}", weapon.Damage.ToString());
                    fields.SetField($"CRIT{weaponIndex}", weapon.Critical);
                    fields.SetField($"RANGE{weaponIndex}", weapon.Range);
                    fields.SetField($"TYPE{weaponIndex}", weapon.Type.ToString());
                    fields.SetField($"AMMO{weaponIndex}", weapon.Ammo);
                    fields.SetField($"SPECIAL{weaponIndex}", string.Join(";", weapon.Specials));
                    weaponIndex++;
                }

                //Abilities
                StringBuilder sbAbilities = new StringBuilder();
                foreach (var ability in character.Abilities)
                {
                    sbAbilities.Append(ability.Name);
                    sbAbilities.AppendLine();
                }
                fields.SetField("ABILITIES", sbAbilities.ToString());

                //Feats
                StringBuilder sbFeats = new StringBuilder();
                foreach (var feat in character.Feats)
                {
                    sbFeats.Append(feat.Name);
                    sbFeats.AppendLine();
                }
                fields.SetField("FEATSANDPROFICIENCES", sbFeats.ToString());

                //Equipment
                int itemIndex = 1;
                foreach (var item in character.Equipments)
                {
                    fields.SetField($"ITEM{itemIndex}", item.Name);
                    fields.SetField($"LEVEL{itemIndex}", item.Level.ToString());
                    fields.SetField($"BULK{itemIndex}", item.Bulk);
                    itemIndex++;
                }
                if (character.Armor.Name != null)
                {
                    fields.SetField($"ITEM{itemIndex}", character.Armor.Name);
                    fields.SetField($"LEVEL{itemIndex}", character.Armor.Level.ToString());
                    fields.SetField($"BULK{itemIndex}", character.Armor.Bulk);
                }                

                //Spells
                if (character.Spells.Count > 0 && character.Class.Levels.Max().SpellsPerDay != null)
                {
                    int spellIndex = 1;
                    foreach (var spell in character.Spells.Where(s => s.MysticLevel == 0 || s.TechnoLevel == 0))
                    {
                        fields.SetField($"SPELLS/ORISINS{spellIndex}", spell.Name);
                        spellIndex++;
                    }
                    spellIndex = 1;
                    fields.SetField("PERDAY1", character.Class.Levels.Max().SpellsPerDay.First.ToString());
                    foreach (var spell in character.Spells.Where(s => s.MysticLevel == 1 || s.TechnoLevel == 1))
                    {
                        fields.SetField($"LEVEL 1 - {spellIndex}", spell.Name);
                        spellIndex++;
                    }
                    spellIndex = 1;
                    fields.SetField("PERDAY2", character.Class.Levels.Max().SpellsPerDay.Second.ToString());
                    foreach (var spell in character.Spells.Where(s => s.MysticLevel == 2 || s.TechnoLevel == 2))
                    {
                        fields.SetField($"LEVEL 2 - {spellIndex}", spell.Name);
                        spellIndex++;
                    }
                    spellIndex = 1;
                    fields.SetField("PERDAY3", character.Class.Levels.Max().SpellsPerDay.Third.ToString());
                    foreach (var spell in character.Spells.Where(s => s.MysticLevel == 3 || s.TechnoLevel == 3))
                    {
                        fields.SetField($"LEVEL 3 - {spellIndex}", spell.Name);
                        spellIndex++;
                    }
                    spellIndex = 1;
                    fields.SetField("PERDAY4", character.Class.Levels.Max().SpellsPerDay.Fourth.ToString());
                    foreach (var spell in character.Spells.Where(s => s.MysticLevel == 4 || s.TechnoLevel == 4))
                    {
                        fields.SetField($"LEVEL 4 - {spellIndex}", spell.Name);
                        spellIndex++;
                    }
                    spellIndex = 1;
                    fields.SetField("PERDAY5", character.Class.Levels.Max().SpellsPerDay.Fifth.ToString());
                    foreach (var spell in character.Spells.Where(s => s.MysticLevel == 5 || s.TechnoLevel == 5))
                    {
                        fields.SetField($"LEVEL 5 - {spellIndex}", spell.Name);
                        spellIndex++;
                    }
                    spellIndex = 1;
                    fields.SetField("PERDAY6", character.Class.Levels.Max().SpellsPerDay.Sixth.ToString());
                    foreach (var spell in character.Spells.Where(s => s.MysticLevel == 6 || s.TechnoLevel == 6))
                    {
                        fields.SetField($"LEVEL 6 - {spellIndex}", spell.Name);
                        spellIndex++;
                    }
                }                

                //Credits
                fields.SetField("MOOLAH", character.Credits.ToString());

                stamper.FormFlattening = true;
                stamper.Close();
            }

            System.Diagnostics.Process.Start(characterFile);
        }
    }
}
