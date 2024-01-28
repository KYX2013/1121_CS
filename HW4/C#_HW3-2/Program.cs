using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace C__HW3_2
{
    internal class Program
    {
        struct polygon
        {
            public int graph;
            public double area;
            public double peri;
            public double val;
        }

        static void swap(ref polygon polygon1, ref polygon polygon2)
        {
            int tmpGraph = polygon1.graph;
            polygon1.graph = polygon2.graph;
            polygon2.graph = tmpGraph;

            double tmpArea = polygon1.area;
            polygon1.area = polygon2.area;
            polygon2.area = tmpArea;

            double tmpPeri = polygon1.peri;
            polygon1.peri = polygon2.peri;
            polygon2.peri = tmpPeri;

            double tmpVal = polygon1.val;
            polygon1.val = polygon2.val;
            polygon2.val = tmpVal;
        }

        static bool larger(polygon polygon1, polygon polygon2)
        {
            if (polygon1.val > polygon2.val)
            {
                return true;
            }
            else if (polygon1.val == polygon2.val && polygon1.graph > polygon2.graph)
            { 
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            //Console.Write("輸入:\n\n圖形數:");
            int num;
            num = int.Parse(Console.ReadLine());
            polygon[] poly = new polygon[num];

            //initial
            for (int i = 0; i < num; i++)
            {
                //Console.WriteLine("圖形名稱:");
                poly[i] = new polygon();
                //Console.WriteLine("圖形輸入需求:");
                switch (Console.ReadLine())
                {
                    case "Square":
                        //Console.Write("邊長:");
                        int a = int.Parse(Console.ReadLine());
                        poly[i].area = a*a;
                        poly[i].peri = 4*a;
                        poly[i].graph = 1;
                        break;
                    case "Rectangle":
                        //Console.Write("長:");
                        int b1 = int.Parse(Console.ReadLine());
                        //Console.Write("寬:");
                        int b2 = int.Parse(Console.ReadLine());
                        poly[i].area = b1 * b2;
                        poly[i].peri = 2*(b1 + b2);
                        poly[i].graph = 2;
                        break;
                    case "Triangle":
                        //Console.Write("邊長:");
                        int c1 = int.Parse(Console.ReadLine());
                        //Console.Write("高:");
                        int c2 = int.Parse(Console.ReadLine());
                        poly[i].area = c1 * c2;
                        poly[i].peri = 3 * c1;
                        poly[i].graph = 3;
                        break;
                    case "Circle":
                        //Console.Write("半徑:");
                        int d = int.Parse(Console.ReadLine());
                        poly[i].area = 3.14*d*d;
                        poly[i].peri = 2*d*3.14;
                        poly[i].graph = 4;
                        break;
                }

                poly[i].val = Math.Pow(poly[i].area,(1/3)) + Math.Sqrt(poly[i].peri);
            }

            //sort
            for (int i = 0; i < poly.Length; i++)
            {
                for (int j = i+1; j < poly.Length; j++)
                {
                    if (larger(poly[i], poly[j]))
                    {
                        swap(ref poly[i], ref poly[j]);
                    }
                }
            }

            //output
            for (int i = 0; i < poly.Length; i++)
            {
                Console.WriteLine("({0}, {1})", poly[i].peri, poly[i].area);
            }

            Console.Read();
        }
    }
}
