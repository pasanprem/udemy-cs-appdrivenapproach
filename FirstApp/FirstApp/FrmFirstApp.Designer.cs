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
            this.BtnHello = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpMood = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.PicSad = new System.Windows.Forms.PictureBox();
            this.PicSmile = new System.Windows.Forms.PictureBox();
            this.PicTwo = new System.Windows.Forms.PictureBox();
            this.PicOne = new System.Windows.Forms.PictureBox();
            this.GrpMood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOne)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is my first app";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(119, 70);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(381, 20);
            this.TxtName.TabIndex = 1;
            // 
            // BtnHello
            // 
            this.BtnHello.Location = new System.Drawing.Point(93, 332);
            this.BtnHello.Name = "BtnHello";
            this.BtnHello.Size = new System.Drawing.Size(163, 54);
            this.BtnHello.TabIndex = 4;
            this.BtnHello.Text = "Hello";
            this.BtnHello.UseVisualStyleBackColor = true;
            this.BtnHello.Click += new System.EventHandler(this.BtnHello_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(354, 333);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(156, 53);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GrpMood
            // 
            this.GrpMood.Controls.Add(this.radioButton2);
            this.GrpMood.Controls.Add(this.radioButton1);
            this.GrpMood.Location = new System.Drawing.Point(652, 61);
            this.GrpMood.Name = "GrpMood";
            this.GrpMood.Size = new System.Drawing.Size(103, 134);
            this.GrpMood.TabIndex = 6;
            this.GrpMood.TabStop = false;
            this.GrpMood.Text = "Mood";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Happy";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sad";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // PicSad
            // 
            this.PicSad.Image = global::FirstApp.Properties.Resources.sad_smiley;
            this.PicSad.Location = new System.Drawing.Point(655, 356);
            this.PicSad.Name = "PicSad";
            this.PicSad.Size = new System.Drawing.Size(96, 61);
            this.PicSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSad.TabIndex = 9;
            this.PicSad.TabStop = false;
            this.PicSad.Visible = false;
            // 
            // PicSmile
            // 
            this.PicSmile.Image = global::FirstApp.Properties.Resources.Mr__Smiley_Face_svg;
            this.PicSmile.Location = new System.Drawing.Point(655, 241);
            this.PicSmile.Name = "PicSmile";
            this.PicSmile.Size = new System.Drawing.Size(97, 82);
            this.PicSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSmile.TabIndex = 8;
            this.PicSmile.TabStop = false;
            this.PicSmile.Visible = false;
            // 
            // PicTwo
            // 
            this.PicTwo.Image = ((System.Drawing.Image)(resources.GetObject("PicTwo.Image")));
            this.PicTwo.Location = new System.Drawing.Point(333, 159);
            this.PicTwo.Name = "PicTwo";
            this.PicTwo.Size = new System.Drawing.Size(198, 118);
            this.PicTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTwo.TabIndex = 3;
            this.PicTwo.TabStop = false;
            // 
            // PicOne
            // 
            this.PicOne.Image = global::FirstApp.Properties.Resources.T1VTgUev_TYhd;
            this.PicOne.Location = new System.Drawing.Point(73, 159);
            this.PicOne.Name = "PicOne";
            this.PicOne.Size = new System.Drawing.Size(203, 118);
            this.PicOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOne.TabIndex = 2;
            this.PicOne.TabStop = false;
            // 
            // FrmFirstApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(844, 524);
            this.Controls.Add(this.PicSad);
            this.Controls.Add(this.PicSmile);
            this.Controls.Add(this.GrpMood);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnHello);
            this.Controls.Add(this.PicTwo);
            this.Controls.Add(this.PicOne);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Name = "FrmFirstApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First App";
            this.GrpMood.ResumeLayout(false);
            this.GrpMood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.PictureBox PicOne;
        private System.Windows.Forms.PictureBox PicTwo;
        private System.Windows.Forms.Button BtnHello;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GrpMood;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox PicSmile;
        private System.Windows.Forms.PictureBox PicSad;
    }
}

