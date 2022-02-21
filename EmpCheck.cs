using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagePro
{
    internal class EmpCheck
    {
      public static void EmpPresentOrNot()
        {
            Random random = new Random();
            int num = random.Next(0,2);
            if (num == 1)
            {
                Console.WriteLine("Employee Present");
            }
            else
            {
                Console.WriteLine("Employee Absent");
            }
        } 
    }
}
