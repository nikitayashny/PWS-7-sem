﻿namespace WinFormMain
{
    partial class Form1
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
            this.S1 = new System.Windows.Forms.TextBox();
            this.K1 = new System.Windows.Forms.TextBox();
            this.F1 = new System.Windows.Forms.TextBox();
            this.S2 = new System.Windows.Forms.TextBox();
            this.K2 = new System.Windows.Forms.TextBox();
            this.F2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.F3 = new System.Windows.Forms.TextBox();
            this.K3 = new System.Windows.Forms.TextBox();
            this.S3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // S1
            // 
            this.S1.Location = new System.Drawing.Point(74, 49);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(100, 20);
            this.S1.TabIndex = 0;
            // 
            // K1
            // 
            this.K1.Location = new System.Drawing.Point(212, 49);
            this.K1.Name = "K1";
            this.K1.Size = new System.Drawing.Size(100, 20);
            this.K1.TabIndex = 1;
            // 
            // F1
            // 
            this.F1.Location = new System.Drawing.Point(346, 49);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(100, 20);
            this.F1.TabIndex = 2;
            // 
            // S2
            // 
            this.S2.Location = new System.Drawing.Point(74, 118);
            this.S2.Name = "S2";
            this.S2.Size = new System.Drawing.Size(100, 20);
            this.S2.TabIndex = 3;
            // 
            // K2
            // 
            this.K2.Location = new System.Drawing.Point(212, 118);
            this.K2.Name = "K2";
            this.K2.Size = new System.Drawing.Size(100, 20);
            this.K2.TabIndex = 4;
            // 
            // F2
            // 
            this.F2.Location = new System.Drawing.Point(346, 118);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(100, 20);
            this.F2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Int";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Int";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Float";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Float";
            // 
            // F3
            // 
            this.F3.Enabled = false;
            this.F3.Location = new System.Drawing.Point(346, 260);
            this.F3.Name = "F3";
            this.F3.Size = new System.Drawing.Size(100, 20);
            this.F3.TabIndex = 14;
            // 
            // K3
            // 
            this.K3.Enabled = false;
            this.K3.Location = new System.Drawing.Point(212, 260);
            this.K3.Name = "K3";
            this.K3.Size = new System.Drawing.Size(100, 20);
            this.K3.TabIndex = 13;
            // 
            // S3
            // 
            this.S3.Enabled = false;
            this.S3.Location = new System.Drawing.Point(74, 260);
            this.S3.Name = "S3";
            this.S3.Size = new System.Drawing.Size(100, 20);
            this.S3.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "RESULT";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 325);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.F3);
            this.Controls.Add(this.K3);
            this.Controls.Add(this.S3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.K2);
            this.Controls.Add(this.S2);
            this.Controls.Add(this.F1);
            this.Controls.Add(this.K1);
            this.Controls.Add(this.S1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox S1;
        private System.Windows.Forms.TextBox K1;
        private System.Windows.Forms.TextBox F1;
        private System.Windows.Forms.TextBox S2;
        private System.Windows.Forms.TextBox K2;
        private System.Windows.Forms.TextBox F2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox F3;
        private System.Windows.Forms.TextBox K3;
        private System.Windows.Forms.TextBox S3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
    }
}

