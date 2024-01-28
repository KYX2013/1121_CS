using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[8, 5];
            int n;
            bool conflict = false;
            Console.WriteLine("輸入:");
            Console.Write("課程數:");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("課程編號:");
                int course = int.Parse(Console.ReadLine());
                Console.Write("一周上幾次課:");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("課程開始時間:");

                for(int j = 0; j < count; j++)
                {
                    string start = Console.ReadLine();

                    int x = (int)start[2] - 49;
                    int y = (int)start[0] - 49;
                    if (table[x, y] == 0)
                    {
                        table[x, y] = course;
                        table[x+1, y] = course;
                        table[x+2, y] = course;
                    }
                    else
                    {
                        conflict = true;
                    }
                }
            }

            Console.WriteLine("\n輸出:\n"+((conflict)?"Yes":"No"));
            Console.Read();
        }
    }
}
