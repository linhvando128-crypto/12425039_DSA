using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai03
    {
        class KhungNganXep
        {
            public string TenHam;
            public string ThamSo;
            public string DiaChiTraVe;

            public KhungNganXep(string tenHam, string thamSo, string diaChiTraVe)
            {
                TenHam = tenHam;
                ThamSo = thamSo;
                DiaChiTraVe = diaChiTraVe;
            }
        }

        static Stack<KhungNganXep> callStack = new Stack<KhungNganXep>();

        // Gọi hàm: đẩy khung mới vào Stack
        static void GoiHam(string tenHam, string thamSo, string diaChiTraVe)
        {
            callStack.Push(new KhungNganXep(tenHam, thamSo, diaChiTraVe));
            Console.WriteLine($"-> Gọi hàm {tenHam}({thamSo}), đã đẩy khung vào Stack.");
        }

        // Hàm kết thúc: lấy khung ra khỏi Stack
        static void KetThucHam()
        {
            if (callStack.Count == 0)
            {
                Console.WriteLine("Stack rỗng, không có hàm nào để kết thúc!");
                return;
            }
            KhungNganXep khung = callStack.Pop();
            Console.WriteLine($"<- Hàm {khung.TenHam} kết thúc, trả về {khung.DiaChiTraVe}.");
        }

        // Hiển thị Stack từ đỉnh xuống đáy
        static void HienThiStack()
        {
            Console.WriteLine("--- Call Stack (từ đỉnh xuống đáy) ---");
            if (callStack.Count == 0)
            {
                Console.WriteLine("(rỗng)");
                return;
            }
            foreach (KhungNganXep k in callStack)
                Console.WriteLine($"  {k.TenHam}({k.ThamSo})  - địa chỉ trả về: {k.DiaChiTraVe}");
        }

        // Ví dụ mô phỏng hàm đệ quy GiaiThua(n)
        static void GiaiThua(int n, string diaChiTraVe)
        {
            GoiHam("GiaiThua", n.ToString(), diaChiTraVe);
            HienThiStack();

            if (n > 1)
                GiaiThua(n - 1, "GiaiThua(" + n + ")");

            KetThucHam();
            HienThiStack();
        }

        public static void Run()
        {
            callStack.Clear();

            string chon;
            do
            {
                Console.WriteLine("\n== MÔ PHỎNG FUNCTION CALL STACK ==");
                Console.WriteLine("1. Gọi hàm (đẩy khung vào Stack)");
                Console.WriteLine("2. Kết thúc hàm (lấy khung ra khỏi Stack)");
                Console.WriteLine("3. Hiển thị Stack");
                Console.WriteLine("4. Chạy ví dụ: GiaiThua(3) bằng đệ quy");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                chon = (Console.ReadLine() ?? "").Trim();

                if (chon == "1")
                {
                    Console.Write("Tên hàm: ");
                    string ten = (Console.ReadLine() ?? "").Trim();
                    Console.Write("Tham số: ");
                    string thamSo = (Console.ReadLine() ?? "").Trim();
                    Console.Write("Địa chỉ trả về (hàm gọi nó): ");
                    string diaChi = (Console.ReadLine() ?? "").Trim();

                    if (ten == "")
                        Console.WriteLine("Tên hàm không được để trống!");
                    else
                        GoiHam(ten, thamSo, diaChi);
                }
                else if (chon == "2") KetThucHam();
                else if (chon == "3") HienThiStack();
                else if (chon == "4")
                {
                    callStack.Clear();
                    GoiHam("Main", "", "Hệ điều hành");   // hàm Main chạy đầu tiên
                    GiaiThua(3, "Main");
                    KetThucHam();                         // Main kết thúc
                }
                else if (chon != "0") Console.WriteLine("Lựa chọn không hợp lệ!");
            } while (chon != "0");
        }
    }
}