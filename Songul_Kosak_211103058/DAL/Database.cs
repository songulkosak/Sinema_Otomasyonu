using Dapper;
using Songul_Kosak_211103058.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songul_Kosak_211103058.DAL
{
    public class Database
    {
        private string ConnectionString = @"
Server=DESKTOP-ER0GUQT\SQLEXPRESS;
Database=otomasyonsinema;
Integrated Security=true;";

        public List<KullaniciGiris> Giris(KullaniciGiris a)
        {
            using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<KullaniciGiris>("select * from KullaniciGiris where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre", a).ToList();
            }
        }
        public void FilmEkle(Film film)
        {
            using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                var result = db.Execute("Insert into Film values (@FilmAdi,@Yonetmen,@FilmTuru,@FilmSuresi,@FilmVizyonTarihi,@Oyuncular,@Afis)", film);
            }
        }
        public List<Film> FilmListele()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                return con.Query<Film>("select * from Film").ToList();
            }
        }
        public void FilmSil(Film film)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                var result = con.Execute("delete Film where FilmId=@FilmId", film);
            }
        }
        public void SalonEkle(Salon salon)
        {
            using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                var result = db.Execute("Insert into Salon values (@SalonAdi,@SalonTasarimi)", salon);
            }
        }
        public void SatisGuncelle(Satis2 guncelle)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                var result = con.Execute(@"update Satis2 set Seansi=@Seansi,FilmAdi=@FilmAdi,AdSoyad=@AdSoyad,Salon=SalonAdi,KoltukNo=@KoltukNo,TelNo=@TelNo,Ucret=@Ucret,SatisTarihi=@SatisTarihi where SatisId=@SatisId", guncelle);
            }
        }
        public List<Satis2> SatisListele()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                return con.Query<Satis2>("select * from Satis2").ToList();
            }
        }
        public List<Seans> GetSeanslar()
        {
            using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Seans>("select * from Seans").ToList();
            }
        }
        public List<Film> GetFilmler()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                return con.Query<Film>("select * from Film").ToList();
            }
        }
        public List<Salon> Salon()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                return con.Query<Salon>("select * from Salon").ToList();
            }
        }
        public void Koltukİptal(int Id)
        {
            var str = "delete from SatisTable where KoltukNo = @p1";
            using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                var result = db.Execute(str, new { p1 = Id });

            }
        }
        public void SatisEkle(Satis2 satis)
        {
            using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                var result = db.Execute("Insert into Satis2 values (@KoltukNo,@Saat,@AdSoyad,@TelNo,@Ucret)", satis);
            }
        }
        public List<Satis2> GetSatislar()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                return con.Query<Satis2>(@"select * from Satis2 ").ToList();
            }
        }
    }
}
