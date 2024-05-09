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
    public partial class KullanciHesap : Form
    {
        public KullanciHesap()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_paracek_Click(object sender, EventArgs e)
        {
            ParaCek paraCek = new ParaCek();
            paraCek.ShowDialog();
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kasyer_Load(object sender, EventArgs e)
        {
            Controller contro = new Controller();
            aboneBilgileri abone = new aboneBilgileri();
            abone =contro.GetAdSoyadBakiye(Form1.gidenKullanci);
            lbl_ad.Text = abone.ad;
            lbl_soyad.Text = abone.soyad;
            lbl_bakiye.Text = abone.bakiye;
            lbl_ibanNo.Text = abone.ibanno;
        }

        private void btn_paraYatir_Click(object sender, EventArgs e)
        {
            parayatir para = new parayatir();
            para.ShowDialog();
            this.Close();

        }

        private void btn_paraAktarim_Click(object sender, EventArgs e)
        {
            ParaAktarim paraaktarim = new ParaAktarim();
            paraaktarim.ShowDialog();
            this.Close();
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            Form1 foro = new Form1();
            foro.Show();
            this.Hide();
        }

        private void btn_hesapBligi_Click(object sender, EventArgs e)
        {
            AboneninBilgileri abo = new AboneninBilgileri();
            abo.Show();
            this.Hide();

        }
    }
}
