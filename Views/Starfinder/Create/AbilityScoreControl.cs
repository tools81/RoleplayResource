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
    public partial class AbilityScoreControl : UserControl
    {
        private Base _baseControl;
        private Character _character;

        public AbilityScoreControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.StarFinder_Banner_AbilityScores;

            _baseControl = baseControl;
            _character = character;

            PopulateValues(_character.AbilityScores);
            AddEvent(this);
        }

        public void PopulateValues(List<AbilityScore> abilityScoreList)
        {
            numStrScore.Value = Convert.ToDecimal(abilityScoreList.Where(x => x.Abbreviation == "STR").Select(x => x.Score + x.ScoreBonus).FirstOrDefault());
            numDexScore.Value = Convert.ToDecimal(abilityScoreList.Where(x => x.Abbreviation == "DEX").Select(x => x.Score + x.ScoreBonus).FirstOrDefault());
            numConScore.Value = Convert.ToDecimal(abilityScoreList.Where(x => x.Abbreviation == "CON").Select(x => x.Score + x.ScoreBonus).FirstOrDefault());
            numIntScore.Value = Convert.ToDecimal(abilityScoreList.Where(x => x.Abbreviation == "INT").Select(x => x.Score + x.ScoreBonus).FirstOrDefault());
            numWisScore.Value = Convert.ToDecimal(abilityScoreList.Where(x => x.Abbreviation == "WIS").Select(x => x.Score + x.ScoreBonus).FirstOrDefault());
            numChaScore.Value = Convert.ToDecimal(abilityScoreList.Where(x => x.Abbreviation == "CHA").Select(x => x.Score + x.ScoreBonus).FirstOrDefault());

            lblStrMod.Text = abilityScoreList.Where(x => x.Abbreviation == "STR").Select(x => x.Mod).FirstOrDefault().ToString();
            lblDexMod.Text = abilityScoreList.Where(x => x.Abbreviation == "DEX").Select(x => x.Mod).FirstOrDefault().ToString();
            lblConMod.Text = abilityScoreList.Where(x => x.Abbreviation == "CON").Select(x => x.Mod).FirstOrDefault().ToString();
            lblIntMod.Text = abilityScoreList.Where(x => x.Abbreviation == "INT").Select(x => x.Mod).FirstOrDefault().ToString();
            lblWisMod.Text = abilityScoreList.Where(x => x.Abbreviation == "WIS").Select(x => x.Mod).FirstOrDefault().ToString();
            lblChaMod.Text = abilityScoreList.Where(x => x.Abbreviation == "CHA").Select(x => x.Mod).FirstOrDefault().ToString();
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
            foreach (var abilityScore in _character.AbilityScores)
            {
                switch (abilityScore.Abbreviation)
                {
                    case "STR":
                        abilityScore.Score = Convert.ToInt32(numStrScore.Value) - abilityScore.ScoreBonus;
                        break;
                    case "DEX":
                        abilityScore.Score = Convert.ToInt32(numDexScore.Value) - abilityScore.ScoreBonus;
                        break;
                    case "CON":
                        abilityScore.Score = Convert.ToInt32(numConScore.Value) - abilityScore.ScoreBonus;
                        break;
                    case "INT":
                        abilityScore.Score = Convert.ToInt32(numIntScore.Value) - abilityScore.ScoreBonus;
                        break;
                    case "WIS":
                        abilityScore.Score = Convert.ToInt32(numWisScore.Value) - abilityScore.ScoreBonus;
                        break;
                    case "CHA":
                        abilityScore.Score = Convert.ToInt32(numChaScore.Value) - abilityScore.ScoreBonus;
                        break;
                    default:
                        break;
                }
            }

            _baseControl.UpdateCharacter(_character);
        }
    }
}
