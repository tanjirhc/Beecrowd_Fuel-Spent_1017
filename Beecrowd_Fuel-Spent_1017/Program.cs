using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_Fuel_Spent_1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours, velocity;
            double distancePerLitre = 12.0;

            hours = int.Parse(Console.ReadLine());
            velocity = int.Parse(Console.ReadLine());

            double total = (velocity * hours) / distancePerLitre;

            string med1 = string.Format("{0:00.000}", total);
            Console.WriteLine(med1);
            Console.ReadKey();
        }
    }
}
