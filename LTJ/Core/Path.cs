using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTJ.Core
{
   static class Path
    {
        static public string MainPath()
        {
            return Environment.CurrentDirectory;
        }
        static public string DataPath()
        {
            return Environment.CurrentDirectory.ToString() + "\\Data";
        }
    }
}
