using System;

namespace Unit7_Overriding
{
    class Cha
    {
        public virtual void Speak()
        {
            Console.WriteLine("Cha is speaking...");
        }
    }

    class Con : Cha
    {
        public override void Speak()
        {
            Console.WriteLine("Con is speaking...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cha newFather = new Cha();
            Con newSon = new Con();

            Console.Write("Cha = new Cha(): ");
            newFather.Speak();
            Console.Write("Con = new Con(): ");
            newSon.Speak();

            Cha newFather1 = new Con();
            //Con newDaughter = new Cha(); Không thể khởi tạo được
            Console.Write("Cha = new Con(): ");
            newFather1.Speak();

            Console.WriteLine("Con always != Cha();");

            Console.ReadKey();
        }
    }
}
