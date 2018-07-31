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
            this.AllText = new System.Windows.Forms.Label();
            this.BeznalText = new System.Windows.Forms.Label();
            this.NalText = new System.Windows.Forms.Label();
            this.NowMoney = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AllText);
            this.panel1.Controls.Add(this.BeznalText);
            this.panel1.Controls.Add(this.NalText);
            this.panel1.Controls.Add(this.NowMoney);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 143);
            this.panel1.TabIndex = 1;
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
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 404);
            this.Controls.Add(this.panel1);
            this.Name = "FinanceForm";
            this.Text = "Finance";
            this.Load += new System.EventHandler(this.Finance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AllText;
        private System.Windows.Forms.Label BeznalText;
        private System.Windows.Forms.Label NalText;
        private System.Windows.Forms.Label NowMoney;
    }
}