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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MasterDoldur();
        }

        private void MasterDoldur()
        {
            string[] universiteler = { "İTÜ", "YTÜ", "İSÜ", "KTÜ", "ODTÜ" };

            cmbUniversiteler.Items.Clear();
            cmbxMaster.Items.Clear();

            cmbUniversiteler.Items.AddRange(universiteler);
            cmbxMaster.Items.AddRange(universiteler);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;
            string adres = txtAcikAdres.Text;
            string liseAdi = txtLiseAdi.Text;

            string universite = cmbUniversiteler.SelectedItem.ToString();

            string cinsiyet = rdbtnErkek.Checked ? "Erkek" : "Kadın";

            string yas = nudYas.Value.ToString();

            string master = cmbxMaster.SelectedItem.ToString();

            string bilgi = $"Adı Soyadı: {adSoyad} Yaş: {yas} Cinsiyet: {cinsiyet} Adres: {adres} Lise: {liseAdi} Üniversite: {universite} Master: {master}";

            if (chbxOnay.Checked)
                listBox1.Items.Add(bilgi);
            else
                MessageBox.Show("Lütfen onaylayınız.");
        }
    }
}
