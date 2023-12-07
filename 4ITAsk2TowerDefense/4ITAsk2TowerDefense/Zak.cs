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
    public partial class Zak : UserControl,IUpdateable
    {
        private int mentalniZdravi;
        private int rychlost;
        public Zak(int mentalniZdravi, int rychlost) : this()
        {
            this.mentalniZdravi = mentalniZdravi;
            this.rychlost = rychlost;
        }
        private Zak()
        {
            InitializeComponent();
        }

        public void GameUpdate()
        {
           // MessageBox.Show(this.ToString());
            //Žák zdrhá po trase
        }
    }
}
