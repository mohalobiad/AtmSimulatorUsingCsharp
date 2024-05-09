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
    public partial class parayatir : Form
    {
        public parayatir()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullanciHesap kasi = new KullanciHesap();
            kasi.Show();
            this.Close();
        }

        private void btn_paraYatir_Click(object sender, EventArgs e)
        {
            Controller contro = new Controller();
            aboneBilgileri abone = new aboneBilgileri();
            abone = contro.GetAdSoyadBakiye(Form1.gidenKullanci);
            if (string.IsNullOrEmpty(txt_BakiyeParaYatir.Text))
            {
                MessageBox.Show("eksik parametre lütfen Tekrar Deneyiniz");
            }
            else
            {
                int yeniBakiye = int.Parse(txt_BakiyeParaYatir.Text) + int.Parse(abone.bakiye);
                if (yeniBakiye > 19999999)
                {

                    MessageBox.Show("Girdiğiniz tutar bakiye limitinizi aşıyor");

                }
                else
                {
                    Loginstatus result = contro.parayatır(yeniBakiye, Form1.gidenKullanci);
                    if (result == Loginstatus.basarli)
                    {
                        MessageBox.Show("Paranız Başarıyla yatırılmıştır");
                        KullanciHesap kasi = new KullanciHesap();
                        kasi.Show();
                        this.Close();
                    }
                    else if (result == Loginstatus.basarsiz)
                    {
                        MessageBox.Show("Para Yatırılken hata oluştu, Tekrar Deneyiniz");
                    }
                    else
                    {
                        MessageBox.Show("Eksik Parametre Var lütfen Doldurunuz!");
                    }

                }
            }
            
            
        }

        private void txt_BakiyeParaYatir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }
    }
}
