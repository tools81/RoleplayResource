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
    public partial class SpellControl : UserControl
    {
        private Base _baseControl;
        private Character _character;
        private Spell _spell;

        public SpellControl(Base baseControl, Spell spell, Character character)
        {
            InitializeComponent();

            _baseControl = baseControl;
            _character = character;
            _spell = spell;

            lblSpellName.Text = spell.Name;
            lblMysticLevel.Text = spell.MysticLevel >= 0 ? spell.MysticLevel.ToString() : "N/A";
            lblTechnoLevel.Text = spell.TechnoLevel >= 0 ? spell.TechnoLevel.ToString() : "N/A";
            lblSchool.Text = spell.School;
            lblTime.Text = spell.Time;
            lblRange.Text = spell.Range;
            lblDuration.Text = spell.Duration;
            lblSavingThrow.Text = spell.SavingThrow;
            lblTarget.Text = spell.Target;
            chkResistance.Checked = spell.Resistance;
            txtDescription.AppendText(spell.Description.Replace(@"/line", Environment.NewLine));

            SetSpellSelected(character.Spells);
        }

        private void chkSpellSelected_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpellSelected.Checked)
                _character.Spells.Add(_spell);
            else
                _character.Spells.Remove(_spell);
            _baseControl.UpdateCharacter(_character);
        }

        public void SetSpellSelected(List<Spell> spells)
        {
            if (spells.Contains(_spell))
            {
                this.BackColor = Color.AliceBlue;
                chkSpellSelected.Checked = true;
            }            
        }
    }
}
