# Buoi02_Mang&dslk

- Họ tên: Đỗ Văn Linh
- MSV: 12425039
- Lớp: 124251

## Bài đã làm

### chương4

| Bài | Nội dung |
|---|---|
|1|Nhập mảng một chiều n phần tử, in mảng, chèn phần tử x vào vị trí k|
|2|Quản lý nhân viên (mảng đối tượng NhanVien): tổng thực lĩnh, nhân viên lương cơ bản thấp nhất, đếm nhân viên thưởng >= 1.200.000, sắp xếp theo phòng ban tăng dần rồi mã NV giảm dần, tăng lương cơ bản 5%|
|3|Ma trận vuông cấp n: tính tổng, giá trị dương nhỏ nhất, tổng đường chéo phụ, kiểm tra đường chéo chính tăng dần|
|4|Danh sách liên kết đơn (phần 1): thêm cuối, đếm số phần tử bằng x, tìm phần tử dương nhỏ nhất, xóa phần tử x đầu tiên|
|5|Danh sách liên kết đơn (phần 2): tìm max, tính tổng, đếm số nguyên tố, đếm số âm/dương/0, đếm phần tử bằng x, tìm phần tử dương nhỏ nhất|

### bài tập cuối sách

| Bài | Nội dung |
|---|---|
|7|Quản lý nhiệt độ: nhập nhiệt độ n ngày, tìm ngày nóng nhất, lạnh nhất và nhiệt độ trung bình|
|8|Thống kê từ: tách chuỗi thành các từ và đếm số lần xuất hiện của mỗi từ bằng Dictionary|
|9|Xử lý số nguyên: in ra các số nguyên tố, số chẵn, số hoàn hảo trong mảng|
|10|Ma trận xoắn ốc: in các phần tử của ma trận m x n theo thứ tự xoắn ốc|
|11|Ma trận đặc biệt: kiểm tra ma trận đơn vị, ma trận đối xứng|
|12|Game Minesweeper: sinh bảng mìn ngẫu nhiên m x n, mỗi ô không phải mìn hiển thị số mìn xung quanh (kết quả thay đổi theo mỗi lần chạy do dùng Random)|
|13|Đảo ngược danh sách liên kết đơn|
|14|Gộp hai danh sách liên kết đã sắp xếp thành một danh sách sắp xếp|
|15|Phát hiện chu trình trong danh sách liên kết (thuật toán hai con trỏ chậm - nhanh)|
|16|Hệ thống lịch sử duyệt web: dùng hai Stack (back, forward) cho thao tác truy cập, Back và Forward|
|17|Playlist nhạc: dùng List, chuyển bài Next/Previous theo vòng tròn, thêm bài hát mới|
|18|Hệ thống đặt hàng: chuyển trạng thái đơn hàng Chờ xử lý → Đang giao → Hoàn thành|

## Lệnh chạy

Chương trình có menu chọn bài, chạy bằng `dotnet run` rồi nhập số thứ tự bài (0 để thoát).

### chương4
```bash
docnet run 1
docnet run 2
docnet run 3
docnet run 4
docnet run 5
```

### bài tập cuối sách
```bash
docnet run 6
docnet run 7
docnet run 8
docnet run 9
docnet run 10
docnet run 11
docnet run 12
docnet run 13
docnet run 14
docnet run 15
docnet run 16
docnet run 17
```

## Kết quả chạy

### chương4

### bài1

```csharp
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    using System;

    class Bai01
    {
        public static void Run()
        {
            Console.Write("NHẬP N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"NHẬP A[{i}]: ");
                a[i] = int.Parse(Console.ReadLine()!);
            }

            Console.Write("DANH SÁCH: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            Console.Write("NHẬP PHẦN TỬ X CẦN CHÈN: ");
            int x = int.Parse(Console.ReadLine()!);
            Console.Write("NHẬP VỊ TRÍ K CẦN CHÈN: ");
            int k = int.Parse(Console.ReadLine()!);

            int[] tmp = new int[n + 1];
            for (int i = 0; i < k; i++)
            {
                tmp[i] = a[i];
            }
            tmp[k] = x;
            for (int i = k; i < n; i++)
            {
                tmp[i + 1] = a[i];
            }

            Console.Write("DANH SÁCH SAU KHI CHÈN: ");
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.Write(tmp[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
```

