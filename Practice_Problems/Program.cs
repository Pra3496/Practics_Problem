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
                Console.WriteLine("1 : Check Whether a Given Number is Even or Odd");
                Console.WriteLine("0 : Exit");
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