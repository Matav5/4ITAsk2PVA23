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
        public Priserka() : this(10, "liveMatavReaction.png", "Matav", 3)
        {
        }
        public Priserka(float zivoty, string cestaKObrazku, string jmeno, int penizkyVPenezence)
        {
            InitializeComponent();
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

        protected virtual void Priserka_MouseClick(object sender, MouseEventArgs e)
        {
            Zasah(ManazerHrace.Instance.Poskozeni);
        }
        public virtual void KlavesovaPriserka_KeyDown(object sender, KeyEventArgs e)
        {
        }
        public void Zasah(int poskozeni = 1)
        {
            Zivoty -= poskozeni;
        }
    }
}
