using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace LTJ.Core
{
    static public class XML
    {
        static public void CreateXMLFilesFinance()
        {
            XDocument xdoc = new XDocument(new XElement("Finance",
                new XElement("Have", new XElement("Beznal", 0), new XElement("Nal", 0)),
                new XElement("Target"), 
                new XElement("Bank")));
            xdoc.Save(Path.FinanceXMLPath());
        }
    }
}
