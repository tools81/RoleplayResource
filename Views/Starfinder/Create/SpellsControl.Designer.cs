namespace Views.Starfinder.Create
{
    partial class SpellsControl
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
            this.imgBanner = new System.Windows.Forms.PictureBox();
            this.pnlSpells = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            this.SuspendLayout();
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
            // pnlSpells
            // 
            this.pnlSpells.AutoScroll = true;
            this.pnlSpells.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlSpells.Location = new System.Drawing.Point(3, 40);
            this.pnlSpells.Name = "pnlSpells";
            this.pnlSpells.Size = new System.Drawing.Size(462, 766);
            this.pnlSpells.TabIndex = 4;
            this.pnlSpells.WrapContents = false;
            // 
            // SpellsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSpells);
            this.Controls.Add(this.imgBanner);
            this.Name = "SpellsControl";
            this.Size = new System.Drawing.Size(468, 809);
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBanner;
        private System.Windows.Forms.FlowLayoutPanel pnlSpells;
    }
}
