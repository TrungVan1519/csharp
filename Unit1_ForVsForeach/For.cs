using System;
using System.Collections.Generic;
using System.Text;

namespace ForVsForeach
{
    class For
    {
        private int newNum;

        public For(int newNum)
        {
            this.newNum = newNum;
        }

        private bool Check(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        public void Display()
        {
            if (Check(newNum))
            {
                Console.WriteLine("{0} la so nguyen to", newNum);
            }
            else
            {
                Console.WriteLine("{0} khong phai la so nguyen to", newNum);
            }
        }

        public void Print()
        {
            for (int i = 0; i < newNum; i++)
            {
                if (Check(i))
                {
                    Console.Write("{0, 5}", i);
                }
            }
        }
    }
}
