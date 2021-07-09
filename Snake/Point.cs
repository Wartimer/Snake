﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        int x;
        int y;
        internal char sym;

        public Point() { }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }


        public void Move(int offset, Direction dir)
        {
            if (dir == Direction.RIGHT)
                x += offset;
            else if (dir == Direction.LEFT)
                x -= offset;
            else if (dir == Direction.UP)
                y -= offset;
            else if (dir == Direction.DOWN)
                y += offset;
        }

        public bool IsHit(Point p)
        {
            return p.x == x && p.y == y;
        }



        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
