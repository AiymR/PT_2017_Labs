using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml
{  [Serializable]
    public class Complex
    {
        public int a;
        public int b;
        public Complex(int a, int b)
        {


            this.a = a;
            this.b = b;
        }

        public Complex()
        {
            this.a = 1;
            this.b = 1;
            
        }

        public void Generate()
        {

        }

        /*public static complex operator +(complex c1, complex c2)
        {
            complex c = new complex(0, 0);
            c.a = c1.a + c2.a;
            c.b = c1.b + c2.b;
            return c;

        }*/

        public override string ToString()
        {
            return string.Format("{0} + {1}i", a, b);
        } 



        class Program
        {

            static void Main(string[] args)
            {

               /* XmlSerializer xs = new XmlSerializer(typeof(Complex));

                Complex s = new Complex(5,6);
                FileStream fs = new FileStream("testwxl.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                s.a = 7;
                s.b = 8;
                xs.Serialize(fs, s);
                fs.Close();*/



                XmlSerializer xs = new XmlSerializer(typeof(Complex));
                FileStream fs = new FileStream("testwxl.txt", FileMode.Open, FileAccess.Read);
                Complex s2 = new Complex();
                s2 = xs.Deserialize(fs) as Complex;
                Console.WriteLine(s2);
                Console.ReadKey();
                fs.Close();
            }
        }
    }
}