namespace Rep
{
    partial class FrmRep
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
            this.BtnRep = new System.Windows.Forms.Button();
            this.BtnCounter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRep
            // 
            this.BtnRep.Location = new System.Drawing.Point(185, 77);
            this.BtnRep.Name = "BtnRep";
            this.BtnRep.Size = new System.Drawing.Size(190, 54);
            this.BtnRep.TabIndex = 0;
            this.BtnRep.Text = "Rep Example";
            this.BtnRep.UseVisualStyleBackColor = true;
            this.BtnRep.Click += new System.EventHandler(this.BtnRep_Click);
            // 
            // BtnCounter
            // 
            this.BtnCounter.Location = new System.Drawing.Point(185, 176);
            this.BtnCounter.Name = "BtnCounter";
            this.BtnCounter.Size = new System.Drawing.Size(189, 48);
            this.BtnCounter.TabIndex = 1;
            this.BtnCounter.Text = "Counter Loop";
            this.BtnCounter.UseVisualStyleBackColor = true;
            this.BtnCounter.Click += new System.EventHandler(this.BtnCounter_Click);
            // 
            // FrmRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rep.Properties.Resources.Easy_Fantasy_Art_Drawings_3_e1572083237870;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 396);
            this.Controls.Add(this.BtnCounter);
            this.Controls.Add(this.BtnRep);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rep Intro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRep;
        private System.Windows.Forms.Button BtnCounter;
    }
}

