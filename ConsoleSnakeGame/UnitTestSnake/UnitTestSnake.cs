using ConsoleSnakeGame;
using GameGeneric;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestSnake
{
    [TestClass]
    public class UnitTestSnake
    {
        SnakeInfo snakeInfo = new SnakeInfo
        {
            SnakeHead = new Point(50, 10),
            ColorHead = new ColorChar(
                    'O',
                    ConsoleColor.Blue,
                    ConsoleColor.Cyan),
            ColorTail = new ColorChar(
                    'x',
                    ConsoleColor.DarkGreen,
                    ConsoleColor.Red),
            UpdatePeriodSec = 0.1f
        };

        [TestMethod]
        public void TestSnakeSelfCollisionFalse()
        {
            Snake snake = new Snake(snakeInfo);
            snake.AddToTail(new Point { x = snake.Head.x, y = snake.Head.y + 1});
            snake.AddToTail(new Point { x = snake.Head.x, y = snake.Head.y + 2 });
            Assert.IsFalse(snake.IsCollisionWithHead());
        }


        [TestMethod]
        public void TestSnakeSelfCollisionTrue()
        {
            Snake snake = new Snake(snakeInfo);
            snake.AddToTail(new Point { x = snake.Head.x, y = snake.Head.y + 1 });
            snake.AddToTail(new Point { x = snake.Head.x, y = snake.Head.y + 2 });
            snake.Head.y = snake.Head.y + 1;
            Assert.IsTrue(snake.IsCollisionWithHead());
        }


    }
}