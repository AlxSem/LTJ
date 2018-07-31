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
        #region Инициализация пустых XML
        #region Финансы
        static public void CreateXMLFilesFinance()
        {
            XDocument xdoc = new XDocument(new XElement("Finance",
                new XElement("Have", new XElement("Beznal", 0), new XElement("Nal", 0)),
                new XElement("Target"),
                new XElement("Bank"),
                new XElement("History"),
                new XElement("Comunal"),
                new XElement("Other", new XElement("Proezd"), new XElement("Eat"), new XElement("Coffee"), new XElement("Vape"))));
            xdoc.Save(Path.FinanceXMLPath());
        }

        #endregion Финансы
        #endregion Инициализация пустых XML
        #region Достаем данные
        static public double LoadMoneyNal
        {

            get
            {
                XDocument xdoc = XDocument.Load(Path.FinanceXMLPath());
                return Convert.ToDouble(xdoc.Element("Finance").Element("Have").Element("Nal").Value.ToString());
            }
            set
            {
                XDocument xdoc = XDocument.Load(Path.FinanceXMLPath());
                Convert.ToDouble(xdoc.Element("Finance").Element("Have").Element("Nal").Value = value.ToString());
                xdoc.Save(Path.FinanceXMLPath());
            }
           }
        static public double LoadMoneyBeznal
        {
            get
            {
                XDocument xdoc = XDocument.Load(Path.FinanceXMLPath());
                return Convert.ToDouble(xdoc.Element("Finance").Element("Have").Element("Beznal").Value.ToString());
            }
            set
            {
                XDocument xdoc = XDocument.Load(Path.FinanceXMLPath());
                Convert.ToDouble(xdoc.Element("Finance").Element("Have").Element("Beznal").Value = value.ToString());
                xdoc.Save(Path.FinanceXMLPath());
            }
        }
        #endregion Достаем данные
    }
}
