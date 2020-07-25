using System;
using System.Collections.Generic;
using System.Text;

namespace Guy_O.O_Cap03
{
    public class Guy
    {
        public string Nome { get; set; }
        public double Dinheiro { get; set; }

        public void GiveCash(double give)
        {
            Dinheiro += give;
        }

        public void TakeCash(double take)
        {
            Dinheiro = Dinheiro - take;
        }
    }
}
