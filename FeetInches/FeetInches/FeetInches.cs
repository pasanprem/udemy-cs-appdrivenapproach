using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeetInches
{
    public partial class FeetInches : Form
    {
        public FeetInches()
        {
            InitializeComponent();
        }

        private void BtnFeetInches_Click(object sender, EventArgs e)
        {
            int inches;
            int feet;
            int remaininginches;

            inches = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter inches", "", ""));

            feet = inches / 12;
            remaininginches = inches % 12;

            MessageBox.Show("You entered " + inches + " inches" + "\n" + "That is " + feet + " feet and " + remaininginches + " inches");
        }
    }
}
