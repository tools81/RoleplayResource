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
    public partial class InitiativeControl : UserControl
    {
        private Base _baseControl;
        private Character _character;

        public InitiativeControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.Starfinder_Banner_Initiative;

            _baseControl = baseControl;
            _character = character;

            PopulateValues(_character.Init);
            AddEvent(this);
        }

        public void PopulateValues(Initiative init)
        {
            numInitMisc.Text = init.MiscMod.ToString();
            lblTotal.Text = init.Total.ToString();
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
            _character.Init.MiscMod = Convert.ToInt32(numInitMisc.Value);

            _baseControl.UpdateCharacter(_character);
        }
    }
}
