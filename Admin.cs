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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Controller contro = new Controller();
            List<usersForAdmin> userlist = contro.GetAllUsersForAdmin();
           
            dataGridView1.DataSource = userlist;
        }

        private void btn_sifre_Click(object sender, EventArgs e)
        {
            usersForAdmin user = new usersForAdmin();  
            user.ad = txt_ad.Text;
            user.soyad = txt_soyad.Text;
            user.bakiye = txt_bakiye.Text;
            user.ibanno = txt_ibanno.Text;
            user.kullanciAdi = txt_kullanciad.Text.Trim().ToLower();
            user.sifre = txt_sifre.Text.Trim().ToLower();
            user.yetki = txt_yetki.Text.Trim().ToLower();
            user.emailAd = txt_emailad.Text.Trim().ToLower();
            user.GuvenlikSoru = txt_guvenliksor.Text;
            user.guvenlikCevabi = txt_guvenlikcevabi.Text.Trim().ToLower();
            Controller contro = new Controller();
            Loginstatus result = contro.KayitEkle(user);

            if (result == Loginstatus.basarli)
            {
                MessageBox.Show("kayıt başarıla eklenmiştir");
                List<usersForAdmin> userlist = contro.GetAllUsersForAdmin();
                dataGridView1.DataSource = userlist;
            }
            else if ( result == Loginstatus.basarsiz)
            {
                MessageBox.Show("kayıt eklenirken hata oluştu");
            }
            else
            {
                MessageBox.Show("Eksek Parametre, Lütfen Doldurunuz");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 foro = new Form1();
            foro.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_bakiye.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_ibanno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_kullanciad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_emailad.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_guvenliksor.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txt_guvenlikcevabi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                usersForAdmin user = new usersForAdmin();
                user.id = int.Parse(txt_id.Text);
                user.ad = txt_ad.Text;
                user.soyad = txt_soyad.Text;
                user.bakiye = txt_bakiye.Text;
                user.ibanno = txt_ibanno.Text;
                user.kullanciAdi = txt_kullanciad.Text.Trim().ToLower();
                user.sifre = txt_sifre.Text.Trim().ToLower();
                user.yetki = txt_yetki.Text.Trim().ToLower();
                user.emailAd = txt_emailad.Text.Trim().ToLower();
                user.GuvenlikSoru = txt_guvenliksor.Text;
                user.guvenlikCevabi = txt_guvenlikcevabi.Text.Trim().ToLower();
                Controller contro = new Controller();
                Loginstatus result = contro.kayitGuncelle(user);

                if (result == Loginstatus.basarli)
                {
                    MessageBox.Show("kayıt başarıla Güncellendi");
                    List<usersForAdmin> userlist = contro.GetAllUsersForAdmin();

                    dataGridView1.DataSource = userlist;

                }
                else if (result == Loginstatus.basarsiz)
                {

                }
                else
                {
                    MessageBox.Show("kayıt Güncellenirken hata oluştu");

                }
            }
            else
            {
                MessageBox.Show("Eksek Parametre, Lütfen Doldurunuz");
            }
            

        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_id.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            Controller contro = new Controller();
            Loginstatus result = contro.kayitSil((int)dataGridView1.CurrentRow.Cells[0].Value);
            if (result == Loginstatus.basarli)
            {
                MessageBox.Show("kayıt başarıla Silinmiştir");
                List<usersForAdmin> userlist = contro.GetAllUsersForAdmin();
                txt_ad.Text = null;
                txt_soyad.Text = null;
                txt_bakiye.Text = null;
                txt_ibanno.Text = null;
                txt_kullanciad.Text = null;
                txt_sifre.Text = null;
                txt_yetki.Text = null;
                txt_emailad.Text = null;
                txt_guvenliksor.Text = null;
                txt_guvenlikcevabi.Text = null;
                dataGridView1.DataSource = userlist;


            }
            else
            {
                MessageBox.Show("kayıt Güncellenirken hata oluştu");

            }
        }
    }
}
