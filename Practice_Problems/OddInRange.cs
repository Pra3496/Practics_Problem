using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class OddInRange
    {
        public int From_Range;

        public int To_Range;

        public  void Display()
        {
            if ((this.From_Range < 0))
            {
                Console.WriteLine("\n\tThe range is Negative");
            }
            else if (this.From_Range > this.To_Range)
            {
                Console.WriteLine("\n\tFrom range is greater than ending range");
            }
            else
            {
                for (int i = From_Range; i <= this.To_Range; i++)
                {
                    if ((i % 2) != 0)
                    {
                        Console.Write("\t" + i);
                    }
                }
            }
        }
    }
}
