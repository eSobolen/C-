using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            A test = new A();

            Console.WriteLine(test.c);
            test.c = 2;
            Console.WriteLine(test.c);
            Console.ReadKey();
        }
    }
    class A
    {
        private float a = 10;
        private float b = 10;

        public float c
        {
            get { return a %= b; }
            set { value = a+b; }
        }
    }
}