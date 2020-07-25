using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatarinaFestas
{
    public class DinnerParty
    {
        public DinnerParty(int numberOfPeople, bool helthyoption, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthOption(helthyoption);
            CalculateCostOfDecorations(fancyDecorations);
        }
        
        private bool fancyDecorations;
        public const int CostOfFoofPerPerson = 25;
        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public void SetPartyOption(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }

        public void SetNumberOfPeople(int people)
        {
            NumberOfPeople = people;
        }

        public decimal CostOfDecorations = 0;
        public decimal CostOfBeveragePerPerson;
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

        public void CalculateCostOfDecorations(bool fancy)
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

        public decimal CalculateCost(bool helthyOption)
        {
            decimal totalCost = CostOfDecorations +
               ((CostOfBeveragePerPerson + CostOfFoofPerPerson)
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
