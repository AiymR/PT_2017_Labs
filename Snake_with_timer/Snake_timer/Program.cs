using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 40);
            Console.SetBufferSize(80, 40);
            Console.WriteLine("[1] - New Game, [2] - Continue");
            string n = Console.ReadLine();
            if ( n == "1")
            {
                Console.Clear();
                Game g = new Game();
                g.Start();
            }
            if (n =="2") 
                
            {


            }
        }
    }
}
