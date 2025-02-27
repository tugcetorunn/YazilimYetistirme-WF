using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_StudentProject
{
    public partial class FormStudentList : Form
    {
        public FormStudentList()
        {
            InitializeComponent();
        }
        List<OgrenciBilgi> ogrenciler;
        private void FormStudentList_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            listBox1.Items.Clear();

            string jsonVeri = File.ReadAllText("StudentProject.json");
            List<OgrenciBilgi> ogrenciler = JsonConvert.DeserializeObject<List<OgrenciBilgi>>(jsonVeri); // json okuma veriyi getirme

            foreach (var ogrenci in ogrenciler)
            {
                //listBox1.Items.Add($"ID: {ogrenci.ID} / Ad: {ogrenci.Ad} / Soyad: {ogrenci.SoyAd} / Cinsiyet: {ogrenci.Cinsiyet} / Bölüm: {ogrenci.Bolum}");
                listBox1.Items.Add(ogrenci);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgrenciBilgi ogrenci = ogrenciler[listBox1.SelectedIndex];

            lblDetay.Text = ogrenci.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                int index = listBox1.SelectedIndex;

                ogrenciler.RemoveAt(index);

                string jsonVeri = JsonConvert.SerializeObject(ogrenciler, Formatting.Indented);

                File.WriteAllText("StudentProject.json", jsonVeri);
            }
        }
    }
}
