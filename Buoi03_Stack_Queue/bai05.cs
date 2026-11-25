using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai05
    {
        public static void Run()
        {
            Queue<string> duongTruyen = new Queue<string>();   // lưu các gói tin
            int soGoi = 0;                                     // đánh số thứ tự gói tin

            string chon;
            do
            {
                Console.WriteLine("\n== MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU ==");
                Console.WriteLine("1. Gửi gói tin (Enqueue)");
                Console.WriteLine("2. Xử lý gói tin (Dequeue)");
                Console.WriteLine("3. Hiển thị các gói tin đang chờ");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                chon = (Console.ReadLine() ?? "").Trim();

                if (chon == "1")
                {
                    Console.Write("Nhập nội dung gói tin: ");
                    string noiDung = (Console.ReadLine() ?? "").Trim();
                    if (noiDung == "")
                    {
                        Console.WriteLine("Nội dung gói tin không được để trống!");
                    }
                    else
                    {
                        soGoi++;
                        string goiTin = "Gói " + soGoi + ": " + noiDung;
                        duongTruyen.Enqueue(goiTin);   // thêm vào cuối Queue
                        Console.WriteLine("Đã gửi " + goiTin);
                    }
                }
                else if (chon == "2")
                {
                    if (duongTruyen.Count == 0)
                        Console.WriteLine("Không có gói tin nào để xử lý!");
                    else
                        Console.WriteLine("Đã xử lý -> " + duongTruyen.Dequeue());   // lấy từ đầu Queue
                }
                else if (chon == "3")
                {
                    if (duongTruyen.Count == 0)
                    {
                        Console.WriteLine("Đường truyền trống.");
                    }
                    else
                    {
                        Console.WriteLine("Các gói tin đang chờ (theo thứ tự đến):");
                        foreach (string x in duongTruyen)
                            Console.WriteLine("  - " + x);
                    }
                }
                else if (chon != "0") Console.WriteLine("Lựa chọn không hợp lệ!");
            } while (chon != "0");
        }
    }
}