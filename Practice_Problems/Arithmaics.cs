using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class Arithmaics
    {
        public static void ArithmaticsOps()
        {
            Console.Write("1st number: ");
            int iNo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2nd number: ");
            int iNo2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nArithmatics Operations\n");
            Console.Write("1.Multiplication \n2.Divide \n3.Subtraction \n4.Addition\nEnter The option : ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("----------- RESULT ----------\n");
                    int iRes = iNo1 * iNo2;
                    Console.WriteLine("Given Number : {0} and {1}\nResult is : {2}", iNo1,iNo2,iRes);
                    Console.WriteLine("\n----------- END ----------");
                    break;
                case 2: 
                    float fRes = (float)iNo1 / (float)iNo2;
                    Console.WriteLine("----------- RESULT ----------\n");
                    Console.WriteLine("Given Number : {0} and {1}\nResult is : {2}", iNo1, iNo2, fRes);
                    Console.WriteLine("\n----------- END ----------");
                    break;
                case 3: 
                    iRes = iNo1 - iNo2;
                    Console.WriteLine("----------- RESULT ----------\n");
                    Console.WriteLine("Given Number : {0} and {1}\nResult is : {2}", iNo1, iNo2, iRes);
                    Console.WriteLine("\n----------- END ----------");
                    break;
                case 4: 
                    iRes = iNo1 + iNo2;
                    Console.WriteLine("----------- RESULT ----------\n");
                    Console.WriteLine("Given Number : {0} and {1}\nResult is : {2}", iNo1, iNo2, iRes);
                    Console.WriteLine("\n----------- END ----------");
                    break;
                default :
                    Console.WriteLine("Please Enter Proper input from given options");
                    break;

            }
        }
    }
}
