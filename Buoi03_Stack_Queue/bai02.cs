using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai02
    {
        static Stack<string> backStack = new Stack<string>();      // lịch sử "Back"
        static Stack<string> forwardStack = new Stack<string>();   // lịch sử "Forward"
        static string trangHienTai = "";

        // Truy cập trang mới: đẩy trang hiện tại vào Back, xóa sạch Forward
        static void TruyCap(string url)
        {
            if (trangHienTai != "")
                backStack.Push(trangHienTai);
            trangHienTai = url;
            forwardStack.Clear();
            Console.WriteLine("Đang truy cập: " + trangHienTai);
        }

        // Nhấn "Back": đẩy trang hiện tại vào Forward, lấy trang từ Back ra hiển thị
        static void Back()
        {
            if (backStack.Count == 0)
            {
                Console.WriteLine("Không thể quay lại!");
                return;
            }
            forwardStack.Push(trangHienTai);
            trangHienTai = backStack.Pop();
            Console.WriteLine("Quay lại: " + trangHienTai);
        }

        // Nhấn "Forward": đẩy trang hiện tại vào Back, lấy trang từ Forward ra hiển thị
        static void Forward()
        {
            if (forwardStack.Count == 0)
            {
                Console.WriteLine("Không thể chuyển tiếp!");
                return;
            }
            backStack.Push(trangHienTai);
            trangHienTai = forwardStack.Pop();
            Console.WriteLine("Chuyển tiếp: " + trangHienTai);
        }

        static void HienThiTrangHienTai()
        {
            if (trangHienTai == "")
                Console.WriteLine("Chưa truy cập trang nào.");
            else
                Console.WriteLine("Trang hiện tại: " + trangHienTai);
        }

        public static void Run()
        {
            // Đặt lại dữ liệu mỗi lần vào bài
            backStack.Clear();
            forwardStack.Clear();
            trangHienTai = "";

            string chon;
            do
            {
                Console.WriteLine("\n== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT WEB ==");
                Console.WriteLine("1. Truy cập trang mới");
                Console.WriteLine("2. Back (quay lại)");
                Console.WriteLine("3. Forward (chuyển tiếp)");
                Console.WriteLine("4. Hiển thị trang hiện tại");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                chon = (Console.ReadLine() ?? "").Trim();

                if (chon == "1")
                {
                    Console.Write("Nhập URL: ");
                    string url = (Console.ReadLine() ?? "").Trim();
                    if (url == "")
                        Console.WriteLine("URL không được để trống!");
                    else
                        TruyCap(url);
                }
                else if (chon == "2") Back();
                else if (chon == "3") Forward();
                else if (chon == "4") HienThiTrangHienTai();
                else if (chon != "0") Console.WriteLine("Lựa chọn không hợp lệ!");
            } while (chon != "0");
        }
    }
}