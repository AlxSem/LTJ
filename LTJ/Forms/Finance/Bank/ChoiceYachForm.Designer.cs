namespace LTJ.Forms.Finance.Bank
{
    partial class ChoiceYachForm
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
            this.ChoiceYachCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChoiceYachCB
            // 
            this.ChoiceYachCB.FormattingEnabled = true;
            this.ChoiceYachCB.Location = new System.Drawing.Point(121, 22);
            this.ChoiceYachCB.Name = "ChoiceYachCB";
            this.ChoiceYachCB.Size = new System.Drawing.Size(151, 21);
            this.ChoiceYachCB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете ячейку";
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Location = new System.Drawing.Point(15, 55);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(25, 13);
            this.InfoText.TabIndex = 2;
            this.InfoText.Text = "Info";
            // 
            // ChoiceYachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChoiceYachCB);
            this.Name = "ChoiceYachForm";
            this.Text = "ChoiceYachForm";
            this.Load += new System.EventHandler(this.ChoiceYachForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChoiceYachCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfoText;
    }
}