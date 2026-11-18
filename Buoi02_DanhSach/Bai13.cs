using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Node13
    {
        public int data;
        public Node13? next;
        public Node13(int val)
        {
            data = val;
            next = null;
        }
    }

    class LinkedList13
    {
        public Node13? pHead = null;

        public void ThemCuoi(int val)
        {
            Node13 newNode = new Node13(val);
            if (pHead == null) pHead = newNode;
            else
            {
                Node13 p = pHead;
                while (p.next != null) p = p.next;
                p.next = newNode;
            }
        }

        public void DaoNguoc()
        {
            Node13? prev = null;
            Node13? current = pHead;
            Node13? next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            pHead = prev;
        }

        public void InDanhSach()
        {
            Node13? p = pHead;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }

    class Bai13
    {
        public static void Run()
        {
            LinkedList13 list = new LinkedList13();
            list.ThemCuoi(1);
            list.ThemCuoi(2);
            list.ThemCuoi(3);
            list.ThemCuoi(4);

            Console.Write("DANH SÁCH BAN ĐẦU: ");
            list.InDanhSach();
            list.DaoNguoc();
            Console.Write("DANH SÁCH SAU KHI ĐẢO NGƯỢC: ");
            list.InDanhSach();
        }
    }
}
