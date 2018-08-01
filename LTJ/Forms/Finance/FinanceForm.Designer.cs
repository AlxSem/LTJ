namespace LTJ
{
    partial class FinanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinMoney = new System.Windows.Forms.Button();
            this.AddMoney = new System.Windows.Forms.Button();
            this.AllText = new System.Windows.Forms.Label();
            this.BeznalText = new System.Windows.Forms.Label();
            this.NalText = new System.Windows.Forms.Label();
            this.NowMoney = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReservBank = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grnAllBankText = new System.Windows.Forms.Label();
            this.usdBankText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MinMoney);
            this.panel1.Controls.Add(this.AddMoney);
            this.panel1.Controls.Add(this.AllText);
            this.panel1.Controls.Add(this.BeznalText);
            this.panel1.Controls.Add(this.NalText);
            this.panel1.Controls.Add(this.NowMoney);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 150);
            this.panel1.TabIndex = 1;
            // 
            // MinMoney
            // 
            this.MinMoney.Image = global::LTJ.Properties.Resources.add;
            this.MinMoney.Location = new System.Drawing.Point(138, 102);
            this.MinMoney.Name = "MinMoney";
            this.MinMoney.Size = new System.Drawing.Size(32, 32);
            this.MinMoney.TabIndex = 5;
            this.MinMoney.UseVisualStyleBackColor = true;
            this.MinMoney.Click += new System.EventHandler(this.MinMoney_Click);
            // 
            // AddMoney
            // 
            this.AddMoney.Image = global::LTJ.Properties.Resources.add;
            this.AddMoney.Location = new System.Drawing.Point(8, 102);
            this.AddMoney.Name = "AddMoney";
            this.AddMoney.Size = new System.Drawing.Size(32, 32);
            this.AddMoney.TabIndex = 4;
            this.AddMoney.UseVisualStyleBackColor = true;
            this.AddMoney.Click += new System.EventHandler(this.AddMoney_Click);
            // 
            // AllText
            // 
            this.AllText.AutoSize = true;
            this.AllText.Location = new System.Drawing.Point(8, 81);
            this.AllText.Name = "AllText";
            this.AllText.Size = new System.Drawing.Size(37, 13);
            this.AllText.TabIndex = 3;
            this.AllText.Text = "Всего";
            // 
            // BeznalText
            // 
            this.BeznalText.AutoSize = true;
            this.BeznalText.Location = new System.Drawing.Point(8, 56);
            this.BeznalText.Name = "BeznalText";
            this.BeznalText.Size = new System.Drawing.Size(83, 13);
            this.BeznalText.TabIndex = 2;
            this.BeznalText.Text = "Безналичными";
            // 
            // NalText
            // 
            this.NalText.AutoSize = true;
            this.NalText.Location = new System.Drawing.Point(8, 33);
            this.NalText.Name = "NalText";
            this.NalText.Size = new System.Drawing.Size(66, 13);
            this.NalText.TabIndex = 1;
            this.NalText.Text = "Наличными";
            // 
            // NowMoney
            // 
            this.NowMoney.AutoSize = true;
            this.NowMoney.Location = new System.Drawing.Point(8, 9);
            this.NowMoney.Name = "NowMoney";
            this.NowMoney.Size = new System.Drawing.Size(78, 13);
            this.NowMoney.TabIndex = 0;
            this.NowMoney.Text = "Сейчас денег:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.usdBankText);
            this.panel2.Controls.Add(this.grnAllBankText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ReservBank);
            this.panel2.Location = new System.Drawing.Point(218, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 150);
            this.panel2.TabIndex = 2;
            // 
            // ReservBank
            // 
            this.ReservBank.AutoSize = true;
            this.ReservBank.Location = new System.Drawing.Point(12, 80);
            this.ReservBank.Name = "ReservBank";
            this.ReservBank.Size = new System.Drawing.Size(62, 13);
            this.ReservBank.TabIndex = 0;
            this.ReservBank.Text = "В резерве ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сейчас денег в банке:";
            // 
            // grnAllBankText
            // 
            this.grnAllBankText.AutoSize = true;
            this.grnAllBankText.Location = new System.Drawing.Point(10, 32);
            this.grnAllBankText.Name = "grnAllBankText";
            this.grnAllBankText.Size = new System.Drawing.Size(57, 13);
            this.grnAllBankText.TabIndex = 2;
            this.grnAllBankText.Text = "В гривнах";
            // 
            // usdBankText
            // 
            this.usdBankText.AutoSize = true;
            this.usdBankText.Location = new System.Drawing.Point(10, 55);
            this.usdBankText.Name = "usdBankText";
            this.usdBankText.Size = new System.Drawing.Size(64, 13);
            this.usdBankText.TabIndex = 3;
            this.usdBankText.Text = "В долларах";
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FinanceForm";
            this.Text = "Finance";
            this.Load += new System.EventHandler(this.Finance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AllText;
        private System.Windows.Forms.Label BeznalText;
        private System.Windows.Forms.Label NalText;
        private System.Windows.Forms.Label NowMoney;
        private System.Windows.Forms.Button AddMoney;
        private System.Windows.Forms.Button MinMoney;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label usdBankText;
        private System.Windows.Forms.Label grnAllBankText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReservBank;
    }
}