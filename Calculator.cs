using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatIons
{
    public class Calculator
    {
        public static void Multiplication()
        {
            Console.WriteLine("Enter the First Number");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Product of the Number is:" + A * B);
        }

    }
}
