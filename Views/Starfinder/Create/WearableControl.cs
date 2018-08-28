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

namespace Views.Starfinder.Create
{
    public partial class WearableControl : UserControl
    {
        private Base _baseControl;
        private Character _character;
        private bool _onFirstCall = true;

        public WearableControl(Character character, Base baseControl)
        {
            InitializeComponent();

            _baseControl = baseControl;
            _character = character;

            imgArmorBanner.Image = Properties.Resources.Starfinder_Banner_Armor;

            cboArmorName.DataSource = Lists.Armors
                            .OrderBy(p => p.Name)
                            .Select(p => p.Name)
                            .ToList();

            PopulateValues(_character);
        }

        public void PopulateValues(Character _character)
        {
            if (_character.Armor.Name == null && _onFirstCall)
            {
                cboArmorName.SelectedItem = null;
                _onFirstCall = false;
            }

            var armor = Lists.Armors.FirstOrDefault(a => a.Name == cboArmorName.Text);

            if (armor == null)
                return;

            _character.Armor = armor;
            _character.ArmorClass.WearableEnergyBonus = armor.EAC;
            _character.ArmorClass.WearableKineticBonus = armor.KAC;
            txtBulk.Text = armor.Bulk.ToString();
            numCost.Value = armor.Value;
            numEac.Value = armor.EAC;
            numKac.Value = armor.KAC;
            numLevel.Value = armor.Level;
            numMaxDex.Value = armor.MaxDex;
            numPenalty.Value = armor.Penalty;
            numSpeedAdjustment.Value = armor.SpeedAdjust;
            numSlots.Value = armor.UpgradeSlots;
        }

        private void cboArmorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateValues(_character);
            _baseControl.UpdateCharacter(_character);
        }     
    }
}
