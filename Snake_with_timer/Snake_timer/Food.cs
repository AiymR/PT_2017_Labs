using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeII
{
    [Serializable]
    public class Food : GameObject
    {
        public Food()
        {
            color = ConsoleColor.Blue;
            this.sign = 'F';
            this.points.Add(new Point(new Random().Next(3,30), new Random().Next(3,30)));
        }

    }
}