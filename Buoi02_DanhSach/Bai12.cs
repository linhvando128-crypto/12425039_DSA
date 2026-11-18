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
