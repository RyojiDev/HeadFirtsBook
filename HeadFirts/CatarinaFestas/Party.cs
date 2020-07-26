using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatarinaFestas
{
    public class Party
    {
        
        private int numberOfPeople;
        public decimal CostOfDecorations = 0;
        public decimal CostOfBeveragePerPerson;
        private bool fancyDecorations;

        public const int CostOfFoodPerPerson = 25;
        public virtual int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
        }

        public virtual void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public virtual decimal CalculateCost(bool helthyOption)
        {
            decimal totalCost = CostOfDecorations +
               ((CostOfBeveragePerPerson + CostOfFoodPerPerson)
               * NumberOfPeople);
            if (NumberOfPeople > 12)
            {
                totalCost += 100;
            }
               return totalCost;
        }
    }
}
