using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai6
    {
        public static void Run()
        {
            Queue<string> hangDoi = new Queue<string>();
            string chon;
            do
            {
                Console.WriteLine("\n== MÔ PHỎNG HỆ THỐNG IN ==");
                Console.WriteLine("1. Thêm yêu cầu in");
                Console.WriteLine("2. Xử lý yêu cầu in");
                Console.WriteLine("3. Hiển thị danh sách hàng đợi");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                chon = (Console.ReadLine() ?? "").Trim();

                if (chon == "1")
                {
                    Console.Write("Nhập tên tài liệu: ");
                    hangDoi.Enqueue(Console.ReadLine() ?? "");
                    Console.WriteLine("Đã thêm vào hàng đợi.");
                }
                else if (chon == "2")
                {
                    if (hangDoi.Count > 0)
                        Console.WriteLine("Đang in: " + hangDoi.Dequeue());
                    else
                        Console.WriteLine("Không có yêu cầu in nào!");
                }
                else if (chon == "3")
                {
                    if (hangDoi.Count == 0)
                    {
                        Console.WriteLine("Hàng đợi trống.");
                    }
                    else
                    {
                        Console.WriteLine("Các yêu cầu đang chờ:");
                        foreach (string x in hangDoi)
                            Console.WriteLine(" - " + x);
                    }
                }
            } while (chon != "0");
        }
    }
}