using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FastColoredTextBoxNS;

namespace YK_47_Creator.UserControls
{
    public partial class AdditionItem : UserControl
    {
        string _AdditionsPath = "";
        public FastColoredTextBox txtCode = new FastColoredTextBox();
        public AdditionItem(string AdditionsPath)
        {
            InitializeComponent();
            _AdditionsPath = AdditionsPath;
        }

        private void AdditionItem_Load(object sender, EventArgs e)
        {
            txtCode.Dock = DockStyle.Fill;
            FileInfo fInfo = new FileInfo(_AdditionsPath);

            if (fInfo.Extension == ".cs")
                txtCode.Language = Language.CSharp;
            else if (fInfo.Extension == ".js")
                txtCode.Language = Language.JS;
            else if (fInfo.Extension == ".vb")
                txtCode.Language = Language.VB;

            txtCode.BackColor = Color.FromArgb(44,44,44);
            txtCode.ForeColor = Color.Lime;

            panel1.Controls.Add(txtCode);
            FileStream fStream = new FileStream(_AdditionsPath,FileMode.Open,FileAccess.Read);
            StreamReader sReader = new StreamReader(fStream);
            int LineLen = 0;
            string Line = sReader.ReadLine();
            while (Line != null)
            {
                if (Line.StartsWith("//") && LineLen == 0)
                    textBox1.Text = Line;
                else if (Line.StartsWith("//") && LineLen >= 1)
                    label2.Text += Line;
                else
                    txtCode.Text += Line + "\n";
                Line = sReader.ReadLine();
                LineLen++;
            }

            sReader.Close();
            fStream.Close();
        }
    }
}
