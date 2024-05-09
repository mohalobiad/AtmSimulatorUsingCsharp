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
    public partial class SifreDegistirme : Form
    {
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sorgulama_Click(object sender, EventArgs e)
        {
            try
            {
                Controller controler = new Controller();
                Loginstatus result = controler.geAuthentication(txt_GuvKullanciAd.Text.Trim().ToLower(), comboBox1.SelectedItem.ToString(), txt_GuvenlikSoruCevabi.Text.Trim().ToLower()); ;
                if (result == Loginstatus.basarli)
                {
                    MessageBox.Show("Girdiğiniz Belgeler Doğrudur", "Blgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmailKoduGondermeVesifreDegistirme emol = new EmailKoduGondermeVesifreDegistirme();
                    emol.Show();
                    this.Hide();
                }
                else if (result == Loginstatus.basarsiz)
                {
                    MessageBox.Show("yanliş belgeler girmişsiniz", "Blgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("eksik parametre , llütfen bir daha deneyiniz ", "Blgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("eksik parametre , llütfen bir daha deneyiniz ", "Blgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form1 foro = new Form1();
            foro.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            Controller controler = new Controller();
            List<LoginTable> logintablelist = controler.logintablu();
            foreach ( LoginTable logintable in logintablelist)
            {
                comboBox1.Items.Add(logintable.guvenliksoru);
            }
            
        }

        private void txt_GuvKullanciAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
