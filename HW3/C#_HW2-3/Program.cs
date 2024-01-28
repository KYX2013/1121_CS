using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace C__HW2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*string OCT="";
            int[] input = new int[0];
            Console.WriteLine("輸入數字:");
            while ((OCT = Console.ReadLine()) != "")
            {
                if (input.Length == 0)
                {
                    var lst = new List<int>();
                    lst.Add(int.Parse(OCT));
                    input = lst.ToArray();
                }
                else
                {
                    var lst = input.ToList();
                    lst.Add(int.Parse(OCT));
                    input = lst.ToArray();
                }
            }*/

            const int leng = 16;
            int[] input = new int[5] { 47, 919, 1143, 2158, 3046 };

            //Output
            //Console.WriteLine("輸出:\n");
            Console.WriteLine("                   二進位             十六進位");
            for (int i = 0; i < input.Length; i++) {
                string BIN = "", HEX = "";

                //ToBin
                BIN = Convert.ToString(input[i],2);
                while(BIN.Length < leng)
                    BIN = "0" + BIN;

                //ToHex
                HEX = Convert.ToString(input[i],16);
                while(HEX.Length < leng)
                    HEX = "0" + HEX;

                Console.WriteLine("{0,10}{1,20}{2,20}", input[i], BIN, HEX);
            }
            Console.Read();
        }
    }
}
