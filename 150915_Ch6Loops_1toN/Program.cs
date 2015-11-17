using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150915_Ch6Loops_1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints on the console the numbers from 1 to N. 
            
            Console.WriteLine("What is the integer n?");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            while (n > num)
            {
                ++num;
                Console.WriteLine(num);
            }
        



        }
    }
}
