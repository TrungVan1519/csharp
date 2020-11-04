using System;

namespace ForVsForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            try
            {
                Console.Write("Nhap so can kiem tra: ");
                number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new Exception();
                }

                For newFor = new For(number);
                newFor.Display();
                Console.WriteLine("Danh sach cac so nguyen to nho hon {0} la:", number);
                newFor.Print();

                Foreach newForeach = new Foreach(number);
                Console.WriteLine("\nDanh sach:");
                newForeach.Print();
            }
            catch (Exception)
            {
                Console.WriteLine("Can nhap so duong!!!");
            }

            Console.ReadKey();
        }

        private static bool isPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
