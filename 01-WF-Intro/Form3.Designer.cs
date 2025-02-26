namespace _01_WF_Intro
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnKadin = new System.Windows.Forms.RadioButton();
            this.rdbtnErkek = new System.Windows.Forms.RadioButton();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.nudYas = new System.Windows.Forms.NumericUpDown();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAcikAdres = new System.Windows.Forms.TextBox();
            this.lblAcikAdres = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLiseAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbUniversiteler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxMaster = new System.Windows.Forms.ComboBox();
            this.chbxOnay = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnKadin);
            this.groupBox1.Controls.Add(this.rdbtnErkek);
            this.groupBox1.Controls.Add(this.lblCinsiyet);
            this.groupBox1.Controls.Add(this.nudYas);
            this.groupBox1.Controls.Add(this.lblYas);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(290, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kisisel Bilgiler";
            // 
            // rdbtnKadin
            // 
            this.rdbtnKadin.AutoSize = true;
            this.rdbtnKadin.Location = new System.Drawing.Point(188, 82);
            this.rdbtnKadin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbtnKadin.Name = "rdbtnKadin";
            this.rdbtnKadin.Size = new System.Drawing.Size(55, 19);
            this.rdbtnKadin.TabIndex = 5;
            this.rdbtnKadin.Text = "Kadın";
            this.rdbtnKadin.UseVisualStyleBackColor = true;
            // 
            // rdbtnErkek
            // 
            this.rdbtnErkek.AutoSize = true;
            this.rdbtnErkek.Checked = true;
            this.rdbtnErkek.Location = new System.Drawing.Point(85, 81);
            this.rdbtnErkek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbtnErkek.Name = "rdbtnErkek";
            this.rdbtnErkek.Size = new System.Drawing.Size(53, 19);
            this.rdbtnErkek.TabIndex = 5;
            this.rdbtnErkek.TabStop = true;
            this.rdbtnErkek.Text = "Erkek";
            this.rdbtnErkek.UseVisualStyleBackColor = true;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(14, 82);
            this.lblCinsiyet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(52, 15);
            this.lblCinsiyet.TabIndex = 4;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // nudYas
            // 
            this.nudYas.Location = new System.Drawing.Point(85, 51);
            this.nudYas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudYas.Name = "nudYas";
            this.nudYas.Size = new System.Drawing.Size(97, 23);
            this.nudYas.TabIndex = 3;
            this.nudYas.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(16, 55);
            this.lblYas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(27, 15);
            this.lblYas.TabIndex = 2;
            this.lblYas.Text = "Yaş:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(9, 23);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(66, 15);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Adı Soyadı:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(85, 23);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(196, 23);
            this.txtAdSoyad.TabIndex = 0;
            this.txtAdSoyad.Text = "zafer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAcikAdres);
            this.groupBox2.Controls.Add(this.lblAcikAdres);
            this.groupBox2.Location = new System.Drawing.Point(8, 113);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(288, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres Bilgileri";
            // 
            // txtAcikAdres
            // 
            this.txtAcikAdres.Location = new System.Drawing.Point(83, 20);
            this.txtAcikAdres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAcikAdres.Multiline = true;
            this.txtAcikAdres.Name = "txtAcikAdres";
            this.txtAcikAdres.Size = new System.Drawing.Size(195, 56);
            this.txtAcikAdres.TabIndex = 1;
            this.txtAcikAdres.Text = "Bakırköy";
            // 
            // lblAcikAdres
            // 
            this.lblAcikAdres.AutoSize = true;
            this.lblAcikAdres.Location = new System.Drawing.Point(8, 22);
            this.lblAcikAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcikAdres.Name = "lblAcikAdres";
            this.lblAcikAdres.Size = new System.Drawing.Size(66, 15);
            this.lblAcikAdres.TabIndex = 0;
            this.lblAcikAdres.Text = "Açık Adres:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(76, 314);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(184, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(316, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 293);
            this.panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(8, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 274);
            this.listBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 203);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(272, 77);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.txtLiseAdi);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(264, 49);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lise Bilgileri";
            // 
            // txtLiseAdi
            // 
            this.txtLiseAdi.Location = new System.Drawing.Point(85, 19);
            this.txtLiseAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLiseAdi.Name = "txtLiseAdi";
            this.txtLiseAdi.Size = new System.Drawing.Size(159, 23);
            this.txtLiseAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lise Adı:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Red;
            this.tabPage2.Controls.Add(this.cmbUniversiteler);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(264, 49);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Üniversite";
            // 
            // cmbUniversiteler
            // 
            this.cmbUniversiteler.FormattingEnabled = true;
            this.cmbUniversiteler.Items.AddRange(new object[] {
            "İstanbul Teknik Üniversitesi",
            "ODTÜ",
            "YTÜ",
            "Işık",
            "Nişantaşı",
            "Beykent",
            "Atlas"});
            this.cmbUniversiteler.Location = new System.Drawing.Point(102, 19);
            this.cmbUniversiteler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUniversiteler.Name = "cmbUniversiteler";
            this.cmbUniversiteler.Size = new System.Drawing.Size(158, 23);
            this.cmbUniversiteler.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Üniversite Adı:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cmbxMaster);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(264, 49);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Master";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Üniversite";
            // 
            // cmbxMaster
            // 
            this.cmbxMaster.FormattingEnabled = true;
            this.cmbxMaster.Location = new System.Drawing.Point(92, 16);
            this.cmbxMaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbxMaster.Name = "cmbxMaster";
            this.cmbxMaster.Size = new System.Drawing.Size(164, 23);
            this.cmbxMaster.TabIndex = 0;
            // 
            // chbxOnay
            // 
            this.chbxOnay.AutoSize = true;
            this.chbxOnay.Location = new System.Drawing.Point(18, 288);
            this.chbxOnay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbxOnay.Name = "chbxOnay";
            this.chbxOnay.Size = new System.Drawing.Size(276, 19);
            this.chbxOnay.TabIndex = 5;
            this.chbxOnay.Text = "Yukarıdaki bilgilerin doğruluğunu onaylıyorum.";
            this.chbxOnay.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 347);
            this.Controls.Add(this.chbxOnay);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "FrmKullaniciKaydet";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAdSoyad;
        private TextBox txtAdSoyad;
        private Label lblYas;
        private NumericUpDown nudYas;
        private RadioButton rdbtnKadin;
        private RadioButton rdbtnErkek;
        private Label lblCinsiyet;
        private GroupBox groupBox2;
        private TextBox txtAcikAdres;
        private Label lblAcikAdres;
        private Button btnKaydet;
        private Panel panel1;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtLiseAdi;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox cmbUniversiteler;
        private Label label2;
        private CheckBox chbxOnay;
        private Label label3;
        private ComboBox cmbxMaster;
    }
}