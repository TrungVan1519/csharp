using System;

namespace Unit9_String.SplitVsString.ToCharArray
{
    class Program
    {
        static void xuLyChuoi1(string s)
        {
            string[] s1;
            string s2 = "";
            //char[] s3; khong su dung den do co char[] s4

            s1 = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < s1.Length; i++)
            {
                s1[i] = s1[i].ToLower();
                char[] s4 = s1[i].ToCharArray();
                s4[0] = char.ToUpper(s4[0]);
                s1[i] = new string(s4);
                s2 += s1[i] + ' ';
            }
            s2 = s2.Trim();
            Console.WriteLine("Chuoi 1 dc xu ly la: " + s2 + "\n");
        }
        /* Hoat động:
         * string[] s1 tach chuoi s thanh mang string de xoa char space o giua cac s1[i]
         * string s2 + cac s1[i] de thanh chuoi da xoa cac char space va + them 1 char space
         * char[] s3 tach cac string s1[i] thanh mang char sau do lay ra char first de ToUpper
         * s2.Trim() de xoa cac char space o dau va cuoi string s2 
         */

        static void xuLyChuoi2(string s)
        {
            string[] s1;
            string s2 = " ";
            char[] s3;

            s1 = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < s1.Length; i++)
            {
                s1[i] = s1[i].ToLower();
                s3 = s1[i].ToCharArray();
                s3[0] = char.ToUpper(s3[0]);
                s1[i] = new string(s3);
                s2 += s1[i] + ' ';
            }
            s2 = s2.Trim();
            Console.WriteLine("Chuoi 2 dc xu ly la: " + s2 + "\n");

        }
        /* Hoạt động:
         * string[] s1 tach chuoi s thanh mang string de xoa char space o giua cac s1[i]
         * string s2 + cac s1[i] de thanh chuoi da xoa cac char space va + them 1 char space
         * char[] s3 tach cac string s1[i] thanh mang char sau do lay ra char first de ToUpper
         * s2.Trim() de xoa cac char space o dau va cuoi string s2
         * */

        static void xuLyChuoi3(string s)
        {
            string[] s1;
            string s2 = " ";
            s1 = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < s1.Length; i++)
            {
                s1[i] = s1[i].ToLower();
                char s3 = s1[i].ToCharArray()[0];
                s3 = char.ToUpper(s3);
                //s1[i] = new string(s3); khong su dung dc vi day la 1 ky tu
                s2 += s1[i] + ' ';
            }
            s2 = s2.Trim();
            Console.WriteLine("Chuoi 3 dc xu ly la: " + s2 + "\n");
            // co the thay chuoi 3 khong xu ly dc chuoi s ban dau do chon char s3 chu khong phai char[] s3 nen khi 
            // ToUpper xong khong biet cach hop ve thanh chuoi s1[i] de s2 += s1[i] dc :(( zip113
        }

        static void xuLyChuoi4(string s)
        {
            string[] s1;
            string s2 = " ";
            s1 = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < s1.Length; i++)
            {
                s1[i] = s1[i].ToLower();
                char[] s3 = new char[s1[i].Length];
                for (int j = 0; j < s3.Length; j++)
                {
                    s3[j] = s1[i].ToCharArray()[j];
                }
                s3[0] = char.ToUpper(s3[0]);
                s1[i] = new string(s3);
                s2 += s1[i] + ' ';
            }
            s2 = s2.Trim();
            Console.WriteLine("Chuoi 4 dc xu ly la: " + s2 + "\n");
        }
        /* Hoạt động:
         * string[] s1 tach chuoi s thanh mang string de xoa char space o giua cac s1[i]
         * string s2 + cac s1[i] de thanh chuoi da xoa cac char space va + them 1 char space
         * char[] s3 tach cac string s1[i] thanh mang char sau do lay ra char first de ToUpper
         * s2.Trim() de xoa cac char space o dau va cuoi string s2
         * */

        static void xuLyChuoi5(string s)
        {
            string[] s1;
            //string s2; bi bao loi :))
            string s2 = " ";
            char[] s3;
            string s4;
            s1 = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < s1.Length; i++)
            {
                s2 += s1[i] + ' ';
            }
            s2 = s2.Trim();
            s2 = s2.ToLower();
            s3 = s2.ToCharArray();
            for (int i = 0; i < s3.Length; i++)
            {
                if (s3[i] == s3[0])
                {
                    s3[i] = char.ToUpper(s3[i]);
                }
                if (s3[i] == ' ')
                {
                    s3[i + 1] = char.ToUpper(s3[i + 1]);
                }
            }
            s4 = new string(s3);
            Console.WriteLine("Chuoi 5 dc xu ly la: " + s4 + "\n");
            // chua hieu tai sao khong xu ly dc lun :((
            // update: da tim ra loi do so sanh vs 23 (ma cua space trong ASCII), phai so sanh luon vs ' ' luon
        }
        /* Hoạt động:
         * string[] s1 tach chuoi s thanh mang string de xoa char space o giua cac s1[i]
         * string s2 + cac s1[i] de thanh chuoi da xoa cac char space va + them 1 char space
         * string s2.Trim() de xoa cac char space o dau va dac biet la o cuoi do + thua 1 char space
         * char[] s3 tach cac string s2[i] thanh mang char 
         * sau o lay cac phan tu s3[i] == s3[0] de ToUpper
         * hoac lay cac phan tu s3[i] == char space thi lay char ngay so de ToUpper
         * string s4 = new string(s3)
         * */

        static void Main(string[] args)
        {
            string s = "  NGuyeN     Thi    GiAi       ThOAT     ";

            s = s.Trim();
            Console.WriteLine("string s.Trim() = " + s);
            xuLyChuoi1(s);
            xuLyChuoi2(s);
            xuLyChuoi3(s);
            xuLyChuoi4(s);
            xuLyChuoi5(s);
            Console.ReadKey();
        }
    }
    /* Chú ý:
     * Trong tất cả các hàm xử lý chuỗi phải chú ý câu lệnh này:
     * s4[0] = char.ToUpper(s4[0]);                                             Hàm xử lý 1
     * s3[0] = char.ToUpper(s3[0]);                                             Hàm xử lý 2
     * s3 = char.ToUpper(s3);                                                   Hàm xử lý 3
     *  s3[0] = char.ToUpper(s3[0]);                                            Hàm xử lý 4
     *  s3[i] = char.ToUpper(s3[i]); và s3[i + 1] = char.ToUpper(s3[i + 1]);    Hàm xử lý 5
     *  Câu lệnh này có tác dụng đổi char đầu mỗi arrString[i] thành char hoa
     *  Phải viết đầy đủ câu lệnh này, không được viết tắt: VD: char.ToUpper(s4[0]); 
     *  Nếu viết tắt như trên thì char đầu sẽ không được đổi từ char thường thành char hoa dù các phần khác đều ok
     *  */
}
