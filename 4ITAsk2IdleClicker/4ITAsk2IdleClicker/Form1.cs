namespace _4ITAsk2IdleClicker
{
    public partial class Form1 : Form
    {
        int pocetKorunek = 0;
        public int PocetKorunek
        {
            get => pocetKorunek;
            set
            {
                pocetKorunek = value;
                label1.Text = $"Mé korunky: {pocetKorunek} CZK";
            }
        }
        public Form1()
        {
            InitializeComponent();
            VytvorPriserku();
        }

        private void VytvorPriserku()
        {
            KlavesovaPriserka priserka = new KlavesovaPriserka(10,"liveMatavReaction.png","Matav", 3);
            priserka.OnSmrt += Priserka_OnSmrt;
            panel1.Controls.Add(priserka);

        }

        private void Priserka_OnSmrt(Priserka priserka)
        {
            panel1.Controls.Remove(priserka);
            priserka.OnSmrt -= Priserka_OnSmrt;
            PocetKorunek += priserka.PenizkyVPenezence;
            VytvorPriserku();

        }
    }
}