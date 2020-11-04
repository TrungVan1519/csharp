using System;

namespace Unit3_OneDimensionalArray
{
    class Program
    {
        static void Set_Value(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Nhap: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Get_Value(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0, 5}", item.ToString());
            }
        }

        static void Insertion_Sort_Increase(int[] arr)
        {
            int i;
            int tmp;
            int j;
            for (i = 1; i < arr.Length; i++)
            {
                tmp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > tmp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = tmp;
            }
        }

        static void Slection_Sort_Decrease(int[] arr)
        {
            int i, j;
            int tmp;
            for (i = 0; i < arr.Length - 1; i++)
            {
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int length;
            Console.Write("Nhap so luong phan tu cho mang: ");
            length = int.Parse(Console.ReadLine());

            int[] newArr = new int[length];
            Set_Value(newArr);
            Console.WriteLine("Mang la:");
            Insertion_Sort_Increase(newArr);
            Get_Value(newArr);
            Console.WriteLine();
            Slection_Sort_Decrease(newArr);
            Get_Value(newArr);
            Console.ReadKey();
        }
    }
}
