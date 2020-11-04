using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4_Inheritance
{
    class FourBasic : TenBasic
    {
        double score_TenBasic;

        protected override double Canculate_Score()
        {
            score_TenBasic = base.Canculate_Score();
            return score_TenBasic;
        }

        public void Rating_Score()
        {
            double evaluation_Score = Canculate_Score();

            float score_FourBasic = 0;

            if (score_TenBasic >= 8.5)
            {
                if (score_TenBasic >= 9)
                {
                    Console.WriteLine("Ban dc xep hang: Xuat sac: A+");
                    score_FourBasic = 4.0F;
                }
                else
                {
                    Console.WriteLine("Ban dc xep hang: Gioi: A");
                    score_FourBasic = 3.5F;
                }
            }
            else if (score_TenBasic <= 8.4 && score_TenBasic > 6.5)
            {
                if (score_TenBasic >= 7.0)
                {
                    Console.WriteLine("Ban dc xep hang: Kha: B+");
                    score_FourBasic = 3.0F;
                }
                else
                {
                    Console.WriteLine("Ban dc xep hang: Trung binh kha: B");
                    score_FourBasic = 2.5F;
                }
            }
            else if (score_TenBasic <= 6.4 && score_TenBasic >= 5.5)
            {
                Console.WriteLine("Ban dc xep hang: Trung binh: C");
                score_FourBasic = 2.0F;
            }
            else if (score_TenBasic <= 5.4 && score_TenBasic >= 4.0)
            {
                Console.WriteLine("Ban dc xep hang: Trung binh yeu: D");
                score_FourBasic = 1.0F;
            }
            else
            {
                Console.WriteLine("Chia buon ban xep hang: Yeu: F");
                score_FourBasic = 0;
            }
        }
    }
}
