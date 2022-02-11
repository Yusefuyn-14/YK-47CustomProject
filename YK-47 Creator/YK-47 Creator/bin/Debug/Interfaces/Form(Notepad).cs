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

namespace Notepad
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
        public Form1()
        {
            InitializeComponent();
// #STRN_VRSC
// #COMP_CODE
            Thread.Sleep(250);
// #RUNN_PROC
        }
// #DECR_CODE
// #ENCR_CODE
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farkliKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sayfaYapisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonrakiniBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tumunuSecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatTarihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.duzenToolStripMenuItem,
            this.bicimToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 23);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.acToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farkliKaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.sayfaYapisiToolStripMenuItem,
            this.yazdirToolStripMenuItem,
            this.toolStripSeparator2,
            this.cikisToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 19);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.yeniToolStripMenuItem.Text = "Yeni             ";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.acToolStripMenuItem.Text = "Ac";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            this.farkliKaydetToolStripMenuItem.Name = "farkliKaydetToolStripMenuItem";
            this.farkliKaydetToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.farkliKaydetToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.farkliKaydetToolStripMenuItem.Text = "Farkli Kaydet";
            this.farkliKaydetToolStripMenuItem.Click += new System.EventHandler(this.farkliKaydetToolStripMenuItem_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            this.sayfaYapisiToolStripMenuItem.Name = "sayfaYapisiToolStripMenuItem";
            this.sayfaYapisiToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.sayfaYapisiToolStripMenuItem.Text = "Sayfa Yapisi";
            this.yazdirToolStripMenuItem.Name = "yazdirToolStripMenuItem";
            this.yazdirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.yazdirToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.yazdirToolStripMenuItem.Text = "Yazdir";
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.cikisToolStripMenuItem.Text = "Cikis";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            this.duzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.toolStripSeparator3,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapistirToolStripMenuItem,
            this.silToolStripMenuItem,
            this.toolStripSeparator4,
            this.bulToolStripMenuItem,
            this.sonrakiniBulToolStripMenuItem,
            this.degistirToolStripMenuItem,
            this.gitToolStripMenuItem,
            this.toolStripSeparator5,
            this.tumunuSecToolStripMenuItem,
            this.saatTarihToolStripMenuItem});
            this.duzenToolStripMenuItem.Name = "duzenToolStripMenuItem";
            this.duzenToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.duzenToolStripMenuItem.Text = "Duzen";
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            this.yapistirToolStripMenuItem.Name = "yapistirToolStripMenuItem";
            this.yapistirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.yapistirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.yapistirToolStripMenuItem.Text = "Yapistir";
            this.yapistirToolStripMenuItem.Click += new System.EventHandler(this.yapistirToolStripMenuItem_Click);
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(180, 6);
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.bulToolStripMenuItem.Text = "Bul...";
            this.sonrakiniBulToolStripMenuItem.Name = "sonrakiniBulToolStripMenuItem";
            this.sonrakiniBulToolStripMenuItem.ShortcutKeyDisplayString = "F3";
            this.sonrakiniBulToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sonrakiniBulToolStripMenuItem.Text = "Sonrakini Bul";
            this.degistirToolStripMenuItem.Name = "degistirToolStripMenuItem";
            this.degistirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+H";
            this.degistirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.degistirToolStripMenuItem.Text = "Degistir...";
            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+G";
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gitToolStripMenuItem.Text = "Git...";
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(180, 6);
            this.tumunuSecToolStripMenuItem.Name = "tumunuSecToolStripMenuItem";
            this.tumunuSecToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.tumunuSecToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tumunuSecToolStripMenuItem.Text = "Tumunu Sec";
            this.tumunuSecToolStripMenuItem.Click += new System.EventHandler(this.tumunuSecToolStripMenuItem_Click);
            this.saatTarihToolStripMenuItem.Name = "saatTarihToolStripMenuItem";
            this.saatTarihToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.saatTarihToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.saatTarihToolStripMenuItem.Text = "Saat/Tarih";
            this.saatTarihToolStripMenuItem.Click += new System.EventHandler(this.saatTarihToolStripMenuItem_Click);
            this.bicimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaziTipiToolStripMenuItem});
            this.bicimToolStripMenuItem.Name = "bicimToolStripMenuItem";
            this.bicimToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.bicimToolStripMenuItem.Text = "Bicim";
            this.yaziTipiToolStripMenuItem.Name = "yaziTipiToolStripMenuItem";
            this.yaziTipiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yaziTipiToolStripMenuItem.Text = "Yazi Tipi...";
            this.yaziTipiToolStripMenuItem.Click += new System.EventHandler(this.yaziTipiToolStripMenuItem_Click);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(585, 351);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "{0}";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 374);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Adsiz - Not Defteri";
            this.Load += Form1_Load;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farkliKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sayfaYapisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonrakiniBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tumunuSecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatTarihToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziTipiToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBox1.Text == "{0}") textBox1.Text = "";

        }

        string filePath = "";
        string getFileName(string path)
        {
            FileInfo fInfo = new FileInfo(path);
            return fInfo.Name;
        }
        private void farkliKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Metin Belgeleri(*.txt)|*.txt|Tum Dosyalar(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Text = getFileName(sfd.FileName) + " - Not defteri";
                FileStream fStream = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sWrite = new StreamWriter(fStream);
                foreach (var item in textBox1.Lines)
                    sWrite.WriteLine(item.ToString());
                sWrite.Flush();
                sWrite.Close();
                fStream.Close();
            }
        }
        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Metin Belgeleri(*.txt)|*.txt|Tum Dosyalar(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Text = getFileName(ofd.FileName) + " - Not Defteri";
                filePath = ofd.FileName;
                FileStream fStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sReader = new StreamReader(fStream);
                string line = sReader.ReadLine();
                while (line != null)
                {
                    textBox1.Text += line + "\n";
                    line = sReader.ReadLine();
                }
                sReader.Close();
                fStream.Close();
            }
        }
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void saatTarihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Text = "Adsiz - Not Defteri";
            filePath = "";
        }
        private void tumunuSecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void yaziTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = textBox1.Font;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fd.Font;
            }
        }
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                FileStream fStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sWrite = new StreamWriter(fStream);
                foreach (var item in textBox1.Lines)
                    sWrite.WriteLine(item.ToString());
                sWrite.Flush();
                sWrite.Close();
                fStream.Close();
            }
            else
                farkliKaydetToolStripMenuItem.PerformClick();
        }
    }
}
