using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_StudentProject
{
    public partial class FormStudentAdd : Form
    {
        List<OgrenciBilgi> ogrenciler;
        public FormStudentAdd(string username)
        {
            InitializeComponent();
            lblKullanici.Text = "Hoşgeldin " + username;
            ogrenciler = new List<OgrenciBilgi>();
        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == string.Empty || txtSoyad.Text == string.Empty || comboBox1.SelectedIndex == null)
            {
                MessageBox.Show("Alanları doldurun.");
            }

            //if (!rdbtnErkek.Checked && !rdbtnKadın.Checked)
            //{
            //    MessageBox.Show("cinsiyet seçmediniz.");
            //}

            string cinsiyet = "";

            if (rdbtnKadın.Checked == true)
            {
                cinsiyet = "Kadın";
            }
            else if (rdbtnErkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                MessageBox.Show("Cinsiyet seçmediniz.");
            }

            string bolum = comboBox1.SelectedItem.ToString();
            string resimYolu = txtResimYukle.Text;

            var ogrenci = new OgrenciBilgi
            {
                ID = Guid.NewGuid(),
                Ad = txtAd.Text,
                SoyAd = txtSoyad.Text,
                Cinsiyet = cinsiyet,
                Bolum = bolum,
                ResimYolu = resimYolu
            };


            if (checkBox1.Checked)
            {
                ogrenciler.Add(ogrenci);

                //TextKaydet(ogrenci);

                // var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonVeri = JsonConvert.SerializeObject(ogrenciler, Formatting.Indented);

                File.WriteAllText("StudentProject.json", jsonVeri);



                //FormStudentList formStudentList = new FormStudentList();
                //formStudentList.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bilgilerinizi onaylayınız.");
            }

            Temizle();
                        
        }

        private void TextKaydet(OgrenciBilgi ogrenci)
        {
            string pathFolder = @"C:\Users\halkbank\Desktop\New folder\YazilimYetistirme-WF\04-StudentProject\images";

            string folderName = "";
            string txtName = "";

            folderName = ogrenci.ID.ToString().Substring(0, 5) + "-" + txtAd.Text.ToUpper();

            Directory.CreateDirectory(pathFolder + folderName);

            txtName = pathFolder + folderName + @"\" + folderName + ".txt";

            using (File.Create(txtName)) ;

            if (txtResimYukle.Text != "")
            {
                if (Directory.Exists(pathFolder + folderName))
                {
                    string kaynak = txtResimYukle.Text;
                    string hedef = pathFolder + folderName + @"\" + ogrenci.ID.ToString().Substring(0, 5) + Path.GetExtension(kaynak);

                    File.Copy(kaynak, hedef, true);

                    string[] icerik = {
                            "Adı: " + ogrenci.Ad,
                            "Soyadı: " + ogrenci.SoyAd,
                            "Cinsiyeti: " + ogrenci.Cinsiyet,
                            "Bölümü: " + ogrenci.Bolum
                        };

                    File.WriteAllLines(txtName, icerik);

                    using (StreamWriter sw = new StreamWriter(@"C:\Users\halkbank\Desktop\New folder\YazilimYetistirme-WF\04-StudentProject\students.txt", true))
                    {
                        sw.WriteLine("\n" + txtAd.Text);
                    }

                    MessageBox.Show("Kopyalandı.");
                }
                else
                {
                    MessageBox.Show("Klasör oluşturulamadı.");
                }
            }
        }

        private void Temizle() // yeniden kullanılabilir
        {
            foreach (var item in this.Controls)
            {
                if (item is GroupBox)
                {
                    var group = (GroupBox)item; // item as Group

                    foreach (var groupItem in group.Controls)
                    {
                        if (groupItem is TextBox)
                        {
                            ((TextBox)groupItem).Text = "";
                        }

                        if (groupItem is CheckBox)
                        {
                            ((CheckBox)groupItem).Checked = false;
                        }

                        if (groupItem is RadioButton)
                        {
                            ((RadioButton)groupItem).Checked = false;
                        }

                        if (groupItem is ComboBox)
                        {
                            ((ComboBox)groupItem).SelectedIndex = -1; // seçilmemiş hale getirir. 
                        }

                        if (groupItem is PictureBox)
                        {
                            ((PictureBox)groupItem).Image = null;
                        }

                        AlanlariTemizle(item);
                    }
                }
            }
        }

        private void AlanlariTemizle(object? item) // re-use
        {
            if (item is TextBox)
            {
                ((TextBox)item).Text = "";
            }

            if (item is CheckBox)
            {
                ((CheckBox)item).Checked = false;
            }

            if (item is ComboBox)
            {
                ((ComboBox)item).SelectedIndex = -1; // seçilmemiş hale getirir. 
            }

            if (item is RadioButton)
            {
                ((RadioButton)item).Checked = false; // seçilmemiş hale getirir. 
            }

            if (item is PictureBox)
            {
                ((PictureBox)item).Image = null;
            }
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Dosyaları (*.png)|*.png|JPEG Dosyaları (*.jpeg)|(*.jpeg)|JPG Dosyaları (*jpg)|(*.jpg)";
            DialogResult result = openFileDialog1.ShowDialog();
            string filepath = "";

            if (result == DialogResult.OK)
            {

            }
            txtResimYukle.Text = openFileDialog1.FileName;
            pictureBox1.ImageLocation = txtResimYukle.Text;
        }

        private void FormStudentAdd_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            string[] bolumler = { "Bilgisayar Mühendisliği", "Yazılım Mühendisliği", "Endüstri Mühendisliği" };
            comboBox1.Items.AddRange(bolumler);

            string jsonVeri = File.ReadAllText("StudentProject.json");
            OgrenciBilgi ogrenci = JsonConvert.DeserializeObject<OgrenciBilgi>(jsonVeri); // json okuma veriyi getirme
            List<OgrenciBilgi> students = new List<OgrenciBilgi> { ogrenci };
            ogrenciler.AddRange(students);
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            FormStudentList formStudentList = new FormStudentList();
            formStudentList.Show();
            this.Hide();
        }
    }

    public class OgrenciBilgi
    {
        public Guid? ID { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Cinsiyet { get; set; }
        public string Bolum { get; set; }
        public string ResimYolu { get; set; }

        public override string ToString()
        {
            return $"ID: {ID} / Ad: {Ad} / Soyad: {SoyAd} / Cinsiyet: {Cinsiyet} / Bölüm: {Bolum}";
        }
    }

}
