using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreControls
{
    public partial class FrmMoreControls : Form
    {
        public FrmMoreControls()
        {
            InitializeComponent();
        }

        private void HsbNumber_Scroll(object sender, ScrollEventArgs e)
        {
            TxtNumber.Text = HsbNumber.Value.ToString();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void BtnGoto_Click(object sender, EventArgs e)
        {
            FrmTwo x = new FrmTwo();
            x.Show();
        }
    }
}
