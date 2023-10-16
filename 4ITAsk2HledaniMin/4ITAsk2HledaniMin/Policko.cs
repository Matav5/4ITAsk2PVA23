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
        public int PocetMinOkolo => pocetMinOkolo;

        private bool maMinu;

        public bool MaMinu => maMinu;


        private bool jeOdhaleny;

        public bool JeOdhaleny => jeOdhaleny;

        private int x;

        public int X => x;

        private int y;

        public int Y => y;

        public event Action<Policko> OnPolickoKliknul;
        private Policko()
        {
            InitializeComponent();
        }
        public Policko(int x, int y) : this()
        {
            this.x = x;
            this.y = y;
            label1.Visible = false;
            BackColor = Color.LightGray;
        }

        private void Policko_MouseClick(object sender, MouseEventArgs e)
        {
            OnPolickoKliknul?.Invoke(this);
        }

        internal void VlozMinu()
        {
            maMinu = true;
        }

        internal void NastavPocetMin(int pocetMin)
        {
            pocetMinOkolo = pocetMin;
            label1.Text = pocetMin.ToString();
        }

        internal void OdhalSe()
        {
            jeOdhaleny = true;
            label1.Show();
            BackColor = Color.White;
        }
    }
}
