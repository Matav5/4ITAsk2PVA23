namespace _4ITAsk2Opak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VytvarecMamin vytvarecMamin = new VytvarecMamin();
            vytvarecMamin.ShowDialog();
            flowLayoutPanel1.Controls.Add(vytvarecMamin.VytvorenaMamina);
        }
    }
}