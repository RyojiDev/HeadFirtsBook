using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigEars
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant[] elephants = new Elephant[7];
            elephants[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant() { Name = "Lucinda", EarSize = 33 };
            elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant() { Name = "Lucille", EarSize = 32 };
            elephants[4] = new Elephant() { Name = "Lars", EarSize = 44 };
            elephants[5] = new Elephant() { Name = "Linda", EarSize = 37 };
            elephants[6] = new Elephant() { Name = "Humfrey", EarSize = 45 };
            Elephant biggesEars = elephants[0];
            List<Elephant> elefantes = new List<Elephant>();

            for (int i = 1; i < elephants.Length; i++)
            {
                if (elephants[i].EarSize > biggesEars.EarSize)
                {
                    biggesEars = elephants[i];
                }
                Console.WriteLine(biggesEars.EarSize.ToString());

                List<Elephant> ele = elephants.OrderByDescending(p => p.EarSize).ToList();
                elephants = elephants.OrderByDescending(p=>p.EarSize).ToArray();
   
            }

        }
    }
}
