using ATMUygulamasi.enumlar;
using ATMUygulamasi.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi.dao
{
    public class veritabani
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        List<LoginTable> logintablelist;
        public veritabani()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-0BPGSIR\SQLEXPRESS;Initial Catalog=market;User ID=sa;password=1");

        }
        
        public void baglantiayarla()
        {
            if (con.State== System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }

        public User login(string kullanciAdi , string sifre)
        {
            con.Open();
            cmd = new SqlCommand("select * from loginTable where kullancadi=@kulanci and sifre =@sifre ", con);
            cmd.Parameters.AddWithValue("@kulanci", kullanciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.kullanciadi = dr["kullancadi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.emailad = dr["emailad"].ToString();
                user.guvenliksoru = dr["guvenliksoru"].ToString();
                user.guvenlikcevabi = dr["guvenlikcevabi"].ToString();
                user.status = Loginstatus.basarli;
                return user;

            }
            else
            {
                User user = new User();
                user.status = Loginstatus.basarsiz;
                return user;

            }
            con.Close();        
        }

        public List<LoginTable> logintablu()
        {
            logintablelist = new List<LoginTable>();
            con.Open();
            cmd = new SqlCommand("guvenlikksorusuGetir_sp",con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoginTable logintable = new LoginTable();
                logintable.id = int.Parse(dr["id"].ToString());
                logintable.kullanciadi= dr["kullancadi"].ToString();
                logintable.sifre = dr["sifre"].ToString();
                logintable.yetki = dr["yetki"].ToString();
                logintable.emailad = dr["emailad"].ToString();
                logintable.guvenliksoru = dr["guvenliksoru"].ToString();
                logintable.guvenlikcevabi = dr["guvenlikcevabi"].ToString();
                logintablelist.Add(logintable);
            }
            con.Close();
            return logintablelist;
        }

        public Loginstatus geAuthentication(string kullanciadi,string guvenliksorusu,string guvenlikcevabi)
        {
            con.Open();

            cmd = new SqlCommand("select count(*) from loginTable where kullancadi=@kulad and guvenliksoru=@GuvSoru and guvenlikcevabi=@Guvcevabi", con);
            cmd.Parameters.AddWithValue("@kulad", kullanciadi);
            cmd.Parameters.AddWithValue("@GuvSoru", guvenliksorusu);
            cmd.Parameters.AddWithValue("@Guvcevabi", guvenlikcevabi);
            returnvalue = (int)cmd.ExecuteScalar();
            con.Close();
            if (returnvalue==1)
            {
                return Loginstatus.basarli;
            }
            else
            {
                return Loginstatus.basarsiz;
            }
        }
        public Loginstatus getgeAuthenticationEmail(string emali)
        {
            con.Open();
            cmd = new SqlCommand("select count(*) from loginTable where emailad=@ema", con);
            cmd.Parameters.AddWithValue("@ema", emali);
            returnvalue = (int)cmd.ExecuteScalar();
            con.Close();
            if (returnvalue==1)
            {
                return Loginstatus.basarli;
            }
            else
            {
                return Loginstatus.basarsiz;
            }
        }

        public string getkullanciad(string emailAd)
        {
            con.Open();
            cmd = new SqlCommand("select kullancadi from loginTable where emailad=@ema", con);
            cmd.Parameters.AddWithValue("@ema", emailAd);
            dr = cmd.ExecuteReader();
            dr.Read();
            LoginTable loginTable = new LoginTable();
            loginTable.kullanciadi = dr["kullancadi"].ToString();
            con.Close();
            return loginTable.kullanciadi;
        }
        public Loginstatus ChanngePassword(string email,string sifre)
        {
            con.Open();

            cmd = new SqlCommand("ChangePassword_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sire", sifre);
            cmd.Parameters.AddWithValue("@ema", email);
            cmd.ExecuteNonQuery();
            con.Close();
            return Loginstatus.basarli;
        }
        public aboneBilgileri GetAdSoyadBakiye(string logindenGelenKullanciadi)
        {
            con.Open();
            aboneBilgileri abone = new aboneBilgileri();
            cmd = new SqlCommand("select * from loginTable where kullancadi=@kulad", con);
            cmd.Parameters.AddWithValue("@kulad", logindenGelenKullanciadi);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                abone.ad= dr["ad"].ToString();
                abone.soyad= dr["soyad"].ToString();
                abone.bakiye= dr["bakiye"].ToString();
                abone.ibanno= dr["ibanno"].ToString();
            }
            con.Close();
            return abone;
        }
        public Loginstatus parayatır(int yenibakiye, string logindenGelenKullanciadi )
        {
            con.Open();
            aboneBilgileri abone = new aboneBilgileri();
            cmd = new SqlCommand("update loginTable set bakiye=@baki where kullancadi=@kulad", con);
            cmd.Parameters.AddWithValue("@baki", yenibakiye.ToString());
            cmd.Parameters.AddWithValue("@kulad", logindenGelenKullanciadi);
            int rereturnvalue = cmd.ExecuteNonQuery();
            if (rereturnvalue == 1)
            {
                return Loginstatus.basarli;
            }
            else
            {
                return Loginstatus.basarsiz;
            }

        }
        public Loginstatus paracek(int yenibakiye, string logindenGelenKullanciadi)
        {
            con.Open();
            aboneBilgileri abone = new aboneBilgileri();
            cmd = new SqlCommand("update loginTable set bakiye=@baki where kullancadi=@kulad", con);
            cmd.Parameters.AddWithValue("@baki", yenibakiye.ToString());
            cmd.Parameters.AddWithValue("@kulad", logindenGelenKullanciadi);
            int rereturnvalue = cmd.ExecuteNonQuery();
            if (rereturnvalue == 1)
            {
                return Loginstatus.basarli;
            }
            else
            {
                return Loginstatus.basarsiz;
            }
        }
        public aboneBilgileri Getkullanciwhithiban(string iban)
        {
            con.Open();
            aboneBilgileri abone = new aboneBilgileri();
            cmd = new SqlCommand("select * from loginTable where ibanno=@ibo", con);
            cmd.Parameters.AddWithValue("@ibo", iban);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                abone.ad = dr["ad"].ToString();
                abone.soyad = dr["soyad"].ToString();
                abone.bakiye = dr["bakiye"].ToString();
                abone.ibanno = dr["ibanno"].ToString();
            }
            con.Close();
            return abone;
        }
        public Loginstatus getgeAuthenticationiban(string iban)
        {
            con.Open();
            cmd = new SqlCommand("select count(*) from loginTable where ibanno=@ibo", con);
            cmd.Parameters.AddWithValue("@ibo", iban);
            returnvalue = (int)cmd.ExecuteScalar();
            con.Close();
            if (returnvalue == 1)
            {
                return Loginstatus.basarli;
            }
            else
            {
                return Loginstatus.basarsiz;
            }
        }
        public Loginstatus parayatıribanile(int yenibakiye, string iban)
        {
            con.Open();
            aboneBilgileri abone = new aboneBilgileri();
            cmd = new SqlCommand("update loginTable set bakiye=@baki where ibanno=@ibo", con);
            cmd.Parameters.AddWithValue("@baki", yenibakiye.ToString());
            cmd.Parameters.AddWithValue("@ibo", iban);
            int rereturnvalue = cmd.ExecuteNonQuery();
            if (rereturnvalue == 1)
            {
                return Loginstatus.basarli;
            }
            else
            {
                return Loginstatus.basarsiz;
            }
        }
        public aboneBilgileri GetTumAboneBilgileri(string logindenGelenKullanciadi)
        {
            con.Open();
            aboneBilgileri abone = new aboneBilgileri();
            cmd = new SqlCommand("select * from loginTable where kullancadi=@kulad", con);
            cmd.Parameters.AddWithValue("@kulad", logindenGelenKullanciadi);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                abone.ad = dr["ad"].ToString();
                abone.soyad = dr["soyad"].ToString();
                abone.bakiye = dr["bakiye"].ToString();
                abone.ibanno = dr["ibanno"].ToString();
               abone.kullanciAdi= dr["kullancadi"].ToString();
                abone.sifre = dr["sifre"].ToString();
                abone.yetki = dr["yetki"].ToString();
                abone.emailAd = dr["emailad"].ToString();
                abone.GuvenlikSoru = dr["guvenliksoru"].ToString();
                abone.guvenlikCevabi = dr["guvenlikcevabi"].ToString();


            }
            con.Close();
            return abone;
        }
        public Loginstatus getAuthenticationKullanciAdi(string YenikullanciAdi)
        {
            con.Open();
            cmd = new SqlCommand("select count(*) from loginTable where kullancadi=@kula", con);
            cmd.Parameters.AddWithValue("@kula", YenikullanciAdi);
            returnvalue = (int)cmd.ExecuteScalar();
            con.Close();
            if (returnvalue == 1)
            {
                return Loginstatus.basarli;
            }
            else
            {
                return Loginstatus.basarsiz;
            }
        }
        public List<usersForAdmin> GetAllUsersForAdmin()
        {
            con.Open();
            List<usersForAdmin> userlist = new List<usersForAdmin>();
            cmd = new SqlCommand("select * from loginTable", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usersForAdmin user = new usersForAdmin();
                user.id = int.Parse(dr["id"].ToString());
                user.ad = dr["ad"].ToString();
                user.soyad = dr["soyad"].ToString();
                user.bakiye = dr["bakiye"].ToString();
                user.ibanno = dr["ibanno"].ToString();
                user.kullanciAdi = dr["kullancadi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.emailAd = dr["emailad"].ToString();
                user.GuvenlikSoru = dr["guvenliksoru"].ToString();
                user.guvenlikCevabi = dr["guvenlikcevabi"].ToString();
                userlist.Add(user);
            }
            con.Close();
            return userlist;
        }

        public Loginstatus KayitEkle(usersForAdmin user)
        {
            con.Open();
            cmd = new SqlCommand("kullanciEkle_sp",con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ad",user.ad);
            cmd.Parameters.AddWithValue("@soyad", user.soyad);
            cmd.Parameters.AddWithValue("@bakiye", user.bakiye);
            cmd.Parameters.AddWithValue("@kullanciadi", user.kullanciAdi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@emailad", user.emailAd);
            cmd.Parameters.AddWithValue("@ibanno", user.ibanno);
            cmd.Parameters.AddWithValue("@guvenliksoru", user.GuvenlikSoru);
            cmd.Parameters.AddWithValue("@guvenlikcevabi", user.guvenlikCevabi);
            returnvalue= cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue==1)
            {
                return Loginstatus.basarli;
            }
            else
            {
                return Loginstatus.basarsiz;
            }
        }
        public Loginstatus kayitGuncelle(usersForAdmin user)
        {
            con.Open();
            cmd = new SqlCommand("kullanciGuncelle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@ad", user.ad);
            cmd.Parameters.AddWithValue("@soyad", user.soyad);
            cmd.Parameters.AddWithValue("@bakiye", user.bakiye);
            cmd.Parameters.AddWithValue("@kullanciadi", user.kullanciAdi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@emailad", user.emailAd);
            cmd.Parameters.AddWithValue("@ibanno", user.ibanno);
            cmd.Parameters.AddWithValue("@guvenliksoru", user.GuvenlikSoru);
            cmd.Parameters.AddWithValue("@guvenlikcevabi", user.guvenlikCevabi);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return Loginstatus.basarli;
            }
            else
            {
                return Loginstatus.basarsiz;
            }
        }
        public Loginstatus kayitSil(int id)
        {
            con.Open();

            cmd = new SqlCommand("delete from loginTable where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return Loginstatus.basarli;
            }
            else
            {
                return Loginstatus.basarsiz;
            }
        }


    }
}
