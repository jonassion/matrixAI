using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("helloworld");
        }

        public int Plus(int a, int b)
        {
            int result = 0;
            int test = 0;
            checked
            {
                result = a + b;
            }
            return result;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
}
