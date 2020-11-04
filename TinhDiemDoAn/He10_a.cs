using System;
using System.Collections.Generic;
using System.Text;

namespace TinhDiemDoAn
{
    class He10_a
    {
        string name;
        float diemGiuaKy;
        float diemCuoiKy;
        float diemChuyenCan;

        protected double tinhDiemThang10(ref float diemGiuaKy, ref float diemCuoiKy, ref float diemChuyenCan)
        {
            double diemPhay = (diemGiuaKy * 0.7 + diemChuyenCan * 0.3) * 0.3 + diemCuoiKy * 0.7;
            return diemPhay;
        }

        public virtual double nhapDiemThang10()
        {
            try
            {
                Console.Write("Nhap ten mon: ");
                name = Console.ReadLine();
                Console.Write("Nhap diem giua ky: ");
                diemGiuaKy = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem cuoi ky: ");
                diemCuoiKy = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem chuyen can: ");
                diemChuyenCan = float.Parse(Console.ReadLine());
                if (diemGiuaKy < 0 || diemCuoiKy < 0 || diemChuyenCan < 0 || diemGiuaKy > 10 || diemCuoiKy > 10 || diemChuyenCan > 10)
                {
                    throw new Exception("Co loi!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            double n = tinhDiemThang10(ref diemGiuaKy, ref diemCuoiKy, ref diemChuyenCan);
            return n;
        }
    }
}
