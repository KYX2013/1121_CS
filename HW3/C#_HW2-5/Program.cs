using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] sudoku = new int[9, 9];
            bool result = true;

            //input
            Console.WriteLine("輸入:");
            for (int i = 0; i < 9; i++)
            {
                string row = Console.ReadLine();
                int idx = 0;
                for (int j = 0; j < row.Length; j++)
                {
                    int x = (int)row[j];
                    if (x>=48 && x<=57)
                    {
                        sudoku[i, idx] = (int)row[j]-48;
                        idx++;
                    }
                }
            }

            //check row && column
            for (int i = 0; i < 9 && result; i++)
            {
                for (int j = 0; j < 9 && result; j++)
                {
                    for(int k = j+1; k < 9 && result; k++)
                    {
                        if (sudoku[i, j] == sudoku[i, k] || sudoku[j, i] == sudoku[k,i])
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }
            //check square
            for (int i = 0; i < 9 && result; i++)
            {
                int x = (i/3) * 3;
                int y = (i%3) * 3;
                var lst = new List<int>();
                for (int j = 0; j < 9; j++)
                {
                    int a = (x + j / 3);
                    int b = (y + j % 3);
                    lst.Add(sudoku[a,b]);
                }

                for(int a = 0; a < 9; a++)
                {
                    for(int b = a+1 ; b < 9; b++)
                    {
                        if (lst[a] == lst[b])
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("\n輸出:");
            Console.WriteLine(result ? "\nYes" : "\nNo");
            Console.Read();
        }
    }
}
