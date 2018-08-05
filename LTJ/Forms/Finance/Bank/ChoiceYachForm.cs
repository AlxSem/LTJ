using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTJ.Forms.Finance.Bank
{
    public partial class ChoiceYachForm : Form
    {
        public ChoiceYachForm()
        {
            InitializeComponent();
        }

        private void ChoiceYachForm_Load(object sender, EventArgs e)
        {
            List<string> List = Core.XML.ListYach();
            foreach(string el in List)
            {
                ChoiceYachCB.Items.Add(el);
            }

        }
    }
}
