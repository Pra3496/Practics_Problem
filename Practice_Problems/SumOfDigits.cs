using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class SumOfDigits
    {
        public static void SumOfDigitsOfNumber(int iNo)
        {
            int iNum = iNo;
            int iSum = 0;
            while (iNum != 0)
            {
                int iRem = iNum % 10;
                iSum += iRem;
                iNum = iNum / 10;
            }
            Console.WriteLine("\n----------- RESULT ----------\n");
            Console.WriteLine("Given Number : {0}\nSum of Digits is : {1}",iNo,iSum);
            Console.WriteLine("\n----------- END ----------");
        }
    }
}
