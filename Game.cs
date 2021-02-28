using System;
using System.Threading;

namespace Snakecode
{
    public class Game
    {
        public Game()
        {
            Console.SetWindowSize(90, 25);
            Walls walls = new Walls(80, 25);
            walls.Draw();
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80, 25, '#', '@', '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            Params settings = new Params();
            Sounds sound = new Sounds(settings.GetResourcesFolder());
            sound.Play();
            Counter count = new Counter(0);
            count.ScoreWrite();
            Sounds soundEat = new Sounds(settings.GetResourcesFolder());
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    count.ScoreUp();
                    count.ScoreWrite();
                    soundEat.PlayEat();
                }

             
                snake.Move();

                new Speed(count.GetScore());

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.MandlKey(key.Key);
                }
                
            }
            new WriteGameOver();
            sound.Stop();
            Thread.Sleep(1500);
            new Leader_Board(count.GetScore(), settings.GetResourcesFolder()); // Запись имени игрока + счёта
            ShowBestScores best = new ShowBestScores();
            best.ReadFile(); //Показ лучших игроков
        }
        
    }
}