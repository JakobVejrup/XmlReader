using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace XMLParsing
{

    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = "C:\\Users\\jakob\\source\\repos\\XMLParsing\\XMLParsing\\Orders.XML";

            try
            {
                using XmlReader reader = XmlReader.Create(filePath);
                var parser = new OrderParser();
                var orders = parser.Parse(filePath);

                foreach (var order in orders)
                {
                    Console.WriteLine(order);
                }
            }
            catch (IOException)
            {
                Console.WriteLine($"Fejl");
            }
        }
    }
}

