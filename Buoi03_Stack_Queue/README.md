Buoi03_Stack_Queue
Họ tên: Đỗ Văn Linh
MSV: 12425039
Lớp: 124251
Bài đã làm
bài tập chương
Bài	Nội dung
1	Kiểm tra tính đúng đắn của biểu thức toán học: dùng Stack kiểm tra các cặp ngoặc (), [], {} có khớp và đúng thứ tự hay không
2	Mô phỏng lịch sử trình duyệt web: dùng hai Stack (back, forward) cho thao tác Truy cập, Back, Forward và hiển thị trang hiện tại
3	Mô phỏng quá trình thực thi chương trình (Function Call Stack): đẩy/lấy khung hàm (tên hàm, tham số, địa chỉ trả về), có ví dụ đệ quy GiaiThua(3)
4	Mô phỏng hệ thống in: dùng Queue, thêm yêu cầu in (Enqueue), xử lý yêu cầu in (Dequeue), hiển thị các yêu cầu đang chờ
5	Mô phỏng đường truyền dữ liệu: dùng Queue chứa các gói tin được đánh số thứ tự, gửi (Enqueue) và xử lý (Dequeue) theo thứ tự đến
6	Mô phỏng hàng đợi tại Trung tâm Dịch vụ Khách hàng / ngân hàng: Queue các đối tượng KhachHang (tên, thời gian đến, loại dịch vụ) (thời gian đến lấy theo giờ hệ thống nên thay đổi mỗi lần chạy)
bài tập cuối sách
Bài	Nội dung
4	Mô phỏng lịch sử trình duyệt web: hai Stack back/forward, các thao tác Visit, Back, Forward
5	Kiểm tra chuỗi ngoặc ( ) đúng: chuỗi chỉ gồm ( và ), dùng Stack để kiểm tra
6	Mô phỏng hệ thống in: Queue các tài liệu cần in
7	Mô phỏng đường truyền dữ liệu: Queue các gói dữ liệu, gửi và nhận theo thứ tự
8	Mô phỏng dịch vụ khách hàng: Queue khách hàng chờ, phục vụ theo thứ tự đến
9	Tính giá trị biểu thức hậu tố bằng Stack
10	Kiểm tra tính hợp lệ của biểu thức trung tố (ký tự, ngoặc, toán tử liên tiếp, đầu/cuối biểu thức)
11	Tính giá trị biểu thức trung tố: kiểm tra hợp lệ, chuyển sang hậu tố bằng Stack rồi tính giá trị
Lệnh chạy

Chương trình có menu chọn bài, chạy bằng dotnet run rồi nhập số thứ tự bài (0 để thoát). Sau mỗi bài, nhấn phím bất kỳ để quay lại menu.

bài tập chương
bash
dotnet run   # nhập 1  -> Bài 1
dotnet run   # nhập 2  -> Bài 2
dotnet run   # nhập 3  -> Bài 3
dotnet run   # nhập 4  -> Bài 4
dotnet run   # nhập 5  -> Bài 5
dotnet run   # nhập 6  -> Bài 6
bài tập cuối sách
bash
dotnet run   # nhập 7   -> Bài 4
dotnet run   # nhập 8   -> Bài 5
dotnet run   # nhập 9   -> Bài 6
dotnet run   # nhập 10  -> Bài 7
dotnet run   # nhập 11  -> Bài 8
dotnet run   # nhập 12  -> Bài 9
dotnet run   # nhập 13  -> Bài 10
dotnet run   # nhập 14  -> Bài 11
Kết quả chạy

Ghi chú: với các bài có menu con, đoạn [menu] là phần menu của bài được in lại sau mỗi thao tác (đã lược bớt cho gọn).

