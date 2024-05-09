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
   

    public partial class ParaAktarim : Form
    {
        int SmdikiKulYeniBakiye;
        int DegerKulyeniBakiye;
        public ParaAktarim()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_paraYatir_Click(object sender, EventArgs e)
        {
            Controller SmdikiAboneContro = new Controller();
            aboneBilgileri simdikiabone = new aboneBilgileri();
            simdikiabone = SmdikiAboneContro.GetAdSoyadBakiye(Form1.gidenKullanci);

            Controller DegerAboneContro = new Controller();
            Loginstatus result = DegerAboneContro.getgeAuthenticationiban(txt_iban.Text);
            aboneBilgileri DegerAbone = new aboneBilgileri();
            DegerAbone = DegerAboneContro.Getkullanciwhithiban(txt_iban.Text);

            if (!string.IsNullOrEmpty(txt_iban.Text)&&!string.IsNullOrEmpty(txt_alinacakmiktar.Text))
            {
                
                if (simdikiabone.ibanno== txt_iban.Text)
                {
                    MessageBox.Show("lütfen ibanınız koymayın");
                }
                else
                {
                    if (result == Loginstatus.basarli)
                    {
                        if (int.Parse(txt_alinacakmiktar.Text) > int.Parse(simdikiabone.bakiye))
                        {
                            MessageBox.Show("o kadar paranız yoktur");
                        }
                        else
                        {
                            SmdikiKulYeniBakiye = int.Parse(simdikiabone.bakiye) - int.Parse(txt_alinacakmiktar.Text);
                            Loginstatus sonuc = SmdikiAboneContro.paracek(SmdikiKulYeniBakiye, Form1.gidenKullanci);
                            if (sonuc == Loginstatus.basarli)
                            {
                                DegerKulyeniBakiye = int.Parse(txt_alinacakmiktar.Text) + int.Parse(DegerAbone.bakiye);
                                Loginstatus soresult = DegerAboneContro.parayatıribanile(DegerKulyeniBakiye, txt_iban.Text);
                                if(soresult == Loginstatus.basarli)
                                {
                                    MessageBox.Show("Paranız başarıyla Aktarıldı");
                                    KullanciHesap kasi = new KullanciHesap();
                                    kasi.Show();
                                    this.Close();

                                }
                                else
                                {
                                    MessageBox.Show("Paranız aktarılken hata oluştu");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Para aktarılken hata oluştu, Tekrar Deneyiniz");
                            }
                        }


                    }

                    else
                    {
                        MessageBox.Show("böyle bir iban Yoktur");
                    }
                }
            }
            else
            {
                MessageBox.Show("Eksik Parametre");
                
            }
            


        }

        private void ParaAktarim_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            KullanciHesap kasi = new KullanciHesap();
            kasi.Show();
            this.Close();
        }

        private void txt_alinacakmiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
