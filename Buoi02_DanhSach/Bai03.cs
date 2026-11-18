using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai03
    {
        static int TinhTong(int[,] a, int n)
        {
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    t += a[i, j];
                }
            }
            return t;
        }

        static int TimDuongNhoNhat(int[,] a, int n)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > 0 && a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            return min == int.MaxValue ? -1 : min;
        }

        static int TinhTongCheoPhu(int[,] a, int n)
        {
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                t += a[i, n - 1 - i];
            }
            return t;
        }

        static bool KiemTraCheoChinhTangDan(int[,] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i, i] >= a[i + 1, i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Run()
        {
            Console.Write("NHẬP CẤP MA TRẬN N: ");
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

            Console.WriteLine($"TỔNG MA TRẬN: {TinhTong(a, n)}");
            Console.WriteLine($"GIÁ TRỊ DƯƠNG NHỎ NHẤT: {TimDuongNhoNhat(a, n)}");
            Console.WriteLine($"TỔNG ĐƯỜNG CHÉO PHỤ: {TinhTongCheoPhu(a, n)}");
            Console.WriteLine($"ĐƯỜNG CHÉO CHÍNH TĂNG DẦN: {KiemTraCheoChinhTangDan(a, n)}");
        }
    }
}
