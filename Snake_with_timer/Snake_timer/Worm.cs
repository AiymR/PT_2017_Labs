using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeII
{
    [Serializable]
    public class Worm : GameObject
    {
        Game game = null;
        public int dx;
        public int dy;

        public void LinkToGame(Game game)
        {
            this.game = game;
        }


        public void AttachGameLink(Game game)
        {
            this.game = game;
        }

        public Worm()
        {
            color = ConsoleColor.Green;
            this.sign = '*';
            this.points.Add(new Point(2, 2));
        }

        public void Move()
        {
            while (true)
            {
                game.ShowInfo();
                Clear();
                for (int i = points.Count - 1; i > 0; --i)
                {
                    points[i].x = points[i - 1].x;
                    points[i].y = points[i - 1].y;
                }
                points[0].x = points[0].x + dx;
                points[0].y = points[0].y + dy;

                Draw();

                if(game.Collision())
                {
                    Console.Clear();
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("Press esc to close ");
                    break;
                }

                game.CanEat();
                Thread.Sleep(200);
            }
        }
    }
}