#### kết quả

```text
Chọn bài: 1

NHẬP N: 5
NHẬP A[0]: 10
NHẬP A[1]: 20
NHẬP A[2]: 30
NHẬP A[3]: 40
NHẬP A[4]: 50
DANH SÁCH: 10 20 30 40 50 
NHẬP PHẦN TỬ X CẦN CHÈN: 25
NHẬP VỊ TRÍ K CẦN CHÈN: 2
DANH SÁCH SAU KHI CHÈN: 10 20 25 30 40 50 
```

### bài2

```csharp
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
```

#### kết quả

```text
Chọn bài: 2

NHẬP SỐ LƯỢNG NHÂN VIÊN: 3
NHẬP THÔNG TIN NHÂN VIÊN THỨ 1:
MÃ NHÂN VIÊN: NV01
HỌ VÀ TÊN: Nguyen Van A
NĂM SINH: 2000
PHÒNG BAN: KT
LƯƠNG CƠ BẢN: 8000000
THƯỞNG: 1500000
NHẬP THÔNG TIN NHÂN VIÊN THỨ 2:
MÃ NHÂN VIÊN: NV02
HỌ VÀ TÊN: Tran Thi B
NĂM SINH: 1999
PHÒNG BAN: KD
LƯƠNG CƠ BẢN: 7000000
THƯỞNG: 1000000
NHẬP THÔNG TIN NHÂN VIÊN THỨ 3:
MÃ NHÂN VIÊN: NV03
HỌ VÀ TÊN: Le Van C
NĂM SINH: 2001
PHÒNG BAN: KT
LƯƠNG CƠ BẢN: 7000000
THƯỞNG: 1200000
TỔNG THỰC LĨNH: 25700000
DANH SÁCH NHÂN VIÊN LƯƠNG CƠ BẢN THẤP NHẤT:
NV02 - Tran Thi B - 7000000
NV03 - Le Van C - 7000000
SỐ NHÂN VIÊN THƯỞNG >= 1200000: 2
DANH SÁCH SAU KHI SẮP XẾP:
NV02 - Tran Thi B - KD
NV03 - Le Van C - KT
NV01 - Nguyen Van A - KT
ĐÃ CẬP NHẬT TĂNG LƯƠNG CƠ BẢN LÊN 5% CHO TẤT CẢ NHÂN VIÊN.
```

