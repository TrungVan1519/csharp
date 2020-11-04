using System;

namespace Unit5_Array
{
    class Program
    {
        static void Main(string[] args)
        {


            Version2 version2 = new Version2();
            Version1 version1 = new Version1();

            #region Array version 1

            int[] arr;
            int n1, value1;

            Console.WriteLine("Version1:");

            Console.Write("Nhap so phan tu mang: ");
            n1 = int.Parse(Console.ReadLine());
            arr = new int[20];

            Console.WriteLine("\nNhap mang:");
            version1.Set_Value(arr, n1);

            Console.WriteLine("\nMang la: ");
            version1.Get_Value(arr, n1);

            Console.WriteLine("\nMang sau khi sap xep la:");
            version1.Selection_Sort(arr, n1);
            version1.Get_Value(arr, n1);

            Console.WriteLine("\nThem do dai cho mang:");
            version1.Add_Length(ref n1);

            Console.Write("\nNhap gia tri can them: ");
            value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMang moi la: ");
            version1.Add_Value(arr, n1, value1);
            version1.Get_Value(arr, n1);

            #endregion

            #region Array version 2

            int[] newArr, newArr1;
            int n2, value2;

            Console.WriteLine("\n\nVersion2:");

            Console.Write("Nhap so phan tu mang: ");
            n2 = int.Parse(Console.ReadLine());

            newArr = new int[n2];
            Console.WriteLine("\nNhap mang:");
            version2.Set_Value(newArr);
            Console.WriteLine("\nMang ban dau la:");
            version2.Get_Value(newArr);

            Console.WriteLine("\nMang sau khi sap xep la:");
            version2.Selection_Sort(newArr);
            version2.Get_Value(newArr);

            Console.Write("\nNhap gia tri muon them: ");
            value2 = int.Parse(Console.ReadLine());

            n2++;
            newArr1 = new int[n2];
            version2.Copy_Array(newArr1, newArr);
            version2.Add_Element(newArr1, n2, value2);

            Console.WriteLine("\nMang moi la:");
            version2.Get_Value(newArr1);

            #endregion
            Console.ReadKey();
        }
    }
}
