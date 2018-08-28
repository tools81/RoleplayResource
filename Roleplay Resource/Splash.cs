using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Custom_Controls;
using System.IO;
using Storage;
using DataLayer;

namespace Roleplay_Resource
{
    public partial class Splash : Form
    {
        private ComboImageBox _comboImageBox = new ComboImageBox();
        private bool _loadCharacterSelectionMade = false;

        public Splash()
        {
            InitializeComponent();
            this.Height = 216;

            Populate();
            CheckSourceDirectory();
        }       

        private void Populate()
        {
            _comboImageBox.Width = 423;
            _comboImageBox.ItemHeight = 65;

            DropDownItem item = new DropDownItem();
            item.Image = Properties.Resources.Starfinder_logo;
            item.Value = "Starfinder";

            DropDownItem item2 = new DropDownItem();
            item2.Image = Properties.Resources.Pathfinder_logo;
            item2.Value = "Pathfinder";

            DropDownItem item3 = new DropDownItem();
            item3.Image = Properties.Resources.WOD_logo;
            item3.Value = "WorldOfDarkness";

            DropDownItem item4 = new DropDownItem();
            item4.Image = Properties.Resources.GameOfThrones_logo;
            item4.Value = "GameOfThrones";

            _comboImageBox.Items.Add(item);
            _comboImageBox.Items.Add(item2);
            _comboImageBox.Items.Add(item3);
            _comboImageBox.Items.Add(item4);
            _comboImageBox.SelectedIndex = 0;
            pnlGameSelect.Controls.Add(_comboImageBox);
        }

        private void CheckSourceDirectory()
        {
            if (Directory.Exists(Properties.Settings.Default.Source))
            {
                lblSourceMessage.Visible = false;
                Source.Path = Properties.Settings.Default.Source;
                btnCreate.Visible = true;
                btnLoad.Visible = true;
            }                
            else
            {
                lblSourceMessage.Visible = true;
                btnCreate.Visible = false;
                btnLoad.Visible = false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (_comboImageBox.SelectedIndex > 0)
            {
                MessageBox.Show("This ruleset is not yet implemented.", "Roleplay Resource");
                return;   
            }

            CreateCharacter create = new CreateCharacter((Enums.Ruleset)Enum.Parse(typeof(Enums.Ruleset), _comboImageBox.SelectedItem.ToString()));
            create.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (_comboImageBox.SelectedIndex > 0)
            {
                MessageBox.Show("This ruleset is not yet implemented.", "Roleplay Resource");
                return;
            }

            this.Height = 481;

            switch ((Enums.Ruleset)Enum.Parse(typeof(Enums.Ruleset), _comboImageBox.SelectedItem.ToString()))
            {
                case Enums.Ruleset.Starfinder:
                    lstCharacters.DataSource = DataLayer.Starfinder.Lists.Characters;
                    break;
                case Enums.Ruleset.Pathfinder:
                    break;
                case Enums.Ruleset.WorldOfDarkness:
                    break;
                default:
                    break;
            }
        }

        private void lstCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loadCharacterSelectionMade)
            {
                CreateCharacter create = new CreateCharacter((Enums.Ruleset)Enum.Parse(typeof(Enums.Ruleset), _comboImageBox.SelectedItem.ToString()), lstCharacters.SelectedItem.ToString());
                create.Show();
            }
            else
                _loadCharacterSelectionMade = true;
            
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            if (fbdSourceDirectory.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Properties.Settings.Default.Source = fbdSourceDirectory.SelectedPath + @"\";
                    Properties.Settings.Default.Save();
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read directory. Original error: " + ex.Message);
                }
            }
        }
    }
}
