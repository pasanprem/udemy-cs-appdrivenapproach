namespace Combo
{
    partial class FrmCombo
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
            this.CboTest = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LstTest = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CboTest
            // 
            this.CboTest.FormattingEnabled = true;
            this.CboTest.Items.AddRange(new object[] {
            "London",
            "New York",
            "Paris"});
            this.CboTest.Location = new System.Drawing.Point(70, 84);
            this.CboTest.Name = "CboTest";
            this.CboTest.Size = new System.Drawing.Size(215, 21);
            this.CboTest.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dropdown Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LstTest
            // 
            this.LstTest.FormattingEnabled = true;
            this.LstTest.Location = new System.Drawing.Point(393, 88);
            this.LstTest.Name = "LstTest";
            this.LstTest.Size = new System.Drawing.Size(213, 147);
            this.LstTest.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate Numbers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(563, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Listbox Value";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(476, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "Remove Listbox Value";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Combo.Properties.Resources.dbd11ti_7d3adb13_dee2_4753_8b74_8006195a8cd4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LstTest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CboTest);
            this.Name = "FrmCombo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo Box Examples";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LstTest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

