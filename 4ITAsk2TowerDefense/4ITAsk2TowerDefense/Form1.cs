namespace _4ITAsk2TowerDefense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            pictureBox1.Controls.Add(new Vez(0,0,0));
            pictureBox1.Controls.Add(new Zak(0,0));
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Control prvek in pictureBox1.Controls)
            {
                if(prvek is IUpdateable updateable)
                {
                    updateable.GameUpdate();
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Vez vez = new Vez(50,1.5f,25);
            Point poziceVeze = e.Location;
            poziceVeze.Offset(-vez.Width / 2, -vez.Height / 2);
            vez.Location = poziceVeze;
            pictureBox1.Controls.Add(vez);
        }
    }
}