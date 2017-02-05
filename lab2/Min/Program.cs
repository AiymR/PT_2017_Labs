using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min
{
    class Program
    {
        static bool IsPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); ++i)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadToEnd();
            string[] numbers = text.Split(' ');
            int[] a = new int[numbers.Length];
            int min = int.MaxValue;

            for (int i = 0; i < numbers.Length; ++i)
            {
                //int min = int.MaxValue;
                a[i] = int.Parse(numbers[i]);
                if (IsPrime(a[i]))
                {

                    {
                        if (min > a[i])
                            min = a[i];

                        
                        
                    }

                    
                }
            }


            StreamWriter sw = new StreamWriter(fs);

            //sw.WriteLine("Hello world!");

            sw.WriteLine(min);

            sw.Close();
            fs.Close();
            
            Console.ReadKey();
        }
    }
}

