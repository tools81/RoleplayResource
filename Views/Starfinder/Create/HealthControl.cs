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
    public partial class HealthControl : UserControl
    {
        private Base _baseControl;
        private Character _character;

        public HealthControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.Starfinder_Banner_Health;

            _baseControl = baseControl;
            _character = character;

            PopulateValues(_character.Health);
        }

        public void PopulateValues(Health health)
        {
            lblStamina.Text = health.Stamina.ToString();
            lblHit.Text = health.HitPoints.ToString();
            lblResolve.Text = health.Resolve.ToString();            
        }
    }
}
