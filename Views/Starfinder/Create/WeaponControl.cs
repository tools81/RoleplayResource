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
    public partial class WeaponControl : UserControl
    {
        private Base _baseControl;
        private Character _character;
        private int _index;
        private bool _onFirstCall = true;

        public WeaponControl(Character character, Base baseControl, int index)
        {
            InitializeComponent();

            _baseControl = baseControl;
            _character = character;
            _index = index;

            cboWeaponName.DataSource = Lists.Weapons
                            .OrderBy(p => p.Name)
                            .Select(p => p.Name)
                            .ToList();

            cboType.DataSource = Enum.GetValues(typeof(Enums.WeaponType))
                .Cast<Enum>()
                .ToList();
            cboType.DisplayMember = "value";
            cboType.SelectedIndex = -1;
        }

        private void cboWeaponName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_character.Weapons[_index].Name == null && _onFirstCall)
            {
                cboWeaponName.SelectedItem = null;
                _onFirstCall = false;
            }

            Weapon weapon = Lists.Weapons.FirstOrDefault(w => w.Name == cboWeaponName.Text);

            if (weapon != null)
            {
                txtAmmo.Text = weapon.Ammo;
                numBonus.Value = _character.Attack.AttackBonus + weapon.AttackBonus;
                numCost.Value = weapon.Value;
                txtCritical.Text = weapon.Critical;
                txtDamage.Text = weapon.DamageBonus > 0 ? weapon.Damage + $"+{weapon.DamageBonus}" : weapon.Damage;
                numLevel.Value = weapon.Level;
                txtRange.Text = weapon.Range;
                cboType.Text = weapon.Type.ToString();
                txtSpecial.Text = string.Join(";", weapon.Specials);

                _character.Weapons[_index] = weapon;
                _baseControl.UpdateCharacter(_character);
            }                       
        }

        public void SetSelectedWeapon(Weapon weapon)
        {

        }
    }
}