### bài3

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai03
    {
        static int TinhTong(int[,] a, int n)
        {
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    t += a[i, j];
                }
            }
            return t;
        }

        static int TimDuongNhoNhat(int[,] a, int n)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > 0 && a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            return min == int.MaxValue ? -1 : min;
        }

        static int TinhTongCheoPhu(int[,] a, int n)
        {
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                t += a[i, n - 1 - i];
            }
            return t;
        }

        static bool KiemTraCheoChinhTangDan(int[,] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i, i] >= a[i + 1, i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Run()
        {
            Console.Write("NHẬP CẤP MA TRẬN N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine($"TỔNG MA TRẬN: {TinhTong(a, n)}");
            Console.WriteLine($"GIÁ TRỊ DƯƠNG NHỎ NHẤT: {TimDuongNhoNhat(a, n)}");
            Console.WriteLine($"TỔNG ĐƯỜNG CHÉO PHỤ: {TinhTongCheoPhu(a, n)}");
            Console.WriteLine($"ĐƯỜNG CHÉO CHÍNH TĂNG DẦN: {KiemTraCheoChinhTangDan(a, n)}");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 3

NHẬP CẤP MA TRẬN N: 3
A[0,0] = 1
A[0,1] = 2
A[0,2] = 3
A[1,0] = 4
A[1,1] = 5
A[1,2] = 6
A[2,0] = 7
A[2,1] = 8
A[2,2] = 9
TỔNG MA TRẬN: 45
GIÁ TRỊ DƯƠNG NHỎ NHẤT: 1
TỔNG ĐƯỜNG CHÉO PHỤ: 15
ĐƯỜNG CHÉO CHÍNH TĂNG DẦN: True
```

### bài4

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Node4
    {
        public int data;
        public Node4? next;
        public Node4(int val)
        {
            data = val;
            next = null;
        }
    }

    class LinkedList4
    {
        public Node4? pHead = null;

        public void ThemCuoi(int val)
        {
            Node4 newNode = new Node4(val);
            if (pHead == null)
            {
                pHead = newNode;
            }
            else
            {
                Node4 p = pHead;
                while (p.next != null) p = p.next;
                p.next = newNode;
            }
        }

        public int DemSoBangX(int x)
        {
            int d = 0;
            Node4? p = pHead;
            while (p != null)
            {
                if (p.data == x) d++;
                p = p.next;
            }
            return d;
        }

        public int TimPhanTuDuongNhoNhat()
        {
            int min = int.MaxValue;
            Node4? p = pHead;
            while (p != null)
            {
                if (p.data > 0 && p.data < min)
                {
                    min = p.data;
                }
                p = p.next;
            }
            return min == int.MaxValue ? -1 : min;
        }

        public void XoaXDauTien(int x)
        {
            if (pHead == null) return;
            if (pHead.data == x)
            {
                pHead = pHead.next;
                return;
            }
            Node4 t = pHead;
            while (t.next != null && t.next.data != x)
            {
                t = t.next;
            }
            if (t.next != null)
            {
                t.next = t.next.next;
            }
        }

        public void InDanhSach()
        {
            Node4? p = pHead;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }

    class Bai04
    {
        public static void Run()
        {
            LinkedList4 list = new LinkedList4();
            list.ThemCuoi(5);
            list.ThemCuoi(2);
            list.ThemCuoi(8);
            list.ThemCuoi(2);

            Console.Write("DANH SÁCH BAN ĐẦU: ");
            list.InDanhSach();
            Console.WriteLine($"SỐ LƯỢNG SỐ BẰNG 2: {list.DemSoBangX(2)}");
            Console.WriteLine($"PHẦN TỬ DƯƠNG NHỎ NHẤT: {list.TimPhanTuDuongNhoNhat()}");
            list.XoaXDauTien(2);
            Console.Write("DANH SÁCH SAU KHI XÓA 2 ĐẦU TIÊN: ");
            list.InDanhSach();
        }
    }
}
```

#### kết quả

```text
Chọn bài: 4

DANH SÁCH BAN ĐẦU: 5 2 8 2 
SỐ LƯỢNG SỐ BẰNG 2: 2
PHẦN TỬ DƯƠNG NHỎ NHẤT: 2
DANH SÁCH SAU KHI XÓA 2 ĐẦU TIÊN: 5 8 2 
```

### bài5

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Node5
    {
        public int data;
        public Node5? next;
        public Node5(int val)
        {
            data = val;
            next = null;
        }
    }

    class LinkedList5
    {
        public Node5? l = null;

        public void ThemCuoi(int val)
        {
            Node5 newNode = new Node5(val);
            if (l == null)
            {
                l = newNode;
            }
            else
            {
                Node5 p = l;
                while (p.next != null) p = p.next;
                p.next = newNode;
            }
        }

        public int TimMax()
        {
            if (l == null) return int.MinValue;
            int max = int.MinValue;
            Node5? p = l;
            while (p != null)
            {
                if (p.data > max) max = p.data;
                p = p.next;
            }
            return max;
        }

        public int TinhTong()
        {
            int t = 0;
            Node5? p = l;
            while (p != null)
            {
                t += p.data;
                p = p.next;
            }
            return t;
        }

        bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public int DemSoNguyenTo()
        {
            int dem = 0;
            Node5? p = l;
            while (p != null)
            {
                if (LaSoNguyenTo(p.data)) dem++;
                p = p.next;
            }
            return dem;
        }

        public void DemAmDuongKhong(out int am, out int duong, out int khong)
        {
            am = 0;
            duong = 0;
            khong = 0;
            Node5? p = l;
            while (p != null)
            {
                if (p.data < 0) am++;
                else if (p.data > 0) duong++;
                else khong++;
                p = p.next;
            }
        }

        public int DemSoBangX(int x)
        {
            int dem = 0;
            Node5? p = l;
            while (p != null)
            {
                if (p.data == x) dem++;
                p = p.next;
            }
            return dem;
        }

        public int TimPhanTuDuongNhoNhat()
        {
            int min = int.MaxValue;
            Node5? p = l;
            while (p != null)
            {
                if (p.data > 0 && p.data < min)
                {
                    min = p.data;
                }
                p = p.next;
            }
            return min == int.MaxValue ? -1 : min;
        }

        public void InDanhSach()
        {
            Node5? p = l;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }

    class Bai05
    {
        public static void Run()
        {
            LinkedList5 list = new LinkedList5();
            list.ThemCuoi(-3);
            list.ThemCuoi(5);
            list.ThemCuoi(0);
            list.ThemCuoi(7);
            list.ThemCuoi(5);

            Console.Write("DANH SÁCH L: ");
            list.InDanhSach();
            Console.WriteLine($"PHẦN TỬ LỚN NHẤT: {list.TimMax()}");
            Console.WriteLine($"TỔNG CÁC PHẦN TỬ: {list.TinhTong()}");
            Console.WriteLine($"SỐ LƯỢNG SỐ NGUYÊN TỐ: {list.DemSoNguyenTo()}");
            list.DemAmDuongKhong(out int am, out int duong, out int khong);
            Console.WriteLine($"SỐ ÂM: {am}, SỐ DƯƠNG: {duong}, SỐ 0: {khong}");
            Console.WriteLine($"SỐ PHẦN TỬ BẰNG 5: {list.DemSoBangX(5)}");
            Console.WriteLine($"PHẦN TỬ DƯƠNG NHỎ NHẤT: {list.TimPhanTuDuongNhoNhat()}");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 5

DANH SÁCH L: -3 5 0 7 5 
PHẦN TỬ LỚN NHẤT: 7
TỔNG CÁC PHẦN TỬ: 14
SỐ LƯỢNG SỐ NGUYÊN TỐ: 3
SỐ ÂM: 1, SỐ DƯƠNG: 3, SỐ 0: 1
SỐ PHẦN TỬ BẰNG 5: 2
PHẦN TỬ DƯƠNG NHỎ NHẤT: 5
```

---

### bài tập cuối sách

### bài7

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai07
    {
        public static void Run()
        {
            Console.Write("NHẬP SỐ NGÀY N: ");
            int n = int.Parse(Console.ReadLine()!);
            double[] a = new double[n];
            double tong = 0;
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"NHẬP NHIỆT ĐỘ NGÀY THỨ {i + 1}: ");
                a[i] = double.Parse(Console.ReadLine()!);
                tong += a[i];
                if (a[i] > a[maxIndex]) maxIndex = i;
                if (a[i] < a[minIndex]) minIndex = i;
            }

            Console.WriteLine($"NGÀY CÓ NHIỆT ĐỘ CAO NHẤT LÀ NGÀY {maxIndex + 1} VỚI {a[maxIndex]} ĐỘ");
            Console.WriteLine($"NGÀY CÓ NHIỆT ĐỘ THẤP NHẤT LÀ NGÀY {minIndex + 1} VỚI {a[minIndex]} ĐỘ");
            Console.WriteLine($"NHIỆT ĐỘ TRUNG BÌNH: {tong / n}");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 6

NHẬP SỐ NGÀY N: 5
NHẬP NHIỆT ĐỘ NGÀY THỨ 1: 30.5
NHẬP NHIỆT ĐỘ NGÀY THỨ 2: 32
NHẬP NHIỆT ĐỘ NGÀY THỨ 3: 28
NHẬP NHIỆT ĐỘ NGÀY THỨ 4: 35.5
NHẬP NHIỆT ĐỘ NGÀY THỨ 5: 29
NGÀY CÓ NHIỆT ĐỘ CAO NHẤT LÀ NGÀY 4 VỚI 35.5 ĐỘ
NGÀY CÓ NHIỆT ĐỘ THẤP NHẤT LÀ NGÀY 3 VỚI 28 ĐỘ
NHIỆT ĐỘ TRUNG BÌNH: 31
```

### bài8

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai08
    {
        public static void Run()
        {
            Console.Write("NHẬP MỘT CHUỖI VĂN BẢN: ");
            string s = Console.ReadLine()!.ToLower();
            string[] words = s.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string w in words)
            {
                if (dict.ContainsKey(w))
                {
                    dict[w]++;
                }
                else
                {
                    dict[w] = 1;
                }
            }

            Console.WriteLine("SỐ LẦN XUẤT HIỆN CỦA MỖI TỪ:");
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
```

#### kết quả

```text
Chọn bài: 7

NHẬP MỘT CHUỖI VĂN BẢN: Xin chào, xin chào mọi người!
SỐ LẦN XUẤT HIỆN CỦA MỖI TỪ:
xin: 2
chào: 2
mọi: 1
người: 1
```

### bài9

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai09
    {
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static bool LaSoHoanHao(int n)
        {
            if (n <= 1) return false;
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i != n / i) sum += n / i;
                }
            }
            return sum == n;
        }

        public static void Run()
        {
            Console.Write("NHẬP SỐ LƯỢNG PHẦN TỬ N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"NHẬP A[{i}]: ");
                a[i] = int.Parse(Console.ReadLine()!);
            }

            Console.Write("CÁC SỐ NGUYÊN TỐ: ");
            foreach (int x in a)
            {
                if (LaSoNguyenTo(x)) Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.Write("CÁC SỐ CHẴN: ");
            foreach (int x in a)
            {
                if (x % 2 == 0) Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.Write("CÁC SỐ HOÀN HẢO: ");
            foreach (int x in a)
            {
                if (LaSoHoanHao(x)) Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}
```

#### kết quả

```text
Chọn bài: 8

NHẬP SỐ LƯỢNG PHẦN TỬ N: 6
NHẬP A[0]: 6
NHẬP A[1]: 7
NHẬP A[2]: 10
NHẬP A[3]: 28
NHẬP A[4]: 13
NHẬP A[5]: 1
CÁC SỐ NGUYÊN TỐ: 7 13 
CÁC SỐ CHẴN: 6 10 28 
CÁC SỐ HOÀN HẢO: 6 28 
```

### bài10

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai10
    {
        public static void Run()
        {
            Console.Write("NHẬP SỐ HÀNG M: ");
            int m = int.Parse(Console.ReadLine()!);
            Console.Write("NHẬP SỐ CỘT N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine("MA TRẬN THEO THỨ TỰ XOẮN ỐC:");
            int top = 0, bottom = m - 1, left = 0, right = n - 1;
            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++) Console.Write(a[top, i] + " ");
                top++;

                for (int i = top; i <= bottom; i++) Console.Write(a[i, right] + " ");
                right--;

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--) Console.Write(a[bottom, i] + " ");
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--) Console.Write(a[i, left] + " ");
                    left++;
                }
            }
            Console.WriteLine();
        }
    }
}
```

#### kết quả

```text
Chọn bài: 9

NHẬP SỐ HÀNG M: 3
NHẬP SỐ CỘT N: 4
A[0,0] = 1
A[0,1] = 2
A[0,2] = 3
A[0,3] = 4
A[1,0] = 5
A[1,1] = 6
A[1,2] = 7
A[1,3] = 8
A[2,0] = 9
A[2,1] = 10
A[2,2] = 11
A[2,3] = 12
MA TRẬN THEO THỨ TỰ XOẮN ỐC:
1 2 3 4 8 12 11 10 9 5 6 7 
```

### bài11

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai11
    {
        public static void Run()
        {
            Console.Write("NHẬP CẤP MA TRẬN VUÔNG N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            bool isUnit = true;
            bool isSymmetric = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && a[i, j] != 1) isUnit = false;
                    if (i != j && a[i, j] != 0) isUnit = false;
                    if (a[i, j] != a[j, i]) isSymmetric = false;
                }
            }

            Console.WriteLine($"LÀ MA TRẬN ĐƠN VỊ: {isUnit}");
            Console.WriteLine($"LÀ MA TRẬN ĐỐI XỨNG: {isSymmetric}");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 10

NHẬP CẤP MA TRẬN VUÔNG N: 3
A[0,0] = 1
A[0,1] = 0
A[0,2] = 0
A[1,0] = 0
A[1,1] = 1
A[1,2] = 0
A[2,0] = 0
A[2,1] = 0
A[2,2] = 1
LÀ MA TRẬN ĐƠN VỊ: True
LÀ MA TRẬN ĐỐI XỨNG: True
```

### bài12

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai12
    {
        public static void Run()
        {
            Console.Write("NHẬP SỐ HÀNG M: ");
            int m = int.Parse(Console.ReadLine()!);
            Console.Write("NHẬP SỐ CỘT N: ");
            int n = int.Parse(Console.ReadLine()!);
            int[,] board = new int[m, n];

            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = rand.Next(0, 2);
                }
            }

            Console.WriteLine("BẢNG MÌN (M LÀ MÌN, SỐ KHÁC LÀ SỐ MÌN XUNG QUANH):");
            int[,] result = new int[m, n];
            int[] dr = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dc = { -1, 0, 1, -1, 1, -1, 0, 1 };

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == 1)
                    {
                        result[i, j] = 9;
                    }
                    else
                    {
                        int count = 0;
                        for (int k = 0; k < 8; k++)
                        {
                            int ni = i + dr[k];
                            int nj = j + dc[k];
                            if (ni >= 0 && ni < m && nj >= 0 && nj < n && board[ni, nj] == 1)
                            {
                                count++;
                            }
                        }
                        result[i, j] = count;
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((result[i, j] == 9 ? "M " : result[i, j] + " "));
                }
                Console.WriteLine();
            }
        }
    }
}
```

#### kết quả

```text
Chọn bài: 11

