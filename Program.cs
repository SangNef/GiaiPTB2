using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Double A, B, C, x1, x2;
            Nhapso(out A, 1);
            Nhapso(out B, 2);
            Nhapso(out C, 3);

            int result = GiaiPTB2(A, B, C, out x1, out x2);

            if (result == 0 )
            {
                Console.WriteLine("Phương trình vô nghiệm");
            } else if (result == 1)
            {
                Console.WriteLine($"Phương trình có nghiệm kép: x = {x1}");
            } else
            {
                Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
            }
            Console.ReadKey();
        }
        static void Nhapso(out double num, int index)
        {
            Console.Write($"Nhập số thực thứ {index}: ");
            double.TryParse(Console.ReadLine(), out num);
        }
        static int GiaiPTB2(double A, double B, double C, out double x1, out double x2)
        {
            double delta = B * B - 4 * A * C;
            if (delta < 0)
            {
                //x1 = x2 = 0;
                return 0;
            } else if (delta == 0)
            {
                x1 = x2 = -B / (2 * A);
                return 1;
            }
            else
            {
                x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                x2 = (-B - Math.Sqrt(delta)) / (2 * A);
                return 2;
            }
        }
    }
}
