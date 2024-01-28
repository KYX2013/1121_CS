using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CE5_1
{
    // 定義IMyComparable介面
    public interface IMyComparable
    {
        // 宣告IMyComparable介面的MyCompareTo方法
        int MyCompareTo(object obj);
    }

    class MyArray
    {
        public static void MySort(IMyComparable[] obj, int idx)
        {
            // 使用氣泡排序法來排序陣列
            if (idx > 0)
            {
                for (int i = 0; i <= obj.Length - 2; i++)
                {
                    for (int j = i + 1; j <= obj.Length - 1; j++)
                    {
                        // 如果 obj[j] 比 obj[i] 小的話就交換
                        if (obj[j].MyCompareTo(obj[i]) < 0)
                        {
                            // 進行兩數交換
                            IMyComparable tmp = obj[j];
                            obj[j] = obj[i];
                            obj[i] = tmp;
                        }
                    }
                }
            }
            else
            {
                for (int x = 0; x <= obj.Length - 2; x++)
                {
                    for (int y = x + 1; y <= obj.Length - 1; y++)
                    {
                        // 如果 obj[j] 比 obj[i] 小的話就交換
                        if (obj[y].MyCompareTo(obj[x]) > 0)
                        {
                            // 進行兩數交換
                            IMyComparable tmp = obj[y];
                            obj[y] = obj[x];
                            obj[x] = tmp;
                        }
                    }
                }
            }

        }

    }
    // 定義一個使用 IMyComparable 介面的類別 Vector
    class Vector : IMyComparable
    {
        public int X { get; set; }      // 定義X屬性
        public int Y { get; set; }      // 定義Y屬性

        public Vector()
        {
            X = 0;
            Y = 0;
        }

        public Vector(int vX, int vY)
        {
            X = vX;
            Y = vY;
        }

        public void Show()          // 用來顯示向量座標 (X,Y)
        {
            if (X < Y)
                Console.Write($"({X},{Y})  ");
            else
                Console.Write($"({Y},{X})  ");
        }

        // 實作出IMyComparable介面中的MyCompareTo方法
        int IMyComparable.MyCompareTo(object obj)
        {
            Vector v = (Vector)obj;
            return (X * X + Y * Y) - (v.X * v.X + v.Y * v.Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 建立一個內含五個向量的陣列物件vecArray       
            Vector[] ascArray = {  new Vector(20, 10), new Vector(50, 20),  new Vector(90, 40),
                                                     new Vector(10, 10),  new Vector(40, 30) };
            Vector[] dscArray = {  new Vector(20, 10), new Vector(50, 20),  new Vector(90, 40),
                                                     new Vector(10, 10),  new Vector(40, 30) }; ;
            Vector[] vecArray = {  new Vector(20, 10), new Vector(50, 20),  new Vector(90, 40),
                                                     new Vector(10, 10),  new Vector(40, 30) };


            Console.Write("\n 1. 排序前 : ");
            for (int i = 0; i <= vecArray.GetUpperBound(0); i++)
            {
                vecArray[i].Show();
            }
            Console.WriteLine();
            Console.WriteLine();

            MyArray.MySort(ascArray, 1);     //呼叫 System.Array 類別的 Sort 方法
            MyArray.MySort(dscArray, -1);     //呼叫 System.Array 類別的 Sort 方法


            for (int a = 0; a < vecArray.Length; a++)
            {
                if (a % 2 == 0)
                {
                    vecArray[a].X = dscArray[a / 2].X;
                    vecArray[a].Y = dscArray[a / 2].Y;
                }
                else
                {
                    vecArray[a].X = ascArray[a / 2].X;
                    vecArray[a].Y = ascArray[a / 2].Y;
                }
            }


            Console.Write("\n 2. 排序後 : ");
            for (int i = 0; i <= vecArray.GetUpperBound(0); i++)
            {
                vecArray[i].Show();
            }
            Console.Read();
        }
    }
}