NHẬP SỐ HÀNG M: 4
NHẬP SỐ CỘT N: 5
BẢNG MÌN (M LÀ MÌN, SỐ KHÁC LÀ SỐ MÌN XUNG QUANH):
1 M 2 1 1 
2 2 2 M 1 
M 1 1 2 2 
1 1 0 1 M 
```

### bài13

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Node13
    {
        public int data;
        public Node13? next;
        public Node13(int val)
        {
            data = val;
            next = null;
        }
    }

    class LinkedList13
    {
        public Node13? pHead = null;

        public void ThemCuoi(int val)
        {
            Node13 newNode = new Node13(val);
            if (pHead == null) pHead = newNode;
            else
            {
                Node13 p = pHead;
                while (p.next != null) p = p.next;
                p.next = newNode;
            }
        }

        public void DaoNguoc()
        {
            Node13? prev = null;
            Node13? current = pHead;
            Node13? next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            pHead = prev;
        }

        public void InDanhSach()
        {
            Node13? p = pHead;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }

    class Bai13
    {
        public static void Run()
        {
            LinkedList13 list = new LinkedList13();
            list.ThemCuoi(1);
            list.ThemCuoi(2);
            list.ThemCuoi(3);
            list.ThemCuoi(4);

            Console.Write("DANH SÁCH BAN ĐẦU: ");
            list.InDanhSach();
            list.DaoNguoc();
            Console.Write("DANH SÁCH SAU KHI ĐẢO NGƯỢC: ");
            list.InDanhSach();
        }
    }
}
```

