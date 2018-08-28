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
    public partial class FeatsControl : UserControl
    {
        private Base _baseControl;
        private Character _character;
        private ToolTip _toolTip = new ToolTip();

        public FeatsControl(Character character, Base baseControl)
        {
            InitializeComponent();

            imgBanner.Image = Properties.Resources.StarFinder_Banner_Feats;

            _baseControl = baseControl;
            _character = character;

            cboFeats.DataSource = Lists.Feats
                            .OrderBy(p => p.Name)
                            .Select(p => p.Name)
                            .ToList();

            PopulateValues(_character.Feats);
        }

        public void PopulateValues(List<Feat> feats)
        {
            gridFeats.Rows.Clear();
            foreach (var feat in feats)
            {
                if (feat != null)
                    gridFeats.Rows.Add(feat.Name);
            }           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Feat feat = Lists.Feats.FirstOrDefault(a => a.Name == cboFeats.Text);
            if (!_character.Feats.Contains(feat))
                _character.Feats.Add(feat);
            _baseControl.UpdateCharacter(_character);
        }

        private void gridFeats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                Feat feat = _character.Feats.FirstOrDefault(f => f.Name == gridFeats.Rows[e.RowIndex].Cells["FeatName"].Value.ToString());
                _character.Feats.Remove(feat);
                _baseControl.UpdateCharacter(_character);
            }
        }

        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            var description = Lists.Feats.FirstOrDefault(f => f.Name == cboFeats.Text).Description;
            _toolTip.Show(RegExHelper.Wordwrap(description, 100), this.btnInfo, 32767);
        }

        private void gridFeats_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                var description = Lists.Feats.FirstOrDefault(f => f.Name == gridFeats.Rows[e.RowIndex].Cells[0].Value.ToString()).Description;
                gridFeats.Rows[e.RowIndex].Cells[1].ToolTipText = description;
            }
        }

        private void cboFeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrerequisite.Text = Lists.Feats.Where(f => f.Name == cboFeats.Text).Select(f => f.Prereq).FirstOrDefault();
        }
    }
}
