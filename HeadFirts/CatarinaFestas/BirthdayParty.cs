using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatarinaFestas
{
    public class BirthdayParty
    {
        public int NumberOfPeople { get; set; }
        public decimal CostOfDecorations { get; set; }
        public int CakeSize { get; set; }


        public void  CalculateCostOfDecorations(decimal ratePeople, decimal rateValue)
        {
            this.CostOfDecorations  = ((this.NumberOfPeople * ratePeople) + rateValue) + 25 * this.NumberOfPeople;
        }

        public string CalculateCost(int wordsCount = 0)
        {
            double wordPrice = wordsCount * 0.25;
            decimal resultado;

            if (this.NumberOfPeople <= 4)
            {
                this.CakeSize = 20;
                resultado = this.CostOfDecorations += 40 + Convert.ToDecimal(wordPrice);
                return resultado.ToString();
            }
            else
            {
                this.CakeSize = 40;
                resultado = this.CostOfDecorations += 75 + Convert.ToDecimal(wordPrice);
                return resultado.ToString();
            }
        }
    }
}
