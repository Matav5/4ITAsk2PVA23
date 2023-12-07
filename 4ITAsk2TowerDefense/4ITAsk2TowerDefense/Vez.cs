using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ITAsk2TowerDefense
{
    public partial class Vez : UserControl, IUpdateable
    {
        private int dosah;
        private float intervalUtoku;
        private int mentalniPoskozeni;
        public Vez(int dosah, float intervalUtoku, int mentalniPoskozeni) : this()
        {
            this.dosah = dosah;
            this.intervalUtoku = intervalUtoku;
            this.mentalniPoskozeni= mentalniPoskozeni;
        }
        private Vez()
        {
            InitializeComponent();
        }

        public void GameUpdate()
        {
            //Po intervalu => Pew pew
            //Na koho bude dělat Pew pew
         //   MessageBox.Show(this.ToString());
        }

        private void Vez_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
