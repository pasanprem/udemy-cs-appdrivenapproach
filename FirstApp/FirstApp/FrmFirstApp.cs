using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class FrmFirstApp : Form
    {
        public FrmFirstApp()
        {
            InitializeComponent();
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + TxtName.Text);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PicSmile.Visible = true;
            PicSad.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PicSad.Visible = true;
            PicSmile.Visible = false;
        }
    }
}
