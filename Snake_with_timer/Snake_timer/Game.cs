using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace SnakeII
{
    [Serializable]
    public class Game
    {
        public Worm worm = null;
        public Wall wall = null;
        public Food food = null;
        public int level = 1;
        public int score = 0;


        public void Start()
        {
            worm = new Worm();
            worm.AttachGameLink(this);
            wall = new Wall();
            food = new Food();
            wall.DrawField();
            food.Draw();

            Thread t = new Thread(new ThreadStart(worm.Move));
            t.Start();

            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {

                    case ConsoleKey.F3:
                        wall = wall.Load() as Wall;
                        worm = worm.Load() as Worm;
                       worm.LinkToGame(this);
                        t.Abort();

                        t = new Thread(new ThreadStart(worm.Move));
                        t.IsBackground = true;
                        t.Start();

                        break;
                    case ConsoleKey.F2:
                        this.Save();
                        break;
                   
                    case ConsoleKey.UpArrow:
                        worm.dx = 0;
                        worm.dy = -1;
                        break;
                    case ConsoleKey.DownArrow:
                        worm.dx = 0;
                        worm.dy = 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        worm.dx = -1;
                        worm.dy = 0;
                        break;
                    case ConsoleKey.RightArrow:
                        worm.dx = 1;
                        worm.dy = 0;
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }

            }
        }
        public bool CanEat()
        {
            if (worm.points[0].Equals(food.points[0]))
            {
                worm.points.Add(food.points[0]);
                food = new Food();
                food.Draw();
                score++;
                return true;
            }
            return false;
        }
        public bool Collision()
        {
            for (int i = 0; i < wall.points.Count-2; i++)
            { for(int j=1;j < worm.points.Count;j++)
                if (worm.points[0].Equals(wall.points[i]) || worm.points[0].Equals(worm.points[j]))
                {
                    return true;
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(41, 0);
            Console.Write("Level: " + level);
            Console.SetCursorPosition(41, 2);
            Console.Write("Score: " + score);
        }

        
        public void Load()
        {
            worm = new Worm();
            worm.LinkToGame(this);

            wall = new Wall();
            food = new Food();
            
            worm.Draw();
            wall.Draw();
            food.Draw();
        }
        public void Save()
        {
            worm.Save();
            wall.Save();
                
        }
    }
}
