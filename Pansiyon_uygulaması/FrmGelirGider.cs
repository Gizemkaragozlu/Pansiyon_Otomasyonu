﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_uygulaması
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TP-GKARAGOZLU;Initial Catalog=DbPansiyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            LblPersonelMaas.Text = (personel * 1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text)
                - (Convert.ToInt32(LblPersonelMaas.Text)
                + Convert.ToInt32(LblAlinanUrun1.Text)
                + Convert.ToInt32(LblAlinanUrun2.Text)
                + Convert.ToInt32(LblAlinanUrun3.Text)
                + Convert.ToInt32(LblElektrik.Text)
                + Convert.ToInt32(LblSu.Text)
                + Convert.ToInt32(LblDgaz.Text));
                
               LblSonuc.Text = sonuc.ToString();

        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //Kasadaki toplam tutar...
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from TblMusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //Gıda
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida) as toplam1 from TblStoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanUrun1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();
            //İçecek
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(İcecek) as toplam2 from TblStoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlinanUrun2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();
            //Çerez
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Cerezler) as toplam3 from TblStoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlinanUrun3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            //Elektrik
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam4 from TblFaturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblElektrik.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            //Su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam5 from TblFaturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblSu.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();

            //Dogalgaz
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(Dogalgaz) as toplam6 from TblFaturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblDgaz.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();
        }
    }
}
