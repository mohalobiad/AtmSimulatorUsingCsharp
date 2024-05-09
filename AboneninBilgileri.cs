using ATMUygulamasi.controller;
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
    public partial class AboneninBilgileri : Form
    {
        public AboneninBilgileri()
        {
            InitializeComponent();
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KullanciHesap kasi = new KullanciHesap();
            kasi.Show();
            this.Close();
        }

        private void AboneninBilgileri_Load(object sender, EventArgs e)
        {
            Controller contro = new Controller();
            aboneBilgileri abone = new aboneBilgileri();
            abone = contro.GetTumAboneBilgileri(Form1.gidenKullanci);
            txt_Ad.Text = abone.ad;
            txt_SoyAd.Text = abone.soyad;
            txt_Bakiye.Text = abone.bakiye;
            txt_KullanciAd.Text = abone.kullanciAdi;
            txt_Sifre.Text = abone.sifre;
            txt_yetki.Text = abone.yetki;
            txt_emailAd.Text = abone.emailAd;
            txt_ibanNo.Text = abone.ibanno;
            txt_GuvenlikSoru.Text = abone.GuvenlikSoru;
            txt_guvenlikCevabi.Text = abone.guvenlikCevabi;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_Ad.Text);
                MessageBox.Show("kopaylanmiştir");
            }
            catch
            {
                MessageBox.Show("Hata oluştu Tekrar Deneyiniz ");
            }
            
        }

        private void btn_sifre_Click(object sender, EventArgs e)
        {
            Form1 foro = new Form1();
            foro.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_SoyAd.Text);
                MessageBox.Show("kopaylanmiştir");
            }
            catch
            {
                MessageBox.Show("Hata oluştu Tekrar Deneyiniz ");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_Bakiye.Text);
                MessageBox.Show("kopaylanmiştir");
            }
            catch
            {
                MessageBox.Show("Hata oluştu Tekrar Deneyiniz ");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_KullanciAd.Text);
                MessageBox.Show("kopaylanmiştir");
            }
            catch
            {
                MessageBox.Show("Hata oluştu Tekrar Deneyiniz ");
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_Sifre.Text);
                MessageBox.Show("kopaylanmiştir");
            }
            catch
            {
                MessageBox.Show("Hata oluştu Tekrar Deneyiniz ");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_yetki.Text);
                MessageBox.Show("kopaylanmiştir");
            }
            catch
            {
                MessageBox.Show("Hata oluştu Tekrar Deneyiniz ");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_emailAd.Text);
                MessageBox.Show("kopaylanmiştir");
            }
            catch
            {
                MessageBox.Show("Hata oluştu Tekrar Deneyiniz ");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            try
            {
                Clipboard.SetText(txt_ibanNo.Text);
                MessageBox.Show("kopaylanmiştir");
            }
            catch
            {
                MessageBox.Show("Hata oluştu Tekrar Deneyiniz ");
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_GuvenlikSoru.Text);
                MessageBox.Show("kopaylanmiştir");
            }
            catch
            {
                MessageBox.Show("Hata oluştu Tekrar Deneyiniz ");
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_guvenlikCevabi.Text);
                MessageBox.Show("kopaylanmiştir");
            }
            catch
            {
                MessageBox.Show("Hata oluştu Tekrar Deneyiniz ");
            }
            
        }

        private void btn_KullanciAdi_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Controller contro = new Controller(); 
            aboneBilgileri abone = new aboneBilgileri();
            abone = contro.GetTumAboneBilgileri(Form1.gidenKullanci);
            txt_Ad.Text = abone.ad;

            if (txt_Ad.Text == abone.ad)
            {
                MessageBox.Show("var olan Adınız Güncelleyemezsiniz");
            }
            else
            {
                MessageBox.Show("Bu kullanci olur");
            }
            
        }
    }
}
