using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai06
    {
        // Thông tin một khách hàng: tên, thời gian đến, loại dịch vụ
        class KhachHang
        {
            public string Ten;
            public string ThoiGianDen;
            public string LoaiDichVu;

            public KhachHang(string ten, string loaiDichVu)
            {
                Ten = ten;
                LoaiDichVu = loaiDichVu;
                ThoiGianDen = DateTime.Now.ToString("HH:mm:ss");   // giờ khách đến
            }
        }

        public static void Run()
        {
            Queue<KhachHang> hangDoi = new Queue<KhachHang>();

            string chon;
            do
            {
                Console.WriteLine("\n== MÔ PHỎNG HÀNG ĐỢI TẠI TRUNG TÂM DỊCH VỤ / NGÂN HÀNG ==");
                Console.WriteLine("1. Khách hàng mới đến (Enqueue)");
                Console.WriteLine("2. Nhân viên phục vụ khách hàng (Dequeue)");
                Console.WriteLine("3. Hiển thị trạng thái hàng đợi");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                chon = (Console.ReadLine() ?? "").Trim();

                if (chon == "1")
                {
                    Console.Write("Tên khách hàng: ");
                    string ten = (Console.ReadLine() ?? "").Trim();
                    Console.Write("Loại dịch vụ (ví dụ: Gửi tiền, Rút tiền, Tư vấn): ");
                    string loai = (Console.ReadLine() ?? "").Trim();

                    if (ten == "")
                    {
                        Console.WriteLine("Tên khách hàng không được để trống!");
                    }
                    else
                    {
                        KhachHang kh = new KhachHang(ten, loai);
                        hangDoi.Enqueue(kh);   // thêm vào cuối hàng đợi
                        Console.WriteLine($"Đã thêm {kh.Ten} vào hàng đợi lúc {kh.ThoiGianDen}.");
                    }
                }
                else if (chon == "2")
                {
                    if (hangDoi.Count == 0)
                    {
                        Console.WriteLine("Không có khách hàng nào trong hàng đợi!");
                    }
                    else
                    {
                        KhachHang kh = hangDoi.Dequeue();   // lấy khách ở đầu hàng đợi
                        Console.WriteLine($"Đang phục vụ: {kh.Ten} - Dịch vụ: {kh.LoaiDichVu} - Đến lúc: {kh.ThoiGianDen}");
                    }
                }
                else if (chon == "3")
                {
                    Console.WriteLine("Số khách hàng đang chờ: " + hangDoi.Count);
                    if (hangDoi.Count > 0)
                    {
                        int stt = 1;
                        foreach (KhachHang kh in hangDoi)
                        {
                            Console.WriteLine($"  {stt}. {kh.Ten} - {kh.LoaiDichVu} - đến lúc {kh.ThoiGianDen}");
                            stt++;
                        }
                    }
                }
                else if (chon != "0") Console.WriteLine("Lựa chọn không hợp lệ!");
            } while (chon != "0");
        }
    }
}