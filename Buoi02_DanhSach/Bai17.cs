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
