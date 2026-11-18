using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Node15
    {
        public int data;
        public Node15? next;
        public Node15(int val)
        {
            data = val;
            next = null;
        }
    }

    class Bai15
    {
        public static bool CoChuTrinh(Node15? head)
        {
            Node15? slow = head;
            Node15? fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow?.next;
                fast = fast.next.next;
                if (slow == fast) return true;
            }
            return false;
        }

        public static void Run()
        {
            Node15 head = new Node15(1);
            head.next = new Node15(2);
            head.next.next = new Node15(3);
            head.next.next.next = head.next;

            Console.WriteLine($"DANH SÁCH CÓ CHỨA CHU TRÌNH: {CoChuTrinh(head)}");
        }
    }
}
