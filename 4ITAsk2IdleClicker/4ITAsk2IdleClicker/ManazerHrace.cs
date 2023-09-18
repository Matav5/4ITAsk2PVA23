using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ITAsk2IdleClicker
{
    internal class ManazerHrace
    {
        private static ManazerHrace instance;
        public static ManazerHrace Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManazerHrace();
                return instance;
            }
        }

        private int poskozeni = 1;
        public int Poskozeni
        {
            get => poskozeni;
            set => poskozeni = value;
        }



    }
}
