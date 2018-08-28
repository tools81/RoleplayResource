namespace Views.Starfinder.Create
{
    partial class FeatsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridFeats = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboFeats = new System.Windows.Forms.ComboBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPrerequisite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.imgBanner = new System.Windows.Forms.PictureBox();
            this.FeatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridFeats)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFeats
            // 
            this.gridFeats.AllowUserToAddRows = false;
            this.gridFeats.AllowUserToDeleteRows = false;
            this.gridFeats.AllowUserToResizeColumns = false;
            this.gridFeats.AllowUserToResizeRows = false;
            this.gridFeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFeats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeatName,
            this.Info,
            this.Edit});
            this.gridFeats.Location = new System.Drawing.Point(3, 73);
            this.gridFeats.MultiSelect = false;
            this.gridFeats.Name = "gridFeats";
            this.gridFeats.RowHeadersVisible = false;
            this.gridFeats.Size = new System.Drawing.Size(362, 230);
            this.gridFeats.TabIndex = 4;
            this.gridFeats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFeats_CellContentClick);
            this.gridFeats.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFeats_CellMouseEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Controls.Add(this.cboFeats, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 309);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 30);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // cboFeats
            // 
            this.cboFeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFeats.FormattingEnabled = true;
            this.cboFeats.Location = new System.Drawing.Point(3, 3);
            this.cboFeats.MaxDropDownItems = 10;
            this.cboFeats.Name = "cboFeats";
            this.cboFeats.Size = new System.Drawing.Size(264, 24);
            this.cboFeats.TabIndex = 6;
            this.cboFeats.SelectedIndexChanged += new System.EventHandler(this.cboFeats_SelectedIndexChanged);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.White;
            this.btnInfo.BackgroundImage = global::Views.Properties.Resources.Button_Info;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(273, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(24, 23);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.MouseEnter += new System.EventHandler(this.btnInfo_MouseEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = global::Views.Properties.Resources.Button_Add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(319, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPrerequisite
            // 
            this.lblPrerequisite.AutoSize = true;
            this.lblPrerequisite.Location = new System.Drawing.Point(75, 342);
            this.lblPrerequisite.Name = "lblPrerequisite";
            this.lblPrerequisite.Size = new System.Drawing.Size(72, 13);
            this.lblPrerequisite.TabIndex = 6;
            this.lblPrerequisite.Text = "lblPrerequisite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prerequisite:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Views.Properties.Resources.Button_Info;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 25;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Views.Properties.Resources.Button_Remove;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 25;
            // 
            // imgBanner
            // 
            this.imgBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBanner.Location = new System.Drawing.Point(3, 3);
            this.imgBanner.Name = "imgBanner";
            this.imgBanner.Size = new System.Drawing.Size(300, 64);
            this.imgBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBanner.TabIndex = 3;
            this.imgBanner.TabStop = false;
            // 
            // FeatName
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.FeatName.DefaultCellStyle = dataGridViewCellStyle1;
            this.FeatName.HeaderText = "Name";
            this.FeatName.Name = "FeatName";
            this.FeatName.ReadOnly = true;
            this.FeatName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FeatName.Width = 290;
            // 
            // Info
            // 
            this.Info.HeaderText = "";
            this.Info.Image = global::Views.Properties.Resources.Button_Info;
            this.Info.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Info.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Info.Width = 25;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::Views.Properties.Resources.Button_Remove;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 25;
            // 
            // FeatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrerequisite);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gridFeats);
            this.Controls.Add(this.imgBanner);
            this.Name = "FeatsControl";
            this.Size = new System.Drawing.Size(368, 364);
            ((System.ComponentModel.ISupportInitialize)(this.gridFeats)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBanner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboFeats;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridFeats;
        private System.Windows.Forms.Label lblPrerequisite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatName;
        private System.Windows.Forms.DataGridViewImageColumn Info;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}
