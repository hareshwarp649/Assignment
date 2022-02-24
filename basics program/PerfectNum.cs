using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowApp
{
    internal class PerfectNum
    {
        public static void NumPerfect()
        {
            int num, i ,sum=0;
            int min, max;

            Console.WriteLine("Find the Perfect number");
            Console.WriteLine("---------------------");
            Console.WriteLine("Input the Starting Range");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the ending point");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Perfect Number within Given Range:");
            for (num = min; num <= max; num++)
            {
                i = 1;
                sum = 0;

                while(i<num)
                {
                    if (num % i == 0) 
                    sum = sum + i;
                    i++;                }
            }
            if (sum == num)
                Console.WriteLine("  ", sum);
        }
    }
}
