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
        static public bool MBQuest(string text1, string text2)
        {
            DialogResult result = MessageBox.Show(text1, text2, MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) return true;
            else return false;
        }
    }
}
