﻿using System;

namespace BaiTap11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ga1=10,
                 Ga2=30,
                   Ga3=25,
                     Ga4=36;
            int sum = Ga1 + Ga2 + Ga3 + Ga4;
            double QuiDoi = (double)sum / 12;
            int QuiDoi1 = sum / 12;//phần nguyên
            QuiDoi = QuiDoi - QuiDoi1;//phần dư thập phân 0.xxxx
            QuiDoi = QuiDoi * 12;//ra số trứng dạng thập phân
            int QuiDoi2 = (int)QuiDoi;

            Console.WriteLine("so trung ga 1 la :{0}", Ga1);
            Console.WriteLine("so trung ga 2 la :{0}", Ga2);
            Console.WriteLine("so trung ga 3 la :{0}", Ga3);
            Console.WriteLine("so trung ga 4 la :{0}", Ga4);
            Console.Write("\n\n");
            Console.Write("toan bo so trung la {0} la {1} ta {2} trung", sum, QuiDoi1, QuiDoi2);
            Console.ReadKey();
        }
    }
}
