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