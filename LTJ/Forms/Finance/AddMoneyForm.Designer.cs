﻿namespace LTJ.Forms.FinanceForm
{
    partial class AddMoneyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NalTextBox = new System.Windows.Forms.TextBox();
            this.BeznalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наличные: ";
            // 
            // NalTextBox
            // 
            this.NalTextBox.Location = new System.Drawing.Point(98, 16);
            this.NalTextBox.Name = "NalTextBox";
            this.NalTextBox.Size = new System.Drawing.Size(124, 20);
            this.NalTextBox.TabIndex = 1;
            // 
            // BeznalTextBox
            // 
            this.BeznalTextBox.Location = new System.Drawing.Point(98, 48);
            this.BeznalTextBox.Name = "BeznalTextBox";
            this.BeznalTextBox.Size = new System.Drawing.Size(124, 20);
            this.BeznalTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Безналичные: ";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(98, 78);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(124, 57);
            this.NoteTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Описание:";
            // 
            // Confirm
            // 
            this.Confirm.Image = global::LTJ.Properties.Resources.add;
            this.Confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Confirm.Location = new System.Drawing.Point(12, 159);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(210, 40);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "Готово";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // AddMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BeznalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NalTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddMoneyForm";
            this.Text = "AddMoneyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NalTextBox;
        private System.Windows.Forms.TextBox BeznalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Confirm;
    }
}