using System;

namespace Unit3_Interface
{
    class Cha
    {
        public virtual void Walk()
        {
            Console.WriteLine("Cha is walking...");
        }
    }

    interface Me
    {
        void Run();
    }

    interface Ong
    {
        void Fly();
    }

    class Con : Cha, Me, Ong
    {
        public override void Walk()
        {
            Console.WriteLine("Con is walking...");
        }

        public void Run()
        {
            Console.WriteLine("Con is running...");
        }

        public void Fly()
        {
            Console.WriteLine("Con is flying...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Con newSon = new Con();
            newSon.Walk();
            newSon.Run();
            newSon.Fly();

            Console.ReadKey();
        }
    }
}
