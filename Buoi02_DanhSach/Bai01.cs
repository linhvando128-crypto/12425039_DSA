using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    using System;

    class Bai01
    {
        public static void Run()
        {
            Console.Write("NHẬP N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"NHẬP A[{i}]: ");
                a[i] = int.Parse(Console.ReadLine()!);
            }

            Console.Write("DANH SÁCH: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            Console.Write("NHẬP PHẦN TỬ X CẦN CHÈN: ");
            int x = int.Parse(Console.ReadLine()!);
            Console.Write("NHẬP VỊ TRÍ K CẦN CHÈN: ");
            int k = int.Parse(Console.ReadLine()!);

            int[] tmp = new int[n + 1];
            for (int i = 0; i < k; i++)
            {
                tmp[i] = a[i];
            }
            tmp[k] = x;
            for (int i = k; i < n; i++)
            {
                tmp[i + 1] = a[i];
            }

            Console.Write("DANH SÁCH SAU KHI CHÈN: ");
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.Write(tmp[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
