namespace Roleplay_Resource
{
    partial class Splash
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
            this.pnlGameSelect = new System.Windows.Forms.Panel();
            this.lblGameSelect = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.lstCharacters = new System.Windows.Forms.ListBox();
            this.fbdSourceDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSourceMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlGameSelect
            // 
            this.pnlGameSelect.Location = new System.Drawing.Point(7, 41);
            this.pnlGameSelect.Name = "pnlGameSelect";
            this.pnlGameSelect.Size = new System.Drawing.Size(442, 86);
            this.pnlGameSelect.TabIndex = 0;
            // 
            // lblGameSelect
            // 
            this.lblGameSelect.AutoSize = true;
            this.lblGameSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameSelect.ForeColor = System.Drawing.Color.White;
            this.lblGameSelect.Location = new System.Drawing.Point(12, 9);
            this.lblGameSelect.Name = "lblGameSelect";
            this.lblGameSelect.Size = new System.Drawing.Size(99, 29);
            this.lblGameSelect.TabIndex = 1;
            this.lblGameSelect.Text = "Ruleset";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Black;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(12, 132);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(99, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Character";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Black;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(117, 132);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Character";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSource
            // 
            this.btnSource.BackColor = System.Drawing.Color.Black;
            this.btnSource.ForeColor = System.Drawing.Color.White;
            this.btnSource.Location = new System.Drawing.Point(337, 132);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(99, 23);
            this.btnSource.TabIndex = 4;
            this.btnSource.Text = "Change Source";
            this.btnSource.UseVisualStyleBackColor = false;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // lstCharacters
            // 
            this.lstCharacters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.ItemHeight = 25;
            this.lstCharacters.Location = new System.Drawing.Point(12, 189);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(424, 229);
            this.lstCharacters.TabIndex = 5;
            this.lstCharacters.SelectedIndexChanged += new System.EventHandler(this.lstCharacters_SelectedIndexChanged);
            // 
            // lblSourceMessage
            // 
            this.lblSourceMessage.AutoSize = true;
            this.lblSourceMessage.ForeColor = System.Drawing.Color.White;
            this.lblSourceMessage.Location = new System.Drawing.Point(212, 158);
            this.lblSourceMessage.Name = "lblSourceMessage";
            this.lblSourceMessage.Size = new System.Drawing.Size(227, 13);
            this.lblSourceMessage.TabIndex = 6;
            this.lblSourceMessage.Text = "Source Directory requires update! Click above!";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(451, 442);
            this.Controls.Add(this.lblSourceMessage);
            this.Controls.Add(this.lstCharacters);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblGameSelect);
            this.Controls.Add(this.pnlGameSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.Text = "Roleplay Resource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameSelect;
        private System.Windows.Forms.Label lblGameSelect;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.ListBox lstCharacters;
        private System.Windows.Forms.FolderBrowserDialog fbdSourceDirectory;
        private System.Windows.Forms.Label lblSourceMessage;
    }
}

