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
    public class OrderParser
    {
        public List<Order> Parse(string filePath)
        {
            var orders = new List<Order>();
            using (XmlReader reader = XmlReader.Create(filePath))
            { 
                Order? currentOrder = null;

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Order":
                                currentOrder = new Order();
                                break;
                            case "Id":
                                if (currentOrder != null)
                                    currentOrder.Id = reader.ReadElementContentAsInt();
                                break;
                            case "Kunde":
                                if (currentOrder != null)
                                    currentOrder.Kunde = reader.ReadElementContentAsString();
                                break;
                            case "Pris":
                                if (currentOrder != null)
                                    currentOrder.Pris = (int)reader.ReadElementContentAsDecimal();
                                break;

                        }
                    }
                    else if (reader.Name == "Order" && reader.NodeType == XmlNodeType.EndElement)
                    { 
                        if (currentOrder != null)
                        {
                            orders.Add(currentOrder);
                            currentOrder = null;
                        }
                    }
                }
            }
            return orders;
        }
    }
}