bài tập chương
bài1
csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai01
    {
        // Kiểm tra ngoặc đóng có khớp với ngoặc mở không
        static bool KhopNgoac(char mo, char dong)
        {
            return (mo == '(' && dong == ')')
                || (mo == '[' && dong == ']')
                || (mo == '{' && dong == '}');
        }

        static bool KiemTraBieuThuc(string bieuThuc)
        {
            Stack<char> st = new Stack<char>();

            // Duyệt từng ký tự của biểu thức
            foreach (char c in bieuThuc)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    // Gặp ngoặc mở -> đẩy vào Stack
                    st.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    // Gặp ngoặc đóng -> Stack rỗng thì sai
                    if (st.Count == 0)
                        return false;

                    // Lấy phần tử đỉnh ra, không khớp loại ngoặc thì sai
                    char mo = st.Pop();
                    if (!KhopNgoac(mo, c))
                        return false;
                }
                // Các ký tự khác (số, toán tử, chữ...) thì bỏ qua
            }

            // Duyệt hết: Stack rỗng thì hợp lệ, còn ngoặc mở chưa đóng thì sai
            return st.Count == 0;
        }

        public static void Run()
        {
            Console.WriteLine("== KIỂM TRA TÍNH ĐÚNG ĐẮN CỦA BIỂU THỨC TOÁN HỌC ==");
            Console.WriteLine("Ví dụ hợp lệ: {[(1 + 2) * 3] - 4}");
            Console.WriteLine("Ví dụ sai   : (1 + [2 * 3)]");
            Console.Write("Nhập biểu thức: ");
            string bieuThuc = Console.ReadLine() ?? "";

            if (KiemTraBieuThuc(bieuThuc))
                Console.WriteLine("=> Biểu thức hợp lệ.");
            else
                Console.WriteLine("=> Biểu thức sai.");
        }
    }
}
kết quả
text
Chọn: 1

== KIỂM TRA TÍNH ĐÚNG ĐẮN CỦA BIỂU THỨC TOÁN HỌC ==
Ví dụ hợp lệ: {[(1 + 2) * 3] - 4}
Ví dụ sai   : (1 + [2 * 3)]
Nhập biểu thức: {[(1 + 2) * 3] - 4}
=> Biểu thức hợp lệ.

Chọn: 1

== KIỂM TRA TÍNH ĐÚNG ĐẮN CỦA BIỂU THỨC TOÁN HỌC ==
Ví dụ hợp lệ: {[(1 + 2) * 3] - 4}
Ví dụ sai   : (1 + [2 * 3)]
Nhập biểu thức: (1 + [2 * 3)]
=> Biểu thức sai.
bài2
csharp
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
kết quả
text
Chọn: 2

[menu]
Chọn: 1
Nhập URL: google.com
Đang truy cập: google.com

[menu]
Chọn: 1
Nhập URL: github.com
Đang truy cập: github.com

[menu]
Chọn: 1
Nhập URL: stackoverflow.com
Đang truy cập: stackoverflow.com

[menu]
Chọn: 2
Quay lại: github.com

[menu]
Chọn: 2
Quay lại: google.com

[menu]
Chọn: 2
Không thể quay lại!

[menu]
Chọn: 3
Chuyển tiếp: github.com

[menu]
Chọn: 4
Trang hiện tại: github.com

[menu]
Chọn: 1
Nhập URL: youtube.com
Đang truy cập: youtube.com

[menu]
Chọn: 3
Không thể chuyển tiếp!

[menu]
Chọn: 0
bài3
csharp
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
kết quả
text
Chọn: 3

[menu]
Chọn: 4
-> Gọi hàm Main(), đã đẩy khung vào Stack.
-> Gọi hàm GiaiThua(3), đã đẩy khung vào Stack.
--- Call Stack (từ đỉnh xuống đáy) ---
  GiaiThua(3)  - địa chỉ trả về: Main
  Main()  - địa chỉ trả về: Hệ điều hành
-> Gọi hàm GiaiThua(2), đã đẩy khung vào Stack.
--- Call Stack (từ đỉnh xuống đáy) ---
  GiaiThua(2)  - địa chỉ trả về: GiaiThua(3)
  GiaiThua(3)  - địa chỉ trả về: Main
  Main()  - địa chỉ trả về: Hệ điều hành
