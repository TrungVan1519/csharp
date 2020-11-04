using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //string newString = "Dao Van, Trung 123, 4, 6, 8";
            //string patterns = @" |, | \d";

            //Regex newRegex = new Regex(patterns);
            //Regex newRegex1 = new Regex(@"\d", RegexOptions.Singleline);

            //Console.WriteLine("newString: " + newString);

            #region class Regex:
            //Console.WriteLine("newRegex.Split: ");
            //string[] arrString = newRegex.Split(newString);
            //foreach (string item in arrString)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\nnewRegex.Replace: ");
            //string outputString = newRegex.Replace(newString, patterns);
            //Console.WriteLine(outputString);
            #endregion

            #region class Match:
            //Match newMatch = newRegex1.Match(newString);
            //if (newMatch != Match.Empty)
            //{
            //    Console.WriteLine("!= Match.Empty == newMatch.Value: " + newMatch.Value);
            //}

            //if(newMatch.Success)
            //{
            //    Console.WriteLine("newMatch.Success == newMatch.NextMatch(): " + newMatch.NextMatch());
            //}

            //MatchCollection newMatchCol = newRegex1.Matches(newString);
            //Console.WriteLine("Match item in newMatchCol: ");
            //foreach(Match item in newMatchCol)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("object item in arrObj[]: ");
            //object[] arrObj = new object[newMatchCol.Count];
            //newMatchCol.CopyTo(arrObj, 0);
            //foreach( var item in arrObj)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            string newString = "Today is 9/4/2018 and tomorrow is 9/5/2018 and now is 1:20PM";
            string dayPatterns = @"(?<Day>((\d+)/(\d+)/(\d+)\s+))";
            string timePatterns = @"(?<Time>((\d+):(\d+\w+)))";
            string patterns = dayPatterns + timePatterns;

            //// Viết ra chuỗi ban đầu
            //Console.WriteLine("newString: " + newString);

            //// Tạo ra các đối tượng Regex
            //Regex newRegex = new Regex(dayPatterns);
            Regex newRegex1 = new Regex(patterns);

            //// Cắt 1 phần tử đầu thỏa mãn Regex
            //Match newMatch = newRegex.Match(newString);

            //// Kiểm tra xem có string nào thỏa mãn Regex k? Nếu có thì viết ra 1 phần tử đầu tiên thỏa mãn
            //if (newRegex.IsMatch(newString))
            //{
            //    Console.WriteLine("newMatch: " + newMatch.Value);
            //}

            //// Kiểm tra xem việc cắt newString có thành công k? Nếu thành công thì tạo ra 1 newMatch và sẽ viết ra phần tử tiếp theo của newMatch chứ không phải newMatch
            //if (newMatch.Success)
            //{
            //    Console.WriteLine("newMatch = newMatch.NextMatch(): " + newMatch.NextMatch());
            //}

            //// Lưu các phần tử newMatch vào 1 mảng MathCollection và duyệt từng phần tử 
            //Console.WriteLine("Items in newMatchCol: ");
            //MatchCollection newMatchCol = newRegex.Matches(newString);
            //foreach(var item in newMatchCol)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            // Sử dụng thuộc tính Groups của newMatch
            MatchCollection newMatchCol1 = newRegex1.Matches(newString);
            foreach (Match item in newMatchCol1)
            {
                if (item.Length != 0)
                {
                    Console.WriteLine("newMatch.Groups[Day]: " + item.Groups[0]);
                    Console.WriteLine("NewMAtch.Groups[Time]: " + item.Groups["Time"]);
                }
            }
            Console.ReadKey();
        }
    }
}
