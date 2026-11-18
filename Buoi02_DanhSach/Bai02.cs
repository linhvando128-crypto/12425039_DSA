using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class NhanVien
    {
        public string MaNV { get; set; } = "";
        public string HoTen { get; set; } = "";
        public int Namsinh { get; set; }
        public string Phongban { get; set; } = "";
        public int LuongCB { get; set; }
        public int Thuong { get; set; }
        public int ThucLinh => LuongCB + Thuong;
    }

    class Bai02
    {
        public static void Run()
        {
            Console.Write("NHẬP SỐ LƯỢNG NHÂN VIÊN: ");
            int n = int.Parse(Console.ReadLine()!);
            NhanVien[] ds = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                ds[i] = new NhanVien();
                Console.WriteLine($"NHẬP THÔNG TIN NHÂN VIÊN THỨ {i + 1}:");
                Console.Write("MÃ NHÂN VIÊN: ");
                ds[i].MaNV = Console.ReadLine()!;
                Console.Write("HỌ VÀ TÊN: ");
                ds[i].HoTen = Console.ReadLine()!;
                Console.Write("NĂM SINH: ");
                ds[i].Namsinh = int.Parse(Console.ReadLine()!);
                Console.Write("PHÒNG BAN: ");
                ds[i].Phongban = Console.ReadLine()!;
                Console.Write("LƯƠNG CƠ BẢN: ");
                ds[i].LuongCB = int.Parse(Console.ReadLine()!);
                Console.Write("THƯỞNG: ");
                ds[i].Thuong = int.Parse(Console.ReadLine()!);
            }

            int tongThucLinh = 0;
            for (int i = 0; i < n; i++)
            {
                tongThucLinh += ds[i].ThucLinh;
            }
            Console.WriteLine($"TỔNG THỰC LĨNH: {tongThucLinh}");

            int minLuongCB = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (ds[i].LuongCB < minLuongCB)
                {
                    minLuongCB = ds[i].LuongCB;
                }
            }
            Console.WriteLine("DANH SÁCH NHÂN VIÊN LƯƠNG CƠ BẢN THẤP NHẤT:");
            for (int i = 0; i < n; i++)
            {
                if (ds[i].LuongCB == minLuongCB)
                {
                    Console.WriteLine($"{ds[i].MaNV} - {ds[i].HoTen} - {ds[i].LuongCB}");
                }
            }

            int demThuong = 0;
            for (int i = 0; i < n; i++)
            {
                if (ds[i].Thuong >= 1200000)
                {
                    demThuong++;
                }
            }
            Console.WriteLine($"SỐ NHÂN VIÊN THƯỞNG >= 1200000: {demThuong}");

            var dsSapXep = ds.OrderBy(nv => nv.Phongban).ThenByDescending(nv => nv.MaNV).ToArray();
            Console.WriteLine("DANH SÁCH SAU KHI SẮP XẾP:");
            foreach (var nv in dsSapXep)
            {
                Console.WriteLine($"{nv.MaNV} - {nv.HoTen} - {nv.Phongban}");
            }

            for (int i = 0; i < n; i++)
            {
                ds[i].LuongCB = (int)(ds[i].LuongCB * 1.05);
            }
            Console.WriteLine("ĐÃ CẬP NHẬT TĂNG LƯƠNG CƠ BẢN LÊN 5% CHO TẤT CẢ NHÂN VIÊN.");
        }
    }
}
