using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ITAsk2IdleClicker
{
    public partial class KlavesovaPriserka : Priserka
    {
        public KlavesovaPriserka(float zivoty, string cestaKObrazku, string jmeno, int penizkyVPenezence) : base(zivoty, cestaKObrazku, jmeno, penizkyVPenezence)
        {

        }

        private void KlavesovaPriserka_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("NAPSAL JSI NĚCOOOO");
        }

        private void KlavesovaPriserka_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show("NAPSAL JSI NĚCOOOO");

        }
    }
}
