using MySqlConnector;

namespace _4ITAsk2DatabazeMemu
{
    public partial class Form1 : Form
    {
        // Memísky se budou vytváøet podle databáze
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
                //Tady získám jednotlivý informace o záznamech

                MessageBox.Show(reader.GetString("url"));

            }
            db.Close();
        }
    }
}