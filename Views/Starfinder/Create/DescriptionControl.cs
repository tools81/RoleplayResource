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
using DataLayer.Starfinder;
using Rules.Starfinder;

namespace Views.Starfinder.Create
{
    public partial class DescriptionControl : UserControl
    {
        private Base _baseControl;
        private Character _character;

        public DescriptionControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.StarFinder_Banner_Description;

            _baseControl = baseControl;
            _character = character;
            PopulateComboboxes();

            PopulateValues(character);
            AddEvent(this);
        }

        private void PopulateComboboxes()
        {
            cboGender.DataSource = Enum.GetValues(typeof(Enums.Gender))
                            .Cast<Enums.Gender>()
                            .Select(p => new { Key = (int)p, Value = p.ToString() })
                            .ToList();
            cboGender.DisplayMember = "Value";
            cboGender.ValueMember = "Key";

            cboSize.DataSource = Enum.GetValues(typeof(Enums.CharacterSize))
                            .Cast<Enums.CharacterSize>()
                            .Select(p => new { Key = (int)p, Value = p.ToString() })
                            .ToList();
            cboSize.DisplayMember = "Value";
            cboSize.ValueMember = "Key";

            cboAlignment.DataSource = Enum.GetValues(typeof(Enums.Alignment))
                            .Cast<Enums.Alignment>()
                            .Select(p => new { Key = (int)p, Value = p.ToString() })
                            .ToList();
            cboAlignment.DisplayMember = "Value";
            cboAlignment.ValueMember = "Key";

            cboClass.DataSource = Lists.Classes
                            .OrderBy(p => p.Name)
                            .Select(p => p.Name)
                            .ToList();

            cboRace.DataSource = Lists.Races
                            .OrderBy(p => p.Name)
                            .Select(p => p.Name)
                            .ToList();

            cboTheme.DataSource = Lists.Themes
                            .OrderBy(p => p.Name)
                            .Select(p => p.Name)
                            .ToList();

            cboDeity.DataSource = Lists.Deities
                            .OrderBy(p => p.Name)
                            .Select(p => p.Name)
                            .ToList();
        }

        public void PopulateValues(Character character)
        {
            txtName.Text = character.Name;
            txtPlayer.Text = character.PlayerName;
            numLevel.Value = character.Level;
            if (character.Race != null && !string.IsNullOrEmpty(character.Race.Name))
                numSpeed.Value = character.Race.Speed + character.Race.SpeedBonus;
            cboSize.Text = character.Size.ToString();
            cboAlignment.Text = character.Alignment.ToString();
            cboClass.Text = character.Class == null ? string.Empty : character.Class.Name;
            cboRace.Text = character.Race == null ? string.Empty : character.Race.Name;
            cboTheme.Text = character.Theme == null ? string.Empty : character.Theme.Name;
            cboDeity.Text = character.Deity == null ? string.Empty : character.Deity.Name;
            txtHomeworld.Text = character.HomeWorld;
        }

        private void AddEvent(Control parentCtrl)
        {
            foreach (Control c in parentCtrl.Controls)
            {
                c.KeyDown += new KeyEventHandler(C_KeyDown);
                c.Click += new EventHandler(C_KeyDown);

                if (c is ComboBox)
                    c.TextChanged += new EventHandler(C_KeyDown);

                AddEvent(c);
            }
        }

        private void C_KeyDown(object sender, EventArgs e)
        {
            _character.Name = txtName.Text;
            _character.PlayerName = txtPlayer.Text;
            _character.Level = Convert.ToInt32(numLevel.Value);
            _character.Size =  (Enums.CharacterSize)Enum.Parse(typeof(Enums.CharacterSize), cboSize.Text);
            _character.Alignment = (Enums.Alignment)Enum.Parse(typeof(Enums.Alignment), cboAlignment.Text);
            _character.Deity.Name = cboDeity.Text;
            _character.HomeWorld = txtHomeworld.Text;

            if (!string.IsNullOrEmpty(cboRace.Text) && _character.Race != null && _character.Race.Name != cboRace.Text)
                _character.Race = Lists.Races.Where(c => c.Name == cboRace.Text).FirstOrDefault();
                                        
            if (!string.IsNullOrEmpty(cboTheme.Text) && _character.Theme != null && _character.Theme.Name != cboTheme.Text)
                _character.Theme = Lists.Themes.Where(c => c.Name == cboTheme.Text).FirstOrDefault();

            if (!string.IsNullOrEmpty(cboClass.Text) && _character.Class != null && _character.Class.Name != cboClass.Text)
                _character.Class = Lists.Classes.Where(c => c.Name == cboClass.Text).FirstOrDefault();          

            _baseControl.UpdateCharacter(_character);
        }

        private void cboRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_character.Race != null && !string.IsNullOrEmpty(_character.Race.Name))
            {
                foreach (var bonus in _character.Race.Bonuses)
                {
                    BonusHandler.SetAnyBonusValue(bonus);
                }
                _baseControl.UpdateCharacter(_character);
            }
        }

        private void cboTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_character.Theme != null && !string.IsNullOrEmpty(_character.Theme.Name))
            {
                foreach (var bonus in _character.Theme.Bonuses)
                {
                    BonusHandler.SetAnyBonusValue(bonus);
                }
                _baseControl.UpdateCharacter(_character);
            }
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_character.Class != null && !string.IsNullOrEmpty(_character.Class.Name))
            {
                foreach (var bonus in _character.Class.Bonuses)
                {
                    BonusHandler.SetAnyBonusValue(bonus);
                }
                _baseControl.UpdateCharacter(_character);
            }
        }
    }
}
