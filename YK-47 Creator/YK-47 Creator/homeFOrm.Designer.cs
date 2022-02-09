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
            this.comboPayloadStyle = new System.Windows.Forms.ComboBox();
            this.comboPayload = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPaylodCode = new System.Windows.Forms.Panel();
            this.panelPayloadCryption = new System.Windows.Forms.Panel();
            this.btnRandomPass = new System.Windows.Forms.Button();
            this.txtPubKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrivKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCryptionMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelProjectSelection = new System.Windows.Forms.Panel();
            this.comboSkin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelResultCode = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panelProjectCode = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.visualStudioTabControl1 = new VisualStudioTabControl.VisualStudioTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelCompilerCode = new System.Windows.Forms.Panel();
            this.panelCryptionCode = new System.Windows.Forms.Panel();
            this.panelPayloadSelection.SuspendLayout();
            this.panelPayloadCryption.SuspendLayout();
            this.panelProjectSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.visualStudioTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPayloadSelection
            // 
            this.panelPayloadSelection.Controls.Add(this.comboPayloadStyle);
            this.panelPayloadSelection.Controls.Add(this.comboPayload);
            this.panelPayloadSelection.Controls.Add(this.label1);
            this.panelPayloadSelection.Location = new System.Drawing.Point(6, 3);
            this.panelPayloadSelection.Name = "panelPayloadSelection";
            this.panelPayloadSelection.Size = new System.Drawing.Size(776, 27);
            this.panelPayloadSelection.TabIndex = 0;
            // 
            // comboPayloadStyle
            // 
            this.comboPayloadStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.comboPayloadStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPayloadStyle.ForeColor = System.Drawing.Color.Red;
            this.comboPayloadStyle.FormattingEnabled = true;
            this.comboPayloadStyle.Location = new System.Drawing.Point(142, 3);
            this.comboPayloadStyle.Name = "comboPayloadStyle";
            this.comboPayloadStyle.Size = new System.Drawing.Size(128, 21);
            this.comboPayloadStyle.TabIndex = 2;
            this.comboPayloadStyle.SelectedIndexChanged += new System.EventHandler(this.comboPayloadStyle_SelectedIndexChanged);
            // 
            // comboPayload
            // 
            this.comboPayload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.comboPayload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPayload.ForeColor = System.Drawing.Color.Red;
            this.comboPayload.FormattingEnabled = true;
            this.comboPayload.Items.AddRange(new object[] {
            "Custom"});
            this.comboPayload.Location = new System.Drawing.Point(276, 3);
            this.comboPayload.Name = "comboPayload";
            this.comboPayload.Size = new System.Drawing.Size(221, 21);
            this.comboPayload.TabIndex = 1;
            this.comboPayload.SelectedIndexChanged += new System.EventHandler(this.comboPayload_SelectedIndexChanged);
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
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(776, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Adres ve porta manuel olarak alt taraftaki kodlardan müdahele ediniz.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPaylodCode
            // 
            this.panelPaylodCode.Location = new System.Drawing.Point(6, 57);
            this.panelPaylodCode.Name = "panelPaylodCode";
            this.panelPaylodCode.Size = new System.Drawing.Size(776, 375);
            this.panelPaylodCode.TabIndex = 2;
            // 
            // panelPayloadCryption
            // 
            this.panelPayloadCryption.Controls.Add(this.btnRandomPass);
            this.panelPayloadCryption.Controls.Add(this.txtPubKey);
            this.panelPayloadCryption.Controls.Add(this.label4);
            this.panelPayloadCryption.Controls.Add(this.txtPrivKey);
            this.panelPayloadCryption.Controls.Add(this.label3);
            this.panelPayloadCryption.Controls.Add(this.comboCryptionMethod);
            this.panelPayloadCryption.Controls.Add(this.label2);
            this.panelPayloadCryption.Location = new System.Drawing.Point(6, 434);
            this.panelPayloadCryption.Name = "panelPayloadCryption";
            this.panelPayloadCryption.Size = new System.Drawing.Size(776, 52);
            this.panelPayloadCryption.TabIndex = 3;
            // 
            // btnRandomPass
            // 
            this.btnRandomPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomPass.Location = new System.Drawing.Point(749, 2);
            this.btnRandomPass.Name = "btnRandomPass";
            this.btnRandomPass.Size = new System.Drawing.Size(27, 23);
            this.btnRandomPass.TabIndex = 0;
            this.btnRandomPass.Text = "R";
            this.btnRandomPass.UseVisualStyleBackColor = true;
            this.btnRandomPass.Click += new System.EventHandler(this.btnRandomPass_Click);
            // 
            // txtPubKey
            // 
            this.txtPubKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtPubKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPubKey.ForeColor = System.Drawing.Color.Red;
            this.txtPubKey.Location = new System.Drawing.Point(534, 29);
            this.txtPubKey.Name = "txtPubKey";
            this.txtPubKey.PasswordChar = '*';
            this.txtPubKey.Size = new System.Drawing.Size(212, 20);
            this.txtPubKey.TabIndex = 7;
            this.txtPubKey.Text = "12345678";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(404, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Public Key :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrivKey
            // 
            this.txtPrivKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtPrivKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrivKey.ForeColor = System.Drawing.Color.Red;
            this.txtPrivKey.Location = new System.Drawing.Point(534, 3);
            this.txtPrivKey.Name = "txtPrivKey";
            this.txtPrivKey.PasswordChar = '*';
            this.txtPrivKey.Size = new System.Drawing.Size(212, 20);
            this.txtPrivKey.TabIndex = 4;
            this.txtPrivKey.Text = "12345678";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(407, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Private Key :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboCryptionMethod
            // 
            this.comboCryptionMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.comboCryptionMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCryptionMethod.ForeColor = System.Drawing.Color.Red;
            this.comboCryptionMethod.FormattingEnabled = true;
            this.comboCryptionMethod.Items.AddRange(new object[] {
            "DES",
            "tripleDES"});
            this.comboCryptionMethod.Location = new System.Drawing.Point(142, 3);
            this.comboCryptionMethod.Name = "comboCryptionMethod";
            this.comboCryptionMethod.Size = new System.Drawing.Size(259, 21);
            this.comboCryptionMethod.TabIndex = 4;
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
            // panelProjectSelection
            // 
            this.panelProjectSelection.Controls.Add(this.comboSkin);
            this.panelProjectSelection.Controls.Add(this.label5);
            this.panelProjectSelection.Location = new System.Drawing.Point(4, 3);
            this.panelProjectSelection.Name = "panelProjectSelection";
            this.panelProjectSelection.Size = new System.Drawing.Size(778, 30);
            this.panelProjectSelection.TabIndex = 4;
            // 
            // comboSkin
            // 
            this.comboSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.comboSkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSkin.ForeColor = System.Drawing.Color.Red;
            this.comboSkin.FormattingEnabled = true;
            this.comboSkin.Items.AddRange(new object[] {
            "Custom"});
            this.comboSkin.Location = new System.Drawing.Point(142, 5);
            this.comboSkin.Name = "comboSkin";
            this.comboSkin.Size = new System.Drawing.Size(378, 21);
            this.comboSkin.TabIndex = 1;
            this.comboSkin.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
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
            this.btnCreate.Location = new System.Drawing.Point(3, 574);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(794, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panelProjectCode
            // 
            this.panelProjectCode.Location = new System.Drawing.Point(4, 35);
            this.panelProjectCode.Name = "panelProjectCode";
            this.panelProjectCode.Size = new System.Drawing.Size(778, 456);
            this.panelProjectCode.TabIndex = 15;
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
            this.visualStudioTabControl1.Controls.Add(this.tabPage1);
            this.visualStudioTabControl1.Controls.Add(this.tabPage2);
            this.visualStudioTabControl1.Controls.Add(this.tabPage3);
            this.visualStudioTabControl1.Controls.Add(this.tabPage4);
            this.visualStudioTabControl1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.visualStudioTabControl1.HorizontalLineColor = System.Drawing.Color.Red;
            this.visualStudioTabControl1.ItemSize = new System.Drawing.Size(240, 16);
            this.visualStudioTabControl1.Location = new System.Drawing.Point(2, 53);
            this.visualStudioTabControl1.Name = "visualStudioTabControl1";
            this.visualStudioTabControl1.SelectedIndex = 0;
            this.visualStudioTabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.visualStudioTabControl1.ShowClosingButton = false;
            this.visualStudioTabControl1.ShowClosingMessage = false;
            this.visualStudioTabControl1.Size = new System.Drawing.Size(796, 518);
            this.visualStudioTabControl1.TabIndex = 16;
            this.visualStudioTabControl1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPage1.Controls.Add(this.panelPayloadCryption);
            this.tabPage1.Controls.Add(this.panelPayloadSelection);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.panelPaylodCode);
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(788, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Payload";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPage2.Controls.Add(this.panelProjectSelection);
            this.tabPage2.Controls.Add(this.panelProjectCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(788, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ana Yazılım";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPage3.Controls.Add(this.panelCryptionCode);
            this.tabPage3.Controls.Add(this.panelCompilerCode);
            this.tabPage3.Location = new System.Drawing.Point(4, 20);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(788, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eklenti";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPage4.Controls.Add(this.panelResultCode);
            this.tabPage4.Location = new System.Drawing.Point(4, 20);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(788, 494);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Çıktı";
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
            // panelCompilerCode
            // 
            this.panelCompilerCode.Location = new System.Drawing.Point(6, 3);
            this.panelCompilerCode.Name = "panelCompilerCode";
            this.panelCompilerCode.Size = new System.Drawing.Size(776, 147);
            this.panelCompilerCode.TabIndex = 0;
            // 
            // panelCryptionCode
            // 
            this.panelCryptionCode.Location = new System.Drawing.Point(6, 151);
            this.panelCryptionCode.Name = "panelCryptionCode";
            this.panelCryptionCode.Size = new System.Drawing.Size(776, 172);
            this.panelCryptionCode.TabIndex = 1;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
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
            this.panelPayloadCryption.ResumeLayout(false);
            this.panelPayloadCryption.PerformLayout();
            this.panelProjectSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.visualStudioTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPayloadSelection;
        private System.Windows.Forms.ComboBox comboPayload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPaylodCode;
        private System.Windows.Forms.Panel panelPayloadCryption;
        private System.Windows.Forms.TextBox txtPubKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrivKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCryptionMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelProjectSelection;
        private System.Windows.Forms.ComboBox comboSkin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelResultCode;
        private System.Windows.Forms.Button btnRandomPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panelProjectCode;
        private System.Windows.Forms.ComboBox comboPayloadStyle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VisualStudioTabControl.VisualStudioTabControl visualStudioTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelCompilerCode;
        private System.Windows.Forms.Panel panelCryptionCode;
    }
}

