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
    public partial class WeaponsControl : UserControl
    {
        private Base _baseControl;
        private Character _character;

        public WeaponsControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.Starfinder_Banner_Weapons;

            _baseControl = baseControl;
            _character = character;

            var weaponControlLimit = 4;
            for (int i = 0; i < weaponControlLimit; i++)
            {
                WeaponControl weaponControl = new WeaponControl(_character, _baseControl, i);
                pnlWeapons.Controls.Add(weaponControl);
            }

            PopulateValues(_character.Weapons);
        }

        public void PopulateValues(List<Weapon> weapons)
        {
            int index = 0;
            foreach (var weapon in weapons)
            {
                if (!string.IsNullOrEmpty(weapon.Name))
                    ((WeaponControl)pnlWeapons.Controls[index]).SetSelectedWeapon(weapon);
            }
        }
    }
}
