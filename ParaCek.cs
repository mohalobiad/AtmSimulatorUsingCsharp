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
    public partial class ParaCek : Form
    {
        int yeniBakiye;
        public ParaCek()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller contro = new Controller();
            aboneBilgileri abone = new aboneBilgileri();
            abone = contro.GetAdSoyadBakiye(Form1.gidenKullanci);
            if (string.IsNullOrEmpty(txt_paraCek.Text))
            {
                MessageBox.Show("eksik parametre lütfen Tekrar Deneyiniz");
            }
            else
            {
                if (int.Parse(txt_paraCek.Text) > int.Parse(abone.bakiye))
                {
                    MessageBox.Show("o kadar paranız yoktur");
                }
                else
                {
                    yeniBakiye = int.Parse(abone.bakiye) - int.Parse(txt_paraCek.Text);
                    Loginstatus result = contro.paracek(yeniBakiye, Form1.gidenKullanci);
                    if (result == Loginstatus.basarli)
                    {
                        MessageBox.Show("Para Çekme işlemi başariyla gerçekleştirildi");
                        KullanciHesap kasi = new KullanciHesap();
                        kasi.Show();
                        this.Close();
                    }
                    else if (result == Loginstatus.basarsiz)
                    {
                        MessageBox.Show("Para Çekilirkem hata oluştu, Tekrar Deneyiniz");
                    }
                    

                }
            }
            
            
            

       }

        private void button1_Click(object sender, EventArgs e)
        {
            KullanciHesap kasi = new KullanciHesap();
            kasi.Show();
            this.Close();
        }

        private void txt_paraCek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
