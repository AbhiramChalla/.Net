using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a=10;
            int a = 0;
            int b = 0;
            int sum = 0;
            Console.WriteLine("Enter value for a: ");
            Console.ReadLine();
            Console.WriteLine("Enter value for b: ");
            Console.ReadLine();
            sum = Add(a, b);

        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
