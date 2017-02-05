using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadToEnd();
            string[] numbers = text.Split(' ');
            int[]ar = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; ++i)
            {
              ar[i] =int.Parse(numbers[i]);

            }
            int max, min;
            max = int.MinValue;
            min = int.MaxValue;
            for (int i = 0; i < numbers.Length; ++i)
            {
                if (max < ar[i]) max = ar[i];
                if (min > ar[i]) min = ar[i];
            }


            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadKey();
            // FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // StreamReader sr = new StreamReader(fs);

            // string text = sr.ReadToEnd();

            //Console.WriteLine(text);

            sr.Close();
            fs.Close();
        }
    }

}

