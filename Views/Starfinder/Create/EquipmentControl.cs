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
using Views.Shared;

namespace Views.Starfinder.Create
{
    public partial class EquipmentControl : UserControl
    {
        private Base _baseControl;
        private Character _character;
        private ToolTip _toolTip = new ToolTip();

        public EquipmentControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.Starfinder_Banner_Equipment;

            _baseControl = baseControl;
            _character = character;

            cboEquipment.DataSource = Lists.Equipments
                            .OrderBy(p => p.Name)
                            .Select(p => p.Name)
                            .ToList();

            PopulateValues(_character.Equipments);
        }

        public void PopulateValues(List<Equipment> equipment)
        {
            numCredits.Value = _character.Credits;

            gridEquipment.Rows.Clear();
            foreach (var item in equipment)
            {
                if (item != null)
                    gridEquipment.Rows.Add(item.Name, item.Value, item.Bulk);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Equipment item = Lists.Equipments.FirstOrDefault(a => a.Name == cboEquipment.Text);
            if (!_character.Equipments.Contains(item))
                _character.Equipments.Add(item);
            _baseControl.UpdateCharacter(_character);
        }

        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            var description = Lists.Equipments.FirstOrDefault(f => f.Name == cboEquipment.Text).Description;
            _toolTip.Show(RegExHelper.Wordwrap(description, 100), this.btnInfo, 32767);
        }

        private void cboEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipment equip = Lists.Equipments.FirstOrDefault(p => p.Name == cboEquipment.Text);
            txtBulk.Text = equip.Bulk;
            numLevel.Value = equip.Level;
            numCost.Value = equip.Value;
        }

        private void gridEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                Equipment item = _character.Equipments.FirstOrDefault(f => f.Name == gridEquipment.Rows[e.RowIndex].Cells["EquipmentName"].Value.ToString());
                _character.Equipments.Remove(item);
                _baseControl.UpdateCharacter(_character);
            }
        }

        private void gridEquipment_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                var description = Lists.Equipments.FirstOrDefault(f => f.Name == gridEquipment.Rows[e.RowIndex].Cells[0].Value.ToString()).Description;
                gridEquipment.Rows[e.RowIndex].Cells[3].ToolTipText = description;
            }
        }
    }
}
