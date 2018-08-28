namespace Views.Starfinder.Create
{
    partial class EquipmentControl
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
            this.imgBanner = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numCredits = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboEquipment = new System.Windows.Forms.ComboBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridEquipment = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.txtBulk = new System.Windows.Forms.TextBox();
            this.EquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bulk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredits)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBanner
            // 
            this.imgBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBanner.Location = new System.Drawing.Point(3, 27);
            this.imgBanner.Name = "imgBanner";
            this.imgBanner.Size = new System.Drawing.Size(300, 31);
            this.imgBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBanner.TabIndex = 3;
            this.imgBanner.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Credits: $";
            // 
            // numCredits
            // 
            this.numCredits.Location = new System.Drawing.Point(297, 5);
            this.numCredits.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCredits.Name = "numCredits";
            this.numCredits.Size = new System.Drawing.Size(68, 20);
            this.numCredits.TabIndex = 5;
            this.numCredits.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Controls.Add(this.cboEquipment, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 296);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 30);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // cboEquipment
            // 
            this.cboEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEquipment.FormattingEnabled = true;
            this.cboEquipment.Location = new System.Drawing.Point(3, 3);
            this.cboEquipment.MaxDropDownItems = 10;
            this.cboEquipment.Name = "cboEquipment";
            this.cboEquipment.Size = new System.Drawing.Size(264, 24);
            this.cboEquipment.TabIndex = 6;
            this.cboEquipment.SelectedIndexChanged += new System.EventHandler(this.cboEquipment_SelectedIndexChanged);
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
            // gridEquipment
            // 
            this.gridEquipment.AllowUserToAddRows = false;
            this.gridEquipment.AllowUserToDeleteRows = false;
            this.gridEquipment.AllowUserToResizeColumns = false;
            this.gridEquipment.AllowUserToResizeRows = false;
            this.gridEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipmentName,
            this.Cost,
            this.Bulk,
            this.Info,
            this.Edit});
            this.gridEquipment.Location = new System.Drawing.Point(3, 64);
            this.gridEquipment.MultiSelect = false;
            this.gridEquipment.Name = "gridEquipment";
            this.gridEquipment.RowHeadersVisible = false;
            this.gridEquipment.Size = new System.Drawing.Size(362, 226);
            this.gridEquipment.TabIndex = 6;
            this.gridEquipment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEquipment_CellContentClick);
            this.gridEquipment.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEquipment_CellMouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bulk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost: $";
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(56, 337);
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(37, 20);
            this.numLevel.TabIndex = 14;
            // 
            // numCost
            // 
            this.numCost.Location = new System.Drawing.Point(224, 337);
            this.numCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(72, 20);
            this.numCost.TabIndex = 15;
            // 
            // txtBulk
            // 
            this.txtBulk.Location = new System.Drawing.Point(130, 336);
            this.txtBulk.Name = "txtBulk";
            this.txtBulk.Size = new System.Drawing.Size(42, 20);
            this.txtBulk.TabIndex = 16;
            // 
            // EquipmentName
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.EquipmentName.DefaultCellStyle = dataGridViewCellStyle1;
            this.EquipmentName.HeaderText = "Name";
            this.EquipmentName.Name = "EquipmentName";
            this.EquipmentName.ReadOnly = true;
            this.EquipmentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EquipmentName.Width = 201;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.Width = 60;
            // 
            // Bulk
            // 
            this.Bulk.HeaderText = "Bulk";
            this.Bulk.Name = "Bulk";
            this.Bulk.Width = 30;
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
            // EquipmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBulk);
            this.Controls.Add(this.numCost);
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gridEquipment);
            this.Controls.Add(this.numCredits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgBanner);
            this.Name = "EquipmentControl";
            this.Size = new System.Drawing.Size(369, 365);
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredits)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCredits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboEquipment;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridEquipment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.TextBox txtBulk;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bulk;
        private System.Windows.Forms.DataGridViewImageColumn Info;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}
