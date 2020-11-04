using System;

namespace Unit6_Struct
{
    struct Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    /*Chú ý:
     * Trong hàm xuất thông tin không được dùng students[i] = new Student(); nữa 
     * Chỉ được dùng students[i] = new Student(); trong hàm nhập thông tin
     * */

    class Program
    {
        static private void Set_Value(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                Console.Write("Nhap ten: ");
                students[i].Name = Console.ReadLine();
                Console.Write("Nhap tuoi: ");
                students[i].Age = int.Parse(Console.ReadLine());
            }
        }

        static private void Get_Value(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Ho ten: " + students[i].Name);
                Console.WriteLine("Tuoi: " + students[i].Age);
            }
        }
        static void Main(string[] args)
        {
            int count;
            Console.Write("Nhap so luong sinh vien: ");
            count = int.Parse(Console.ReadLine());
            Student[] students = new Student[count];
            Set_Value(students);
            Console.WriteLine();
            Get_Value(students);
            Console.ReadKey();
        }
    }
}
