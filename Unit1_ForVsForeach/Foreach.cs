using System;
using System.Collections.Generic;
using System.Text;

namespace ForVsForeach
{
    class Foreach
    {
        private int newNum;

        public Foreach(int newNum)
        {
            this.newNum = newNum;
        }

        public void Print()
        {
            int[] arrInt = new int[newNum];
            for (int i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = i;
            }
            foreach (var item in arrInt)
            {
                Console.Write("{0, 5}", item.ToString());
            }
        }
    }
}
