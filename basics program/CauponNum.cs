using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowApp
{
    internal class CauponNum
    {
        public static void NumCaupon()
        {

            Console.WriteLine("Coupon Numbers");
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());


            int[] Array = new int[num];
            int count = 0;
            for (int i = 0; i < num; i++)
            {
                bool same = false;
                Random random = new Random();
                int randomNum = random.Next(100, 999);

                foreach (int n in Array)
                {
                    if (n == randomNum)
                    {
                        same = true;
                        break;
                    }

                }
                if (same == true && i > 0)
                {
                    i--;
                }
                else
                {
                    Array[i] = randomNum;
                }
                count++;
            }
            Console.WriteLine($"total number of iterations: {count}");
            Console.WriteLine(String.Join(" ", Array));
        }
    }
}
