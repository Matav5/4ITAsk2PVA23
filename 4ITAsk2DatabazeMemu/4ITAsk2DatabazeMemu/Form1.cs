using MySqlConnector;

namespace _4ITAsk2DatabazeMemu
{
    public partial class Form1 : Form
    {
        // Mem�sky se budou vytv��et podle datab�ze
        public Form1()
        {
            InitializeComponent();
            NactiMemisky();
        }

        private void NactiMemisky()
        {
            MySqlConnection db = new MySqlConnection("HOST=localhost;PORT=3306;USER=root;DATABASE=sk2databazeMemiku");
            db.Open();

            MySqlCommand dotaz = db.CreateCommand();
            dotaz.CommandText = "SELECT * FROM memisky;";
            MySqlDataReader reader = dotaz.ExecuteReader();
            while (reader.Read())
            {
                //Tady z�sk�m jednotliv� informace o z�znamech

                MessageBox.Show(reader.GetString("url"));

            }
            db.Close();
        }
    }
}