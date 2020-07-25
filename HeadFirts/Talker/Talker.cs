using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Talker
{
    public class Talker
    {
        public static int BlahBlahBlah(string thingTosay, int numberOfTimes)
        {
            string finalString = "";
            for(int count = 1; count <= numberOfTimes; count++)
            {
                finalString = finalString + thingTosay + "\n";
            }

            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
