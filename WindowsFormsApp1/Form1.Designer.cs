﻿namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.GitStatusBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SwitchBranchBtn = new System.Windows.Forms.Button();
            this.LogBoxWindow = new System.Windows.Forms.WebBrowser();
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(908, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Open Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(30, 58);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(970, 200);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 272);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Get New Timestamp";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(329, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(467, 306);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(379, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(885, 305);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Generate Filename";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // GitStatusBtn
            // 
            this.GitStatusBtn.Location = new System.Drawing.Point(30, 346);
            this.GitStatusBtn.Name = "GitStatusBtn";
            this.GitStatusBtn.Size = new System.Drawing.Size(116, 23);
            this.GitStatusBtn.TabIndex = 12;
            this.GitStatusBtn.Text = "Git Status";
            this.GitStatusBtn.UseVisualStyleBackColor = true;
            this.GitStatusBtn.Click += new System.EventHandler(this.GitStatusBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Commit Message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(852, 305);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "🗘";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ticket Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "File Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(467, 424);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(379, 20);
            this.textBox4.TabIndex = 18;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // SwitchBranchBtn
            // 
            this.SwitchBranchBtn.Location = new System.Drawing.Point(885, 346);
            this.SwitchBranchBtn.Name = "SwitchBranchBtn";
            this.SwitchBranchBtn.Size = new System.Drawing.Size(115, 23);
            this.SwitchBranchBtn.TabIndex = 19;
            this.SwitchBranchBtn.Text = "Switch Branch";
            this.SwitchBranchBtn.UseVisualStyleBackColor = true;
            this.SwitchBranchBtn.Click += new System.EventHandler(this.SwitchBranchBtn_Click);
            // 
            // LogBoxWindow
            // 
            this.LogBoxWindow.Location = new System.Drawing.Point(30, 460);
            this.LogBoxWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.LogBoxWindow.Name = "LogBoxWindow";
            this.LogBoxWindow.Size = new System.Drawing.Size(970, 199);
            this.LogBoxWindow.TabIndex = 20;
            this.LogBoxWindow.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.LogBoxWindow_DocumentCompleted);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(885, 673);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(115, 23);
            this.button10.TabIndex = 21;
            this.button10.Text = "Git Push";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Logs";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(919, 422);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(81, 23);
            this.button11.TabIndex = 23;
            this.button11.Text = "Re-Ammend";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Path:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 23);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(639, 20);
            this.textBox5.TabIndex = 25;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Current Directory:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Please Open Folder";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Current Branch   :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(854, 422);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 23);
            this.button9.TabIndex = 31;
            this.button9.Text = "Commit";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = " ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(201, 307);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 32;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Ticket Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(464, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = " ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.ClientSize = new System.Drawing.Size(1046, 480);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.LogBoxWindow);
            this.Controls.Add(this.SwitchBranchBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GitStatusBtn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Blaze PR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button GitStatusBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button SwitchBranchBtn;
        private System.Windows.Forms.WebBrowser LogBoxWindow;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

