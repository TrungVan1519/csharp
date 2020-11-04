using System;
using System.Collections.Generic;
using System.Text;

namespace Unit6_Overloading
{
    class Version1
    {
        public Version1()
        {
            Console.WriteLine("I am Vietnamese...");
        }

        public Version1(int a)
        {
            Console.WriteLine("I am English...");
        }

        public Version1(string b)
        {
            Console.WriteLine("I am Spanish...");
        }
    }
}
