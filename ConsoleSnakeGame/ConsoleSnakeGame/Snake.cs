﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnakeGame
{
    class Snake
    {
        public Snake(
            Point snakeHead, 
            Point boardTopLeft, 
            Point boardBottomRight,
            char cHead, 
            char cTail)
        {
            body = new List<Point>();
            body.Add(snakeHead);
            this.boardTopLeft = boardTopLeft;
            this.boardBottomRight = boardBottomRight;
            this.cHead = cHead;
            this.cTail = cTail;
            Console.SetCursorPosition(snakeHead.x, snakeHead.y);
            Console.Write(cHead);
        }

        public void Grow()
        {

        }

        public void Write()
        {
            //todo nath handle also tail
            int sourceLeft = body[0].x, 
                sourceTop = body[0].y,
                sourceWidth = 1, 
                sourceHeight = 1;


            switch (newDirection)
            {
                case Direction.Down:
                    body[0].y++;
                    break;

                case Direction.Left:
                    body[0].x--;
                    break;

                case Direction.Right:
                    body[0].x++;
                    break;

                case Direction.Up:
                    body[0].y--;
                    break;

                default:
                    throw (new Exception($"Unexpected direction : {newDirection}"));
            }        

            Console.MoveBufferArea(
                sourceLeft, sourceTop,
                sourceWidth, sourceHeight,
                body[0].x, body[0].y);
        }

        public void Move(Direction direction)
        {
            newDirection = direction;
        }

        private List<Point> body;
        private Point boardTopLeft,boardBottomRight;
        private char cHead, cTail;
        Direction newDirection;
    }
}
