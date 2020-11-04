using System;

namespace Unit4_TwoDimensionalArray
{
    class Program
    {
        static void Draw(int[,] arr, int col, int row)
        {
            int i, j;
            for (i = 0; i < col; i++)
            {
                for (j = 0; j < row; j++)
                {
                    if (i == 0 || i == col - 1 || j == 0 || j == row - 1)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int colunm, row;
            Console.Write("Nhap so hang: ");
            colunm = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            row = int.Parse(Console.ReadLine());
            int[,] newArr = new int[colunm, row];
            Draw(newArr, colunm, row);
            Console.ReadKey();
        }
    }
}
