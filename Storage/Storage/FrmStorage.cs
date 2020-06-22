using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class FrmStorage : Form
    {
        public FrmStorage()
        {
            InitializeComponent();
        }

        int age;
        string yourname;
        double pay;

        private void BtnGo_Click(object sender, EventArgs e)
        {
            //declaration of variables section
            

            //assignment statements
            age = 15;
            yourname = "John";
            pay = 230.75;

            //display the results... output
            MessageBox.Show("Your age is " + age.ToString());
            MessageBox.Show("Your name is " + yourname);
            MessageBox.Show("Your pay is " + pay.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your name is " + yourname);
        }
    }
}
