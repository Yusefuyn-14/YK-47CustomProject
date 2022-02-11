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
namespace CrackMe
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
        Label lblUserName = new Label();
        Label lblPassword = new Label();
        TextBox txtUserName = new TextBox();
        TextBox txtPassword = new TextBox();
        Button btnLogin = new Button();
// #STRN_VRSC
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SuspendLayout(); this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Name = "Form1"; this.Text = "CrackMe"; this.ResumeLayout(false);
            lblUserName.Text = "UserName :"; lblUserName.AutoSize = true;
            lblUserName.Size = new System.Drawing.Size(50, 50); lblUserName.Location = new System.Drawing.Point(50, 25);
            lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            txtUserName.Size = new System.Drawing.Size(150, 150);
            txtUserName.Location = new System.Drawing.Point(115, 23);
            lblPassword.Text = "Password :"; lblPassword.AutoSize = true;
            lblPassword.Size = new System.Drawing.Size(50, 50); lblPassword.Location = new System.Drawing.Point(50, 50);
            lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight; txtPassword.Size = new System.Drawing.Size(150, 150);
            txtPassword.Location = new System.Drawing.Point(115, 48); btnLogin.Text = "Login";
            btnLogin.Size = new System.Drawing.Size(150, 50); btnLogin.Location = new System.Drawing.Point(115, 70);
            this.Controls.Add(lblUserName); this.Controls.Add(lblPassword); this.Controls.Add(txtUserName);
            this.Controls.Add(txtPassword); this.Controls.Add(btnLogin); btnLogin.Click += BtnLogin_Click;
            this.Load += Form1_Load;
            this.TopMost = true;
            this.ResumeLayout(false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
// #COMP_CODE
// #RUNN_PROC
        }
// #DECR_CODE
// #ENCR_CODE
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Admin" && txtPassword.Text == "Admin123")
                MessageBox.Show("Giris yapildi *_*", "Yes !.!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Giris yapilamadi ;((", "N0o !.!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}