using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class Multiple
    {
        public static void MultipleOf3and5(int range)
        {
            int i = 1,sum=0;

            ;
            while(i != range)
            {

                if(((i%3) == 0) && ((i%5) == 0))
                {  
                    sum = sum + i;
                }


                i++;
            }

            Console.Write("\n\tSum of Multiple of 3 and 5 : "+sum);
        }
    }
}
