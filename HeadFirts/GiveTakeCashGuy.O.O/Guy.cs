using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiveTakeCashGuy.O.O
{
    public class Guy
    {
        public string Nome { get; set; }
        public int Cash  { get; set; }

        

        public int GiveCash(int amount)
        {
            if(amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show(
                    "I don't have enough cash to give you " + amount,
                    Nome + "Says...");
                return 0;
            }

           
        }

        public int ReceiveCash(int amount)
        {
            if(amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + "isn't an amount I'll take ",
                    Nome + " Says... ");
                return 0;
            }
        }


    }
}
