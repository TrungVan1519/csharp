using System;
using System.Collections.Generic;
using System.Text;

namespace Unit10_MaiTrangA9
{
    class Test
    {
        static string s1 = "ma-";
        static string s2 = "kma-";
        static string result = "";
        static List<string> myList = new List<string>();


        public static void Compare(string s1, string s2)
        {
            char[] c1, c2;
            c1 = s1.ToCharArray();
            c2 = s2.ToCharArray();

            for (int i = 0; i < c1.Length; i++)
            {
                for (int j = 0; j < c2.Length; j++)
                {
                    if (c1[i] == c2[j])
                    {
                        result += c1[i];
                        while (true)
                        {
                            i++;
                            j++;
                            if (c1[i] == c2[j])
                            {
                                result += c1[i];
                            }
                            else
                            {
                                myList.Add(result);
                                return;
                            }
                        }
                    }
                }
            }
        }

        static void Main()
        {
            Compare(s1, s2);
            Console.Write(myList.Count);
            Console.ReadKey();
        }
    }
}
