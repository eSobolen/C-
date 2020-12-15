using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            A a = new A(10, 10);
            Console.WriteLine("Значение поля c = " + a.c);
            B b = new B(10, 10);
            Console.WriteLine("Значение поля c2 = " + b.c2);
            B b2 = new B();
            Console.WriteLine("Значение нового  c2 = " + b.c2);
        }
    }

    class A
    {

        private float a;
        private float b;

        public float c
        {
            get { return a / b; }
        }

        public A(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public A()
        {

        }
    }

    class B : A
    {
        float d = 10;

        public float c2
        {
            get { return c + d; }
        }


        public B(float a, float b) : base(a, b)
        {

        }
        public B()
        {

        }
    }
}