using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入欲查詢之絕對路徑:");
            string findPath = Console.ReadLine();

            while (!Directory.Exists(findPath))
            {
                Console.WriteLine("路徑錯誤，請重新輸入");
                Console.Write("請輸入欲查詢之絕對路徑:");
                findPath = Console.ReadLine();
            }

            Console.Write("請輸入欲查詢之檔案名稱:");
            string findFile = Console.ReadLine();
            string[] files = Directory.GetFiles(findPath);
            string[] dirs = Directory.GetDirectories(findPath);
            if (File.Exists(findPath + "\\" + findFile))
            {
                Console.Write($"{findFile}");
            }
            else if (files.Length == 0 && dirs.Length == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                for (int i = 0; i < dirs.Length; i++)
                {
                    Console.WriteLine($"{dirs[i]}");
                }
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine($"{files[i]}");
                }
            }

            Console.Read();
        }
    }
}
