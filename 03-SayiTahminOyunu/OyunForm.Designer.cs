namespace _03_SayiTahminOyunu
{
    partial class OyunForm
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
            this.components = new System.ComponentModel.Container();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.ForeColor = System.Drawing.Color.Black;
            this.lblKullanici.Location = new System.Drawing.Point(31, 21);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 15);
            this.lblKullanici.TabIndex = 0;
            // 
            // btnBasla
            // 
            this.btnBasla.ForeColor = System.Drawing.Color.Black;
            this.btnBasla.Location = new System.Drawing.Point(31, 84);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(459, 47);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Oyunu Başlat";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMesaj);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btnTahmin);
            this.panel1.Controls.Add(this.txtTahmin);
            this.panel1.Controls.Add(this.lblTahmin);
            this.panel1.Controls.Add(this.lblBilgi);
            this.panel1.Location = new System.Drawing.Point(31, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 293);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.ForeColor = System.Drawing.Color.Black;
            this.lblMesaj.Location = new System.Drawing.Point(27, 199);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(41, 15);
            this.lblMesaj.TabIndex = 5;
            this.lblMesaj.Text = "Mesaj:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 149);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(414, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 100;
            // 
            // btnTahmin
            // 
            this.btnTahmin.BackColor = System.Drawing.Color.White;
            this.btnTahmin.ForeColor = System.Drawing.Color.Black;
            this.btnTahmin.Location = new System.Drawing.Point(27, 62);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(414, 23);
            this.btnTahmin.TabIndex = 3;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = false;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(240, 22);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(201, 23);
            this.txtTahmin.TabIndex = 2;
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTahmin.Location = new System.Drawing.Point(27, 25);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(207, 15);
            this.lblTahmin.TabIndex = 1;
            this.lblTahmin.Text = "1 - 100 arasında bir sayı tahmin ediniz:";
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.ForeColor = System.Drawing.Color.Crimson;
            this.lblBilgi.Location = new System.Drawing.Point(27, 107);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(33, 15);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = "Bilgi:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblKullanici);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "OyunForm";
            this.Text = "OyunForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKullanici;
        private Button btnBasla;
        private Panel panel1;
        private Label lblTahmin;
        private Label lblBilgi;
        private Label lblMesaj;
        private ProgressBar progressBar1;
        private Button btnTahmin;
        private TextBox txtTahmin;
        private System.Windows.Forms.Timer timer1;
        //private Label lblKullanici;
        //private Button btnBasla;
        //private Panel panel1;
        //private Label lblMesaj;
        //private ProgressBar prgBarBilgi;
        //private Label lblBilgi;
        //private Button btnTahminEt;
        //private TextBox txtTahmin;
        //private Label label2;
    }
}