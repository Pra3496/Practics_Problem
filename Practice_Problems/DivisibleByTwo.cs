using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class DivisibleByTwo
    {
        public static void Divisible(int iNo)
        {
            if((iNo%2) == 0)
            {
                Console.WriteLine("\n\t{0} is Divisible by 2",iNo);
            }
            else
            {
                Console.WriteLine("\n\t{0} is Divisible NOT by 2", iNo);
            }
        }
    }
}
