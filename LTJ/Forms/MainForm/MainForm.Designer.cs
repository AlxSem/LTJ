namespace LTJ
{
    partial class MainForm
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
            this.FinanseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FinanseForm
            // 
            this.FinanseForm.Location = new System.Drawing.Point(13, 13);
            this.FinanseForm.Name = "FinanseForm";
            this.FinanseForm.Size = new System.Drawing.Size(100, 100);
            this.FinanseForm.TabIndex = 0;
            this.FinanseForm.Text = "Финансы";
            this.FinanseForm.UseVisualStyleBackColor = true;
            this.FinanseForm.Click += new System.EventHandler(this.FinanseForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(902, 538);
            this.Controls.Add(this.FinanseForm);
            this.Name = "MainForm";
            this.Text = "Life Target Journal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FinanseForm;
    }
}