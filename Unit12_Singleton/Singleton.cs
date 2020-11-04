using System;
using System.Collections.Generic;
using System.Text;

namespace Unit12_Singleton
{
    class Singleton
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public static Singleton newSingleton1 = null;
        public static Singleton NewSingleton1
        {
            get
            {
                if (newSingleton1 == null)
                {
                    newSingleton1 = new Singleton();
                }
                return newSingleton1;
            }
        }

        public static Singleton newSingleton2 = null;
        public static Singleton NewSingleton2
        {
            get
            {
                if (newSingleton2 == null)
                {
                    newSingleton2 = new Singleton();
                }
                return newSingleton2;
            }
        }
        private Singleton() { }
    }
}
