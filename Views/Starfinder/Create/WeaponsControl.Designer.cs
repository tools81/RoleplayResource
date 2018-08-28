namespace Views.Starfinder.Create
{
    partial class WeaponsControl
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
            this.pnlWeapons = new System.Windows.Forms.FlowLayoutPanel();
            this.imgBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWeapons
            // 
            this.pnlWeapons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlWeapons.Location = new System.Drawing.Point(3, 40);
            this.pnlWeapons.Name = "pnlWeapons";
            this.pnlWeapons.Size = new System.Drawing.Size(362, 549);
            this.pnlWeapons.TabIndex = 4;
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
            // WeaponsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlWeapons);
            this.Controls.Add(this.imgBanner);
            this.Name = "WeaponsControl";
            this.Size = new System.Drawing.Size(368, 592);
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBanner;
        private System.Windows.Forms.FlowLayoutPanel pnlWeapons;
    }
}
