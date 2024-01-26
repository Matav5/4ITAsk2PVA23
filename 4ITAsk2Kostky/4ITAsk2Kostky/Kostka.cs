using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace _4ITAsk2Kostky
{
    public partial class Kostka : UserControl
    {
        private int cislo;

        public int Cislo
        {
            get => cislo;
            set
            {
                cislo = value;


                //Podle čísla nastavil background
                BackColor = Color.AliceBlue;
                //JeVybrany
                //JeZamkly
            }
        }

        private bool jeVybrana;
        private bool jeZamkla;

        private Action<Kostka> OnKostkaZakliknuto;
        public Kostka()
        {
            InitializeComponent();

        }   

        private void Kostka_MouseClick(object sender, MouseEventArgs e)
        {
            if (jeZamkla)
                return;

            jeVybrana = !jeVybrana;

            OnKostkaZakliknuto?.Invoke(this);
        }
    }
}
