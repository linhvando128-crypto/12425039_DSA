using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai10
    {
        public static void Run()
        {
            Console.Write("NHẬP SỐ HÀNG M: ");
            int m = int.Parse(Console.ReadLine()!);
            Console.Write("NHẬP SỐ CỘT N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine("MA TRẬN THEO THỨ TỰ XOẮN ỐC:");
            int top = 0, bottom = m - 1, left = 0, right = n - 1;
            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++) Console.Write(a[top, i] + " ");
                top++;

                for (int i = top; i <= bottom; i++) Console.Write(a[i, right] + " ");
                right--;

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--) Console.Write(a[bottom, i] + " ");
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--) Console.Write(a[i, left] + " ");
                    left++;
                }
            }
            Console.WriteLine();
        }
    }
}
