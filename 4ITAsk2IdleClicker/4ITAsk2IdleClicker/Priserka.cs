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
    public partial class Priserka : UserControl
    {
        protected float zivoty;

        public event Action<Priserka> OnSmrt;
        public float Zivoty
        {
            get => zivoty;
            set
            {
                zivoty = value;

                progressBar1.Value = (int)Math.Clamp(zivoty, progressBar1.Minimum, progressBar1.Maximum);
                
                if(zivoty <= 0)
                {
                    //Smrt
                    OnSmrt?.Invoke(this);
                }
            }
        }


        protected Image obrazek;
        protected string jmeno;
        protected int penizkyVPenezence;
        public int PenizkyVPenezence => penizkyVPenezence;
        private Priserka()
        {
            InitializeComponent();
        }
        public Priserka(float zivoty, string cestaKObrazku, string jmeno, int penizkyVPenezence) : this()
        {
            this.zivoty = zivoty;
            this.obrazek = Image.FromFile(cestaKObrazku);
            this.jmeno = jmeno;
            this.penizkyVPenezence = penizkyVPenezence;
            NastavGrafiku();
        }

        private void NastavGrafiku()
        {
            pictureBox1.Image = obrazek;
            label1.Text = jmeno;

            progressBar1.Maximum = (int)zivoty;
            progressBar1.Minimum = 0;
            progressBar1.Value = (int)zivoty;
        }

        private void Priserka_MouseClick(object sender, MouseEventArgs e)
        {
            Zasah();
        }

        public void Zasah()
        {
            Zivoty--;
        }
    }
}
