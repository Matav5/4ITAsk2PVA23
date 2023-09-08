using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ITAsk2Opak
{
    public partial class Mamina : UserControl
    {
        protected string jmeno;
        protected int vek;
        protected float vzdalenost;
        public Mamina() 
        {
            InitializeComponent();
        }

        public Mamina(string jmeno, int vek, float vzdalenost, Image obrazekMaminy)
        {
            this.jmeno = jmeno;
            this.vek = vek;
            this.vzdalenost = vzdalenost;
            InitializeComponent();

            pictureBox1.Image = obrazekMaminy;
            label1.Text = ToString();
        }
        public override string ToString()
        {
            return $"{jmeno} ({vek}) je {vzdalenost} km od vás a potřebuje opravit dřez!";
        }
    }
}
