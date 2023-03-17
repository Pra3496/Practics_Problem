using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class ReverseNumber
    {
        public static void reverseNumber(int iNo)
        {
            int iNum = iNo;
            int iRevs = 0;
            while (iNum != 0)
            {
                int iRem = iNum % 10;
                iRevs = iRevs * 10 + iRem;
                iNum = iNum / 10;
            }
            Console.WriteLine("----------- RESULT ----------");
            Console.WriteLine("Given Number : {0}\nReverse Number is : {1}", iNo, iRevs);
            Console.WriteLine("\n----------- END ----------");
        }
    }
}
