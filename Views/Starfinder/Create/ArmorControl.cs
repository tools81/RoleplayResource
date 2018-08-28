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
    public partial class ArmorControl : UserControl
    {
        private Base _baseControl;
        private Character _character;

        public ArmorControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.Starfinder_Banner_ArmorClass;

            _baseControl = baseControl;
            _character = character;

            PopulateValues(_character.ArmorClass);
            AddEvent(this);
        }

        public void PopulateValues(ArmorClass armorClass)
        {
            numDamageReduction.Value = armorClass.DamageReduction + armorClass.MiscDamageReductionMod;
            lblEnergyBonus.Text = armorClass.TotalEnergyBonus.ToString();
            lblKineticBonus.Text = armorClass.TotalKineticBonus.ToString();
            numEnergyMisc.Value = armorClass.MiscEnergyMod;
            numKineticMisc.Value = armorClass.MiscKineticMod;
            lblEnergyTotal.Text = armorClass.EnergyArmorClass.ToString();
            lblKineticTotal.Text = armorClass.KineticArmorClass.ToString();
            lblManeuversTotal.Text = armorClass.ManeuversArmorClass.ToString();
            lblResistances.Text = string.Join(";", armorClass.Resistances.Select(r => $"{r.Type.ToString()}-{r.Value.ToString()}").ToList());
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
            _character.ArmorClass.MiscEnergyMod = Convert.ToInt32(numEnergyMisc.Value);
            _character.ArmorClass.MiscKineticMod = Convert.ToInt32(numKineticMisc.Value);
            _character.ArmorClass.DamageReduction = Convert.ToInt32(numDamageReduction.Value);

            _baseControl.UpdateCharacter(_character);
        }
    }
}
