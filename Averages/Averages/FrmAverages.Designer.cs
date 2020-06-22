namespace Averages
{
    partial class FrmAverages
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
            this.BtnAverages = new System.Windows.Forms.Button();
            this.BtnVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAverages
            // 
            this.BtnAverages.Location = new System.Drawing.Point(231, 147);
            this.BtnAverages.Name = "BtnAverages";
            this.BtnAverages.Size = new System.Drawing.Size(201, 74);
            this.BtnAverages.TabIndex = 0;
            this.BtnAverages.Text = "Averages";
            this.BtnAverages.UseVisualStyleBackColor = true;
            this.BtnAverages.Click += new System.EventHandler(this.BtnAverages_Click);
            // 
            // BtnVolume
            // 
            this.BtnVolume.Location = new System.Drawing.Point(245, 284);
            this.BtnVolume.Name = "BtnVolume";
            this.BtnVolume.Size = new System.Drawing.Size(186, 49);
            this.BtnVolume.TabIndex = 1;
            this.BtnVolume.Text = "Volume of Box";
            this.BtnVolume.UseVisualStyleBackColor = true;
            this.BtnVolume.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAverages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Averages.Properties.Resources._564654;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVolume);
            this.Controls.Add(this.BtnAverages);
            this.Name = "FrmAverages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Averages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAverages;
        private System.Windows.Forms.Button BtnVolume;
    }
}

