using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[5];
            Console.Write("輸入網內語音(秒)-整數:");
            input[0] = int.Parse(Console.ReadLine());
            Console.Write("輸入網外語音(秒)-整數:");
            input[1] = int.Parse(Console.ReadLine());
            Console.Write("市話(秒)-整數:");
            input[2] = int.Parse(Console.ReadLine());
            Console.Write("輸入網內簡訊數-整數:");
            input[3] = int.Parse(Console.ReadLine());
            Console.Write("輸入網外簡訊數-整數:");
            input[4] = int.Parse(Console.ReadLine());

            double[,] price = new double[,] { {0.08, 0.1393, 0.1349, 1.1287, 1.4803},
                                              {0.07, 0.1304, 0.1217, 1.1127, 1.2458},
                                              {0.06, 0.1087, 0.1018, 0.9572, 1.1243} };
            double[] cost = new double[] {183,383,983};

            bool output = false;
            for(int i = 0;i<cost.Length-1;i++)
            {
                double tmp = 0;
                for(int j = 0;j<input.Length;j++)
                {
                    tmp += input[j] * price[i,j];
                }
                Console.WriteLine(tmp);
                if(tmp <= cost[i+1])
                {
                    Console.WriteLine("最佳資費類型:{0}", cost[i]);
                    output = true;
                    break;
                }
            }

            if (!output)
                Console.WriteLine("最佳資費類型:{0}",983);

            Console.Read();
        }
    }
}
