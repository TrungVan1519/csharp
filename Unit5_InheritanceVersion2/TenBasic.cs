using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4_Inheritance
{
    class TenBasic
    {
        string name;
        float mid_Score;
        float final_Score;
        float attendance_Score;
        double score_TenBasic;

        public void Enter_Score()
        {
            try
            {
                Console.Write("Nhap ten mon hoc: ");
                name = Console.ReadLine();
                Console.Write("Nhap diem giua ky: ");
                mid_Score = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem cuoi ky: ");
                final_Score = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem chuyen can: ");
                attendance_Score = float.Parse(Console.ReadLine());
                if (mid_Score < 0 || final_Score < 0 || attendance_Score < 0)
                {
                    throw new Exception("Diem bi nhap sai!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected virtual double Canculate_Score()
        {
            score_TenBasic = (attendance_Score * 0.3 + mid_Score * 0.7) * 0.3 + final_Score * 0.7;
            return score_TenBasic;
        }
    }
}
