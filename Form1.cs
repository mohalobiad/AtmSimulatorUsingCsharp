using ATMUygulamasi.controller;
using ATMUygulamasi.enumlar;
using ATMUygulamasi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMUygulamasi
{
    public partial class Form1 : Form
    {
        public static string gidenKullanci;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_girisYap_Click_1(object sender, EventArgs e)
        {
            Controller controler = new Controller();
            User user = controler.login(Txt_KullanciAdi.Text.ToLower(), Txt_sifre.Text.ToLower());
            if (user != null && user.status == Loginstatus.basarli && user.yetki == "admin")
            {
                gidenKullanci = Txt_KullanciAdi.Text;
                Admin adi = new Admin();
                adi.Show();
                this.Hide();
            }
            else if (user != null && user.status == Loginstatus.basarli && user.yetki == "KullanciHesap")
            {
                gidenKullanci = Txt_KullanciAdi.Text;
                KullanciHesap kasP = new KullanciHesap();
                kasP.Show();
                this.Hide();
            }
            else if (user != null && user.status == Loginstatus.basarsiz)
            {
                MessageBox.Show("Kullanci Adı veya Şifre hatalı, Lütfen Tekrar Deneyiniz !", "Belgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik parametre", "Belgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            SifreDegistirme SdSd = new SifreDegistirme();
            SdSd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
