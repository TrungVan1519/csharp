using System;

namespace ConsoleApp1
{
    abstract class Cha
    {
        protected string hisWife;
        protected abstract void Move();
        public abstract void GoToWork();
    }

    class Con : Cha
    {
        protected override void Move()
        {
            Console.WriteLine("Con is moving...");
        }

        public override void GoToWork()
        {
            Console.WriteLine("Con is going to school...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Con newSon = new Con();
            newSon.GoToWork();

            Console.ReadKey();
        }
    }
}
