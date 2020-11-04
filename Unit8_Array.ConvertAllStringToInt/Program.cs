using System;

namespace Unit8_Array.ConvertAllStringToInt
{
    class Program
    {
        static int[] he(string line)
        {
            string[] parts = line.Split(",".ToCharArray(), //dấu phẩy là dấu ngăn cách cần bỏ đi
                                        StringSplitOptions.RemoveEmptyEntries);
            return Array.ConvertAll<string, int>(parts, int.Parse);
        }
        static void Main(string[] args)
        {
            string str = ("1,2,3,4,5,6,7,8");

            string[] parts = str.Split(',');

            int[] arr = new int[100];
            int[] arr1 = new int[100];
            arr = Array.ConvertAll<string, int>(parts, int.Parse);
            arr1 = he(str);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("--------------------------");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();
        }
    }
}
