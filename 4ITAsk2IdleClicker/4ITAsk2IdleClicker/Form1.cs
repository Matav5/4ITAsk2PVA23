using System.Reflection;

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

            Type typPriserky = typeof(Priserka);
            Assembly assembly = Assembly.GetExecutingAssembly();

            List<TypeInfo> seznamTrid = assembly.DefinedTypes.Where(x => typPriserky.IsAssignableFrom(x)).ToList();

            int nahodnejIndex =  Random.Shared.Next(0, seznamTrid.Count);
            object? obj = Activator.CreateInstance(seznamTrid[nahodnejIndex].AsType());
            
            Priserka priserka = obj as Priserka;

// KeyDown += priserka.KlavesovaPriserka_KeyDown;
            priserka.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(PocetKorunek >= 15)
            {
                ManazerHrace.Instance.Poskozeni++;
                PocetKorunek -= 15;
            }
        }
    }
}