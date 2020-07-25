using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatarinaFestas
{
    public class BirthdayParty
    {
        private int numberOfPeople { get; set; }
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople
        {
            get { return this.numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
                CalculateCakeSize();
                this.CakeWriting = cakeWiriting;
            }
        }
        private bool fancyDecorations;
        public decimal CostOfDecorations { get; set; }
        public int CakeSize { get; set; }

        private string cakeWiriting;

        public string CakeWriting
        {
            get { return this.cakeWiriting; }
            set
            {
                
                int maxLength;
                if (CakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;
                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + "inch cake");
                    if (maxLength > this.cakeWiriting.Length)
                        maxLength = this.cakeWiriting.Length;
                    this.cakeWiriting = cakeWiriting.Substring(0, maxLength);
                }
                else
                    this.cakeWiriting = value;
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations,string cakeWriting)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            this.cakeWiriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }


        public void  CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }

        public decimal CalculateCost()
        {
            decimal totalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
            decimal cakeCost;
            if (CakeSize == 8)
                cakeCost = 40M + CakeWriting.Length * .25M;
            else
                cakeCost = 75 + CakeWriting.Length * .25M;
            return totalCost + cakeCost;
        }


    }
}
