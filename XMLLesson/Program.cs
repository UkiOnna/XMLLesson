using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"Food.xml");
            var rootElement = document.LastChild;

            Console.WriteLine(rootElement.Name);

            foreach (XmlElement element in rootElement)
            {
                Console.WriteLine("  " + element.LocalName);

               foreach(XmlElement el in element)
                {
                    Console.WriteLine("    "+el.LocalName+"  ");
                }

            }

            Console.ReadLine();
        }
    }
}
