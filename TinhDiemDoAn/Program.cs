using System;

namespace TinhDiemDoAn
{
    class Program
    {
        static void Main(string[] args)
        {

            char choose = ' ';
            int choose1 = ' ';
            int count = 0;
        label:
            Console.WriteLine("Ban muon nhap theo cach nao?");
            Console.WriteLine("1. Nhap tung thu 1.");
            Console.WriteLine("2. Nhap het cung 1 luc.");
            Console.WriteLine("0. Thoat.");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Nhap de: ");
            choose1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choose1)
            {
                case 1:
                    {
                    label1:
                        Console.WriteLine("Ban muon nhap diem?");
                        Console.WriteLine("An y / Y de nhap");
                        Console.WriteLine("An n / N de thoat");


                        choose = char.Parse(Console.ReadLine());
                        if (choose == 'y' || choose == 'Y')
                        {
                            count++;
                            He4_a diemDoAn = new He4_a();
                            diemDoAn.nhapDiemThang10();
                            double n = diemDoAn.tinhDiemThang4();
                            goto label1;
                        }
                        else if (choose == 'n' || choose == 'N')
                        {
                            goto label;
                        }
                        else
                        {
                            Console.WriteLine("Ban nhap sai. Vui long nhap lai!");
                            goto label;
                        }
                    }

                case 2:
                    {
                    label1:
                        Console.WriteLine("Ban muon nhap diem?");
                        Console.WriteLine("An y / Y de nhap");
                        Console.WriteLine("An n / N de thoat");


                        choose = char.Parse(Console.ReadLine());
                        if (choose == 'y' || choose == 'Y')
                        {
                            count++;
                            He4_b diemDoAn = new He4_b();
                            Console.WriteLine("Nhap thong tin: ");
                            diemDoAn.nhapDiemThang10();
                            double n = diemDoAn.tinhDiemThang4();
                            goto label1;
                        }
                        else if (choose == 'n' || choose == 'N')
                        {
                            goto label;
                        }
                        else
                        {
                            Console.WriteLine("Ban nhap sai. Vui long nhap lai!");
                            goto label1;
                        }
                    }
                case 0:
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ban nhap sai. Vui long nhap lai!");
                        goto label;
                    }
            }
        }
    }
}
