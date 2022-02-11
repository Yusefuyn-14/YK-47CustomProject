using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YK_47_Creator
{
    public partial class messageBox : Form
    {
        string _Message="",_Hood = "";
        public messageBox(string Message,string Hood)
        {
            InitializeComponent();
            _Message = Message;
            _Hood = Hood;
        }

        private void messageBox_Load(object sender, EventArgs e)
        {
            label1.Text = _Hood;
            label2.Text = _Message;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
