namespace FeetInches
{
    partial class FeetInches
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
            this.BtnFeetInches = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFeetInches
            // 
            this.BtnFeetInches.Location = new System.Drawing.Point(264, 85);
            this.BtnFeetInches.Name = "BtnFeetInches";
            this.BtnFeetInches.Size = new System.Drawing.Size(289, 69);
            this.BtnFeetInches.TabIndex = 0;
            this.BtnFeetInches.Text = "Feet and Inches";
            this.BtnFeetInches.UseVisualStyleBackColor = true;
            this.BtnFeetInches.Click += new System.EventHandler(this.BtnFeetInches_Click);
            // 
            // FeetInches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FeetInches.Properties.Resources.tumblr_pb8hguHlKw1qztcdbo1_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFeetInches);
            this.Name = "FeetInches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feet and Inches";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFeetInches;
    }
}

