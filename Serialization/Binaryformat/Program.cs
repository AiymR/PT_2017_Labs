using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using xml;

namespace BinaryFormattere

{    

        
        class Program
        {
            static void Main(string[] args)
            {
                Complex c = new Complex();
                c.Generate();

                BinaryFormatter bf = new BinaryFormatter();

                using (FileStream fs = new FileStream("complex.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    bf.Serialize(fs, c);
                }
            using (FileStream fs = new FileStream("complex.bin", FileMode.Open, FileAccess.Read))
            {
                Complex s2 = (Complex)bf.Deserialize(fs);
                Console.WriteLine(s2);
                Console.ReadKey();
            }

        }
        }
    }

