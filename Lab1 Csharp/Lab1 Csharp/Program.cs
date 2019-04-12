using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Квадрат_разности
{

    class Program
    {

        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            double rez = -1;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            rez = kv(x, y);
            Console.WriteLine(rez);
        }

        public static double kv(int x, int y)
        {
            return Math.Pow((x - y), 2);
        }

    }
}
