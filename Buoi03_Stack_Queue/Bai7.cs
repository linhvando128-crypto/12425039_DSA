using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai7
    {
        public static void Run()
        {
            Queue<string> duongTruyen = new Queue<string>();
            string chon;
            do
            {
                Console.WriteLine("\n== MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU ==");
                Console.WriteLine("1. Gửi dữ liệu");
                Console.WriteLine("2. Nhận dữ liệu");
                Console.WriteLine("3. Hiển thị dữ liệu trong hàng đợi");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                chon = (Console.ReadLine() ?? "").Trim();

                if (chon == "1")
                {
                    Console.Write("Nhập gói dữ liệu: ");
                    duongTruyen.Enqueue(Console.ReadLine() ?? "");
                    Console.WriteLine("Đã gửi gói dữ liệu.");
                }
                else if (chon == "2")
                {
                    if (duongTruyen.Count > 0)
                        Console.WriteLine("Đã nhận: " + duongTruyen.Dequeue());
                    else
                        Console.WriteLine("Không có dữ liệu để nhận!");
                }
                else if (chon == "3")
                {
                    if (duongTruyen.Count == 0)
                    {
                        Console.WriteLine("Hàng đợi trống.");
                    }
                    else
                    {
                        Console.WriteLine("Các gói dữ liệu còn trong hàng đợi:");
                        foreach (string x in duongTruyen)
                            Console.WriteLine(" - " + x);
                    }
                }
            } while (chon != "0");
        }
    }
}