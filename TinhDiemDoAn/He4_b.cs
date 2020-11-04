using System;
using System.Collections.Generic;
using System.Text;

namespace TinhDiemDoAn
{
    class He4_b : He10_b
    {
        public override double nhapDiemThang10()
        {
            double diemThang10 = base.nhapDiemThang10();
            float diemThang4 = 0;

            if (diemThang10 >= 8.5)
            {
                if (diemThang10 >= 9)
                {
                    Console.WriteLine("Ban dc xep hang: Xuat sac: A+");
                    diemThang4 = 4.0F;
                }
                else
                {
                    Console.WriteLine("Ban dc xep hang: Gioi: A");
                    diemThang4 = 3.5F;
                }
            }
            else if (diemThang10 <= 8.4 && diemThang10 > 6.5)
            {
                if (diemThang10 >= 7.0)
                {
                    Console.WriteLine("Ban dc xep hang: Kha: B+");
                    diemThang4 = 3.0F;
                }
                else
                {
                    Console.WriteLine("Ban dc xep hang: Trung binh kha: B");
                    diemThang4 = 2.5F;
                }
            }
            else if (diemThang10 <= 6.4 && diemThang10 >= 5.5)
            {
                Console.WriteLine("Ban dc xep hang: Trung binh: C");
                diemThang4 = 2.0F;
            }
            else if (diemThang10 <= 5.4 && diemThang10 >= 4.0)
            {
                Console.WriteLine("Ban dc xep hang: Trung binh yeu: D");
                diemThang4 = 1.0F;
            }
            else
            {
                Console.WriteLine("Chia buon ban xep hang: Yeu: F");
                diemThang4 = 0;
            }
            return diemThang4;
        }

        public double tinhDiemThang4()
        {
            double diemThang4 = nhapDiemThang10();
            return diemThang4;
        }
    }
}