-> Gọi hàm GiaiThua(1), đã đẩy khung vào Stack.
--- Call Stack (từ đỉnh xuống đáy) ---
  GiaiThua(1)  - địa chỉ trả về: GiaiThua(2)
  GiaiThua(2)  - địa chỉ trả về: GiaiThua(3)
  GiaiThua(3)  - địa chỉ trả về: Main
  Main()  - địa chỉ trả về: Hệ điều hành
<- Hàm GiaiThua kết thúc, trả về GiaiThua(2).
--- Call Stack (từ đỉnh xuống đáy) ---
  GiaiThua(2)  - địa chỉ trả về: GiaiThua(3)
  GiaiThua(3)  - địa chỉ trả về: Main
  Main()  - địa chỉ trả về: Hệ điều hành
<- Hàm GiaiThua kết thúc, trả về GiaiThua(3).
--- Call Stack (từ đỉnh xuống đáy) ---
  GiaiThua(3)  - địa chỉ trả về: Main
  Main()  - địa chỉ trả về: Hệ điều hành
<- Hàm GiaiThua kết thúc, trả về Main.
--- Call Stack (từ đỉnh xuống đáy) ---
  Main()  - địa chỉ trả về: Hệ điều hành
<- Hàm Main kết thúc, trả về Hệ điều hành.

[menu]
Chọn: 3
--- Call Stack (từ đỉnh xuống đáy) ---
(rỗng)

[menu]
Chọn: 0
bài4
csharp
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
kết quả
text
Chọn: 4

[menu]
Chọn: 1
Nhập tên tài liệu cần in: Bao cao.docx
Đã thêm vào hàng đợi: Bao cao.docx

[menu]
Chọn: 1
Nhập tên tài liệu cần in: Hop dong.pdf
Đã thêm vào hàng đợi: Hop dong.pdf

[menu]
Chọn: 1
Nhập tên tài liệu cần in: Anh the.png
Đã thêm vào hàng đợi: Anh the.png

[menu]
Chọn: 3
Các yêu cầu đang chờ (đầu hàng đợi ở trên cùng):
  1. Bao cao.docx
  2. Hop dong.pdf
  3. Anh the.png

[menu]
Chọn: 2
Đang in: Bao cao.docx

[menu]
Chọn: 3
Các yêu cầu đang chờ (đầu hàng đợi ở trên cùng):
  1. Hop dong.pdf
  2. Anh the.png

[menu]
Chọn: 2
Đang in: Hop dong.pdf

[menu]
Chọn: 2
Đang in: Anh the.png

[menu]
Chọn: 2
Không có yêu cầu in nào!

[menu]
Chọn: 0
bài5
csharp
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
kết quả
text
Chọn: 5

[menu]
Chọn: 1
Nhập nội dung gói tin: Hello
Đã gửi Gói 1: Hello

[menu]
Chọn: 1
Nhập nội dung gói tin: Xin chao
Đã gửi Gói 2: Xin chao

[menu]
Chọn: 1
Nhập nội dung gói tin: Data 123
Đã gửi Gói 3: Data 123

[menu]
Chọn: 3
Các gói tin đang chờ (theo thứ tự đến):
  - Gói 1: Hello
  - Gói 2: Xin chao
  - Gói 3: Data 123

[menu]
Chọn: 2
Đã xử lý -> Gói 1: Hello

[menu]
Chọn: 3
Các gói tin đang chờ (theo thứ tự đến):
  - Gói 2: Xin chao
  - Gói 3: Data 123

[menu]
Chọn: 2
Đã xử lý -> Gói 2: Xin chao

[menu]
Chọn: 2
Đã xử lý -> Gói 3: Data 123

[menu]
Chọn: 2
Không có gói tin nào để xử lý!

[menu]
Chọn: 0
bài6
csharp
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
kết quả
text
Chọn: 6

[menu]
Chọn: 1
Tên khách hàng: Nguyen Van A
Loại dịch vụ (ví dụ: Gửi tiền, Rút tiền, Tư vấn): Gui tien
Đã thêm Nguyen Van A vào hàng đợi lúc 08:30:15.

