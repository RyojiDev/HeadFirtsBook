using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatarinaFestas
{
    public class DinnerParty : Party
    {
        private bool fancyDecorations;
        public DinnerParty(int numberOfPeople, bool helthyoption, bool fancyDecorations): base(numberOfPeople,fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthOption(helthyoption);
            CalculateCostOfDecorations(fancyDecorations);
        }
        
   
        public void SetPartyOption(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }
 
        public bool HealthyOption { get; set; }



        public void SetHealthOption(bool helthyOption)
        {
            if (helthyOption)
            {
                CostOfBeveragePerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragePerPerson = 20.00M;
            }
        }

        public override decimal CalculateCost(bool helthyOption)
        {
            decimal totalCost = CostOfDecorations +
               ((CostOfBeveragePerPerson + CostOfFoodPerPerson)
               * NumberOfPeople);
            if (helthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }

    }

}
