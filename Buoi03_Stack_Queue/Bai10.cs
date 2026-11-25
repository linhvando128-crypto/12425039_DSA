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