[menu]
Chọn: 1
Tên khách hàng: Tran Thi B
Loại dịch vụ (ví dụ: Gửi tiền, Rút tiền, Tư vấn): Rut tien
Đã thêm Tran Thi B vào hàng đợi lúc 08:30:42.

[menu]
Chọn: 1
Tên khách hàng: Le Van C
Loại dịch vụ (ví dụ: Gửi tiền, Rút tiền, Tư vấn): Tu van
Đã thêm Le Van C vào hàng đợi lúc 08:31:05.

[menu]
Chọn: 3
Số khách hàng đang chờ: 3
  1. Nguyen Van A - Gui tien - đến lúc 08:30:15
  2. Tran Thi B - Rut tien - đến lúc 08:30:42
  3. Le Van C - Tu van - đến lúc 08:31:05

[menu]
Chọn: 2
Đang phục vụ: Nguyen Van A - Dịch vụ: Gui tien - Đến lúc: 08:30:15

[menu]
Chọn: 3
Số khách hàng đang chờ: 2
  1. Tran Thi B - Rut tien - đến lúc 08:30:42
  2. Le Van C - Tu van - đến lúc 08:31:05

[menu]
Chọn: 0
bài tập cuối sách
bài4 (cuối sách)
csharp
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
kết quả
text
Chọn: 7

[menu]
Chọn: 1
Nhập URL: google.com
Đang truy cập: google.com

[menu]
Chọn: 1
Nhập URL: facebook.com
Đang truy cập: facebook.com

[menu]
Chọn: 4
Trang hiện tại: facebook.com

[menu]
Chọn: 2
Quay lại: google.com

[menu]
Chọn: 3
Tiến lên: facebook.com

[menu]
Chọn: 3
Không thể tiến lên!

[menu]
Chọn: 2
Quay lại: google.com

[menu]
Chọn: 2
Không thể quay lại!

[menu]
Chọn: 0
bài5 (cuối sách)
csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai5
    {
        static bool KiemTraNgoac(string s)
        {
            Stack<char> st = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                {
                    st.Push(c);
                }
                else if (c == ')')
                {
                    if (st.Count == 0) return false; // có ')' mà không có '(' tương ứng
                    st.Pop();
                }
                else
                {
                    return false; // ký tự khác -> sai
                }
            }
            return st.Count == 0; // rỗng -> đúng, còn dư '(' -> sai
        }

        public static void Run()
        {
            Console.Write("Nhập chuỗi chỉ gồm ( và ): ");
            string s = (Console.ReadLine() ?? "").Trim();

            if (KiemTraNgoac(s))
                Console.WriteLine("Xâu đúng");
            else
                Console.WriteLine("Xâu sai");
        }
    }
}
kết quả
text
Chọn: 8

Nhập chuỗi chỉ gồm ( và ): (()())
Xâu đúng

Chọn: 8

