using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
namespace Calculator
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            IntPtr h = Process.GetCurrentProcess().MainWindowHandle;
            ShowWindow(h, 0);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    }
    public partial class Form1 : Form
    {
// #STRN_VRSC
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;


        public Form1()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(296, 64);
            this.textBox1.TabIndex = 10;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(247, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "M-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(191, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "M+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(135, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "MS";
            this.button3.UseVisualStyleBackColor = true;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(79, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "MR";
            this.button4.UseVisualStyleBackColor = true;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(23, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "MC";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(23, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 10;
            this.button6.Text = "←";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(79, 138);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "CE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(135, 138);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "C";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(191, 138);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 7;
            this.button9.Text = "±";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(247, 138);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 6;
            this.button10.Text = "√";
            this.button10.UseVisualStyleBackColor = true;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(23, 194);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 50);
            this.button11.TabIndex = 15;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.Location = new System.Drawing.Point(79, 194);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 50);
            this.button12.TabIndex = 14;
            this.button12.Text = "8";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(135, 194);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 50);
            this.button13.TabIndex = 13;
            this.button13.Text = "9";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(191, 194);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 50);
            this.button14.TabIndex = 12;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(247, 194);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 50);
            this.button15.TabIndex = 11;
            this.button15.Text = "%";
            this.button15.UseVisualStyleBackColor = true;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.Location = new System.Drawing.Point(23, 250);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 50);
            this.button16.TabIndex = 20;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.Location = new System.Drawing.Point(79, 250);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 50);
            this.button17.TabIndex = 19;
            this.button17.Text = "5";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.Location = new System.Drawing.Point(135, 250);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 50);
            this.button18.TabIndex = 18;
            this.button18.Text = "6";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.Location = new System.Drawing.Point(191, 250);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 50);
            this.button19.TabIndex = 17;
            this.button19.Text = "*";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.Location = new System.Drawing.Point(247, 250);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 50);
            this.button20.TabIndex = 16;
            this.button20.Text = "1/x";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.Location = new System.Drawing.Point(23, 306);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(50, 50);
            this.button21.TabIndex = 25;
            this.button21.Text = "1";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button22.Location = new System.Drawing.Point(79, 306);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(50, 50);
            this.button22.TabIndex = 24;
            this.button22.Text = "2";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button23.Location = new System.Drawing.Point(135, 306);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(50, 50);
            this.button23.TabIndex = 23;
            this.button23.Text = "3";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button24.Location = new System.Drawing.Point(191, 306);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(50, 50);
            this.button24.TabIndex = 22;
            this.button24.Text = "-";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button25.Location = new System.Drawing.Point(247, 306);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(50, 106);
            this.button25.TabIndex = 21;
            this.button25.Text = "=";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button26.Location = new System.Drawing.Point(23, 362);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(106, 50);
            this.button26.TabIndex = 29;
            this.button26.Text = "0";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button28.Location = new System.Drawing.Point(135, 362);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(50, 50);
            this.button28.TabIndex = 27;
            this.button28.Text = ",";
            this.button28.UseVisualStyleBackColor = true;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button29.Location = new System.Drawing.Point(191, 362);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(50, 50);
            this.button29.TabIndex = 26;
            this.button29.Text = "+";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 26);
            this.label2.TabIndex = 31;
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "M";
            this.label3.Visible = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();
// #COMP_CODE
// #RUNN_PROC
        }

        char oper = '+';
        int ilkSay = 0;
        int mem = 0;

        void labelAdd(object obj)
        {
            if (label1.Text == "0")
                label1.Text = obj.ToString();
            else
                label1.Text += obj.ToString();
        }
// #DECR_CODE
// #ENCR_CODE
        private void button26_Click(object sender, EventArgs e)
        {
            labelAdd(0);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            labelAdd(1);


        }

        private void button22_Click(object sender, EventArgs e)
        {
            labelAdd(2);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            labelAdd(3);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            labelAdd(4);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            labelAdd(5);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            labelAdd(6);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            labelAdd(7);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            labelAdd(8);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            labelAdd(9);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            operChange('+');
        }

        private void operChange(char op)
        {
            label2.Text = label1.Text + " " + op + " ";
            ilkSay = Convert.ToInt32(label1.Text);
            label1.Text = "0";
            oper = op;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            operChange('-');

        }

        private void button19_Click(object sender, EventArgs e)
        {
            operChange('*');

        }

        private void button14_Click(object sender, EventArgs e)
        {
            operChange('/');
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (ilkSay != 0)
            {
                if (oper == '+')
                    label1.Text = (ilkSay + Convert.ToInt32(label1.Text)).ToString();
                else if (oper == '-')
                    label1.Text = (ilkSay - Convert.ToInt32(label1.Text)).ToString();
                else if (oper == '*')
                    label1.Text = (ilkSay * Convert.ToInt32(label1.Text)).ToString();
                else if (oper == '/')
                    label1.Text = (ilkSay / Convert.ToInt32(label1.Text)).ToString();

                label2.Text = "";
            }
            else if (label2.Text != "")
            {
                ilkSay = Convert.ToInt32(label1.Text);
                button25.PerformClick();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label1.Text) > 0)
                label1.Text = (-1 * Convert.ToInt32(label1.Text)).ToString();
            else if (Convert.ToInt32(label1.Text) < 0)
                label1.Text = (-1 * Convert.ToInt32(label1.Text)).ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            ilkSay = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            ilkSay = 0;
            oper = '+';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mem += Convert.ToInt32(label1.Text);
            label1.Text = "0";
            label3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            mem = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mem -= Convert.ToInt32(label1.Text);
            label1.Text = "0";
            label3.Visible = true;

        }
    }
}
