using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

delegate void ArrMod(int[] a);
namespace C__HW5_2
{
    internal class Program
    {
        static long[] defaultArr = { 20, 45, 22, 39, 27 };
        public static void AddArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                defaultArr[i] += arr[i];
            }
        }
        public static void PowerArr(int x)
        {
            for (int i = 0; i < defaultArr.Length; i++)
            {
                defaultArr[i] = Convert.ToInt64(Math.Pow(defaultArr[i], x));
            }
        }
        public static void SortArr()
        {
            for (int a = 0; a < defaultArr.Length; a++)
            {
                for (int b = a + 1; b < defaultArr.Length; b++)
                {
                    if (defaultArr[a] > defaultArr[b])
                    {
                        long tmp = defaultArr[a];
                        defaultArr[a] = defaultArr[b];
                        defaultArr[b] = tmp;
                    }
                }
            }
        }
        public static void PrintArr()
        {
            Console.WriteLine();
            for (int i = 0; i < defaultArr.Length; i++)
            {
                Console.Write(defaultArr[i] + "\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ArrMod fc1 = new ArrMod(AddArr);
            int[] randomArr = new int[defaultArr.Length];
            //How to generate random array
            var rn = new Random();
            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = rn.Next(1000);
            }

            fc1(randomArr);

            Console.Write("輸入次方數:");
            int times = int.Parse(Console.ReadLine());
            PowerArr(times);

            SortArr();
            PrintArr();
            Console.Read();
        }
    }
}

