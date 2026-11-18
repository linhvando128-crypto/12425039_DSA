using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Bai16
    {
        public static void Run()
        {
            Stack<string> backStack = new Stack<string>();
            Stack<string> forwardStack = new Stack<string>();
            string current = "google.com";
            Console.WriteLine($"TRUY CẬP: {current}");

            backStack.Push(current);
            current = "github.com";
            Console.WriteLine($"TRUY CẬP: {current}");

            backStack.Push(current);
            current = "stackoverflow.com";
            Console.WriteLine($"TRUY CẬP: {current}");

            forwardStack.Clear();
            backStack.Push(current);
            current = backStack.Pop();
            Console.WriteLine($"BACK ĐẾN: {current}");

            forwardStack.Push(current);
            current = forwardStack.Pop();
            Console.WriteLine($"FORWARD ĐẾN: {current}");
        }
    }
}
