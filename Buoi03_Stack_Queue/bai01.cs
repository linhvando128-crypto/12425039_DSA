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