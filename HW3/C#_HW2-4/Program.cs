using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] fig = new string[10, 6] { { "紐約", "73400","865600","180300","446800","" },
                                                { "東京", "840000","850200","911600","705800",""},
                                                { "北京", "711700","219900","431000","806300",""},
                                                { "里約", "745300","347500","522900","944900",""},
                                                { "日內瓦\0", "520400","756100","749200","673100",""},
                                                { "台北", "300300","455900","727800","980600",""},
                                                { "首爾", "430000","374600","161100","686300",""},
                                                { "巴黎", "311500","111500","226200","685700",""},
                                                { "倫敦", "601500","305300","242100","475300",""},
                                                { "柏林", "650100","551500","369200","774200",""} };

            int[] total = new int[5];
            int sum = 0;
            int col = fig.GetLength(0);

            for (int i = 0; i < col; i++)
            {
                int tmp = 0;
                for (int j = 1; j < 5; j++)
                {
                    tmp += int.Parse(fig[i,j]);
                    total[j - 1] += int.Parse(fig[i, j]);
                }
                fig[i, 5] = tmp.ToString();
                sum += tmp;
            }
            total[4] = sum;

            //sort
            for(int i=0; i<10; i++)
            {
                for(int j=i+1; j<10; j++)
                {
                    if (int.Parse(fig[i, 5]) > int.Parse(fig[j, 5]))
                    {
                        for(int a=0; a<=5; a++)
                        {
                            string swap = fig[i, a];
                            fig[i,a] = fig[j, a];
                            fig[j,a] = swap;
                        }
                    }
                }
            }


            //output
            Console.WriteLine("                           第一季              第二季              第三季              第四季         各地區總營業額");
            for (int i = 0; i < col; i++)
            {
                Console.Write("{0,-12}",fig[i, 0]);
                for (int j = 1; j < fig.Length/col; j++)
                    Console.Write("{0,20:N0}", int.Parse(fig[i, j]));
                Console.WriteLine();
            }
            Console.Write("{0,-8}","各季總營業額 ");
            for(int i = 0;i<total.Length;i++)
                Console.Write("{0,20:N0}", total[i]);
            Console.WriteLine();
            Console.Read();
        }
    }
}
