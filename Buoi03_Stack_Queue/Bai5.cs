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