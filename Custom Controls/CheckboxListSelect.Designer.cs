namespace Custom_Controls
{
    partial class CheckboxListSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.clbCheckboxItems = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(77, 20);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "lblHeader";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(317, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // clbCheckboxItems
            // 
            this.clbCheckboxItems.BackColor = System.Drawing.SystemColors.Control;
            this.clbCheckboxItems.CheckOnClick = true;
            this.clbCheckboxItems.ColumnWidth = 190;
            this.clbCheckboxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCheckboxItems.FormattingEnabled = true;
            this.clbCheckboxItems.Location = new System.Drawing.Point(12, 31);
            this.clbCheckboxItems.MultiColumn = true;
            this.clbCheckboxItems.Name = "clbCheckboxItems";
            this.clbCheckboxItems.Size = new System.Drawing.Size(380, 172);
            this.clbCheckboxItems.TabIndex = 4;
            this.clbCheckboxItems.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCheckboxItems_ItemCheck);
            // 
            // CheckboxListSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.clbCheckboxItems);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckboxListSelect";
            this.Text = "Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox clbCheckboxItems;
    }
}