using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    public class Block
    {
        public int width = 25;
        public int height = 25;

        public int x;
        public int y; 
        public int hp;
        public int colour;
        public int type;

        Image image;

        //block types as follows: 0 - powerup block, 1-5 - 1-5 hp
        //block colours/images are the same order

        public static Random rand = new Random();

        public Block(int _x, int _y, int _hp, int _colour, int _type)
        {
            x = _x;
            y = _y;
            hp = _hp;
            colour = _colour;
            type = _type;
        }
    }
}
