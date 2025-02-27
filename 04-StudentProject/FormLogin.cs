using System.Xml.Linq;

namespace _04_StudentProject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            KullaniciOlusturma();
        }

        Dictionary<string, string> kullanicilar = new Dictionary<string, string>();

        private void KullaniciOlusturma()
        {
            kullanicilar.Add("tugcetorun", "1234");
            kullanicilar.Add("talhatorun", "123");
            kullanicilar.Add("eymentoker", "1234");
        }

        string kullaniciAdi;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (kullanicilar.Keys.Contains(kullaniciAdi))
            {
                var kullaniciSifre = kullanicilar[kullaniciAdi];

                if (sifre == kullaniciSifre)
                {
                    lblBilgi.Text = "Giriş başarılı.";
                    FormStudentAdd form = new FormStudentAdd(kullaniciAdi);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    lblBilgi.Text = "Şifreyi yanlış girdiniz.";
                }
            }
            else
            {
                lblBilgi.Text = "Kullanıcı bulunamadı."; ;
            }
        }
        public bool GetUsername(out string username)
        {
            username = kullaniciAdi;
            return username != null && username != "";
        }

    }

    // kullanıcı adı şifre boş mu dolu mu kontrolü
    // kullanıcıya bilgi

    // student add e ad soyad gönderme

    //login için dictionary 3 tane kullanıcı adı şifre belirletyin

    // listede varsa login oplur. olduysa studentadd sayfası açılır. logişn form hide.
}