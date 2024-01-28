using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CE_4
{
    delegate void DangerEvent(int vSpeed);	// 宣告delegate型別

    class Car
    {
        private int _speed;

        public event DangerEvent DangerFast;
        public event DangerEvent DangerSlow;          // 宣告事件

        public int Speed        // 定義 Speed 屬性
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > 200)
                {
                    if (DangerFast != null) DangerFast(value);  // 啟動事件
                }
                else if (value > 0 && value < 50)
                {
                    if (DangerSlow != null) DangerSlow(value);
                }
                _speed = value;
            }
        }
    }

    class Program
    {
        static void TooFast(int vSpeed)
        {
            Console.WriteLine($"\n 你的目前的速度是 {vSpeed},超過 200，請減速 !!!");
        }
        static void TooSlow(int vSpeed)
        {
            Console.WriteLine($"\n 你的目前的速度是 {vSpeed},小於 50，請加速 !!!");
        }

        static void Main(string[] args)
        {
            Car Benz = new Car();
            // 指定 DangerFast 事件由 TooFast 方法來處理
            Benz.DangerFast += new DangerEvent(TooFast);
            // 指定 DangerSlow 事件由 TooSlow 方法來處理
            Benz.DangerSlow += new DangerEvent(TooSlow);
            Benz.Speed = 3;
            Console.Read();
        }
    }
}
