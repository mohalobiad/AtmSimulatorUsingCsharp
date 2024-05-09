using ATMUygulamasi.dao;
using ATMUygulamasi.enumlar;
using ATMUygulamasi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi.controller
{
    public class Controller
    {
        veritabani vrtabn;
        public Controller()
        {
          vrtabn = new veritabani(); 
        }

        public User login(string kullanciAdi, string sifre)
        {
            User result = new User();
            if ( !string.IsNullOrEmpty(kullanciAdi) && !string.IsNullOrEmpty(sifre))
            {
                result = vrtabn.login(kullanciAdi,sifre);

                return result;
            }
            else
            {
               User user = new User();
                user.status = Loginstatus.eksikparamete;
                return user;
            }
            
        }

        public List<LoginTable> logintablu()
        {
            veritabani veritabani = new veritabani();
            List<LoginTable> logintablelist = veritabani.logintablu();
            return logintablelist;
        }

        public Loginstatus geAuthentication(string kullanciadi, string guvenliksorusu, string guvenlikcevabi)
        {
            
            if(!string.IsNullOrEmpty(kullanciadi) && !string.IsNullOrEmpty(guvenliksorusu) && !string.IsNullOrEmpty(guvenlikcevabi))
            {
                Loginstatus result = vrtabn.geAuthentication(kullanciadi, guvenliksorusu, guvenlikcevabi);
                if ( result== Loginstatus.basarli)
                {
                    return result;
                }
                else
                {
                    return Loginstatus.basarsiz;
                }

            }
            else
            {
                return Loginstatus.eksikparamete;
            }
        }
        public Loginstatus getgeAuthenticationEmail(string emali)
        {
            if (!string.IsNullOrEmpty(emali))
            {
                
                Loginstatus result = vrtabn.getgeAuthenticationEmail(emali);
                if (result==Loginstatus.basarli)
                {
                    return result;
                }
                else
                {
                    return Loginstatus.basarsiz;
                }

            }
            else
            {
                return Loginstatus.eksikparamete;
            }
        }
        public string getkullanciad(string emailAd)
        {
            veritabani veritabani = new veritabani();
            string kullanciadi = veritabani.getkullanciad(emailAd);
            return kullanciadi;
        }
        public Loginstatus ChanngePassword(string email, string sifre,string tekrarsifre)
        {
            if (!string.IsNullOrEmpty(sifre) && !string.IsNullOrEmpty(tekrarsifre))
            { 
                if (sifre==tekrarsifre)
                {
                    return vrtabn.ChanngePassword(email, sifre);
                }
                else
                {
                    return Loginstatus.eşitdegil;
                }
                
            }

            else
            {
                return Loginstatus.eksikparamete;
            }
        }
        public aboneBilgileri GetAdSoyadBakiye(string logindenGelenKullanciadi)
        {
           return vrtabn.GetAdSoyadBakiye(logindenGelenKullanciadi);
        }
        public Loginstatus parayatır(int yenibakiye, string logindenGelenKullanciadi)
        {
      
            
                return vrtabn.parayatır(yenibakiye, logindenGelenKullanciadi);
           
        }
        public Loginstatus paracek(int yenibakiye, string logindenGelenKullanciadi)
        {
            return vrtabn.paracek(yenibakiye, logindenGelenKullanciadi);
        }
        public aboneBilgileri Getkullanciwhithiban(string iban)
        {
            return vrtabn.Getkullanciwhithiban(iban);
        }
        public Loginstatus getgeAuthenticationiban(string iban)
        {
            Loginstatus result = vrtabn.getgeAuthenticationiban(iban);
            if (result == Loginstatus.basarli)
            {
                return result;
            }
            else
            {
                return Loginstatus.basarsiz;
            }
        }
        public Loginstatus parayatıribanile(int yenibakiye, string iban)
        {
            return vrtabn.parayatıribanile(yenibakiye, iban);
        }
        public aboneBilgileri GetTumAboneBilgileri(string logindenGelenKullanciadi)
        {
            return vrtabn.GetTumAboneBilgileri(logindenGelenKullanciadi);
        }
        public Loginstatus getAuthenticationKullanciAdi(string YenikullanciAdi)
        {
            if (!string.IsNullOrEmpty(YenikullanciAdi))
            {
                
                return vrtabn.getAuthenticationKullanciAdi(YenikullanciAdi);
            }
            else
            {
                return Loginstatus.eksikparamete;

            }
        }
        public List<usersForAdmin> GetAllUsersForAdmin()
        {
            return vrtabn.GetAllUsersForAdmin();
        }
        public Loginstatus KayitEkle(usersForAdmin user)
        {
            if(!string.IsNullOrEmpty(user.ad)&& !string.IsNullOrEmpty(user.soyad) && !string.IsNullOrEmpty(user.bakiye) && !string.IsNullOrEmpty(user.kullanciAdi) && !string.IsNullOrEmpty(user.sifre) && !string.IsNullOrEmpty(user.yetki) && !string.IsNullOrEmpty(user.emailAd) && !string.IsNullOrEmpty(user.ibanno) && !string.IsNullOrEmpty(user.GuvenlikSoru) && !string.IsNullOrEmpty(user.guvenlikCevabi))
            {
             
                return vrtabn.KayitEkle(user);
            }
            else
            {
                return Loginstatus.eksikparamete;
            }
        }
        public Loginstatus kayitGuncelle(usersForAdmin user)
        {
            if (!string.IsNullOrEmpty(user.ad) && !string.IsNullOrEmpty(user.soyad) && !string.IsNullOrEmpty(user.bakiye) && !string.IsNullOrEmpty(user.kullanciAdi) && !string.IsNullOrEmpty(user.sifre) && !string.IsNullOrEmpty(user.yetki) && !string.IsNullOrEmpty(user.emailAd) && !string.IsNullOrEmpty(user.ibanno) && !string.IsNullOrEmpty(user.GuvenlikSoru) && !string.IsNullOrEmpty(user.guvenlikCevabi))
            {

                return vrtabn.kayitGuncelle(user);
            }
            else
            {
                return Loginstatus.eksikparamete;
            }
        }
        public Loginstatus kayitSil(int id)
        {
            return vrtabn.kayitSil(id);
        }


    }
}
