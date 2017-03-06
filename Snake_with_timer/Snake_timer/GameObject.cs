using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeII
{
    public abstract class GameObject 
    {
        public List<Point> points = new List<Point>();
        public char sign;
        public ConsoleColor color;
        public void Clear()
        {
            for (int i = 0; i < points.Count; ++i)
            {
                Console.SetCursorPosition(points[i].x, points[i].y);
                Console.Write(' ');
            }
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < points.Count; ++i)
            {
                Console.SetCursorPosition(points[i].x, points[i].y);
                Console.Write(sign);
            }
        }
        public GameObject Load()
        {
            GameObject result = null;

            string fname = this.GetType().Name;
            XmlSerializer xs = new XmlSerializer(this.GetType());
            using (FileStream fs = new FileStream(string.Format("{0}.xml", fname), FileMode.Open, FileAccess.Read))
            {
                result = xs.Deserialize(fs) as GameObject;
            }

            return result;
        }
        public void Save()
        {
            string fname = this.GetType().Name;
            XmlSerializer xs = new XmlSerializer(this.GetType());
            using (FileStream fs = new FileStream(string.Format("{0}.xml", fname), FileMode.Truncate, FileAccess.Write))
            {
                xs.Serialize(fs, this);
            }
        }

    }
}
