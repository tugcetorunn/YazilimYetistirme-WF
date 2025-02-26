namespace _03_SayiTahminOyunu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private string _name;

        private void btnGiris_Click(object sender, EventArgs e) // önce oyun ekranı gelecek, başla deyince önce giriş forma aktarak ismi alacak oyuna öyle naşlanacak.
        {
            string name = txtKullaniciAdi.Text;

            if (name != null)
            {
                this.Hide();
            }
        }

        public bool GetName(out string name)
        {
            name = _name;

            return _name != null && _name != "";
        }
    }
}