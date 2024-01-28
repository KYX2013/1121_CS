using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.Write("輸入X:");
            x = int.Parse(Console.ReadLine());

            for (int i = x-1; i > 0 ; i--)
                x += i;

            string binary = "";
            while(x > 0) {
                if (x % 2 == 0)
                    binary = '0' + binary;
                else
                    binary = '1' + binary;

                x >>= 1;
            }
            Console.Write(binary);
            Console.Read();
        }
    }
}
