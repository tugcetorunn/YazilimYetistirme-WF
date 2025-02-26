using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WF_Intro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == string.Empty)
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez.");
            }
            else if (txtSifre.Text == string.Empty)
            {
                MessageBox.Show("Şifre boş geçilemez.");
            }
            else
            {
                bool result = Login(txtKullaniciAdi.Text, txtSifre.Text);
                

                if (result)
                {
                    Form3 form= new Form3();
                    form.Show(); // showdialog ile yeni açılan formu kapatmadan arkadaki forma dokunamıyoruz.
                    Hide();
                }
                else
                {
                    MessageBox.Show("Başarısız");
                }
            }
        }

        private bool Login(string kullaniciAdi, string sifre)
        {
            return kullaniciAdi == "admin" && sifre == "123";
        }
    }
}
