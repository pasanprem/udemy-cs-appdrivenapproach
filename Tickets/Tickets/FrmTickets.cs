using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Tickets
{
    public partial class FrmTickets : Form
    {
        public FrmTickets()
        {
            InitializeComponent();
        }

        private void BtnTickets_Click(object sender, EventArgs e)
        {
            int age;
            double price = 0.0;

            age = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter your age", "Tickets", ""));

            if (age <= 12)
            {
                price = 5.00;
            }
            else if (age > 12 && age <=20)
            {
                price = 6.0;
            }
            else if (age >= 21 && age <= 64)
            {
                price = 10.0;
            }
            else if (age >=65)
            {
                price = 2.0;
            }

            MessageBox.Show("Your price is " + price.ToString("c"));
        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {

        }

        private void BtnGas_Click(object sender, EventArgs e)
        {
            int gas;
            double bill = 0.0;

            gas = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter gas usage in ccf", "Gas Bill", ""));

            if (gas <= 8)
            {
                bill = gas * .50;
            }
            else if (gas > 8)
            {
                bill = (8 * .50) + ((gas - 8) * .30);
            }

            MessageBox.Show("Your bill is : " + bill.ToString("c"));
        }
    }
}
