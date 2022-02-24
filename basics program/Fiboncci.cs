using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowApp
{
    internal class Fiboncci
    {
        public static void DisplayFibonacci()
        {
            int n1 = 0, n2 = 1, n3=0, i, num;
                Console.WriteLine("Enter Number");
            Console.WriteLine("Fibonci Series is");
            num = Convert.ToInt32(Console.ReadLine());

            for(i=2; i<num;i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                
                Console.WriteLine(n3 + "");

            }
            if(n3 % 2 ==0)
            {
                Console.WriteLine("Good Morning");
            }else
            {
                Console.WriteLine( "Good Night");
            }
                
        }
    }
}
