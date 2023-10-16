using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ITAsk2HledaniMin
{
    public partial class Policko : UserControl
    {
        private int pocetMinOkolo;

        private bool maMinu;

        public bool MaMinu => maMinu;


        private bool jeOdhaleny;

        public bool JeOdhaleny => jeOdhaleny;

        private int x;

        public int X => x;

        private int y;

        public int Y => y;
        private Policko()
        {
            InitializeComponent();
        }
        public Policko(int x, int y) : this()
        {
            this.x = x;
            this.y = y;
            label1.Visible = false;
        }

        private void Policko_MouseClick(object sender, MouseEventArgs e)
        {

        }

        internal void VlozMinu()
        {
            maMinu = true;
            BackColor = Color.Red;
        }

        internal void NastavPocetMin(int pocetMin)
        {
            pocetMinOkolo = pocetMin;
            label1.Text = pocetMin.ToString();
        }
    }
}
