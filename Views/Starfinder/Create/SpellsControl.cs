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

namespace Views.Starfinder.Create
{
    public partial class SpellsControl : UserControl
    {
        private Base _baseControl;
        private Character _character;

        public SpellsControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.Starfinder_Banner_Spells;

            _baseControl = baseControl;
            _character = character;

            InitiallyPopulateSpellControls(_character);
            PopulateValues(_character.Spells);
        }

        private void InitiallyPopulateSpellControls(Character character)
        {
            pnlSpells.Refresh();
            foreach (var spell in Lists.Spells)
            {
                SpellControl spellControl = new SpellControl(_baseControl, spell, character);
                pnlSpells.Controls.Add(spellControl);
            }
        }

        public void PopulateValues(List<Spell> spells)
        {
            foreach (var spellControl in pnlSpells.Controls)
            {
                ((SpellControl)spellControl).SetSpellSelected(spells);
            }
        }
    }
}
