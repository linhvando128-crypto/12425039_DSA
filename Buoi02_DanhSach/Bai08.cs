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
