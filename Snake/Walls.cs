using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallsList;
        public Walls()
        {
            Console.BufferHeight = 30;
            Console.BufferWidth = 120;
            Console.SetWindowSize(120, 30);

            wallsList = new List<Figure>();

            var upLine = new HorizontalLine(0, 118, 0, '+');
            var botLine = new HorizontalLine(0, 118, 28, '+');
            var leftLine = new VerticalLine(0, 28, 0, '+');
            var rightLine = new VerticalLine(0, 28, 118, '+');

            wallsList.Add(upLine);
            wallsList.Add(botLine);
            wallsList.Add(leftLine);
            wallsList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallsList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallsList)
                wall.Draw();
        }
    }
}
