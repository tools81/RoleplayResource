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
    public partial class AttackControl : UserControl
    {
        private Base _baseControl;
        private Character _character;

        public AttackControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.Starfinder_Banner_Attack;

            _baseControl = baseControl;
            _character = character;

            PopulateValues(_character.Attack);
            AddEvent(this);
        }

        public void PopulateValues(Attack attack)
        {
            lblMeleeBonus.Text = attack.AttackBonus.ToString();
            numMeleeMisc.Value = attack.MiscMeleeMod;
            lblMeleeTotal.Text = attack.MeleeAttackBonus.ToString();
            lblRangedBonus.Text = attack.AttackBonus.ToString();
            numRangedMisc.Value = attack.MiscRangedMod;
            lblRangedTotal.Text = attack.RangedAttackBonus.ToString();
            lblThrownBonus.Text = attack.AttackBonus.ToString();
            numThrownMisc.Value = attack.MiscThrownMod;
            lblThrownTotal.Text = attack.ThrownAttackBonus.ToString();
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
            _character.Attack.MiscMeleeMod = Convert.ToInt32(numMeleeMisc.Value);
            _character.Attack.MiscRangedMod = Convert.ToInt32(numRangedMisc.Value);
            _character.Attack.MiscThrownMod = Convert.ToInt32(numThrownMisc.Value);

            _baseControl.UpdateCharacter(_character);
        }
    }
}
