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
            GetResultInTextBox1(ExaltB, ExaltS, ExaltM, ExaltR1, ExaltR2);
            GetResultInTextBox1(AnnulB, AnnulS, AnnullM, AnnullR1, AnnulR2);
            GetResultInTextBox1(RegB, RegS, RegM, RegR1, RegR2);
            GetResultInTextBox1(DivB, DivS, DivM, DivR1, DivR2);
            GetResultInTextBox1(GemB, GemS, GemM, GemR1, GemR2);
            GetResultInTextBox1(VaalB, VaalS, VaalM, VaalR1, VaalR2);
            GetResultInTextBox1(JewelB, JewelS, JewelM, JewelR1, JewelR2);
            GetResultInTextBox1(RegretB, RegretS, RegretM, RegretR1, RegretR2);
            GetResultInTextBox1(ChiselB, ChiselS, ChiselM, ChiselR1, ChiselR2);
            GetResultInTextBox1(ScourB, ScourS, ScourM, ScourR1, ScourR2);
            GetResultInTextBox1(CoinB, CoinS, CoinM, CoinR1, CoinR2);
            GetResultInTextBox1(AlchB, AlchS, AlchM, AlchR1, AlchR2);
            GetResultInTextBox1(BlessB, BlessS, BlessM, BlessR1, BlessR2);
            GetResultInTextBox1(GlassB, GlassS, GlassM, GlassR1, GlassR2);
            GetResultInTextBox1(FuseB, FuseS, FuseM, FuseR1, FuseR2);
            GetResultInTextBox1(ChromB, ChromS, ChromM, ChromR1, ChromR2);
            GetResultInTextBox1(ChanceB, ChanceS, ChanceM, ChanceR1, ChanceR2);
            GetResultInTextBox1(AugB, AugS, AugM, AugR1, AugR2);
            GetResultInTextBox1(TransB, TransS, TransM, TransR1, TransR2);
            GetResultInTextBox1(ArmorB, ArmorS, ArmorM, ArmorR1, ArmorR2);
            GetResultInTextBox1(WhetB, WhetS, WhetM, WhetR1, WhetR2);
            GetResultInTextBox1(WisB, WisS, WisM, WisR1, WisR2);
            GetResultInTextBox1(PortB, PortS, PortM, PortR1, PortR2);

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