Nhập chuỗi chỉ gồm ( và ): (()
Xâu sai
bài6 (cuối sách)
csharp
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
kết quả
text
Chọn: 9

[menu]
Chọn: 1
Nhập tên tài liệu: Bai tap.docx
Đã thêm vào hàng đợi.

[menu]
Chọn: 1
Nhập tên tài liệu: Slide.pptx
Đã thêm vào hàng đợi.

[menu]
Chọn: 3
Các yêu cầu đang chờ:
 - Bai tap.docx
 - Slide.pptx

[menu]
Chọn: 2
Đang in: Bai tap.docx

[menu]
Chọn: 3
Các yêu cầu đang chờ:
 - Slide.pptx

[menu]
Chọn: 2
Đang in: Slide.pptx

[menu]
Chọn: 2
Không có yêu cầu in nào!

[menu]
Chọn: 3
Hàng đợi trống.

[menu]
Chọn: 0
bài7 (cuối sách)
csharp
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
kết quả
text
Chọn: 10

[menu]
Chọn: 1
Nhập gói dữ liệu: Packet_1
Đã gửi gói dữ liệu.

[menu]
Chọn: 1
Nhập gói dữ liệu: Packet_2
Đã gửi gói dữ liệu.

[menu]
Chọn: 1
Nhập gói dữ liệu: Packet_3
Đã gửi gói dữ liệu.

[menu]
Chọn: 3
Các gói dữ liệu còn trong hàng đợi:
 - Packet_1
 - Packet_2
 - Packet_3

[menu]
Chọn: 2
Đã nhận: Packet_1

[menu]
Chọn: 3
Các gói dữ liệu còn trong hàng đợi:
 - Packet_2
 - Packet_3

[menu]
Chọn: 2
Đã nhận: Packet_2

[menu]
Chọn: 2
Đã nhận: Packet_3

[menu]
Chọn: 2
Không có dữ liệu để nhận!

[menu]
Chọn: 0
bài8 (cuối sách)
csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai8
    {
        public static void Run()
        {
            Queue<string> khachHang = new Queue<string>();
            string chon;
            do
            {
                Console.WriteLine("\n== MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG ==");
                Console.WriteLine("1. Thêm khách hàng");
                Console.WriteLine("2. Phục vụ khách hàng");
                Console.WriteLine("3. Hiển thị danh sách khách hàng chờ");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                chon = (Console.ReadLine() ?? "").Trim();

                if (chon == "1")
                {
                    Console.Write("Nhập tên hoặc số thứ tự khách hàng: ");
                    khachHang.Enqueue(Console.ReadLine() ?? "");
                    Console.WriteLine("Đã thêm khách hàng vào hàng đợi.");
                }
                else if (chon == "2")
                {
                    if (khachHang.Count > 0)
                        Console.WriteLine("Đang phục vụ: " + khachHang.Dequeue());
                    else
                        Console.WriteLine("Không có khách hàng nào trong hàng đợi!");
                }
                else if (chon == "3")
                {
                    if (khachHang.Count == 0)
                    {
                        Console.WriteLine("Hàng đợi trống.");
                    }
                    else
                    {
                        Console.WriteLine("Khách hàng đang chờ:");
                        foreach (string x in khachHang)
                            Console.WriteLine(" - " + x);
                    }
                }
            } while (chon != "0");
        }
    }
}
kết quả
text
Chọn: 11

[menu]
Chọn: 1
Nhập tên hoặc số thứ tự khách hàng: Khach 01
Đã thêm khách hàng vào hàng đợi.

[menu]
Chọn: 1
Nhập tên hoặc số thứ tự khách hàng: Khach 02
Đã thêm khách hàng vào hàng đợi.

[menu]
Chọn: 1
Nhập tên hoặc số thứ tự khách hàng: Khach 03
Đã thêm khách hàng vào hàng đợi.

[menu]
Chọn: 3
Khách hàng đang chờ:
 - Khach 01
 - Khach 02
 - Khach 03

[menu]
Chọn: 2
Đang phục vụ: Khach 01

[menu]
Chọn: 2
Đang phục vụ: Khach 02

[menu]
Chọn: 3
Khách hàng đang chờ:
 - Khach 03

[menu]
Chọn: 2
Đang phục vụ: Khach 03

[menu]
Chọn: 2
Không có khách hàng nào trong hàng đợi!

