using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo
{
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You picked : " + CboTest.Text);
        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {
            CboTest.Items.Add("Tokyo");
            CboTest.Items.Add("Moscow");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i=1; i<10; i++)
            {
                LstTest.Items.Add(i.ToString() + "\t " + Math.Pow(i,2));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You picked number : " + LstTest.Text.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (LstTest.SelectedIndex != -1)
            {
                LstTest.Items.RemoveAt(LstTest.SelectedIndex);
            }
        }
    }
}
