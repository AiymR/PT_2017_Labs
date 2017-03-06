using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeII
{
    [Serializable]
    public class Wall : GameObject
    {
        public Wall()
        {
            color = ConsoleColor.White;
        }
        public void DrawField()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(0, 0);
            for(int i = 0; i < 39; i++)  
            {
                Console.Write("#");
                points.Add(new Point(i,0));
            }
            Console.WriteLine();
            for(int i = 0; i <38 ; i++)
            {
                Console.Write("#"); 
                points.Add(new Point(1, i));
                for (int j = 1; j < 38; j++) 
                {
                    Console.Write(" ");
                }
    
                Console.Write("#"); 
                points.Add(new Point(38, i));
                Console.WriteLine();
            }
            for (int i = 0; i < 39; i++) 
            {
                Console.Write("#");
                points.Add(new Point(i, 39));
            }
        }
    }
}