#### kết quả

```text
Chọn bài: 12

DANH SÁCH BAN ĐẦU: 1 2 3 4 
DANH SÁCH SAU KHI ĐẢO NGƯỢC: 4 3 2 1 
```

### bài14

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Node14
    {
        public int data;
        public Node14? next;
        public Node14(int val)
        {
            data = val;
            next = null;
        }
    }

    class Bai14
    {
        public static Node14? GopHaiDanhSach(Node14? l1, Node14? l2)
        {
            Node14 dummy = new Node14(0);
            Node14 tail = dummy;
            while (l1 != null && l2 != null)
            {
                if (l1.data <= l2.data)
                {
                    tail.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    tail.next = l2;
                    l2 = l2.next;
                }
                tail = tail.next;
            }
            if (l1 != null) tail.next = l1;
            if (l2 != null) tail.next = l2;
            return dummy.next;
        }

        public static void InDanhSach(Node14? head)
        {
            Node14? p = head;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public static void Run()
        {
            Node14 l1 = new Node14(1);
            l1.next = new Node14(3);
            l1.next.next = new Node14(5);

            Node14 l2 = new Node14(2);
            l2.next = new Node14(4);
            l2.next.next = new Node14(6);

            Console.Write("DANH SÁCH 1: ");
            InDanhSach(l1);
            Console.Write("DANH SÁCH 2: ");
            InDanhSach(l2);

            Node14? merged = GopHaiDanhSach(l1, l2);
            Console.Write("DANH SÁCH SAU KHI GỘP: ");
            InDanhSach(merged);
        }
    }
}
```

#### kết quả

```text
Chọn bài: 13

