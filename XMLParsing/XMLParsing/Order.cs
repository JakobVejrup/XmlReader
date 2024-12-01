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
    public class Order
    {
        public int Id {  get; set; }
        public string? Kunde { get; set; }
        public int Pris { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Kunde {Kunde}, Pris {Pris}";
        }
    }
}
