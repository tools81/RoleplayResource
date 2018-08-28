namespace Views.Starfinder.Create
{
    partial class HealthControl
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
            this.lblStamina = new System.Windows.Forms.Label();
            this.lblHit = new System.Windows.Forms.Label();
            this.lblResolve = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // lblStamina
            // 
            this.lblStamina.AutoSize = true;
            this.lblStamina.Location = new System.Drawing.Point(171, 60);
            this.lblStamina.Name = "lblStamina";
            this.lblStamina.Size = new System.Drawing.Size(13, 13);
            this.lblStamina.TabIndex = 4;
            this.lblStamina.Text = "0";
            // 
            // lblHit
            // 
            this.lblHit.AutoSize = true;
            this.lblHit.Location = new System.Drawing.Point(286, 60);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(13, 13);
            this.lblHit.TabIndex = 5;
            this.lblHit.Text = "0";
            // 
            // lblResolve
            // 
            this.lblResolve.AutoSize = true;
            this.lblResolve.Location = new System.Drawing.Point(393, 60);
            this.lblResolve.Name = "lblResolve";
            this.lblResolve.Size = new System.Drawing.Size(13, 13);
            this.lblResolve.TabIndex = 6;
            this.lblResolve.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stamina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resolve";
            // 
            // HealthControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResolve);
            this.Controls.Add(this.lblHit);
            this.Controls.Add(this.lblStamina);
            this.Controls.Add(this.imgBanner);
            this.Name = "HealthControl";
            this.Size = new System.Drawing.Size(468, 84);
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBanner;
        private System.Windows.Forms.Label lblStamina;
        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.Label lblResolve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
