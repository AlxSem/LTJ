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
    public partial class FinanseForm : Form
    {
        private Panel panel1;

        public FinanseForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 106);
            this.panel1.TabIndex = 0;
            // 
            // FinanseForm
            // 
            this.ClientSize = new System.Drawing.Size(645, 396);
            this.Controls.Add(this.panel1);
            this.Name = "FinanseForm";
            this.Text = "Ой! Денюжки?";
            this.ResumeLayout(false);

        }
    }
}
