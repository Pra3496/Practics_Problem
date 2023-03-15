using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class CheckPositive
    {
        public static void chkNumber(int Num)
        {
            if (Num < 0)
            {
                Console.WriteLine("\n\tThe Given Number {0} is NOT Positive", Num);
            }
            else
            {
                Console.WriteLine("\n\tThe Given Number {0} is Positive", Num);
            }
        }
    }
}
