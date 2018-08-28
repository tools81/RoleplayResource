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
    public partial class SavingThrowControl : UserControl
    {
        private Base _baseControl;
        private Character _character;

        public SavingThrowControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.Starfinder_Banner_SavingThrows;

            _baseControl = baseControl;
            _character = character;

            PopulateValues(_character.SavingThrow);
            AddEvent(this);
        }

        public void PopulateValues(SavingThrow savingThrow)
        {
            lblFortitudeBase.Text = savingThrow.BaseFortitude.ToString();
            numFortitudeMisc.Value = savingThrow.MiscFortitudeMod;
            lblFortitudeTotal.Text = savingThrow.FortitudeSave.ToString();
            lblReflexBase.Text = savingThrow.BaseReflex.ToString();
            numReflexMisc.Value = savingThrow.MiscReflexMod;
            lblReflexTotal.Text = savingThrow.ReflexSave.ToString();
            lblWillBase.Text = savingThrow.BaseWill.ToString();
            numWillMisc.Value= savingThrow.MiscWillMod;
            lblWillTotal.Text = savingThrow.WillSave.ToString();
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
            _character.SavingThrow.MiscFortitudeMod = Convert.ToInt32(numFortitudeMisc.Value);
            _character.SavingThrow.MiscReflexMod = Convert.ToInt32(numReflexMisc.Value);
            _character.SavingThrow.MiscWillMod = Convert.ToInt32(numWillMisc.Value);

            _baseControl.UpdateCharacter(_character);
        }
    }
}
