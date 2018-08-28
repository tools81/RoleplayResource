namespace Views.Starfinder.Create
{
    partial class AbilitiesControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridAbilities = new System.Windows.Forms.DataGridView();
            this.imgBanner = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboAbilities = new System.Windows.Forms.ComboBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.AbilityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridAbilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridAbilities
            // 
            this.gridAbilities.AllowUserToAddRows = false;
            this.gridAbilities.AllowUserToDeleteRows = false;
            this.gridAbilities.AllowUserToOrderColumns = true;
            this.gridAbilities.AllowUserToResizeColumns = false;
            this.gridAbilities.AllowUserToResizeRows = false;
            this.gridAbilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAbilities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AbilityName,
            this.Info,
            this.Edit});
            this.gridAbilities.Location = new System.Drawing.Point(3, 40);
            this.gridAbilities.MultiSelect = false;
            this.gridAbilities.Name = "gridAbilities";
            this.gridAbilities.RowHeadersVisible = false;
            this.gridAbilities.ShowEditingIcon = false;
            this.gridAbilities.Size = new System.Drawing.Size(362, 274);
            this.gridAbilities.TabIndex = 4;
            this.gridAbilities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAbilities_CellContentClick);
            this.gridAbilities.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAbilities_CellMouseEnter);
            // 
            // imgBanner
            // 
            this.imgBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBanner.Location = new System.Drawing.Point(3, 3);
            this.imgBanner.Name = "imgBanner";
            this.imgBanner.Size = new System.Drawing.Size(300, 31);
            this.imgBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBanner.TabIndex = 3;
            this.imgBanner.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.cboAbilities, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 320);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 30);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // cboAbilities
            // 
            this.cboAbilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAbilities.FormattingEnabled = true;
            this.cboAbilities.Location = new System.Drawing.Point(3, 3);
            this.cboAbilities.MaxDropDownItems = 10;
            this.cboAbilities.Name = "cboAbilities";
            this.cboAbilities.Size = new System.Drawing.Size(264, 24);
            this.cboAbilities.TabIndex = 6;
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
            // AbilityName
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.AbilityName.DefaultCellStyle = dataGridViewCellStyle1;
            this.AbilityName.HeaderText = "Name";
            this.AbilityName.Name = "AbilityName";
            this.AbilityName.ReadOnly = true;
            this.AbilityName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AbilityName.Width = 290;
            // 
            // Info
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Views.Properties.Resources.Button_Info";
            this.Info.DefaultCellStyle = dataGridViewCellStyle2;
            this.Info.HeaderText = "";
            this.Info.Image = global::Views.Properties.Resources.Button_Info;
            this.Info.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Info.Name = "Info";
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
            // AbilitiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gridAbilities);
            this.Controls.Add(this.imgBanner);
            this.Name = "AbilitiesControl";
            this.Size = new System.Drawing.Size(368, 364);
            ((System.ComponentModel.ISupportInitialize)(this.gridAbilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBanner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboAbilities;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridAbilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbilityName;
        private System.Windows.Forms.DataGridViewImageColumn Info;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}
