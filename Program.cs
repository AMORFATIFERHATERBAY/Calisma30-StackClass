using System;
using System.Collections;

namespace Calisma30_StackClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack yigin = new Stack();

            yigin.Push(5);
            yigin.Push(56);
            yigin.Push(57);
            yigin.Push(59);
            yigin.Push(75);
            yigin.Push(85);

            Console.WriteLine("Yığınımızın ilk hali...");
            EkranaYaz(yigin);
            Console.WriteLine();

            Console.WriteLine("Yığınımızın ilk hali...ie");
            EkranaYaz1(yigin);

            int sayi = (int)yigin.Pop();
            Console.WriteLine("\nYığının {0} sayısını aldık", sayi);

            sayi = (int)yigin.Pop();
            Console.WriteLine("\nYığının {0} sayısını aldık", sayi);

            sayi = (int)yigin.Peek();
            Console.WriteLine("\nYığının tepesindeki sayı şu anda {0} ", sayi);

            EkranaYaz(yigin);
            Console.WriteLine();
            Console.WriteLine("Yığınımızın son hali...ie");
            EkranaYaz1(yigin);

        }
        public static void EkranaYaz(Stack yigin)
        {
            Object obj = new Object();
            Stack yeniYigin = (Stack)yigin.Clone();

            if (yigin.Count != 0)
            {
                while (yeniYigin.Count > 0)
                    Console.WriteLine("\t" + yeniYigin.Pop().ToString());

            }
            else
                Console.WriteLine("Yigin Bos!");
        }
        public static void EkranaYaz1(Stack yigin)
        {
            IEnumerator ie = yigin.GetEnumerator();

            while (ie.MoveNext())
                Console.WriteLine("\t" + ie.Current);
        }

    }
}
