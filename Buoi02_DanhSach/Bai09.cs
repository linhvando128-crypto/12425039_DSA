using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai09
    {
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static bool LaSoHoanHao(int n)
        {
            if (n <= 1) return false;
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i != n / i) sum += n / i;
                }
            }
            return sum == n;
        }

        public static void Run()
        {
            Console.Write("NHẬP SỐ LƯỢNG PHẦN TỬ N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"NHẬP A[{i}]: ");
                a[i] = int.Parse(Console.ReadLine()!);
            }

            Console.Write("CÁC SỐ NGUYÊN TỐ: ");
            foreach (int x in a)
            {
                if (LaSoNguyenTo(x)) Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.Write("CÁC SỐ CHẴN: ");
            foreach (int x in a)
            {
                if (x % 2 == 0) Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.Write("CÁC SỐ HOÀN HẢO: ");
            foreach (int x in a)
            {
                if (LaSoHoanHao(x)) Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}
