namespace YK_47_Creator
{
    partial class homeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.panelPayloadSelection = new System.Windows.Forms.Panel();
            this.comboBoxPayloadStyle = new System.Windows.Forms.ComboBox();
            this.comboBoxPayload = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInterfaceSelection = new System.Windows.Forms.Panel();
            this.comboBoxInterface = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelResultCode = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.visualStudioTabControl1 = new VisualStudioTabControl.VisualStudioTabControl();
            this.tabPPayload = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxPayloadComp = new System.Windows.Forms.CheckBox();
            this.panelPayloadCryption = new System.Windows.Forms.Panel();
            this.btnRandomPass = new System.Windows.Forms.Button();
            this.txtPrivKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCryptionMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPaylodCode = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPInterface = new System.Windows.Forms.TabPage();
            this.panelInterfaceAdditions = new System.Windows.Forms.Panel();
            this.panelInterfaceCode = new System.Windows.Forms.Panel();
            this.tabPAdditions = new System.Windows.Forms.TabPage();
            this.tabPCompileCode = new System.Windows.Forms.TabPage();
            this.tabPCompileResult = new System.Windows.Forms.TabPage();
            this.richTextBoxCompileResult = new System.Windows.Forms.RichTextBox();
            this.tabPCryption = new System.Windows.Forms.TabPage();
            this.richTextBoxCryptionResult = new System.Windows.Forms.RichTextBox();
            this.btnDescryption = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.txtCryptionPass = new System.Windows.Forms.TextBox();
            this.richTextBoxCryption = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelPayloadSelection.SuspendLayout();
            this.panelInterfaceSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.visualStudioTabControl1.SuspendLayout();
            this.tabPPayload.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPayloadCryption.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.tabPInterface.SuspendLayout();
            this.tabPCompileCode.SuspendLayout();
            this.tabPCompileResult.SuspendLayout();
            this.tabPCryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPayloadSelection
            // 
            this.panelPayloadSelection.Controls.Add(this.comboBoxPayloadStyle);
            this.panelPayloadSelection.Controls.Add(this.comboBoxPayload);
            this.panelPayloadSelection.Controls.Add(this.label1);
            this.panelPayloadSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPayloadSelection.Location = new System.Drawing.Point(0, 0);
            this.panelPayloadSelection.Name = "panelPayloadSelection";
            this.panelPayloadSelection.Size = new System.Drawing.Size(788, 27);
            this.panelPayloadSelection.TabIndex = 10;
            // 
            // comboBoxPayloadStyle
            // 
            this.comboBoxPayloadStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.comboBoxPayloadStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPayloadStyle.ForeColor = System.Drawing.Color.Red;
            this.comboBoxPayloadStyle.FormattingEnabled = true;
            this.comboBoxPayloadStyle.Location = new System.Drawing.Point(142, 3);
            this.comboBoxPayloadStyle.Name = "comboBoxPayloadStyle";
            this.comboBoxPayloadStyle.Size = new System.Drawing.Size(128, 21);
            this.comboBoxPayloadStyle.TabIndex = 2;
            this.comboBoxPayloadStyle.SelectedIndexChanged += new System.EventHandler(this.comboPayloadStyle_SelectedIndexChanged);
            // 
            // comboBoxPayload
            // 
            this.comboBoxPayload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.comboBoxPayload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPayload.ForeColor = System.Drawing.Color.Red;
            this.comboBoxPayload.FormattingEnabled = true;
            this.comboBoxPayload.Items.AddRange(new object[] {
            "Custom"});
            this.comboBoxPayload.Location = new System.Drawing.Point(276, 3);
            this.comboBoxPayload.Name = "comboBoxPayload";
            this.comboBoxPayload.Size = new System.Drawing.Size(221, 21);
            this.comboBoxPayload.TabIndex = 1;
            this.comboBoxPayload.SelectedIndexChanged += new System.EventHandler(this.comboPayload_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zararlı Kodlar :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelInterfaceSelection
            // 
            this.panelInterfaceSelection.Controls.Add(this.comboBoxInterface);
            this.panelInterfaceSelection.Controls.Add(this.label5);
            this.panelInterfaceSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInterfaceSelection.Location = new System.Drawing.Point(0, 0);
            this.panelInterfaceSelection.Name = "panelInterfaceSelection";
            this.panelInterfaceSelection.Size = new System.Drawing.Size(771, 30);
            this.panelInterfaceSelection.TabIndex = 4;
            // 
            // comboBoxInterface
            // 
            this.comboBoxInterface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.comboBoxInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInterface.ForeColor = System.Drawing.Color.Red;
            this.comboBoxInterface.FormattingEnabled = true;
            this.comboBoxInterface.Items.AddRange(new object[] {
            "Custom"});
            this.comboBoxInterface.Location = new System.Drawing.Point(142, 5);
            this.comboBoxInterface.Name = "comboBoxInterface";
            this.comboBoxInterface.Size = new System.Drawing.Size(378, 21);
            this.comboBoxInterface.TabIndex = 1;
            this.comboBoxInterface.SelectedIndexChanged += new System.EventHandler(this.comboInterface_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Özel Yazılım :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelResultCode
            // 
            this.panelResultCode.Location = new System.Drawing.Point(4, 3);
            this.panelResultCode.Name = "panelResultCode";
            this.panelResultCode.Size = new System.Drawing.Size(778, 488);
            this.panelResultCode.TabIndex = 13;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(3, 573);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(794, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // visualStudioTabControl1
            // 
            this.visualStudioTabControl1.ActiveColor = System.Drawing.Color.Red;
            this.visualStudioTabControl1.AllowDrop = true;
            this.visualStudioTabControl1.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.visualStudioTabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.visualStudioTabControl1.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.visualStudioTabControl1.ClosingMessage = null;
            this.visualStudioTabControl1.Controls.Add(this.tabPPayload);
            this.visualStudioTabControl1.Controls.Add(this.tabPInterface);
            this.visualStudioTabControl1.Controls.Add(this.tabPAdditions);
            this.visualStudioTabControl1.Controls.Add(this.tabPCompileCode);
            this.visualStudioTabControl1.Controls.Add(this.tabPCompileResult);
            this.visualStudioTabControl1.Controls.Add(this.tabPCryption);
            this.visualStudioTabControl1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.visualStudioTabControl1.HorizontalLineColor = System.Drawing.Color.Red;
            this.visualStudioTabControl1.ItemSize = new System.Drawing.Size(240, 16);
            this.visualStudioTabControl1.Location = new System.Drawing.Point(2, 54);
            this.visualStudioTabControl1.Name = "visualStudioTabControl1";
            this.visualStudioTabControl1.SelectedIndex = 0;
            this.visualStudioTabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.visualStudioTabControl1.ShowClosingButton = false;
            this.visualStudioTabControl1.ShowClosingMessage = false;
            this.visualStudioTabControl1.Size = new System.Drawing.Size(796, 517);
            this.visualStudioTabControl1.TabIndex = 16;
            this.visualStudioTabControl1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // tabPPayload
            // 
            this.tabPPayload.AutoScroll = true;
            this.tabPPayload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPPayload.Controls.Add(this.panel1);
            this.tabPPayload.Controls.Add(this.panelPayloadCryption);
            this.tabPPayload.Controls.Add(this.panelPaylodCode);
            this.tabPPayload.Controls.Add(this.panel2);
            this.tabPPayload.Controls.Add(this.panelPayloadSelection);
            this.tabPPayload.Location = new System.Drawing.Point(4, 20);
            this.tabPPayload.Name = "tabPPayload";
            this.tabPPayload.Size = new System.Drawing.Size(788, 493);
            this.tabPPayload.TabIndex = 0;
            this.tabPPayload.Text = "Payload";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxPayloadComp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 36);
            this.panel1.TabIndex = 16;
            // 
            // checkBoxPayloadComp
            // 
            this.checkBoxPayloadComp.AutoSize = true;
            this.checkBoxPayloadComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPayloadComp.Location = new System.Drawing.Point(6, 9);
            this.checkBoxPayloadComp.Name = "checkBoxPayloadComp";
            this.checkBoxPayloadComp.Size = new System.Drawing.Size(290, 17);
            this.checkBoxPayloadComp.TabIndex = 1;
            this.checkBoxPayloadComp.Text = "Payloadı derleyip çalıştıralım.(Hata var mı kontrol edersin.)";
            this.checkBoxPayloadComp.UseVisualStyleBackColor = true;
            // 
            // panelPayloadCryption
            // 
            this.panelPayloadCryption.Controls.Add(this.btnRandomPass);
            this.panelPayloadCryption.Controls.Add(this.txtPrivKey);
            this.panelPayloadCryption.Controls.Add(this.label3);
            this.panelPayloadCryption.Controls.Add(this.comboBoxCryptionMethod);
            this.panelPayloadCryption.Controls.Add(this.label2);
            this.panelPayloadCryption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPayloadCryption.Location = new System.Drawing.Point(0, 398);
            this.panelPayloadCryption.Name = "panelPayloadCryption";
            this.panelPayloadCryption.Size = new System.Drawing.Size(788, 27);
            this.panelPayloadCryption.TabIndex = 15;
            // 
            // btnRandomPass
            // 
            this.btnRandomPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomPass.Location = new System.Drawing.Point(745, 2);
            this.btnRandomPass.Name = "btnRandomPass";
            this.btnRandomPass.Size = new System.Drawing.Size(40, 22);
            this.btnRandomPass.TabIndex = 0;
            this.btnRandomPass.Text = "R";
            this.btnRandomPass.UseVisualStyleBackColor = true;
            this.btnRandomPass.Click += new System.EventHandler(this.btnRandomPass_Click);
            // 
            // txtPrivKey
            // 
            this.txtPrivKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtPrivKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrivKey.ForeColor = System.Drawing.Color.Red;
            this.txtPrivKey.Location = new System.Drawing.Point(532, 2);
            this.txtPrivKey.Name = "txtPrivKey";
            this.txtPrivKey.Size = new System.Drawing.Size(212, 20);
            this.txtPrivKey.TabIndex = 4;
            this.txtPrivKey.Text = "12345678";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(405, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Private Key :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCryptionMethod
            // 
            this.comboBoxCryptionMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.comboBoxCryptionMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCryptionMethod.ForeColor = System.Drawing.Color.Red;
            this.comboBoxCryptionMethod.FormattingEnabled = true;
            this.comboBoxCryptionMethod.Items.AddRange(new object[] {
            "DES",
            "tripleDES"});
            this.comboBoxCryptionMethod.Location = new System.Drawing.Point(142, 3);
            this.comboBoxCryptionMethod.Name = "comboBoxCryptionMethod";
            this.comboBoxCryptionMethod.Size = new System.Drawing.Size(260, 21);
            this.comboBoxCryptionMethod.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifreleme Yöntemi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPaylodCode
            // 
            this.panelPaylodCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaylodCode.Location = new System.Drawing.Point(0, 55);
            this.panelPaylodCode.Name = "panelPaylodCode";
            this.panelPaylodCode.Size = new System.Drawing.Size(788, 343);
            this.panelPaylodCode.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownPort);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 28);
            this.panel2.TabIndex = 9;
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.numericUpDownPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownPort.ForeColor = System.Drawing.Color.Red;
            this.numericUpDownPort.Location = new System.Drawing.Point(483, 5);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPort.TabIndex = 3;
            this.numericUpDownPort.Value = new decimal(new int[] {
            444,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(377, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Port :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.ForeColor = System.Drawing.Color.Red;
            this.txtAddress.Location = new System.Drawing.Point(112, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(259, 20);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPInterface
            // 
            this.tabPInterface.AutoScroll = true;
            this.tabPInterface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPInterface.Controls.Add(this.panelInterfaceAdditions);
            this.tabPInterface.Controls.Add(this.panelInterfaceCode);
            this.tabPInterface.Controls.Add(this.panelInterfaceSelection);
            this.tabPInterface.Location = new System.Drawing.Point(4, 20);
            this.tabPInterface.Name = "tabPInterface";
            this.tabPInterface.Size = new System.Drawing.Size(788, 493);
            this.tabPInterface.TabIndex = 1;
            this.tabPInterface.Text = "Arayüz";
            // 
            // panelInterfaceAdditions
            // 
            this.panelInterfaceAdditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInterfaceAdditions.Location = new System.Drawing.Point(0, 486);
            this.panelInterfaceAdditions.Name = "panelInterfaceAdditions";
            this.panelInterfaceAdditions.Size = new System.Drawing.Size(771, 32);
            this.panelInterfaceAdditions.TabIndex = 17;
            // 
            // panelInterfaceCode
            // 
            this.panelInterfaceCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInterfaceCode.Location = new System.Drawing.Point(0, 30);
            this.panelInterfaceCode.Name = "panelInterfaceCode";
            this.panelInterfaceCode.Size = new System.Drawing.Size(771, 456);
            this.panelInterfaceCode.TabIndex = 16;
            // 
            // tabPAdditions
            // 
            this.tabPAdditions.AutoScroll = true;
            this.tabPAdditions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPAdditions.Location = new System.Drawing.Point(4, 20);
            this.tabPAdditions.Name = "tabPAdditions";
            this.tabPAdditions.Size = new System.Drawing.Size(788, 493);
            this.tabPAdditions.TabIndex = 2;
            this.tabPAdditions.Text = "Eklenti";
            // 
            // tabPCompileCode
            // 
            this.tabPCompileCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPCompileCode.Controls.Add(this.panelResultCode);
            this.tabPCompileCode.Location = new System.Drawing.Point(4, 20);
            this.tabPCompileCode.Name = "tabPCompileCode";
            this.tabPCompileCode.Size = new System.Drawing.Size(788, 493);
            this.tabPCompileCode.TabIndex = 3;
            this.tabPCompileCode.Text = "Çıktı";
            // 
            // tabPCompileResult
            // 
            this.tabPCompileResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPCompileResult.Controls.Add(this.richTextBoxCompileResult);
            this.tabPCompileResult.Location = new System.Drawing.Point(4, 20);
            this.tabPCompileResult.Name = "tabPCompileResult";
            this.tabPCompileResult.Size = new System.Drawing.Size(788, 493);
            this.tabPCompileResult.TabIndex = 4;
            this.tabPCompileResult.Text = "Derleme";
            // 
            // richTextBoxCompileResult
            // 
            this.richTextBoxCompileResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.richTextBoxCompileResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCompileResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxCompileResult.ForeColor = System.Drawing.Color.Red;
            this.richTextBoxCompileResult.Location = new System.Drawing.Point(6, 3);
            this.richTextBoxCompileResult.Name = "richTextBoxCompileResult";
            this.richTextBoxCompileResult.ReadOnly = true;
            this.richTextBoxCompileResult.Size = new System.Drawing.Size(776, 488);
            this.richTextBoxCompileResult.TabIndex = 0;
            this.richTextBoxCompileResult.Text = "";
            // 
            // tabPCryption
            // 
            this.tabPCryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPCryption.Controls.Add(this.richTextBoxCryptionResult);
            this.tabPCryption.Controls.Add(this.btnDescryption);
            this.tabPCryption.Controls.Add(this.label8);
            this.tabPCryption.Controls.Add(this.btnEncryption);
            this.tabPCryption.Controls.Add(this.txtCryptionPass);
            this.tabPCryption.Controls.Add(this.richTextBoxCryption);
            this.tabPCryption.Location = new System.Drawing.Point(4, 20);
            this.tabPCryption.Name = "tabPCryption";
            this.tabPCryption.Size = new System.Drawing.Size(788, 493);
            this.tabPCryption.TabIndex = 5;
            this.tabPCryption.Text = "Şifreleme";
            // 
            // richTextBoxCryptionResult
            // 
            this.richTextBoxCryptionResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.richTextBoxCryptionResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxCryptionResult.ForeColor = System.Drawing.Color.Red;
            this.richTextBoxCryptionResult.Location = new System.Drawing.Point(6, 207);
            this.richTextBoxCryptionResult.Name = "richTextBoxCryptionResult";
            this.richTextBoxCryptionResult.Size = new System.Drawing.Size(776, 176);
            this.richTextBoxCryptionResult.TabIndex = 6;
            this.richTextBoxCryptionResult.Text = "";
            // 
            // btnDescryption
            // 
            this.btnDescryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescryption.Location = new System.Drawing.Point(456, 182);
            this.btnDescryption.Name = "btnDescryption";
            this.btnDescryption.Size = new System.Drawing.Size(89, 23);
            this.btnDescryption.TabIndex = 5;
            this.btnDescryption.Text = "Çöz";
            this.btnDescryption.UseVisualStyleBackColor = true;
            this.btnDescryption.Click += new System.EventHandler(this.btnDescryption_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Şifre :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEncryption
            // 
            this.btnEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryption.Location = new System.Drawing.Point(370, 182);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(85, 23);
            this.btnEncryption.TabIndex = 3;
            this.btnEncryption.Text = "Şifrele";
            this.btnEncryption.UseVisualStyleBackColor = true;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // txtCryptionPass
            // 
            this.txtCryptionPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtCryptionPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCryptionPass.ForeColor = System.Drawing.Color.Red;
            this.txtCryptionPass.Location = new System.Drawing.Point(155, 183);
            this.txtCryptionPass.Name = "txtCryptionPass";
            this.txtCryptionPass.Size = new System.Drawing.Size(214, 20);
            this.txtCryptionPass.TabIndex = 1;
            // 
            // richTextBoxCryption
            // 
            this.richTextBoxCryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.richTextBoxCryption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxCryption.ForeColor = System.Drawing.Color.Red;
            this.richTextBoxCryption.Location = new System.Drawing.Point(6, 3);
            this.richTextBoxCryption.Name = "richTextBoxCryption";
            this.richTextBoxCryption.Size = new System.Drawing.Size(776, 176);
            this.richTextBoxCryption.TabIndex = 0;
            this.richTextBoxCryption.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(722, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 20);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(55, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(661, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "               YK-47 Projesi ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.visualStudioTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreate);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YK-47 Custom Project Ver:1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPayloadSelection.ResumeLayout(false);
            this.panelInterfaceSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.visualStudioTabControl1.ResumeLayout(false);
            this.tabPPayload.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPayloadCryption.ResumeLayout(false);
            this.panelPayloadCryption.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.tabPInterface.ResumeLayout(false);
            this.tabPCompileCode.ResumeLayout(false);
            this.tabPCompileResult.ResumeLayout(false);
            this.tabPCryption.ResumeLayout(false);
            this.tabPCryption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPayloadSelection;
        private System.Windows.Forms.ComboBox comboBoxPayload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInterfaceSelection;
        private System.Windows.Forms.ComboBox comboBoxInterface;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelResultCode;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox comboBoxPayloadStyle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VisualStudioTabControl.VisualStudioTabControl visualStudioTabControl1;
        private System.Windows.Forms.TabPage tabPPayload;
        private System.Windows.Forms.TabPage tabPInterface;
        private System.Windows.Forms.TabPage tabPAdditions;
        private System.Windows.Forms.TabPage tabPCompileCode;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabPCompileResult;
        private System.Windows.Forms.RichTextBox richTextBoxCompileResult;
        private System.Windows.Forms.Panel panelInterfaceCode;
        private System.Windows.Forms.Panel panelInterfaceAdditions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPCryption;
        private System.Windows.Forms.Button btnDescryption;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.TextBox txtCryptionPass;
        private System.Windows.Forms.RichTextBox richTextBoxCryption;
        private System.Windows.Forms.RichTextBox richTextBoxCryptionResult;
        private System.Windows.Forms.Panel panelPayloadCryption;
        private System.Windows.Forms.Button btnRandomPass;
        private System.Windows.Forms.TextBox txtPrivKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCryptionMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPaylodCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxPayloadComp;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
    }
}

