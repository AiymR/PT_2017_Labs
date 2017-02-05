using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    public class complex
    {
        public int a;
        public int b;
        public complex(int a, int b)
        {


            this.a = a;
            this.b = b;
        }



        public static complex operator +(complex c1, complex c2)
        {
            complex c = new complex(0, 0);
            c.a = c1.a + c2.a;
            c.b = c1.b + c2.b;
            return c;

        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", a, b);
        }

    }
        class Program
    {
        static void Main(string[] args)
        {
            complex c = new complex(5, 6);
            complex c2 = new complex(2, 6);
            complex c3 = c + c2;


            Console.WriteLine(c3);
            Console.ReadKey();
        }
       // public override string ToString()
        
    //        return string.Format("{0} + {1}i", a, b);
        
    } 
  
}


