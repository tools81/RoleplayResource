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
using DataLayer.Starfinder;
using Views.Shared;

namespace Views.Starfinder.Create
{
    public partial class AbilitiesControl : UserControl
    {
        private Base _baseControl;
        private Character _character;
        private ToolTip _toolTip = new ToolTip();

        public AbilitiesControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.StarFinder_Banner_Abilities;

            _baseControl = baseControl;
            _character = character;

            PopulateValues(_character.Abilities);
        }

        public void PopulateValues(List<Ability> abilities)
        {
            if (_character.Class != null && !string.IsNullOrEmpty(_character.Class.Name))
            {
                cboAbilities.DataSource = Lists.Abilities
                            .Where(p => p.Class == _character.Class.Name)
                            .OrderBy(p => p.Name)
                            .Select(p => p.Name)
                            .ToList();

                gridAbilities.Rows.Clear();

                foreach (var ability in abilities)
                {
                    gridAbilities.Rows.Add(ability.Name);
                }
            }            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Ability ability = Lists.Abilities.FirstOrDefault(a => a.Name == cboAbilities.Text);
            if (!_character.Abilities.Contains(ability))
                _character.Abilities.Add(ability);
            _baseControl.UpdateCharacter(_character);
        }

        private void gridAbilities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                Ability ability = _character.Abilities.FirstOrDefault(f => f.Name == gridAbilities.Rows[e.RowIndex].Cells["AbilityName"].Value.ToString());
                _character.Abilities.Remove(ability);
                _baseControl.UpdateCharacter(_character);
            }
        }

        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboAbilities.Text))
            {
                var description = Lists.Abilities.FirstOrDefault(f => f.Name == cboAbilities.Text).Description;
                _toolTip.Show(RegExHelper.Wordwrap(description, 100), this.btnInfo, 32767);
            }           
        }

        private void gridAbilities_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                var description = Lists.Abilities.FirstOrDefault(f => f.Name == gridAbilities.Rows[e.RowIndex].Cells[0].Value.ToString()).Description;
                gridAbilities.Rows[e.RowIndex].Cells[1].ToolTipText = description;
            }
        }
    }
}
