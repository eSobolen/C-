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
            Console.WriteLine("Значение нового c2 = " + b2.c2); //тут я продемонстрировал работу дефолтного конструктора класса B как и требовал этого таск
            B b3 = new B(10, 5);
            Console.WriteLine("\nЗначения массива: ");
            foreach (var i in b3.array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            if (b)
            {
                Console.WriteLine("b1 = " + true);
            }
            else
            {
                Console.WriteLine("b1 = " + false);
            }
        }
    }

    class A
    {

        private float a;
        private float b;

        public float c
        {
            get { return a + b; }
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

        public float[] array;

        public B(float a, float b) : base(a, b)
        {

        }
        public B()
        {

        }

        public B(int a, float c2) : base(a, c2)
        {
            array = new float[a];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = c2 * i;
            }
        }

        public static bool operator true(B b)
        {
            return b.d > 0;
        }

        public static bool operator false(B b)
        {
            return b.d < 0;
        }
    }
}