DANH SÁCH 1: 1 3 5 
DANH SÁCH 2: 2 4 6 
DANH SÁCH SAU KHI GỘP: 1 2 3 4 5 6 
```

### bài15

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Node15
    {
        public int data;
        public Node15? next;
        public Node15(int val)
        {
            data = val;
            next = null;
        }
    }

    class Bai15
    {
        public static bool CoChuTrinh(Node15? head)
        {
            Node15? slow = head;
            Node15? fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow?.next;
                fast = fast.next.next;
                if (slow == fast) return true;
            }
            return false;
        }

        public static void Run()
        {
            Node15 head = new Node15(1);
            head.next = new Node15(2);
            head.next.next = new Node15(3);
            head.next.next.next = head.next;

            Console.WriteLine($"DANH SÁCH CÓ CHỨA CHU TRÌNH: {CoChuTrinh(head)}");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 14

DANH SÁCH CÓ CHỨA CHU TRÌNH: True
```

### bài16

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai16
    {
        public static void Run()
        {
            Stack<string> backStack = new Stack<string>();
            Stack<string> forwardStack = new Stack<string>();
            string current = "google.com";
            Console.WriteLine($"TRUY CẬP: {current}");

            backStack.Push(current);
            current = "github.com";
            Console.WriteLine($"TRUY CẬP: {current}");

            backStack.Push(current);
            current = "stackoverflow.com";
            Console.WriteLine($"TRUY CẬP: {current}");

            forwardStack.Clear();
            backStack.Push(current);
            current = backStack.Pop();
            Console.WriteLine($"BACK ĐẾN: {current}");

            forwardStack.Push(current);
            current = forwardStack.Pop();
            Console.WriteLine($"FORWARD ĐẾN: {current}");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 15

TRUY CẬP: google.com
TRUY CẬP: github.com
TRUY CẬP: stackoverflow.com
BACK ĐẾN: stackoverflow.com
FORWARD ĐẾN: stackoverflow.com
```

### bài17

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai17
    {
        public static void Run()
        {
            List<string> playlist = new List<string> { "Bài hát 1", "Bài hát 2", "Bài hát 3" };
            int currentIndex = 0;

            Console.WriteLine($"ĐANG PHÁT: {playlist[currentIndex]}");

            currentIndex = (currentIndex + 1) % playlist.Count;
            Console.WriteLine($"NEXT SANG: {playlist[currentIndex]}");

            currentIndex = (currentIndex - 1 + playlist.Count) % playlist.Count;
            Console.WriteLine($"PREVIOUS SANG: {playlist[currentIndex]}");

            playlist.Add("Bài hát 4");
            Console.WriteLine("ĐÃ THÊM BÀI HÁT 4 VÀO PLAYLIST");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 16

ĐANG PHÁT: Bài hát 1
NEXT SANG: Bài hát 2
PREVIOUS SANG: Bài hát 1
ĐÃ THÊM BÀI HÁT 4 VÀO PLAYLIST
```

### bài18

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai18
    {
        public static void Run()
        {
            string trangThai = "Chờ xử lý";
            Console.WriteLine($"TRẠNG THÁI ĐƠN HÀNG: {trangThai}");

            trangThai = "Đang giao";
            Console.WriteLine($"CHUYỂN TRẠNG THÁI: {trangThai}");

            trangThai = "Hoàn thành";
            Console.WriteLine($"CHUYỂN TRẠNG THÁI: {trangThai}");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 17

TRẠNG THÁI ĐƠN HÀNG: Chờ xử lý
CHUYỂN TRẠNG THÁI: Đang giao
CHUYỂN TRẠNG THÁI: Hoàn thành
```
