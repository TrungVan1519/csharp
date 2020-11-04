using System;

namespace Unit12_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Program!");

            Singleton.NewSingleton1.Name = "Dao Trung";
            Singleton.NewSingleton1.Age = 19;

            Singleton.NewSingleton2.Name = "Van Trung";
            Singleton.NewSingleton2.Age = 10;
            #region Wrong Way: Không thể khởi tạo đối tượng kiểu này được do private Constructor
            //try
            //{
            //    Singleton1 ex = new Singleton1();
            //    ex.Age = 19;
            //    ex.Name = "Deo phai Trung dau";
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            Console.WriteLine("Singleton.NewSingleton1.Name: " + Singleton.NewSingleton1.Name);
            Console.WriteLine("Singleton.NewSingleton1.Age: " + Singleton.NewSingleton1.Age);
            Console.WriteLine("Singleton.NewSingleton2.Name: " + Singleton.NewSingleton2.Name);
            Console.WriteLine("Singleton.NewSingleton2.Age: " + Singleton.NewSingleton2.Age);
            Console.ReadKey();
        }
        /* Chú ý:
         * Singleton đã làm private Constructor nên không thể khởi tạo đối tượng từ các lớp ngoài mà chỉ có thể
         * khởi tạo trước 1 đối tượng trong class trước 
         * Vì ta khởi tạo đối tượng trong class của chính nó nên nó có thể truy cập đến những member private 
         * và cũng không cần static cho các member vì mình đã static cho đối tượng rồi nên mặc định những member
         * của đối tượng đó là static
         * */
    }
}
