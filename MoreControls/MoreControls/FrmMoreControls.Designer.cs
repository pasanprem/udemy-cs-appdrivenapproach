namespace MoreControls
{
    partial class FrmMoreControls
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
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.HsbNumber = new System.Windows.Forms.HScrollBar();
            this.MnColours = new System.Windows.Forms.MenuStrip();
            this.coloursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGoto = new System.Windows.Forms.Button();
            this.MnColours.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(384, 558);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(299, 20);
            this.TxtNumber.TabIndex = 0;
            // 
            // HsbNumber
            // 
            this.HsbNumber.LargeChange = 1;
            this.HsbNumber.Location = new System.Drawing.Point(55, 556);
            this.HsbNumber.Maximum = 50;
            this.HsbNumber.Name = "HsbNumber";
            this.HsbNumber.Size = new System.Drawing.Size(272, 24);
            this.HsbNumber.TabIndex = 1;
            this.HsbNumber.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbNumber_Scroll);
            // 
            // MnColours
            // 
            this.MnColours.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloursToolStripMenuItem});
            this.MnColours.Location = new System.Drawing.Point(0, 0);
            this.MnColours.Name = "MnColours";
            this.MnColours.Size = new System.Drawing.Size(759, 24);
            this.MnColours.TabIndex = 2;
            this.MnColours.Text = "menuStrip1";
            // 
            // coloursToolStripMenuItem
            // 
            this.coloursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.coloursToolStripMenuItem.Name = "coloursToolStripMenuItem";
            this.coloursToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.coloursToolStripMenuItem.Text = "Colours";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // BtnGoto
            // 
            this.BtnGoto.Location = new System.Drawing.Point(259, 204);
            this.BtnGoto.Name = "BtnGoto";
            this.BtnGoto.Size = new System.Drawing.Size(242, 114);
            this.BtnGoto.TabIndex = 3;
            this.BtnGoto.Text = "Go to second form";
            this.BtnGoto.UseVisualStyleBackColor = true;
            this.BtnGoto.Click += new System.EventHandler(this.BtnGoto_Click);
            // 
            // FrmMoreControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MoreControls.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 604);
            this.Controls.Add(this.BtnGoto);
            this.Controls.Add(this.HsbNumber);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.MnColours);
            this.MainMenuStrip = this.MnColours;
            this.Name = "FrmMoreControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "More Controls";
            this.MnColours.ResumeLayout(false);
            this.MnColours.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.HScrollBar HsbNumber;
        private System.Windows.Forms.MenuStrip MnColours;
        private System.Windows.Forms.ToolStripMenuItem coloursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.Button BtnGoto;
    }
}

