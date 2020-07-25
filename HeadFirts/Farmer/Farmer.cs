using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer
{
    public class Farmer
    {
        public int BasOfFeed { get; private set; }
        public int FeedMultiplier { get; private set; }
        private int numberOfCows;

        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BasOfFeed = numberOfCows * FeedMultiplier;
            }

        }

        public Farmer(int numberOfCows,int feedMulplier)
        {
            FeedMultiplier = feedMulplier;
            this.numberOfCows = numberOfCows;
        }
    }
}
