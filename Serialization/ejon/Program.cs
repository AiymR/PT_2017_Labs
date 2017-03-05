using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xml;

namespace ejon
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Complex f= new Complex();
             f.a = 7;
             f.b = 8;
             string res = JsonConvert.SerializeObject(f);
             using (FileStream ds = new FileStream("complex.json", FileMode.OpenOrCreate, FileAccess.ReadWrite)) 
             {
                 using (StreamWriter sw = new StreamWriter(ds)) 
                 {
                     sw.WriteLine(res);
                 }
                     }*/

            using (FileStream ds = new FileStream("complex.json", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(ds))
                {
                    string text = sr.ReadToEnd();

                    Complex s2 = JsonConvert.DeserializeObject<Complex>(text);
                    
                    Console.WriteLine(s2);
                    //ds.close();

                    Console.ReadKey();
                }
            }
        }
    }
}
