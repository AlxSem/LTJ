using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTJ
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static private void Init() //инициализация
        {
            if (!Directory.Exists(Core.Path.DataPath())) //Если путь отсутствует Создать папку
            {
                Directory.CreateDirectory(Core.Path.DataPath());
                Core.Core.MBInfo("Созданна папка \"Data\"");

            }
            if (!Directory.Exists(Core.Path.FinancePath()))//если путь отсутсвует Создать папку финансов и создать хмл
            {
                Directory.CreateDirectory(Core.Path.FinancePath());
                Core.Core.MBInfo("Созданна папка \"Finance\"");
                Core.XML.CreateXMLFilesFinance();
            }

        }

        static void Main()
        {
            Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
