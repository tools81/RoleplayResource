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

namespace Views.Starfinder.Create
{
    public partial class SummaryControl : UserControl
    {
        private Base _baseControl;
        private Character _character;

        public SummaryControl(Character character, Base baseControl)
        {
            InitializeComponent();

            _baseControl = baseControl;
            _character = character;

            PopulateValues(_character);            
        }

        public void PopulateValues(Character character)
        {
            _character = character;

            txtSummary.Clear();
                  
            AddHeader();
        }

        private void AddText(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                txtSummary.DeselectAll();
                txtSummary.SelectionFont = new Font(FontFamily.GenericSansSerif, 10.0f, FontStyle.Regular);
                txtSummary.AppendText(value);
            }           
        }

        private void AddTitle(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                txtSummary.DeselectAll();
                txtSummary.SelectionFont = new Font(FontFamily.GenericSansSerif, 16.0f, FontStyle.Bold);
                txtSummary.SelectionColor = Color.DarkBlue;
                txtSummary.AppendText(value);
            }
        }

        private void AddBoldText(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                txtSummary.DeselectAll();
                txtSummary.SelectionFont = new Font(FontFamily.GenericSansSerif, 12.0f, FontStyle.Bold);
                txtSummary.AppendText(value);
            }
        }

        private void AddItalicsText(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                txtSummary.DeselectAll();
                txtSummary.SelectionFont = new Font(FontFamily.GenericSansSerif, 10.0f, FontStyle.Italic);
                txtSummary.SelectionColor = Color.Gray;
                txtSummary.AppendText(value);
            }
        }

        private string GetTextWithLineBreaks(string text)
        {
            return text != null ? text.Replace("/line", Environment.NewLine + Environment.NewLine) : null;
        }

        private void AddHeader()
        {
            AddTitle("Summary");
            txtSummary.AppendText(Environment.NewLine);
            txtSummary.AppendText(Environment.NewLine);
            AddBoldText("Name: ");
            AddText(_character.Name);

            txtSummary.AppendText(Environment.NewLine);
            txtSummary.AppendText(Environment.NewLine);
            AddBoldText((@"Race: "));
            AddText(_character.Race == null ? string.Empty : _character.Race.Name);
            txtSummary.AppendText(Environment.NewLine);
            AddItalicsText(_character.Race == null ? string.Empty : GetTextWithLineBreaks(_character.Race.Description));

            txtSummary.AppendText(Environment.NewLine);
            txtSummary.AppendText(Environment.NewLine);
            AddBoldText("Class: ");
            AddText(_character.Class == null ? string.Empty : _character.Class.Name);
            txtSummary.AppendText(Environment.NewLine);
            AddItalicsText(_character.Class == null ? string.Empty : GetTextWithLineBreaks(_character.Class.Description));
            
            txtSummary.AppendText(Environment.NewLine);
            txtSummary.AppendText(Environment.NewLine);
            AddBoldText((@"Theme: "));
            AddText(_character.Theme == null ? string.Empty : _character.Theme.Name);
            txtSummary.AppendText(Environment.NewLine);
            AddItalicsText(_character.Theme == null ? string.Empty : GetTextWithLineBreaks(_character.Theme.Description));

            txtSummary.AppendText(Environment.NewLine);
            txtSummary.AppendText(Environment.NewLine);
            AddBoldText((@"Abilities: "));            
            foreach (var ability in _character.Abilities)
            {
                txtSummary.AppendText(Environment.NewLine);
                AddText(ability.Name);
                txtSummary.AppendText(Environment.NewLine);
                AddItalicsText(GetTextWithLineBreaks(ability.Description));
                txtSummary.AppendText(Environment.NewLine);
            }

            txtSummary.AppendText(Environment.NewLine);
            AddBoldText((@"Feats: "));
            foreach (var feat in _character.Feats)
            {
                txtSummary.AppendText(Environment.NewLine);
                AddText(feat.Name);
                txtSummary.AppendText(Environment.NewLine);
                AddItalicsText(GetTextWithLineBreaks(feat.Description));
                txtSummary.AppendText(Environment.NewLine);
            }            

            txtSummary.AppendText(Environment.NewLine);
            AddBoldText((@"Armor: "));
            AddText(_character.Armor == null ? string.Empty : _character.Armor.Name);
            txtSummary.AppendText(Environment.NewLine);
            AddItalicsText(GetTextWithLineBreaks(_character.Armor.Description));

            txtSummary.AppendText(Environment.NewLine);
            txtSummary.AppendText(Environment.NewLine);
            AddBoldText((@"Weapons: "));            
            foreach (var weapon in _character.Weapons)
            {
                txtSummary.AppendText(Environment.NewLine);
                AddText(weapon.Name);
                txtSummary.AppendText(Environment.NewLine);
                AddItalicsText(GetTextWithLineBreaks(weapon.Description));
                txtSummary.AppendText(Environment.NewLine);
            }

            txtSummary.AppendText(Environment.NewLine);
            AddBoldText((@"Equipment: "));            
            foreach (var equipment in _character.Equipments)
            {
                txtSummary.AppendText(Environment.NewLine);
                AddText(equipment.Name);
                txtSummary.AppendText(Environment.NewLine);
                AddItalicsText(GetTextWithLineBreaks(equipment.Description));
                txtSummary.AppendText(Environment.NewLine);
            }

            txtSummary.AppendText(Environment.NewLine);
            AddBoldText((@"Spells: "));
            foreach (var spell in _character.Spells)
            {
                txtSummary.AppendText(Environment.NewLine);
                AddText(spell.Name);
                txtSummary.AppendText(Environment.NewLine);
                AddItalicsText(GetTextWithLineBreaks(spell.Description));
                txtSummary.AppendText(Environment.NewLine);
            }
        }
    }
}
