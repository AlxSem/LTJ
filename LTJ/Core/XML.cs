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
                new XElement("Bank", new XElement("BankPropites",new XElement("UAN",0), new XElement("USD",0), new XElement("Reserv",0)), new XElement("Yacheyki")),
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
        static public double LoadBankUAN
        {
            get
            {
                XDocument xdoc = XDocument.Load(Path.FinanceXMLPath());
                return Convert.ToDouble(xdoc.Element("Finance").Element("Bank").Element("BankPropites").Element("UAN").Value.ToString());
            }
            set
            {
                XDocument xdoc = XDocument.Load(Path.FinanceXMLPath());
                Convert.ToDouble(xdoc.Element("Finance").Element("Bank").Element("BankPropites").Element("UAN").Value = value.ToString());
                xdoc.Save(Path.FinanceXMLPath());
            }
        }
        static public double LoadBankUSD
        {
            get
            {
                XDocument xdoc = XDocument.Load(Path.FinanceXMLPath());
                return Convert.ToDouble(xdoc.Element("Finance").Element("Bank").Element("BankPropites").Element("USD").Value.ToString());
            }
            set
            {
                XDocument xdoc = XDocument.Load(Path.FinanceXMLPath());
                Convert.ToDouble(xdoc.Element("Finance").Element("Bank").Element("BankPropites").Element("USD").Value = value.ToString());
                xdoc.Save(Path.FinanceXMLPath());
            }
        }
        static public double LoadBankReserv
        {
            get
            {
                XDocument xdoc = XDocument.Load(Path.FinanceXMLPath());
                return Convert.ToDouble(xdoc.Element("Finance").Element("Bank").Element("BankPropites").Element("Reserv").Value.ToString());
            }
            set
            {
                XDocument xdoc = XDocument.Load(Path.FinanceXMLPath());
                Convert.ToDouble(xdoc.Element("Finance").Element("Bank").Element("BankPropites").Element("Reserv").Value = value.ToString());
                xdoc.Save(Path.FinanceXMLPath());
            }
        }
        #endregion Достаем данные
        #region История
        static public void AddHistory(string Description, string Note, string wasNal, string thusNal, string wasBeznal, string thusBeznal)
        {
            XDocument xdox = XDocument.Load(Path.FinanceXMLPath());
            xdox.Element("Finance").Element("History")
                .Add(new XElement("His",
                new XElement("Day", DateTime.Today.ToShortDateString()),
                new XElement("Description", Description),
                new XElement("Note", Note),
                new XElement("WasNal", wasNal),
                new XElement("ThusNal", thusNal),
                new XElement("WasBeznal", wasBeznal),
                new XElement("ThusBeznal", thusBeznal)));
            xdox.Save(Path.FinanceXMLPath());
        }
        #endregion История
        
    }
}
