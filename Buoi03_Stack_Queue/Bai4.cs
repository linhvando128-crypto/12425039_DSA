using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai4
    {
        // 2 ngăn xếp và 1 biến lưu trang hiện tại
        static Stack<string> backStack = new Stack<string>();
        static Stack<string> forwardStack = new Stack<string>();
        static string currentPage = "";

        static void Visit(string url)
        {
            if (currentPage != "")
                backStack.Push(currentPage);   // đưa trang hiện tại vào backStack
            currentPage = url;                 // gán url làm trang hiện tại
            forwardStack.Clear();              // xóa rỗng forwardStack
            Console.WriteLine("Đang truy cập: " + currentPage);
        }

        static void Back()
        {
            if (backStack.Count > 0)
            {
                forwardStack.Push(currentPage);
                currentPage = backStack.Pop();
                Console.WriteLine("Quay lại: " + currentPage);
            }
            else
            {
                Console.WriteLine("Không thể quay lại!");
            }
        }

        static void Forward()
        {
            if (forwardStack.Count > 0)
            {
                backStack.Push(currentPage);
                currentPage = forwardStack.Pop();
                Console.WriteLine("Tiến lên: " + currentPage);
            }
            else
            {
                Console.WriteLine("Không thể tiến lên!");
            }
        }

        static void ShowCurrentPage()
        {
            if (currentPage == "")
                Console.WriteLine("Chưa truy cập trang nào.");
            else
                Console.WriteLine("Trang hiện tại: " + currentPage);
        }

        public static void Run()
        {
            backStack.Clear();
            forwardStack.Clear();
            currentPage = "";

            string chon;
            do
            {
                Console.WriteLine("\n== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ==");
                Console.WriteLine("1. Truy cập trang mới");
                Console.WriteLine("2. Quay lại");
                Console.WriteLine("3. Tiến lên");
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
                        Visit(url);
                }
                else if (chon == "2") Back();
                else if (chon == "3") Forward();
                else if (chon == "4") ShowCurrentPage();
                else if (chon != "0") Console.WriteLine("Lựa chọn không hợp lệ!");
            } while (chon != "0");
        }
    }
}