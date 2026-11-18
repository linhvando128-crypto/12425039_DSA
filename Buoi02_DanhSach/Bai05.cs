using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH02
{
    class Node5
    {
        public int data;
        public Node5? next;
        public Node5(int val)
        {
            data = val;
            next = null;
        }
    }

    class LinkedList5
    {
        public Node5? l = null;

        public void ThemCuoi(int val)
        {
            Node5 newNode = new Node5(val);
            if (l == null)
            {
                l = newNode;
            }
            else
            {
                Node5 p = l;
                while (p.next != null) p = p.next;
                p.next = newNode;
            }
        }

        public int TimMax()
        {
            if (l == null) return int.MinValue;
            int max = int.MinValue;
            Node5? p = l;
            while (p != null)
            {
                if (p.data > max) max = p.data;
                p = p.next;
            }
            return max;
        }

        public int TinhTong()
        {
            int t = 0;
            Node5? p = l;
            while (p != null)
            {
                t += p.data;
                p = p.next;
            }
            return t;
        }

        bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public int DemSoNguyenTo()
        {
            int dem = 0;
            Node5? p = l;
            while (p != null)
            {
                if (LaSoNguyenTo(p.data)) dem++;
                p = p.next;
            }
            return dem;
        }

        public void DemAmDuongKhong(out int am, out int duong, out int khong)
        {
            am = 0;
            duong = 0;
            khong = 0;
            Node5? p = l;
            while (p != null)
            {
                if (p.data < 0) am++;
                else if (p.data > 0) duong++;
                else khong++;
                p = p.next;
            }
        }

        public int DemSoBangX(int x)
        {
            int dem = 0;
            Node5? p = l;
            while (p != null)
            {
                if (p.data == x) dem++;
                p = p.next;
            }
            return dem;
        }

        public int TimPhanTuDuongNhoNhat()
        {
            int min = int.MaxValue;
            Node5? p = l;
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

        public void InDanhSach()
        {
            Node5? p = l;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }

    class Bai05
    {
        public static void Run()
        {
            LinkedList5 list = new LinkedList5();
            list.ThemCuoi(-3);
            list.ThemCuoi(5);
            list.ThemCuoi(0);
            list.ThemCuoi(7);
            list.ThemCuoi(5);

            Console.Write("DANH SÁCH L: ");
            list.InDanhSach();
            Console.WriteLine($"PHẦN TỬ LỚN NHẤT: {list.TimMax()}");
            Console.WriteLine($"TỔNG CÁC PHẦN TỬ: {list.TinhTong()}");
            Console.WriteLine($"SỐ LƯỢNG SỐ NGUYÊN TỐ: {list.DemSoNguyenTo()}");
            list.DemAmDuongKhong(out int am, out int duong, out int khong);
            Console.WriteLine($"SỐ ÂM: {am}, SỐ DƯƠNG: {duong}, SỐ 0: {khong}");
            Console.WriteLine($"SỐ PHẦN TỬ BẰNG 5: {list.DemSoBangX(5)}");
            Console.WriteLine($"PHẦN TỬ DƯƠNG NHỎ NHẤT: {list.TimPhanTuDuongNhoNhat()}");
        }
    }
}