[menu]
Chọn: 0
bài9 (cuối sách)
csharp
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BTTH03
{
    // Các phần tử của biểu thức hậu tố cách nhau bởi dấu cách. Ví dụ: 3 4 2 * +  => 11
    class Bai9
    {
        // Kiểm tra s có phải là toán hạng (số) không
        public static bool IsOperand(string s)
        {
            return double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out _);
        }

        // Tính giá trị biểu thức hậu tố (Bài 11 dùng lại hàm này)
        public static double TinhHauTo(string postfix)
        {
            Stack<double> stack = new Stack<double>();
            IEnumerable<string> enumer = postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string x in enumer)
            {
                if (IsOperand(x))
                {
                    // toán hạng -> đẩy vào stack
                    stack.Push(double.Parse(x, CultureInfo.InvariantCulture));
                }
                else
                {
                    // toán tử -> lấy 2 phần tử ra tính
                    if (stack.Count < 2)
                        throw new Exception("Biểu thức hậu tố không hợp lệ!");

                    double b = stack.Pop();   // lấy ra trước là toán hạng phải
                    double a = stack.Pop();
                    double r;

                    if (x == "+") r = a + b;
                    else if (x == "-") r = a - b;
                    else if (x == "*") r = a * b;
                    else if (x == "/")
                    {
                        if (b == 0) throw new Exception("Lỗi chia cho 0!");
                        r = a / b;
                    }
                    else throw new Exception("Toán tử không hợp lệ: " + x);

                    stack.Push(r);            // đưa kết quả vào lại stack
                }
            }

            if (stack.Count != 1)
                throw new Exception("Biểu thức hậu tố không hợp lệ!");

            return stack.Pop(); // phần tử còn lại chính là kết quả
        }

        public static void Run()
        {
            Console.WriteLine("Nhập biểu thức hậu tố (các phần tử cách nhau bởi dấu cách), ví dụ: 3 4 2 * +");
            Console.Write("Biểu thức: ");
            string s = Console.ReadLine() ?? "";

            try
            {
                double kq = TinhHauTo(s);
                Console.WriteLine("Kết quả = " + kq);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
kết quả
text
Chọn: 12

Nhập biểu thức hậu tố (các phần tử cách nhau bởi dấu cách), ví dụ: 3 4 2 * +
Biểu thức: 3 4 2 * +
Kết quả = 11

Chọn: 12

Nhập biểu thức hậu tố (các phần tử cách nhau bởi dấu cách), ví dụ: 3 4 2 * +
Biểu thức: 5 1 2 + 4 * + 3 -
Kết quả = 14

Chọn: 12

Nhập biểu thức hậu tố (các phần tử cách nhau bởi dấu cách), ví dụ: 3 4 2 * +
Biểu thức: 4 0 /
Lỗi chia cho 0!
bài10 (cuối sách)
csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai10
    {
        static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        static bool IsOpen(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        static bool IsClose(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        // Kiểm tra biểu thức trung tố hợp lệ (Bài 11 dùng lại hàm này)
        public static bool IsValidInfix(string e)
        {
            string s = e.Replace(" ", "");   // bỏ dấu cách cho dễ xử lý
            if (s.Length == 0) return false;

            // 1. Kiểm tra ký tự hợp lệ
            foreach (char c in s)
            {
                if (!(char.IsDigit(c) || c == '.' || IsOperator(c) || IsOpen(c) || IsClose(c)))
                    return false;
            }

            // 2. Kiểm tra ngoặc bằng stack
            Stack<char> st = new Stack<char>();
            foreach (char c in s)
            {
                if (IsOpen(c))
                {
                    st.Push(c);
                }
                else if (IsClose(c))
                {
                    if (st.Count == 0) return false;   // có ngoặc đóng mà không có ngoặc mở
                    char top = st.Pop();
                    if (c == ')' && top != '(') return false;   // không khớp loại ngoặc
                    if (c == ']' && top != '[') return false;
                    if (c == '}' && top != '{') return false;
                }
            }
            if (st.Count != 0) return false;           // còn ngoặc mở chưa đóng

            // 3. Không bắt đầu hoặc kết thúc bằng toán tử
            if (IsOperator(s[0]) || IsOperator(s[s.Length - 1])) return false;

            // 4. Không có 2 toán tử liên tiếp, không có "( +" hoặc "+ )"
            for (int i = 1; i < s.Length; i++)
            {
                char prev = s[i - 1];
                char cur = s[i];
                if (IsOperator(prev) && IsOperator(cur)) return false;
                if (IsOpen(prev) && IsOperator(cur)) return false;
                if (IsOperator(prev) && IsClose(cur)) return false;
            }

            return true;
        }

        public static void Run()
        {
            Console.Write("Nhập biểu thức trung tố: ");
            string e = Console.ReadLine() ?? "";

            if (IsValidInfix(e))
                Console.WriteLine("Biểu thức hợp lệ");
            else
                Console.WriteLine("Biểu thức không hợp lệ");
        }
    }
}
kết quả
text
Chọn: 13

Nhập biểu thức trung tố: (3 + 5) * [2 - 4]
Biểu thức hợp lệ

Chọn: 13

Nhập biểu thức trung tố: 3 + * 5
Biểu thức không hợp lệ

Chọn: 13

Nhập biểu thức trung tố: (3 + 5
Biểu thức không hợp lệ
bài11 (cuối sách)
csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH03
{
    class Bai11
    {
        // Độ ưu tiên của toán tử
        static int Pri(string op)
        {
            if (op == "*" || op == "/") return 2;
            if (op == "+" || op == "-") return 1;
            return 0; // dấu "("
        }

        // Tách biểu thức thành các phần tử (số nhiều chữ số được giữ nguyên)
        static List<string> TachPhanTu(string e)
        {
            List<string> ds = new List<string>();
            string so = "";
            foreach (char c in e)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    so += c;
                }
                else
                {
                    if (so != "") { ds.Add(so); so = ""; }
                    if (c != ' ') ds.Add(c.ToString());
                }
            }
            if (so != "") ds.Add(so);
            return ds;
        }

        // Chuyển trung tố E sang hậu tố E1
        static string HauTo(string E)
        {
            Stack<string> St = new Stack<string>();      // lưu các phép toán
            StringBuilder E1 = new StringBuilder();      // lưu biểu thức hậu tố
            List<string> enumer = TachPhanTu(E);

            foreach (string s in enumer)
            {
                if (s == "(")
                {
                    St.Push(s);                          // 9.1 ngoặc mở -> đẩy vào Stack
                }
                else if (s == ")")
                {
                    while (St.Peek() != "(")             // 9.2 ngoặc đóng -> lấy ra đến khi gặp (
                        E1.Append(St.Pop() + " ");
                    St.Pop();                            // loại bỏ ( ra khỏi Stack
                }
                else if (Bai9.IsOperand(s))
                {
                    E1.Append(s + " ");                  // 9.3 toán hạng -> viết sau E1
                }
                else
                {
                    // 9.4 toán tử
                    while (St.Count > 0 && Pri(St.Peek()) >= Pri(s))
                        E1.Append(St.Pop() + " ");
                    St.Push(s);
                }
            }

            while (St.Count > 0)                         // lấy hết phần tử còn lại
                E1.Append(St.Pop() + " ");

            return E1.ToString().Trim();
        }

        public static void Run()
        {
            Console.Write("Nhập biểu thức trung tố (ví dụ: 3 + 5 * (2 - 4)): ");
            string e = Console.ReadLine() ?? "";

            // 1. Kiểm tra tính hợp lệ
            if (!Bai10.IsValidInfix(e))
            {
                Console.WriteLine("Biểu thức không hợp lệ!");
                return;
            }

            // Đề bài chỉ dùng ngoặc (), nên đổi [ ] { } thành ( ) để xử lý chung
            e = e.Replace('[', '(').Replace('{', '(').Replace(']', ')').Replace('}', ')');

            // 2. Chuyển sang hậu tố
            string hauTo = HauTo(e);
            Console.WriteLine("Biểu thức hậu tố: " + hauTo);

            // 3. Tính giá trị biểu thức hậu tố
            try
            {
                double kq = Bai9.TinhHauTo(hauTo);
                Console.WriteLine("Kết quả = " + kq);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
kết quả
text
Chọn: 14

Nhập biểu thức trung tố (ví dụ: 3 + 5 * (2 - 4)): 3 + 5 * (2 - 4)
Biểu thức hậu tố: 3 5 2 4 - * +
Kết quả = -7

Chọn: 14

Nhập biểu thức trung tố (ví dụ: 3 + 5 * (2 - 4)): {[(1 + 2) * 3] - 4} / 5
Biểu thức hậu tố: 1 2 + 3 * 4 - 5 /
Kết quả = 1

Chọn: 14

Nhập biểu thức trung tố (ví dụ: 3 + 5 * (2 - 4)): 3 + * 5
Biểu thức không hợp lệ!