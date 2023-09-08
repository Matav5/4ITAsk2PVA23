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
    public partial class VytvarecMamin : Form
    {
        public Mamina VytvorenaMamina = null;
        public VytvarecMamin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VytvorenaMamina = new Mamina(
                     textBox1.Text,
                     (int)numericUpDown1.Value,
                     (float)numericUpDown2.Value,
                     Image.FromFile(textBox2.Text)
                     );
            }
            catch
            {

            }

            Close();
        }
    }
}
