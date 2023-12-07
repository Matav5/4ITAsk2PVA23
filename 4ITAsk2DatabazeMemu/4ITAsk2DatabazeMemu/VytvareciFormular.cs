using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace _4ITAsk2DatabazeMemu
{
    public partial class VytvareciFormular : Form
    {
        /*
            CREATE TABLE memisky(
                 id int PRIMARY KEY AUTO_INCREMENT,
                 url varchar(512) NOT NULL,
                 titulek varchar(64) NOT NULL UNIQUE,
                 hodnoceni tinyint NOT NULL,
                 cas_vytvoreni timestamp DEFAULT now(),
                 cas_upravy timestamp DEFAULT now()
            );
         */
        public VytvareciFormular()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBox1.Text;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = $"{trackBar1.Value}⭐";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection db = new MySqlConnection("HOST=localhost;PORT=3306;USER=root;DATABASE=sk2databazeMemiku");
            db.Open();

            MySqlCommand dotaz =  db.CreateCommand();
            dotaz.CommandText = $"INSERT INTO memisky(url,titulek,hodnoceni) " +
                $"VALUES ('{textBox1.Text}','{textBox2.Text}',{trackBar1.Value});";

            int result = dotaz.ExecuteNonQuery();
            if(result >= 0)
            {
                MessageBox.Show("Úspěšně byl přidán memík");
                Close();
            }
            else
            {
                MessageBox.Show("Neumíš psát. Nebo memík už existuje");

            }
            db.Close();
        }
    }
}
