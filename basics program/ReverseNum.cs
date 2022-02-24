using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowApp
{
    internal class ReverseNum
    {
        public static void NumReverse()
        {
            int num, rev = 0, rem;
            Console.WriteLine("Enter a Number");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse Number" + rev);
        }
    }
}
