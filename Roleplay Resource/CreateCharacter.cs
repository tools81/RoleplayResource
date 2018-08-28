using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rules;
using Storage;
using Views;
using Storage.Starfinder;
using Storage.Interfaces;

namespace Roleplay_Resource
{
    public partial class CreateCharacter : Form
    {
        Storage.Enums.Ruleset _ruleset;

        public CreateCharacter(Storage.Enums.Ruleset ruleset, string characterName = null)
        {
            InitializeComponent();

            switch (ruleset)
            {
                case Storage.Enums.Ruleset.Pathfinder:
                    this.Icon = Properties.Resources.Pathfinder_icon;
                    break;
                case Storage.Enums.Ruleset.Starfinder:
                    this.Icon = Properties.Resources.Starfinder_icon;
                    pnlFill.Controls.Add(new Views.Starfinder.Create.Base(characterName));
                    break;
                case Storage.Enums.Ruleset.WorldOfDarkness:
                    this.Icon = Properties.Resources.WOD_icon;
                    break;
                default:
                    break;
            }

            _ruleset = ruleset;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);

            switch (_ruleset)
            {
                case Storage.Enums.Ruleset.Pathfinder:
                    break;
                case Storage.Enums.Ruleset.Starfinder:
                    Rules.Starfinder.CreateCharacter.Print(Storage.Enums.Ruleset.Starfinder);
                    break;
                case Storage.Enums.Ruleset.WorldOfDarkness:
                    break;
                default:
                    break;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (_ruleset)
            {
                case Storage.Enums.Ruleset.Pathfinder:
                    break;
                case Storage.Enums.Ruleset.Starfinder:
                    Rules.Starfinder.CreateCharacter.SaveCharacter();
                    break;
                case Storage.Enums.Ruleset.WorldOfDarkness:
                    break;
                default:
                    break;
            }
        }

        private void btnSaveQuit_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
            this.Close();
        }
    }
}
