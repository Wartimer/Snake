using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {


            int wHeight = Console.BufferHeight;
            int wWidth = Console.BufferWidth;
            Console.BufferHeight = 30;
            Console.BufferWidth = 120;



            var upLine = new HorizontalLine(0, 118, 0, '+');
            var botLine = new HorizontalLine(0, 118, 28, '+');
            var leftLine = new VerticalLine(0, 28, 0, '+');
            var rightLine = new VerticalLine(0, 28, 119, '+');

            upLine.Draw();
            botLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            var p = new Point(4, 5, '*');

            var s = new Snake(p, 4, Direction.RIGHT);
            s.Draw();

        }



    }
}
