using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql; //Sql fonksiyonlarımı kullanmamı sağlayan kütüphane
using System.Data.SqlClient;//Sql fonksiyonlarımı kullanmamı sağlayan kütüphane

namespace Pansiyon_uygulaması
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=TP-GKARAGOZLU;Initial Catalog=DbPansiyon;Integrated Security=True");
        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101"; //oda 101'e basıldığında txtodano alanıma 101 yaz
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblOda101 (Adi,Soyadi) values (@p1,@p2)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();//Gönderilen parametreler üzerinde değişiklik yapar
            baglanti.Close();

        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblOda102 (Adi,Soyadi) values (@p1,@p2)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();//Gönderilen parametreler üzerinde değişiklik yapar
            baglanti.Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblOda103 (Adi,Soyadi) values (@p1,@p2)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();//Gönderilen parametreler üzerinde değişiklik yapar
            baglanti.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblOda104 (Adi,Soyadi) values (@p1,@p2)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();//Gönderilen parametreler üzerinde değişiklik yapar
            baglanti.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblOda105 (Adi,Soyadi) values (@p1,@p2)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();//Gönderilen parametreler üzerinde değişiklik yapar
            baglanti.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblOda106 (Adi,Soyadi) values (@p1,@p2)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();//Gönderilen parametreler üzerinde değişiklik yapar
            baglanti.Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblOda107 (Adi,Soyadi) values (@p1,@p2)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();//Gönderilen parametreler üzerinde değişiklik yapar
            baglanti.Close();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblOda108 (Adi,Soyadi) values (@p1,@p2)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();//Gönderilen parametreler üzerinde değişiklik yapar
            baglanti.Close();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblOda109 (Adi,Soyadi) values (@p1,@p2)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();//Gönderilen parametreler üzerinde değişiklik yapar
            baglanti.Close();
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void DtpCikisTarih_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarih.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarih.Text);

            TimeSpan Sonuc; //Aralarındaki Farkı alır.
           Sonuc = BuyukTarih - KucukTarih;

            label11.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label11.Text) * 50;
            TxtUcret.Text = Ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblMusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarih) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", comboBox1.Text);
            cmd.Parameters.AddWithValue("@p4", MskTxtTelefon.Text);
            cmd.Parameters.AddWithValue("@p5", TxtMail.Text);
            cmd.Parameters.AddWithValue("@p6", TxtKimlikNo.Text);
            cmd.Parameters.AddWithValue("@p7", TxtOdaNo.Text);
            cmd.Parameters.AddWithValue("@p8", TxtUcret.Text);
            cmd.Parameters.AddWithValue("@p9", DtpGirisTarih.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@p10", DtpCikisTarih.Value.ToString("yyyy-MM-dd"));
            cmd.ExecuteNonQuery();//Gönderilen parametreler üzerinde değişiklik yapar
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            //ODA 1
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOda101", baglanti);
            SqlDataReader oku1 = komut.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda101.Text != "101") ;
           
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false; //Tıklanma özelliğini kaldır
            }

            //ODA 2
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From TblOda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda102.Text != "102") ;
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }

            //ODA 3
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * From TblOda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda103.Text != "103") ;
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }

            //ODA 4
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * From TblOda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda104.Text != "104") ;
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }

            //ODA 5
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * From TblOda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda105.Text != "105") ;
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }

            //ODA 6
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * From TblOda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda106.Text != "106") ;
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }

            //ODA 7
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select * From TblOda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda107.Text != "107") 
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }
              else
            {
                BtnOda109.BackColor = Color.GreenYellow;
            }

            //ODA 8
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select * From TblOda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda108.Text != "108") 
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }
              else
            {
                BtnOda109.BackColor = Color.GreenYellow;
            }

            //ODA 9
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select * From TblOda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda109.Text != "109") 
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }
            else {
                BtnOda109.BackColor = Color.GreenYellow;
            }









        }

         
    
    }
}
//SQl bağlantı adresim = Data Source=TP-GKARAGOZLU;Initial Catalog=DbPansiyon;Integrated Security=True