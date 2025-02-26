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

        private void btnBasla_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.GetName(out string name)) // burada oluşturulan name getname e gönderiliyor. ve orada kontrol ediliyor.
            {
                lblKullanici.Text = "Hoşgeldin " + name;

                panel1.Visible = true;

                int tahmin = int.Parse(lblTahmin.Text);

                Oyun(tahmin);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı girmek zorunludur.");
            }
        }

        private void Oyun(int tahmin)
        {
            Random random = new Random();

            int karsilastirilacakSayi = random.Next(100);

            do
            {
                if (karsilastirilacakSayi == tahmin)
                {
                    lblBilgi.Text = "Bildiniz.";
                    progressBar1.Value = 100;
                }
                else if (karsilastirilacakSayi > tahmin)
                {
                    lblBilgi.Text = "Sayıyı küçült.";
                    progressBar1.Value = (karsilastirilacakSayi - tahmin) / 100;

                    karsilastirilacakSayi = random.Next(0, karsilastirilacakSayi);
                }
                else
                {
                    lblBilgi.Text = "Sayıyı yükselt.";
                    progressBar1.Value = (tahmin - karsilastirilacakSayi);

                    karsilastirilacakSayi = random.Next(karsilastirilacakSayi, 100);
                }

            } while (karsilastirilacakSayi == tahmin);
            
        }

        private void btnBasla_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.GetName(out string name)) // burada oluşturulan name getname e gönderiliyor. ve orada kontrol ediliyor.
            {
                lblKullanici.Text = "Hoşgeldin " + name;

                panel1.Visible = true;

                int tahmin = int.Parse(lblTahmin.Text);

                Oyun(tahmin);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı girmek zorunludur.");
            }
        }
    }
}
