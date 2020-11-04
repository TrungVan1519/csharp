using System;
using System.Collections.Generic;
using System.Text;

namespace Unit6_Overloading
{
    class Version2
    {
        public int[] a = new int[4];
        public Version2()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
        }
        public Version2(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                this.a[i] = a[i];
            }
        }
    }
}
