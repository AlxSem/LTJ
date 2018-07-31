using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTJ.Core
{
    static public class Core
    {
        static public void MBInfo(string text)
        {
            MessageBox.Show(text, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
