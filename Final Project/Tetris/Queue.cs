using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Queue
    {
        private readonly Block[] blocks = new Block[] {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
        };

        private readonly Random random = new Random();
        public Block Next_1 {  get; private set; }
        public Block Next_2 {  get; private set; }
        public Block Next_3 {  get; private set; }
        public Queue() {
            Next_1 = RandomBlock();
            Next_2 = RandomBlock();
            Next_3 = RandomBlock();
        }
        private Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }
        public Block Update()
        {
            Block block = Next_1;
            Next_1 = Next_2;
            Next_2 = Next_3;

            do
            {
                Next_3 = RandomBlock();
            }
            while(Next_2.ID == Next_3.ID);

            return block;
        }
    }
}
