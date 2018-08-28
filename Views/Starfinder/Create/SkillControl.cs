using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage.Starfinder;
using Storage.Interfaces;

namespace Views.Starfinder.Create
{
    public partial class SkillControl : UserControl
    {
        private Base _baseControl;
        private Character _character;

        public SkillControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.StarFinder_Banner_Skills;

            _baseControl = baseControl;
            _character = character;

            List<KeyValuePair<string, string>> professionAbilityList = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("CHA", "Charisma"),
                new KeyValuePair<string, string>("INT", "Intelligence"),
                new KeyValuePair<string, string>("WIS", "Wisdom")
            };

            cboProfession1Ability.DataSource = professionAbilityList;
            cboProfession1Ability.DisplayMember = "Key";
            cboProfession1Ability.ValueMember = "Value";
            cboProfession2Ability.DataSource = professionAbilityList;
            cboProfession2Ability.DisplayMember = "Key";
            cboProfession2Ability.ValueMember = "Value";

            PopulateValues(_character.Skills, _character.SkillPointsPerLevel);
            AddEvent(this);
        }

        public void PopulateValues(List<Skill> skillList, int skillPointsPerLevel)
        {
            lblPerLevel.Text = skillPointsPerLevel.ToString();

            _character.Skills.Where(s => s.Name == Enums.Skills.Profession1).Select(s => s.Ability = (Enums.AbilityScores)Enum.Parse(typeof(Enums.AbilityScores), cboProfession1Ability.SelectedValue.ToString()));
            _character.Skills.Where(s => s.Name == Enums.Skills.Profession2).Select(s => s.Ability = (Enums.AbilityScores)Enum.Parse(typeof(Enums.AbilityScores), cboProfession2Ability.SelectedValue.ToString()));

            Skill skill = skillList.Where(x => x.Name == Enums.Skills.Acrobatics).FirstOrDefault();
            numAcrobaticsRank.Value = Convert.ToDecimal(skill.Rank);
            lblAcrobaticsClass.Text = skill.ClassBonus.ToString();
            numAcrobaticsMisc.Value = skill.MiscMod;
            lblAcrobaticsTotal.Text = skill.Total.ToString();
            SetClassSkill(chkAcrobatics, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Athletics).FirstOrDefault();
            numAthleticsRank.Value = Convert.ToDecimal(skill.Rank);
            lblAthleticsClass.Text = skill.ClassBonus.ToString();
            numAthleticsMisc.Value = skill.MiscMod;
            lblAthleticsTotal.Text = skill.Total.ToString();
            SetClassSkill(chkAthletics, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Bluff).FirstOrDefault();
            numBluffRank.Value = Convert.ToDecimal(skill.Rank);
            lblBluffClass.Text = skill.ClassBonus.ToString();
            numBluffMisc.Value = skill.MiscMod;
            lblBluffTotal.Text = skill.Total.ToString();
            SetClassSkill(chkBluff, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Computers).FirstOrDefault();
            numComputersRank.Value = Convert.ToDecimal(skill.Rank);
            lblComputersClass.Text = skill.ClassBonus.ToString();
            numComputersMisc.Value = skill.MiscMod;
            lblComputersTotal.Text = skill.Total.ToString();
            SetClassSkill(chkComputers, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Culture).FirstOrDefault();
            numCultureRank.Value = Convert.ToDecimal(skill.Rank);
            lblCultureClass.Text = skill.ClassBonus.ToString();
            numCultureMisc.Value = skill.MiscMod;
            lblCultureTotal.Text = skill.Total.ToString();
            SetClassSkill(chkCulture, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Diplomacy).FirstOrDefault();
            numDiplomacyRank.Value = Convert.ToDecimal(skill.Rank);
            lblDiplomacyClass.Text = skill.ClassBonus.ToString();
            numDiplomacyMisc.Value = skill.MiscMod;
            lblDiplomacyTotal.Text = skill.Total.ToString();
            SetClassSkill(chkDiplomacy, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Disguise).FirstOrDefault();
            numDisguiseRank.Value = Convert.ToDecimal(skill.Rank);
            lblDisguiseClass.Text = skill.ClassBonus.ToString();
            numDisguiseMisc.Value = skill.MiscMod;
            lblDisguiseTotal.Text = skill.Total.ToString();
            SetClassSkill(chkDisguise, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Engineering).FirstOrDefault();
            numEngineeringRank.Value = Convert.ToDecimal(skill.Rank);
            lblEngineeringClass.Text = skill.ClassBonus.ToString();
            numEngineeringMisc.Value = skill.MiscMod;
            lblEngineeringTotal.Text = skill.Total.ToString();
            SetClassSkill(chkEngineering, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Intimidate).FirstOrDefault();
            numIntimidateRank.Value = Convert.ToDecimal(skill.Rank);
            lblIntimidateClass.Text = skill.ClassBonus.ToString();
            numIntimidateMisc.Value = skill.MiscMod;
            lblIntimidateTotal.Text = skill.Total.ToString();
            SetClassSkill(chkIntimidate, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.LifeScience).FirstOrDefault();
            numLifeScienceRank.Value = Convert.ToDecimal(skill.Rank);
            lblLifeScienceClass.Text = skill.ClassBonus.ToString();
            numLifeScienceMisc.Value = skill.MiscMod;
            lblLifeScienceTotal.Text = skill.Total.ToString();
            SetClassSkill(chkLifeScience, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Medicine).FirstOrDefault();
            numMedicineRank.Value = Convert.ToDecimal(skill.Rank);
            lblMedicineClass.Text = skill.ClassBonus.ToString();
            numMedicineMisc.Value = skill.MiscMod;
            lblMedicineTotal.Text = skill.Total.ToString();
            SetClassSkill(chkMedicine, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Mysticism).FirstOrDefault();
            numMysticismRank.Value = Convert.ToDecimal(skill.Rank);
            lblMysticismClass.Text = skill.ClassBonus.ToString();
            numMysticismMisc.Value = skill.MiscMod;
            lblMysticismTotal.Text = skill.Total.ToString();
            SetClassSkill(chkMysticism, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Perception).FirstOrDefault();
            numPerceptionRank.Value = Convert.ToDecimal(skill.Rank);
            lblPerceptionClass.Text = skill.ClassBonus.ToString();
            numPerceptionMisc.Value = skill.MiscMod;
            lblPerceptionTotal.Text = skill.Total.ToString();
            SetClassSkill(chkPerception, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.PhysicalScience).FirstOrDefault();
            numPhysicalScienceRank.Value = Convert.ToDecimal(skill.Rank);
            lblPhysicalScienceClass.Text = skill.ClassBonus.ToString();
            numPhysicalScienceMisc.Value = skill.MiscMod;
            lblPhysicalScienceTotal.Text = skill.Total.ToString();
            SetClassSkill(chkPhysicalScience, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Piloting).FirstOrDefault();
            numPilotingRank.Value = Convert.ToDecimal(skill.Rank);
            lblPilotingClass.Text = skill.ClassBonus.ToString();
            numPilotingMisc.Value = skill.MiscMod;
            lblPilotingTotal.Text = skill.Total.ToString();
            SetClassSkill(chkPiloting, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Profession1).FirstOrDefault();
            numProfession1Rank.Value = Convert.ToDecimal(skill.Rank);
            lblProfession1Class.Text = skill.ClassBonus.ToString();
            numProfession1Misc.Value = skill.MiscMod;
            lblProfession1Total.Text = skill.Total.ToString();
            cboProfession1Ability.SelectedValue = skill.Ability.ToString();
            SetClassSkill(chkProfession1, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Profession2).FirstOrDefault();
            numProfession2Rank.Value = Convert.ToDecimal(skill.Rank);
            lblProfession2Class.Text = skill.ClassBonus.ToString();
            numProfession2Misc.Value = skill.MiscMod;
            lblProfession2Total.Text = skill.Total.ToString();
            cboProfession2Ability.SelectedValue = skill.Ability.ToString();
            SetClassSkill(chkProfession2, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.SenseMotive).FirstOrDefault();
            numSenseMotiveRank.Value = Convert.ToDecimal(skill.Rank);
            lblSenseMotiveClass.Text = skill.ClassBonus.ToString();
            numSenseMotiveMisc.Value = skill.MiscMod;
            lblSenseMotiveTotal.Text = skill.Total.ToString();
            SetClassSkill(chkSenseMotive, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.SleightOfHand).FirstOrDefault();
            numSleightOfHandRank.Value = Convert.ToDecimal(skill.Rank);
            lblSleightOfHandClass.Text = skill.ClassBonus.ToString();
            numSleightOfHandMisc.Value = skill.MiscMod;
            lblSleightOfHandTotal.Text = skill.Total.ToString();
            SetClassSkill(chkSleightOfHand, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Stealth).FirstOrDefault();
            numStealthRank.Value = Convert.ToDecimal(skill.Rank);
            lblStealthClass.Text = skill.ClassBonus.ToString();
            numStealthMisc.Value = skill.MiscMod;
            lblStealthTotal.Text = skill.Total.ToString();
            SetClassSkill(chkStealth, skill);

            skill = skillList.Where(x => x.Name == Enums.Skills.Survival).FirstOrDefault();
            numSurvivalRank.Value = Convert.ToDecimal(skill.Rank);
            lblSurvivalClass.Text = skill.ClassBonus.ToString();
            numSurvivalMisc.Value = skill.MiscMod;
            lblSurvivalTotal.Text = skill.Total.ToString();
            SetClassSkill(chkSurvival, skill);
        }

        private void SetClassSkill(Control control, Skill skill)
        {
            if (skill.ClassSkill)
                ((CheckBox)control).Checked = true;
            else
                ((CheckBox)control).Checked = false;
        }

        private void AddEvent(Control parentCtrl)
        {
            foreach (Control c in parentCtrl.Controls)
            {
                c.KeyDown += new KeyEventHandler(C_KeyDown);
                c.Click += new EventHandler(C_KeyDown);
                AddEvent(c);
            }
        }

        private void C_KeyDown(object sender, EventArgs e)
        {
            foreach (var skill in _character.Skills)
            {
                switch (skill.Name)
                {
                    case Enums.Skills.Acrobatics:
                        skill.ClassSkill = chkAcrobatics.Checked;
                        skill.Rank = Convert.ToInt32(numAcrobaticsRank.Value);
                        skill.MiscMod = Convert.ToInt32(numAcrobaticsMisc.Value);
                        break;
                    case Enums.Skills.Athletics:
                        skill.ClassSkill = chkAthletics.Checked;
                        skill.Rank = Convert.ToInt32(numAthleticsRank.Value);
                        skill.MiscMod = Convert.ToInt32(numAthleticsMisc.Value);
                        break;
                    case Enums.Skills.Bluff:
                        skill.ClassSkill = chkBluff.Checked;
                        skill.Rank = Convert.ToInt32(numBluffRank.Value);
                        skill.MiscMod = Convert.ToInt32(numBluffMisc.Value);
                        break;
                    case Enums.Skills.Computers:
                        skill.ClassSkill = chkComputers.Checked;
                        skill.Rank = Convert.ToInt32(numComputersRank.Value);
                        skill.MiscMod = Convert.ToInt32(numComputersMisc.Value);
                        break;
                    case Enums.Skills.Culture:
                        skill.ClassSkill = chkCulture.Checked;
                        skill.Rank = Convert.ToInt32(numCultureRank.Value);
                        skill.MiscMod = Convert.ToInt32(numCultureMisc.Value);
                        break;
                    case Enums.Skills.Diplomacy:
                        skill.ClassSkill = chkDiplomacy.Checked;
                        skill.Rank = Convert.ToInt32(numDiplomacyRank.Value);
                        skill.MiscMod = Convert.ToInt32(numDiplomacyMisc.Value);
                        break;
                    case Enums.Skills.Disguise:
                        skill.ClassSkill = chkDisguise.Checked;
                        skill.Rank = Convert.ToInt32(numDisguiseRank.Value);
                        skill.MiscMod = Convert.ToInt32(numDisguiseMisc.Value);
                        break;
                    case Enums.Skills.Engineering:
                        skill.ClassSkill = chkEngineering.Checked;
                        skill.Rank = Convert.ToInt32(numEngineeringRank.Value);
                        skill.MiscMod = Convert.ToInt32(numEngineeringMisc.Value);
                        break;
                    case Enums.Skills.Intimidate:
                        skill.ClassSkill = chkIntimidate.Checked;
                        skill.Rank = Convert.ToInt32(numIntimidateRank.Value);
                        skill.MiscMod = Convert.ToInt32(numIntimidateMisc.Value);
                        break;
                    case Enums.Skills.LifeScience:
                        skill.ClassSkill = chkLifeScience.Checked;
                        skill.Rank = Convert.ToInt32(numLifeScienceRank.Value);
                        skill.MiscMod = Convert.ToInt32(numLifeScienceMisc.Value);
                        break;
                    case Enums.Skills.Medicine:
                        skill.ClassSkill = chkMedicine.Checked;
                        skill.Rank = Convert.ToInt32(numMedicineRank.Value);
                        skill.MiscMod = Convert.ToInt32(numMedicineMisc.Value);
                        break;
                    case Enums.Skills.Mysticism:
                        skill.ClassSkill = chkMysticism.Checked;
                        skill.Rank = Convert.ToInt32(numMysticismRank.Value);
                        skill.MiscMod = Convert.ToInt32(numMysticismMisc.Value);
                        break;
                    case Enums.Skills.Perception:
                        skill.ClassSkill = chkPerception.Checked;
                        skill.Rank = Convert.ToInt32(numPerceptionRank.Value);
                        skill.MiscMod = Convert.ToInt32(numPerceptionMisc.Value);
                        break;
                    case Enums.Skills.PhysicalScience:
                        skill.ClassSkill = chkPhysicalScience.Checked;
                        skill.Rank = Convert.ToInt32(numPhysicalScienceRank.Value);
                        skill.MiscMod = Convert.ToInt32(numPhysicalScienceMisc.Value);
                        break;
                    case Enums.Skills.Piloting:
                        skill.ClassSkill = chkPiloting.Checked;
                        skill.Rank = Convert.ToInt32(numPilotingRank.Value);
                        skill.MiscMod = Convert.ToInt32(numPilotingMisc.Value);
                        break;
                    case Enums.Skills.Profession1:
                        skill.ClassSkill = chkProfession1.Checked;
                        skill.Rank = Convert.ToInt32(numProfession1Rank.Value);
                        skill.MiscMod = Convert.ToInt32(numProfession1Misc.Value);
                        break;
                    case Enums.Skills.Profession2:
                        skill.ClassSkill = chkProfession2.Checked;
                        skill.Rank = Convert.ToInt32(numProfession2Rank.Value);
                        skill.MiscMod = Convert.ToInt32(numProfession2Misc.Value);
                        break;
                    case Enums.Skills.SenseMotive:
                        skill.ClassSkill = chkSenseMotive.Checked;
                        skill.Rank = Convert.ToInt32(numSenseMotiveRank.Value);
                        skill.MiscMod = Convert.ToInt32(numSenseMotiveMisc.Value);
                        break;
                    case Enums.Skills.SleightOfHand:
                        skill.ClassSkill = chkSleightOfHand.Checked;
                        skill.Rank = Convert.ToInt32(numSleightOfHandRank.Value);
                        skill.MiscMod = Convert.ToInt32(numSleightOfHandMisc.Value);
                        break;
                    case Enums.Skills.Stealth:
                        skill.ClassSkill = chkStealth.Checked;
                        skill.Rank = Convert.ToInt32(numStealthRank.Value);
                        skill.MiscMod = Convert.ToInt32(numStealthMisc.Value);
                        break;
                    case Enums.Skills.Survival:
                        skill.ClassSkill = chkSurvival.Checked;
                        skill.Rank = Convert.ToInt32(numSurvivalRank.Value);
                        skill.MiscMod = Convert.ToInt32(numSurvivalMisc.Value);
                        break;
                    default:
                        break;
                }

                if (skill.ClassSkill && skill.Rank > 0 && skill.ClassBonus == 0)
                    skill.ClassBonus = 3;
            }

            _baseControl.UpdateCharacter(_character);
        }

        private void cboProfession1Ability_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Skills.FirstOrDefault(s => s.Name == Enums.Skills.Profession1).Ability = 
                (Enums.AbilityScores)Enum.Parse(typeof(Enums.AbilityScores), ((KeyValuePair<string, string>)cboProfession1Ability.SelectedItem).Value);
            _baseControl.UpdateCharacter(_character);
        }

        private void cboProfession2Ability_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Skills.FirstOrDefault(s => s.Name == Enums.Skills.Profession2).Ability = 
                (Enums.AbilityScores)Enum.Parse(typeof(Enums.AbilityScores), ((KeyValuePair<string, string>)cboProfession2Ability.SelectedItem).Value);
            _baseControl.UpdateCharacter(_character);
        }
    }
}
