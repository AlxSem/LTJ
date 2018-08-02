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

         public void Reload()
        {
            double nal = Core.XML.LoadMoneyNal;
            double beznal = Core.XML.LoadMoneyBeznal;
            double all = nal + beznal;
            NalText.Text = "Наличными: " + nal.ToString();
            BeznalText.Text = "Безналичными: " + beznal.ToString();
            AllText.Text = "Всего: " + all.ToString();
            double UAN = Core.XML.LoadBankUAN;
            double USD = Core.XML.LoadBankUSD;
            double Reserv = Core.XML.LoadBankReserv;
            grnAllBankText.Text = "В гривнах: " + UAN.ToString();
            usdBankText.Text = "В долларах : " + USD.ToString();
            ReservBank.Text = "В резерве : " + Reserv.ToString();
        }

        
        private void AddMoney_Click(object sender, EventArgs e)
        {
            Forms.FinanceForm.AddMoneyForm addMoneyForm = new Forms.FinanceForm.AddMoneyForm();
            {
                addMoneyForm.Owner = this;
                addMoneyForm.ShowDialog();
                bool result = Core.Core.MBQuest("Хотите записать 10% в Банк?", "Вопрос");
                if (result)
                {

                }
            }

        }

        private void MinMoney_Click(object sender, EventArgs e)
        {
            Forms.Finance.MinMoneyForm minMoneyForm = new Forms.Finance.MinMoneyForm();
            minMoneyForm.Owner = this;
            minMoneyForm.ShowDialog();
        }
    }
}
