using System;

namespace Unit6_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Overloading version1

            Console.WriteLine("Version1");

            Version1 ngVN = new Version1();
            Version1 ngAnh = new Version1(113);
            Version1 ngTBN = new Version1(" DauXanhRauMuong ");

            #endregion

            #region Overloading version2
            Console.WriteLine("\nVersion2");

            int[] a = new int[4] { 1, 2, 3, 4 };
            Version2 t1 = new Version2();
            Version2 t2 = new Version2(a);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(t1.a[i]);
            }
            Console.WriteLine("--------------------");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(t2.a[i]);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
