using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai11
    {
        public static void Run()
        {
            Console.Write("NHẬP CẤP MA TRẬN VUÔNG N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            bool isUnit = true;
            bool isSymmetric = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && a[i, j] != 1) isUnit = false;
                    if (i != j && a[i, j] != 0) isUnit = false;
                    if (a[i, j] != a[j, i]) isSymmetric = false;
                }
            }

            Console.WriteLine($"LÀ MA TRẬN ĐƠN VỊ: {isUnit}");
            Console.WriteLine($"LÀ MA TRẬN ĐỐI XỨNG: {isSymmetric}");
        }
    }
}
