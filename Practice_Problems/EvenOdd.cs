using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    public class EvenOdd
    {

        public static void chkNumber(int number)
        {
            if ((number % 2) == 0)
            {
                Console.WriteLine("\n\tNumber is Even");
            }
            else
            {
                Console.WriteLine("\n\tNumber is Odd");
            }
        }

    }
}
