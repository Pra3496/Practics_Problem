using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class SwapNumber
    {
        public static void Swaping(int iNo,int iNo2)
        {
            int temp;

            Console.WriteLine("\nPrevious");
            Console.WriteLine("\n\tFirst number : " + iNo);
            Console.WriteLine("\n\tSecond number : " + iNo);

            temp = iNo;
            iNo = iNo2;
            iNo2 = temp;

            Console.WriteLine("\nAfter Swaping");
            Console.WriteLine("\n\tFirst number : " + iNo);
            Console.WriteLine("\n\tSecond number : " + iNo);
        }
    }
}
