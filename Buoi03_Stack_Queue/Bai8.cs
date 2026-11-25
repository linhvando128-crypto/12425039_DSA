using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai8
    {
        public static void Run()
        {
            Queue<string> khachHang = new Queue<string>();
            string chon;
            do
            {
                Console.WriteLine("\n== MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG ==");
                Console.WriteLine("1. Thêm khách hàng");
                Console.WriteLine("2. Phục vụ khách hàng");
                Console.WriteLine("3. Hiển thị danh sách khách hàng chờ");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                chon = (Console.ReadLine() ?? "").Trim();

                if (chon == "1")
                {
                    Console.Write("Nhập tên hoặc số thứ tự khách hàng: ");
                    khachHang.Enqueue(Console.ReadLine() ?? "");
                    Console.WriteLine("Đã thêm khách hàng vào hàng đợi.");
                }
                else if (chon == "2")
                {
                    if (khachHang.Count > 0)
                        Console.WriteLine("Đang phục vụ: " + khachHang.Dequeue());
                    else
                        Console.WriteLine("Không có khách hàng nào trong hàng đợi!");
                }
                else if (chon == "3")
                {
                    if (khachHang.Count == 0)
                    {
                        Console.WriteLine("Hàng đợi trống.");
                    }
                    else
                    {
                        Console.WriteLine("Khách hàng đang chờ:");
                        foreach (string x in khachHang)
                            Console.WriteLine(" - " + x);
                    }
                }
            } while (chon != "0");
        }
    }
}