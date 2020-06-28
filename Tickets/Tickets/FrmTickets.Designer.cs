namespace Tickets
{
    partial class FrmTickets
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
            this.BtnTickets = new System.Windows.Forms.Button();
            this.BtnAverage = new System.Windows.Forms.Button();
            this.BtnGas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTickets
            // 
            this.BtnTickets.Location = new System.Drawing.Point(314, 104);
            this.BtnTickets.Name = "BtnTickets";
            this.BtnTickets.Size = new System.Drawing.Size(193, 67);
            this.BtnTickets.TabIndex = 0;
            this.BtnTickets.Text = "Determine Ticket Price";
            this.BtnTickets.UseVisualStyleBackColor = true;
            this.BtnTickets.Click += new System.EventHandler(this.BtnTickets_Click);
            // 
            // BtnAverage
            // 
            this.BtnAverage.Location = new System.Drawing.Point(314, 190);
            this.BtnAverage.Name = "BtnAverage";
            this.BtnAverage.Size = new System.Drawing.Size(193, 64);
            this.BtnAverage.TabIndex = 1;
            this.BtnAverage.Text = "Average";
            this.BtnAverage.UseVisualStyleBackColor = true;
            this.BtnAverage.Click += new System.EventHandler(this.BtnAverage_Click);
            // 
            // BtnGas
            // 
            this.BtnGas.Location = new System.Drawing.Point(314, 281);
            this.BtnGas.Name = "BtnGas";
            this.BtnGas.Size = new System.Drawing.Size(193, 67);
            this.BtnGas.TabIndex = 2;
            this.BtnGas.Text = "Gas";
            this.BtnGas.UseVisualStyleBackColor = true;
            this.BtnGas.Click += new System.EventHandler(this.BtnGas_Click);
            // 
            // FrmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tickets.Properties.Resources.tuscany;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 484);
            this.Controls.Add(this.BtnGas);
            this.Controls.Add(this.BtnAverage);
            this.Controls.Add(this.BtnTickets);
            this.Name = "FrmTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTickets;
        private System.Windows.Forms.Button BtnAverage;
        private System.Windows.Forms.Button BtnGas;
    }
}

