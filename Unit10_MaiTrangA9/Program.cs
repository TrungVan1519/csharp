using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Unit10_MaiTrangA9
{
    class Program
    {
        private static Regex myRegex = new Regex(@"\w+-|\w+");
        private static Regex newRegex = new Regex(@"-$");
        private static List<string> myList = new List<string>();
        private static List<string> result = new List<string>();
        private static List<string> noName = new List<string>();
        private static string newString = "";
        private static string myString = "";
        private static string[] arrString1, arrString2;
        private static int flag = 0;

        private static void Process()
        {
            arrString1 = newRegex.Split(newString);
            MatchCollection collection = myRegex.Matches(arrString1[0]);
            arrString2 = new string[collection.Count];
            for (int i = 0; i < arrString2.Length; i++)
            {
                arrString2[i] = collection[i].ToString();
            }

            Console.WriteLine("old string: " + newString);
            Console.Write("new string: ");
            foreach (var item in arrString2)
            {
                Console.Write(item);
            }
        }

        private static void Compare(string s1, string s2, List<string> list)
        {
            char[] arrChar1 = s1.ToCharArray();
            char[] arrChar2 = s2.ToCharArray();


            for (int x = 0; x < arrChar1.Length; x++)
            {
                for (int y = 0; y < arrChar2.Length; y++)
                {
                    int i = x;
                    int j = y;
                    if (arrChar1[i] == arrChar2[j])
                    {
                        myString = "";
                        myString += arrChar1[i].ToString();
                        while (true)
                        {
                            i++; j++;
                            if (i >= arrChar1.Length || j >= arrChar2.Length)
                            {
                                list.Add(myString);
                                break;
                            }
                            else
                            {
                                if (arrChar1[i] == arrChar2[j])
                                {
                                    myString += arrChar1[i];
                                }

                                else
                                {
                                    list.Add(myString);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void Find()
        {
            //for (int i = 0; i + 1 < arrString2.Length; i++)
            //{
            //    Compare(arrString2[i], arrString2[i + 1]);
            //}

            Compare(arrString2[0], arrString2[1], myList);
            for (int i = 2; i < arrString2.Length; i++)
            {
                for (int j = 0; j < myList.Count; j++)
                {
                    Compare(myList[j], arrString2[i], result);
                }
            }
        }

        private static int Longest()
        {
            int i = 1;
            flag = result[0].Length;
            while (i < result[i].Length)
            {
                if (flag < result[i].Length)
                {
                    flag = result[i].Length;
                }
                i++;
            }
            return flag;
        }

        private static bool Limit(string x)
        {
            int j = 0;

            if (x.Length == Longest())
            {
                if (noName.Count == 0)
                {
                    return true;
                }
                else
                {
                    while (j < noName.Count)
                    {
                        if (noName[j] != x)
                        {
                            j++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        private static void Display()
        {
            for (int i = 0; i < result.Count; i++)
            {
                if (Limit(result[i]))
                {
                    noName.Add(result[i]);
                }
            }
            Console.WriteLine("length of T: " + flag);
            Console.WriteLine("T: ");
            foreach (var item in noName)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            //newString = "--kma--mat-ma-";
            newString = "-efabc--abdabcef---bcef--defcd-";
            Console.WriteLine("b, S");
            Process();
            Console.WriteLine("\n\nc, T");
            Find();
            Display();

            Console.ReadKey();
        }
    }
}
