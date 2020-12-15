using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            for (int i = 0; i < 10; i++)
                Console.Write("{0} ", b[i]);

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
                Console.Write("{0} ", b[(short)i]);


            C<string>.F = "строка";
            C<int>.F = 10;

            Console.WriteLine("{0} {1}", C<string>.F, C<int>.F);

            Console.ReadKey();
        }
    }

    class C<T>
    {
        static public T F;
    }

    class B
    {
        int[] array1;
        int[] array2 = new int[] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90, };

        public B()
        {
            array1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        public int this[int index]
        {
            get { return array1[index]; }
            set { array1[index] = value; }
        }

        public int this[short index2]
        {
            get { return array2[index2]; }
            set { array2[index2] = value; }
        }
    }
}