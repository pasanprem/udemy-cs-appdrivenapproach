namespace FirstApp
{
    partial class FrmFirstApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirstApp));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.PicOne = new System.Windows.Forms.PictureBox();
            this.PicTwo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is my first app";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(151, 70);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(381, 20);
            this.TxtName.TabIndex = 1;
            // 
            // PicOne
            // 
            this.PicOne.Image = global::FirstApp.Properties.Resources.T1VTgUev_TYhd;
            this.PicOne.Location = new System.Drawing.Point(77, 160);
            this.PicOne.Name = "PicOne";
            this.PicOne.Size = new System.Drawing.Size(203, 118);
            this.PicOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOne.TabIndex = 2;
            this.PicOne.TabStop = false;
            // 
            // PicTwo
            // 
            this.PicTwo.Image = ((System.Drawing.Image)(resources.GetObject("PicTwo.Image")));
            this.PicTwo.Location = new System.Drawing.Point(322, 159);
            this.PicTwo.Name = "PicTwo";
            this.PicTwo.Size = new System.Drawing.Size(198, 118);
            this.PicTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTwo.TabIndex = 3;
            this.PicTwo.TabStop = false;
            // 
            // FrmFirstApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicTwo);
            this.Controls.Add(this.PicOne);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Name = "FrmFirstApp";
            this.Text = "First App";
            ((System.ComponentModel.ISupportInitialize)(this.PicOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.PictureBox PicOne;
        private System.Windows.Forms.PictureBox PicTwo;
    }
}

