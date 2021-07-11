using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {


            var walls = new Walls();
            walls.Draw();


            var p = new Point(4, 5, '*');
            var s = new Snake(p, 4, Direction.RIGHT);
            s.Draw();

            FoodCreator fc = new FoodCreator(120, 30, '%');
            Point food = fc.CreateFood();
            food.Draw();

            while (true)
            {
                if(walls.IsHit(s) || s.IsHitTail())
                {
                    break;
                }

                if (s.Eat(food))
                {
                    food = fc.CreateFood();
                    food.Draw();
                }
                else
                    s.Move();

                Thread.Sleep(50);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    s.HandleKey(key.Key);
                }

            }

        }
    }
}
