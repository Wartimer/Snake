﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        internal Direction direction;

        public Snake(Point tail, int length, Direction dir)
        {
            direction = dir;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                var p = new Point(tail);
                p.Move(i, dir);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
    }
}
