using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isprime
{
    class Program
    {
        static bool IsPrime(string x) //функция для проверки простоты
        {
            int a = int.Parse(x); //преобразуем строку в целое число

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

            for (int i = 0; i < args.Length; ++i) //пробегаемся по массиву args
            {
                if (IsPrime(args[i])) //проверяем числа на простоту
                {
                    Console.WriteLine(args[i]); //вывод простых чисел
                }
            }
            Console.ReadKey();
        }
    }
}
