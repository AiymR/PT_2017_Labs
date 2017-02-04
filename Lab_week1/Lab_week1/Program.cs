using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_week1
{
    class Program
    {
        static bool IsPrime(string x) {
            int a = int.Parse(x);

            for (int i = 2; i <= Math.Sqrt(a); ++i)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }

            if (a < 2) return false;


            return true;
        }
    
static void Main(string[] args)
{

    for (int i = 0; i < args.Length; ++i)
    {
        if (IsPrime(args[i])) //
        {
            Console.WriteLine(args[i]); //
        }
    }
    Console.ReadKey();
 }
    }
}
