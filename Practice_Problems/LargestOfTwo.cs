using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class LargestOfTwo
    {
      
        public static void LargestNumber(int iNo,int iNo2)
        {
            if(iNo > iNo2)
            {
                Console.WriteLine("\n\t{0} is Largest Number than {1}",iNo,iNo2);
            }
            else
            {
                Console.WriteLine("\n\t{0} is Largest Number than {1}", iNo2, iNo);
            }
        }
    }
}
