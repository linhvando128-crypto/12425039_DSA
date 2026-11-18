using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai07
    {
        public static void Run()
        {
            Console.Write("NHẬP SỐ NGÀY N: ");
            int n = int.Parse(Console.ReadLine()!);
            double[] a = new double[n];
            double tong = 0;
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"NHẬP NHIỆT ĐỘ NGÀY THỨ {i + 1}: ");
                a[i] = double.Parse(Console.ReadLine()!);
                tong += a[i];
                if (a[i] > a[maxIndex]) maxIndex = i;
                if (a[i] < a[minIndex]) minIndex = i;
            }

            Console.WriteLine($"NGÀY CÓ NHIỆT ĐỘ CAO NHẤT LÀ NGÀY {maxIndex + 1} VỚI {a[maxIndex]} ĐỘ");
            Console.WriteLine($"NGÀY CÓ NHIỆT ĐỘ THẤP NHẤT LÀ NGÀY {minIndex + 1} VỚI {a[minIndex]} ĐỘ");
            Console.WriteLine($"NHIỆT ĐỘ TRUNG BÌNH: {tong / n}");
        }
    }
}
