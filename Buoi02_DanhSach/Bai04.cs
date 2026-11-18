using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Node4
    {
        public int data;
        public Node4? next;
        public Node4(int val)
        {
            data = val;
            next = null;
        }
    }

    class LinkedList4
    {
        public Node4? pHead = null;

        public void ThemCuoi(int val)
        {
            Node4 newNode = new Node4(val);
            if (pHead == null)
            {
                pHead = newNode;
            }
            else
            {
                Node4 p = pHead;
                while (p.next != null) p = p.next;
                p.next = newNode;
            }
        }

        public int DemSoBangX(int x)
        {
            int d = 0;
            Node4? p = pHead;
            while (p != null)
            {
                if (p.data == x) d++;
                p = p.next;
            }
            return d;
        }

        public int TimPhanTuDuongNhoNhat()
        {
            int min = int.MaxValue;
            Node4? p = pHead;
            while (p != null)
            {
                if (p.data > 0 && p.data < min)
                {
                    min = p.data;
                }
                p = p.next;
            }
            return min == int.MaxValue ? -1 : min;
        }

        public void XoaXDauTien(int x)
        {
            if (pHead == null) return;
            if (pHead.data == x)
            {
                pHead = pHead.next;
                return;
            }
            Node4 t = pHead;
            while (t.next != null && t.next.data != x)
            {
                t = t.next;
            }
            if (t.next != null)
            {
                t.next = t.next.next;
            }
        }

        public void InDanhSach()
        {
            Node4? p = pHead;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }

    class Bai04
    {
        public static void Run()
        {
            LinkedList4 list = new LinkedList4();
            list.ThemCuoi(5);
            list.ThemCuoi(2);
            list.ThemCuoi(8);
            list.ThemCuoi(2);

            Console.Write("DANH SÁCH BAN ĐẦU: ");
            list.InDanhSach();
            Console.WriteLine($"SỐ LƯỢNG SỐ BẰNG 2: {list.DemSoBangX(2)}");
            Console.WriteLine($"PHẦN TỬ DƯƠNG NHỎ NHẤT: {list.TimPhanTuDuongNhoNhat()}");
            list.XoaXDauTien(2);
            Console.Write("DANH SÁCH SAU KHI XÓA 2 ĐẦU TIÊN: ");
            list.InDanhSach();
        }
    }
}
