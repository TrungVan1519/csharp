using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4_InheritanceVersion1
{
    class CanBo1
    {
        int age;

        public void Nhap1()
        {
            age = int.Parse(Console.ReadLine());
        }
        protected virtual int Xuat1()
        {
            return age;
        }
    }

    class GiaoVien1 : CanBo1
    {
        protected override int Xuat1()
        {
            int age = base.Xuat1();

            return age;
        }

        public void Xuat2()
        {
            int age = Xuat1();
            if (age < 5)
                Console.WriteLine("nho hon 5");
            else
                Console.WriteLine("else");
        }
    }
}
