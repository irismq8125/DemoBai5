using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrays = { 51, 12, 33, 14, 45, 67, 1, 10, 4, 2, 5 }; // 11 phan tu
            string[] arraysStr = { "A", "T", "k", "P"}; // 4 phan tu
            foreach (var item in arraysStr)
            {
                Console.Write("\t{0}", item);
            }
            Console.WriteLine();
            Console.WriteLine("Truoc khi Sort: {0}", arraysStr[3]);

            Console.WriteLine("Truoc khi Reverse");
            Array.Sort(arraysStr);
            foreach (var item in arraysStr)
            {
                Console.Write("\t{0}", item);
            }
            Console.WriteLine();
            Console.WriteLine();

            Array.Reverse(arraysStr);
            foreach (var item in arraysStr)
            {
                Console.Write("\t{0}", item);
            }
            Console.WriteLine("Sau khi Reverse");
            //for (int i = arrays.Length - 1; i >= 0; i--)
            //{
            //    Console.Write("\t{0}", arrays[i]);
            //}
            Console.WriteLine();
            //Console.WriteLine("Sau khi Sort: {0}", arrays[3]);
            Console.WriteLine("Phan tu dau tien: {0}", arrays[0]);


            tinh tong mang voi cac so chia het cho 2
            Console.WriteLine("Do dai cua mang Arrays la: {0}", arrays.Length);
            int s = 0;
            int k = 0;
            int t = 0;
            int p = 0;
            //s = s + arrays[0];
            //s = s + arrays[1];
            //s = s + arrays[2];
            //s = s + arrays[3];
            //s = s + arrays[4];
            //s = s + arrays[5];
            //s = s + arrays[6];
            //s = s + arrays[7];
            //s = s + arrays[8];
            //s = s + arrays[9];
            //s = s + arrays[10];
            //Console.WriteLine("Tong mang la: {0}", s);

            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] % 2 == 0)
                {
                    k = k + arrays[i];
                }
            }
            Console.WriteLine("Tong mang voi for la: {0}", k);

            foreach (var item in arrays) //item == arrays[i]
            {
                if (item % 2 == 0)
                {
                    t = t + item;
                }
            }
            Console.WriteLine("Tong mang voi foreach la: {0}", t);

            p = arrays.Where(o => o % 2 == 0).Sum();
            Console.WriteLine("Tong mang voi Sum la: {0}", p);

            ////tim so lon nhat trong mang
            //int max = arrays.Max();
            //Console.WriteLine("So lon nhat la: {0}", max);

            ////tim so nho nhat trong mang
            //int min = arrays.Min();
            //Console.WriteLine("So lon nhat la: {0}", min);

            ////tim so trung binh trong mang
            //double a = arrays.Average();
            //Console.WriteLine("Trung binh la: {0}", a);
            Console.ReadKey();
        }
    }
}
