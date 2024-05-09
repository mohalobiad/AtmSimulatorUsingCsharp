using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMUygulamasi.controller;
using ATMUygulamasi.enumlar;

namespace ATMUygulamasi
{
    public partial class EmailKoduGondermeVesifreDegistirme : Form
    {
        int code;
        string emailsave;
        public EmailKoduGondermeVesifreDegistirme()
        {
            InitializeComponent();
        }

        private void EmailKoduGondermeVesifreDegistirme_Load(object sender, EventArgs e)
        {
            grb_GrobBoxSifreDegistirme.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SifreDegistirme sif = new SifreDegistirme();
            sif.Show();
            this.Hide();
        }

        private void btn_DogrulamaGonder_Click(object sender, EventArgs e)
        {
            Controller contro = new Controller();
            Loginstatus result = contro.getgeAuthenticationEmail(txt_MailAdresiG.Text);   
            if (result == Loginstatus.basarli)
            {
                string kullanci = contro.getkullanciad(txt_MailAdresiG.Text);
                Random rdn = new Random();
                code = rdn.Next(111111, 999999);
                MailAddress mailalan = new MailAddress(txt_MailAdresiG.Text, kullanci);
                MailAddress mailgöderen = new MailAddress("duzcemohammad@hotmail.com", "admin");
                MailMessage sms = new MailMessage();

                sms.To.Add(mailalan);
                sms.From = mailgöderen;
                sms.Subject = "Şifre Değiştirme";
                sms.Body = "Şifreniz Değiştirmek için Doğrulama Kodunuz: " + code;

                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("duzcemohammad@hotmail.com", "tw221144");
                smtp.EnableSsl = true;
                smtp.Send(sms);

                MessageBox.Show("doğrulama kodu gönderildi", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if (result == Loginstatus.basarsiz)
            {
                MessageBox.Show("Girilen Email kayıtlı bir kullancıya ait değil,Lütfen Tekrar Deneyiniz !", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("lütfen boş bırakmayınız", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        private void txt_MailAdresiG_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            Controller contro = new Controller();
            Loginstatus result = contro.ChanngePassword(emailsave, txt_yeniSifre.Text, txt_tekrarSifre.Text);
            if (result == Loginstatus.basarli)
            {
                MessageBox.Show("Şifreniz Başarıyla Değiştirilmiştir", "Belgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (result == Loginstatus.eşitdegil)
            {
                MessageBox.Show("lütfen yeni şifre ve tekrarlama şifre eşit olsun", "Belgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("eksik parametre var lütfen tekrar deneyiniz", "Belgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            if (txt_DogrulamaKodu.Text==code.ToString())
            {
                grb_GrobBoxSifreDegistirme.Enabled = true;
                txt_DogrulamaKodu.Text = null;
                emailsave = txt_MailAdresiG.Text;
                txt_MailAdresiG.Text = null;
            }
            else
            {
                MessageBox.Show("Girdiğiniz Doğrulama Kodu hatalı , tekrar Deneyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 foro = new Form1();
            foro.Show();
            this.Hide();
        }
    }
}
