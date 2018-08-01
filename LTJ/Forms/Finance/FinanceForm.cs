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
        public static FinanceForm SelfRef
        {
            get; set;
        }
        public FinanceForm()
        {
            InitializeComponent();
            SelfRef = this;
        }

        private void Finance_Load(object sender, EventArgs e)
        {
            Reload();
        }

         public void Reload()
        {
            double nal = Core.XML.LoadMoneyNal;
            double beznal = Core.XML.LoadMoneyBeznal;
            double all = nal + beznal;
            NalText.Text = "Наличными: " + nal.ToString();
            BeznalText.Text = "Безналичными: " + beznal.ToString();
            AllText.Text = "Всего: " + all.ToString();
        }

        
        private void AddMoney_Click(object sender, EventArgs e)
        {
            Forms.FinanceForm.AddMoneyForm addMoneyForm = new Forms.FinanceForm.AddMoneyForm();
            addMoneyForm.Owner = this;
            addMoneyForm.ShowDialog();
        }
    }
}
