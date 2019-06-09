using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poe_Flipping_Currency
{
    public partial class Form2 : Form
    {
       
        public Form2()

        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            // Inset the remaining currencies
            GetResultInTextBox1(AltB, AltS, AltM, AltR1, AltR2);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        public void GetResultInTextBox1(TextBox first, TextBox second, TextBox margin, TextBox rev1, TextBox rev2)
        {
            var r1 = float.TryParse(first.Text, out float a);
            var r2 = float.TryParse(second.Text, out float b);
            var r3 = float.TryParse(margin.Text, out float c);
            var r4 = float.TryParse(rev1.Text, out float d);
            var r5 = float.TryParse(rev2.Text, out float e);


            if (r1 && r2)
            {
                margin.Text = Math.Round(((a - b)*10),3).ToString();
                rev1.Text = Math.Round((((a - b) * 10)/b),3).ToString();
                rev2.Text = Math.Round((((a - b) * 100) / b),3).ToString();

            }
            else
            {
                margin.Text = "Enter Values";
            }

     
        }

    }
}
