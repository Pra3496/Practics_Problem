using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class iNumberPalindrom
    {
        public static void numPalindrom(int iNo)
        {
            int iNum = iNo;
            int iRevs = 0;
            while (iNum != 0)
            {
                int iRem = iNum % 10;
                iRevs = iRevs * 10 + iRem;
                iNum = iNum / 10;
            }
            if (iRevs == iNo)
            {
                Console.WriteLine("\n----------- RESULT ----------\n");
                Console.WriteLine("Given Number : {0}\nPalindrom is : {1}", iNo, iRevs);
                Console.WriteLine("\n----------- END ----------");
            }
            else
            {
                Console.WriteLine("\n----------- RESULT ----------\n");
                Console.WriteLine("Number {0} is Not Palindrom",iNo);
                Console.WriteLine("\n----------- END ----------");
            }
        }
    }
}
