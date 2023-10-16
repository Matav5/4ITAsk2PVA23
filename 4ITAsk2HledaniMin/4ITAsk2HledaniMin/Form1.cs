namespace _4ITAsk2HledaniMin
{
    public partial class Form1 : Form
    {
        Policko[,] herniPole;
        public Form1()
        {
            InitializeComponent();
            VygenerujPole();
            VlozMiny();
            SpocitejMinyVSousedstvi();
        }

        private void SpocitejMinyVSousedstvi()
        {
            for (int i = 0; i < herniPole.GetLength(0); i++)
            {
                for (int j = 0; j < herniPole.GetLength(1); j++)
                {
                    int pocetMin = SpocitejMinyUPolicka(j, i);
                    herniPole[i, j].NastavPocetMin(pocetMin);
                }
            }
        }

        private int SpocitejMinyUPolicka(int x, int y)
        {
            int pocetMin = 0;
            for (int i = y - 1; i <= y + 1; i++)
            {
                for (int j = x -1; j <= x + 1; j++)
                {
                    if (i < 0 || j < 0 || i > herniPole.GetLength(0) - 1 || j > herniPole.GetLength(1) -1)
                        continue;

                    if (herniPole[i, j].MaMinu)
                        pocetMin++;

                }
            }
            return pocetMin;
        }

        private void VlozMiny()
        {
            int x,y;
            Policko policko;
            for (int i = 0; i < 20; i++)
            {
                y = Random.Shared.Next(0,herniPole.GetLength(0));
                x = Random.Shared.Next(0,herniPole.GetLength(1));
                policko = herniPole[y, x];

                //Zjistim jestli tam je mina -> pokud ne tak vložím
                if (policko.MaMinu)
                {
                    i--;
                    continue;
                }

                policko.VlozMinu();

            }
        }

        private void VygenerujPole()
        {
            herniPole = new Policko[12,12];

            for (int i = 0; i < herniPole.GetLength(0); i++)
            {
                for (int j = 0; j < herniPole.GetLength(1); j++)
                {
                    herniPole[i, j] = new Policko(j,i);
                    flowLayoutPanel1.Controls.Add(herniPole[i, j]);
                    herniPole[i, j].OnPolickoKliknul += Form1_OnPolickoKliknul;
                }
            }
        }

        private void Form1_OnPolickoKliknul(Policko policko)
        {

            if(policko.MaMinu)
                Prohra();
            

            OdhalSe(policko);
            if (herniPole.Cast<Policko>().All(x => x.JeOdhaleny || x.MaMinu))
                Vyhra();
        }

        private void Prohra()
        {
            List<Policko> polickaSMinama = herniPole.Cast<Policko>().Where(x => x.MaMinu).ToList();
            polickaSMinama.ForEach(policko =>
            {
                policko.BackColor = Color.Red;
            });

            MessageBox.Show("Našel jsi minu. Jseš mrtvej", "Skill Issue");
            Application.Restart();
        }

        private void Vyhra()
        {
            MessageBox.Show("Vyhrál jsi!", "GG EZ");
            Application.Restart();
        }

        private void OdhalSe(Policko policko)
        {
            policko.OdhalSe();

            if (policko.PocetMinOkolo > 0)
                return;


            for (int i = policko.Y - 1; i <= policko.Y + 1; i++)
            {
                for (int j = policko.X - 1; j <= policko.X + 1; j++)
                {
                    if (i < 0 || j < 0 || i > herniPole.GetLength(0) - 1 || j > herniPole.GetLength(1) - 1)
                        continue;

                    if (!herniPole[i,j].JeOdhaleny)
                        OdhalSe(herniPole[i, j]);
                }
            }
        }
    }
}