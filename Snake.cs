﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Snakecode
{
    public class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            plist = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.move(i, direction);
                plist.Add(p);
            }
        }

        internal void Move()
        {
            Point tail =plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);
            
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);
            nextPoint.move (1, direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = plist.Last();
            for (int i = 0; i < plist.Count - 2; i++)
            {
                if (head.IsHit(plist[i]))
                    return true;
            }
            return false;
        }

        public void MandlKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                plist.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool BadEat(Point badFood)
        {
            Point head = GetNextPoint();
            if (head.IsHit(badFood))
            {
                badFood.sym = head.sym;
                plist.Add(badFood);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}