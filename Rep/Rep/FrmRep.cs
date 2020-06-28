using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rep
{
    public partial class FrmRep : Form
    {
        public FrmRep()
        {
            InitializeComponent();
        }

        private void BtnRep_Click(object sender, EventArgs e)
        {
            while(true)
            {
                MessageBox.Show("This is a test");

                string response = Microsoft.VisualBasic.Interaction.InputBox("Do you wish to continue y/n?", "", "");

                if (response == "n")
                    break;
            }
        }

        private void BtnCounter_Click(object sender, EventArgs e)
        {
            int counter = 0;

            while (counter <= 10)
            {
                MessageBox.Show("This is counter " + counter.ToString());
                counter++;
            }
        }
    }
}
