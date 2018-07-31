using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTJ
{
    public partial class FinanceForm : Form
    {
        public FinanceForm()
        {
            InitializeComponent();
        }

        private void Finance_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            double nal = Core.XML.LoadMoneyNal;
            double beznal = Core.XML.LoadMoneyBeznal;
            double all = nal + beznal;
            NalText.Text = "Наличными: " + nal.ToString();
            BeznalText.Text = "Безналичными: " + beznal.ToString();
            AllText.Text = "Всего: " + all.ToString();
        }
    }
}
