﻿namespace Practice_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.Clear();
                Console.WriteLine("\nWelcome to File Handling Program\n");
                Console.WriteLine("Please enter an option");
                Console.WriteLine("1  : Check Whether a Given Number is Even or Odd");
                Console.WriteLine("2  : Print Odd Numbers in a Given Range");
                Console.WriteLine("3  : Check Whether a Number is Positive or Not");
                Console.WriteLine("4  : Find the Largest of Two Numberst");
                Console.WriteLine("5  : Swap Two Numbers");
                Console.WriteLine("6  : Divisible by 2");
                Console.WriteLine("7  : Sum of Multiple of 3 and 5 in a given range");
                Console.WriteLine("8  : Find Sum of Given Digits");
                Console.WriteLine("9  : Reverse Number");
                Console.WriteLine("10 : Palindrome Number");
                Console.WriteLine("11 : Arithmatics Operations");
                Console.WriteLine("0  : Exit");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EvenOdd.chkNumber(8);
                        EvenOdd.chkNumber(3);
                        EvenOdd.chkNumber(19);
                        Console.Write("\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;
                    case 2:
                        OddInRange oddRange= new OddInRange();
                        oddRange.From_Range = 1;
                        oddRange.To_Range = 10;
                        oddRange.Display();
                        Console.Write("\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;
                    case 3:
                        CheckPositive.chkNumber(2);
                        CheckPositive.chkNumber(-22);
                        CheckPositive.chkNumber(0);
                        Console.Write("\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;
                    case 4:
                        LargestOfTwo.LargestNumber(25,21);
                        Console.Write("\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;
                    case 5:
                        SwapNumber.Swaping(26, 65);
                        Console.Write("\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;
                    case 6:
                        DivisibleByTwo.Divisible(256);
                        DivisibleByTwo.Divisible(333);
                        DivisibleByTwo.Divisible(3);
                        Console.Write("\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;
                    case 7:
                        Multiple.MultipleOf3and5(100);
                        Console.Write("\n\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;
                    case 8:
                        SumOfDigits.SumOfDigitsOfNumber(1654);
                        Console.Write("\n\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;
                    case 9:
                        ReverseNumber.reverseNumber(321);
                        Console.Write("\n\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;
                    case 10:
                        iNumberPalindrom.numPalindrom(1221);
                        iNumberPalindrom.numPalindrom(1223);
                        Console.Write("\n\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;
                    case 11:
                        Arithmaics.ArithmaticsOps();
                        Console.Write("\n\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid Options");
                        Console.Write("\n*********************\nEnter Any Key...");
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}