namespace _04_StudentProject
{
    partial class FormStudentAdd
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
            this.lblKullanici = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBolum = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdbtnErkek = new System.Windows.Forms.RadioButton();
            this.rdbtnKadın = new System.Windows.Forms.RadioButton();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResimYukle = new System.Windows.Forms.Button();
            this.txtResimYukle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(26, 19);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 15);
            this.lblKullanici.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBolum);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.rdbtnErkek);
            this.groupBox1.Controls.Add(this.rdbtnKadın);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblCinsiyet);
            this.groupBox1.Location = new System.Drawing.Point(26, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(21, 170);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(42, 15);
            this.lblBolum.TabIndex = 8;
            this.lblBolum.Text = "Bölüm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // rdbtnErkek
            // 
            this.rdbtnErkek.AutoSize = true;
            this.rdbtnErkek.Location = new System.Drawing.Point(228, 122);
            this.rdbtnErkek.Name = "rdbtnErkek";
            this.rdbtnErkek.Size = new System.Drawing.Size(53, 19);
            this.rdbtnErkek.TabIndex = 14;
            this.rdbtnErkek.TabStop = true;
            this.rdbtnErkek.Text = "Erkek";
            this.rdbtnErkek.UseVisualStyleBackColor = true;
            // 
            // rdbtnKadın
            // 
            this.rdbtnKadın.AutoSize = true;
            this.rdbtnKadın.Location = new System.Drawing.Point(128, 122);
            this.rdbtnKadın.Name = "rdbtnKadın";
            this.rdbtnKadın.Size = new System.Drawing.Size(55, 19);
            this.rdbtnKadın.TabIndex = 13;
            this.rdbtnKadın.TabStop = true;
            this.rdbtnKadın.Text = "Kadın";
            this.rdbtnKadın.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(128, 51);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(148, 23);
            this.txtAd.TabIndex = 12;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(128, 80);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(148, 23);
            this.txtSoyad.TabIndex = 11;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(20, 51);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 15);
            this.lblAd.TabIndex = 8;
            this.lblAd.Text = "Adı";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(20, 86);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(39, 15);
            this.lblSoyad.TabIndex = 9;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(20, 126);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(49, 15);
            this.lblCinsiyet.TabIndex = 10;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResimYukle);
            this.groupBox2.Controls.Add(this.txtResimYukle);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(402, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 259);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Resim Yükle";
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.Location = new System.Drawing.Point(247, 204);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(75, 23);
            this.btnResimYukle.TabIndex = 2;
            this.btnResimYukle.Text = "Yükle";
            this.btnResimYukle.UseVisualStyleBackColor = true;
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // txtResimYukle
            // 
            this.txtResimYukle.Location = new System.Drawing.Point(21, 204);
            this.txtResimYukle.Name = "txtResimYukle";
            this.txtResimYukle.Size = new System.Drawing.Size(210, 23);
            this.txtResimYukle.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(100, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(254, 387);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(130, 23);
            this.btnGoster.TabIndex = 5;
            this.btnGoster.Text = "Öğrencileri Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(26, 387);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(145, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Öğrenci Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 342);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(276, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Yukarıdaki bilgilerin doğruluğunu onaylıyorum.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormStudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKullanici);
            this.Name = "FormStudentAdd";
            this.Text = "FormStudentAdd";
            this.Load += new System.EventHandler(this.FormStudentAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKullanici;
        private GroupBox groupBox1;
        private Label lblBolum;
        private ComboBox comboBox1;
        private RadioButton rdbtnErkek;
        private RadioButton rdbtnKadın;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblCinsiyet;
        private GroupBox groupBox2;
        private Button btnResimYukle;
        private TextBox txtResimYukle;
        private PictureBox pictureBox1;
        private Button btnGoster;
        private Button btnKaydet;
        private CheckBox checkBox1;
        private OpenFileDialog openFileDialog1;
    }
}