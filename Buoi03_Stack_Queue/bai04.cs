using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{

    class Bai04
    {
        public static void Run()
        {
            Queue<string> hangDoi = new Queue<string>();   // lưu các yêu cầu in

            string chon;
            do
            {
                Console.WriteLine("\n== MÔ PHỎNG HỆ THỐNG IN ẤN ==");
                Console.WriteLine("1. Thêm yêu cầu in (Enqueue)");
                Console.WriteLine("2. Xử lý yêu cầu in (Dequeue)");
                Console.WriteLine("3. Hiển thị các yêu cầu đang chờ");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                chon = (Console.ReadLine() ?? "").Trim();

                if (chon == "1")
                {
                    Console.Write("Nhập tên tài liệu cần in: ");
                    string tenTaiLieu = (Console.ReadLine() ?? "").Trim();
                    if (tenTaiLieu == "")
                    {
                        Console.WriteLine("Tên tài liệu không được để trống!");
                    }
                    else
                    {
                        hangDoi.Enqueue(tenTaiLieu);   // thêm vào cuối Queue
                        Console.WriteLine("Đã thêm vào hàng đợi: " + tenTaiLieu);
                    }
                }
                else if (chon == "2")
                {
                    if (hangDoi.Count == 0)
                        Console.WriteLine("Không có yêu cầu in nào!");
                    else
                        Console.WriteLine("Đang in: " + hangDoi.Dequeue());   // lấy từ đầu Queue
                }
                else if (chon == "3")
                {
                    if (hangDoi.Count == 0)
                    {
                        Console.WriteLine("Hàng đợi trống.");
                    }
                    else
                    {
                        Console.WriteLine("Các yêu cầu đang chờ (đầu hàng đợi ở trên cùng):");
                        int stt = 1;
                        foreach (string x in hangDoi)
                        {
                            Console.WriteLine($"  {stt}. {x}");
                            stt++;
                        }
                    }
                }
                else if (chon != "0") Console.WriteLine("Lựa chọn không hợp lệ!");
            } while (chon != "0");
        }
    }
}