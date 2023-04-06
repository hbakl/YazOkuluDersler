﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        //aşağıda ogrenci ekle metodu tanımlayıp, entityöğrenci sınıfından parametre isimli bir nesne türetiyoruz. Bu sayede entity öğrenci sınıfındaki değişkenlere ulaşabileceğiz.
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TblOgrenci (OgrAd,OgrSoyad,OgrNumara,OgrMail,OgrSifre) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            //eğer bağlantı kapalı ise açacak kod aşağıda
            if (komut1.Connection.State!=ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.AD);
            komut1.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komut1.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komut1.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);
            //return ile etkilenen kayıt sayısını çekiyoruz. bu sayı sorunsuz dönüyorsa proje çalışıyor demektir.
            return komut1.ExecuteNonQuery();
        }
    }
}