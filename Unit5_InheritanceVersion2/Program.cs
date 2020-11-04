using System;

namespace Unit4_Inheritance
{
    class Program
    {
        /* Chú ý1:
        * Trong kế thừa sử dụng virtual-override giúp ta có thể sử dụng 1 phương thức của class Cha ở ngay trong class Con mà chưa cần phải tạo object
        * Vì ta sử dụng virtual-override ở class Cha để nhập, xuất còn class Con thì lấy giá trị đó để đánh giá nên không thể sử dụng False Way để nhập xuất cho mảng object
        * Mọi giải đáp sẽ ở project Inheritance_Ver1
        */

        /* Chú ý2:
         * Trong phần Right Way vẫn còn 1 điều cần chú ý:
         * Trong hàm xuất thông tin thì k được tạo đối tượng nữa mà chỉ tạo đối tượng trong hàm nhập thôi
         * Tạo đối tượng trong hàm nhập là để cấp phát bộ nhớ để nhập
         * Còn trong hàm xuất mà còn tạo thì lúc này sẽ cấp phát bộ nhớ cho đối tượng mới và như thế thì
         * sẽ mất thông tin nhập lúc đầu
         * */
        #region Wrong Way: Không sử dụng được vì bị mất dữ liệu của mảng, nguyên nhân do ta nhập xuất điểm ở các class khác nhau
        //static void Input(int n, FourBasic[] newFourBasic)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        newFourBasic[i] = new FourBasic();
        //        newFourBasic[i].Enter_Score();
        //    }
        //}

        //static void Output(int n, FourBasic[] newFourBasic)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        newFourBasic[i] = new FourBasic();
        //        newFourBasic[i].Rating_Score();
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int n;
        //    Console.Write("Nhap so mon hoc: ");
        //    n = int.Parse(Console.ReadLine());
        //    FourBasic[] newFourBasic = new FourBasic[n];
        //    Input(n, newFourBasic);
        //    Output(n, newFourBasic);
        //    Console.ReadKey();
        //}
        #endregion
        #region Right Way:
        static void result(int n)
        {
            for (int i = 0; i < n; i++)
            {
                FourBasic newfourbasic = new FourBasic();
                newfourbasic.Enter_Score();
                newfourbasic.Rating_Score();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("nhap so mon hoc: ");
            n = int.Parse(Console.ReadLine());
            result(n);
            Console.ReadKey();
        }
        #endregion
    }
}
