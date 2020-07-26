using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatarinaFestas
{
    public class BirthdayParty : Party
    {

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting) : base(numberOfPeople, fancyDecorations)
        {
            CalculateCakeSize();
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            this.cakeWiriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        private int numberOfPeople;
     
        public override int NumberOfPeople
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
      
        public int CakeSize { get; set; }

        private string cakeWiriting = "";

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

        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        public   decimal CalculateCost()
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
