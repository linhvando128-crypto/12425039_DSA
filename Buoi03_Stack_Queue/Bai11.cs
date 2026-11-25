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