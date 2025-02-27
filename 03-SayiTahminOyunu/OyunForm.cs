using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_SayiTahminOyunu
{
    public partial class OyunForm : Form
    {
        public OyunForm()
        {
            InitializeComponent();
        }

        //private void btnBasla_Click(object sender, EventArgs e)
        //{
        //    LoginForm loginForm = new LoginForm();
        //    loginForm.ShowDialog();

        //    if (loginForm.GetName(out string name)) // burada oluşturulan name getname e gönderiliyor. ve orada kontrol ediliyor.
        //    {
        //        lblKullanici.Text = "Hoşgeldin " + name;

        //        panel1.Visible = true;

        //        int tahmin = int.Parse(lblTahmin.Text);

        //        Oyun(tahmin);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Kullanıcı adı girmek zorunludur.");
        //    }
        //}

        int randomSayi = 0;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.GetName(out string name)) // burada oluşturulan name boş bir şekilde getname e gönderiliyor. ve oradaki _name den değer alınıyor.
            {
                lblKullanici.Text = "Hoşgeldin " + name;

                panel1.Visible = true;

                lblBilgi.Text = "";
                lblMesaj.Text = "";
                txtTahmin.Text = "";

                Random random = new Random();
                randomSayi = random.Next(1, 101);
                timer1.Start();
                progressBar1.Value = progressBar1.Maximum;
                btnTahmin.Enabled = true;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı girmek zorunludur.");
            }
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int tahmin;

            try
            {
                tahmin = int.Parse(txtTahmin.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Sayı girmeyi unuttun mu?");
                return;
            }

            if (tahmin == randomSayi)
            {
                lblBilgi.Text = "Tebriks bildiniz.";
                timer1.Stop();
                btnTahmin.Enabled = false;
            }
            else if (tahmin < randomSayi)
            {
                lblBilgi.Text = "Küçük bir sayı girdiniz.";
            }
            else if (tahmin > randomSayi)
            {
                lblBilgi.Text = "Büyük bir sayı girdiniz.";
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value--; // timer her saniyede prograssbarı birer birer düşürüyor.

            btnTahmin.Text = $"Tahmin et ({progressBar1.Value})";

            switch (progressBar1.Value)
            {
                case 50: lblMesaj.Text = "Galiba kaybedeceksin"; break;
                case 40: lblMesaj.Text = "Sen kaybetmek için yarışıyorsun"; break;
                case 30: lblMesaj.Text = "Süren doluyor"; break;
                case 20: lblMesaj.Text = "Bil artık"; break;
                case 10: lblMesaj.Text = "Son hakkın"; break;
                case 0: lblMesaj.Text = "Bilemedin. Bir dahaki sefere artık...";
                    timer1.Stop();
                    btnTahmin.Enabled = false;
                    break;
                default:
                    break;
            }
        }
    }
}
