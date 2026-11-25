using System;
using System.Text;

namespace BTTH03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n============ BUỔI 03: NGĂN XẾP VÀ HÀNG ĐỢI ============");
                Console.WriteLine("1.  Bài 1  - Kiểm tra tính đúng đắn của biểu thức toán học");
                Console.WriteLine("2.  Bài 2  - Mô phỏng lịch sử trình duyệt web");
                Console.WriteLine("3.  Bài 3  - Mô phỏng quá trình thực thi chương trình(Function Call Stack)");
                Console.WriteLine("4.  Bài 4  - Mô phỏng hệ thống in");
                Console.WriteLine("5.  Bài 5  - Mô phỏng đường truyền dữ liệu");
                Console.WriteLine("6.  Bài 6  - Mô phỏng quản lý hàng đợi tại Trung tâm Dịch vụ Khách hàng hoặc ngân hàng");
                Console.WriteLine("--- Bài tập cuối sách ---");
                Console.WriteLine("7.  Bài 4  - Mô phỏng lịch sử trình duyệt web");
                Console.WriteLine("8.  Bài 5  - Kiểm tra chuỗi ngoặc ( ) đúng");
                Console.WriteLine("9.  Bài 6  - Mô phỏng hệ thống in");
                Console.WriteLine("10. Bài 7  - Mô phỏng đường truyền dữ liệu");
                Console.WriteLine("11. Bài 8  - Mô phỏng dịch vụ khách hàng");
                Console.WriteLine("12. Bài 9  - Tính giá trị biểu thức hậu tố");
                Console.WriteLine("13. Bài 10 - Kiểm tra tính hợp lệ của biểu thức trung tố");
                Console.WriteLine("14. Bài 11 - Tính giá trị biểu thức trung tố");
                Console.WriteLine("0.  Thoát");
                Console.Write("Chọn: ");

                string chon = (Console.ReadLine() ?? "").Trim();

                switch (chon)
                {
                    case "1": Bai01.Run(); break;
                    case "2": Bai02.Run(); break;
                    case "3": Bai03.Run(); break;
                    case "4": Bai04.Run(); break;
                    case "5": Bai05.Run(); break;
                    case "6": Bai06.Run(); break;
                    case "7": Bai4.Run(); break;
                    case "8": Bai5.Run(); break;
                    case "9": Bai6.Run(); break;
                    case "10": Bai7.Run(); break;
                    case "11": Bai8.Run(); break;
                    case "12": Bai9.Run(); break;
                    case "13": Bai10.Run(); break;
                    case "14": Bai11.Run(); break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}