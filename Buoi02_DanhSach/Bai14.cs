using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Node14
    {
        public int data;
        public Node14? next;
        public Node14(int val)
        {
            data = val;
            next = null;
        }
    }

    class Bai14
    {
        public static Node14? GopHaiDanhSach(Node14? l1, Node14? l2)
        {
            Node14 dummy = new Node14(0);
            Node14 tail = dummy;
            while (l1 != null && l2 != null)
            {
                if (l1.data <= l2.data)
                {
                    tail.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    tail.next = l2;
                    l2 = l2.next;
                }
                tail = tail.next;
            }
            if (l1 != null) tail.next = l1;
            if (l2 != null) tail.next = l2;
            return dummy.next;
        }

        public static void InDanhSach(Node14? head)
        {
            Node14? p = head;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public static void Run()
        {
            Node14 l1 = new Node14(1);
            l1.next = new Node14(3);
            l1.next.next = new Node14(5);

            Node14 l2 = new Node14(2);
            l2.next = new Node14(4);
            l2.next.next = new Node14(6);

            Console.Write("DANH SÁCH 1: ");
            InDanhSach(l1);
            Console.Write("DANH SÁCH 2: ");
            InDanhSach(l2);

            Node14? merged = GopHaiDanhSach(l1, l2);
            Console.Write("DANH SÁCH SAU KHI GỘP: ");
            InDanhSach(merged);
        }
    }
}
