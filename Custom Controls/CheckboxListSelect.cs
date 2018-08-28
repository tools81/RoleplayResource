using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Controls
{
    public partial class CheckboxListSelect : Form
    {
        public string SelectedItem { get; set; }

        public CheckboxListSelect(string[] items, int bonusValue, string entity)
        {
            InitializeComponent();

            lblHeader.Text = $"Select a(n) {entity} to apply the bonus";

            ((ListBox)clbCheckboxItems).DataSource = items;
        }

        private void clbCheckboxItems_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbCheckboxItems.CheckedItems.Count == 1)
            {
                var isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    var checkedItemIndex = clbCheckboxItems.CheckedIndices[0];
                    clbCheckboxItems.ItemCheck -= clbCheckboxItems_ItemCheck;
                    clbCheckboxItems.SetItemChecked(checkedItemIndex, false);
                    clbCheckboxItems.ItemCheck += clbCheckboxItems_ItemCheck;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedItem = clbCheckboxItems.SelectedItem.ToString();
            this.Close();
        }
    }
}
