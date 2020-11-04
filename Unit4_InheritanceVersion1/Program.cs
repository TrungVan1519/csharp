using System;

namespace Unit4_InheritanceVersion1
{
    /* Chú ý:
     * Trong phần Right Way vẫn còn 1 điều cần chú ý:
     * Trong hàm xuất thông tin thì k được tạo đối tượng nữa mà chỉ tạo đối tượng trong hàm nhập thôi
     * Tạo đối tượng trong hàm nhập là để cấp phát bộ nhớ để nhập
     * Còn trong hàm xuất mà còn tạo thì lúc này sẽ cấp phát bộ nhớ cho đối tượng mới và như thế thì
     * sẽ mất thông tin nhập lúc đầu
     * */
    class Program
    {
        #region Wrong Way: Không sử dụng được vì bị mất dữ liệu của mảng, nguyên nhân do ta nhập xuất điểm ở các class khác nhau
        //static void Input(int n, GiaoVien1[] giaoVien1s)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        giaoVien1s[i] = new GiaoVien1();
        //        giaoVien1s[i].Nhap1();
        //    }
        //}

        //static void Output(int n, GiaoVien1[] giaoVien1s)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        giaoVien1s[i] = new GiaoVien1();
        //        giaoVien1s[i].Xuat2();
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Console.Write("Nhap so luong giao vien: ");
        //    int n = int.Parse(Console.ReadLine());
        //    GiaoVien1[] newGiaoVien1 = new GiaoVien1[n];

        //    Input(n, newGiaoVien1);
        //    Output(n, newGiaoVien1);
        //    Console.ReadKey();
        //}
        #endregion
        #region Right Way:
        static void Input(int n, GiaoVien[] giaoViens)
        {
            for (int i = 0; i < n; i++)
            {
                giaoViens[i] = new GiaoVien();
                Console.Write("Nhap ho va ten giao vien {0}: ", i + 1);
                giaoViens[i].Name = Console.ReadLine();
                Console.Write("Nhap tuoi gia vien {0}: ", i + 1);
                giaoViens[i].Age = int.Parse(Console.ReadLine());
                Console.Write("Nhap don vi cua giao vien {0}: ", i + 1);
                giaoViens[i].DonVi = Console.ReadLine();
                Console.WriteLine();
            }
        }

        static void Output(int n, GiaoVien[] giaoViens)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin cua giao vien thu {0}", i + 1);
                Console.WriteLine(giaoViens[i].Name);
                Console.WriteLine(giaoViens[i].Age);
                Console.WriteLine(giaoViens[i].DonVi);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so luong giao vien: ");
            int n = int.Parse(Console.ReadLine());
            GiaoVien[] newGiaoVien = new GiaoVien[n];
            Input(n, newGiaoVien);
            Output(n, newGiaoVien);
            Console.ReadKey();
        }
        #endregion
    }
}
