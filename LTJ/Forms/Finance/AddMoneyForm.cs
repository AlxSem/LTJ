using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTJ.Forms.FinanceForm
{
    public partial class AddMoneyForm : Form
    {
        public AddMoneyForm()
        {
            InitializeComponent();
           

        }
        
        private void Confirm_Click(object sender, EventArgs e)
        {
            if(NalTextBox.Text == String.Empty)
            {
                NalTextBox.Text = 0.ToString();
            }
            if(BeznalTextBox.Text == String.Empty)
            {
                BeznalTextBox.Text = 0.ToString();
            }
            if(NoteTextBox.Text == String.Empty)
            {
                NoteTextBox.Text = "None";
            }
            double nalLoad = Core.XML.LoadMoneyNal;
            double beznalLoad = Core.XML.LoadMoneyBeznal;
            double nal = Convert.ToDouble(NalTextBox.Text);
            double beznal = Convert.ToDouble(BeznalTextBox.Text);
            string note = NoteTextBox.Text;
            nal += nalLoad;
            beznal += beznalLoad;
            Core.XML.AddHistory("Прибавка", note, nalLoad.ToString(), nal.ToString(), beznalLoad.ToString(), beznal.ToString());
            Core.XML.LoadMoneyNal = nal;
            Core.XML.LoadMoneyBeznal = beznal;
            LTJ.FinanceForm main = this.Owner as LTJ.FinanceForm;
            main.Reload();
            this.Close();
        }
    }
}
