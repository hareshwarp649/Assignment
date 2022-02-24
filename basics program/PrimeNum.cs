using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowApp
{
    class PrimeNum
    {
        public static void NumPrime()
        {
            int n;
            Console.WriteLine("Enter Number");
            n = Convert.ToInt32(Console.ReadLine());
            int a = 0;

            for (int i= 1;i <= n; i++)
                {
                    if ( n % i == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    Console.WriteLine("{0} prime number", n);
                }else
                {
                Console.WriteLine(" not prime number", n);
                }
            Console.ReadLine();
        }
    }
}