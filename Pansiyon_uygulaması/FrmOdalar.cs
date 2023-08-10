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
    public partial class FrmOdalar : Form
    {
        
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TP-GKARAGOZLU;Initial Catalog=DbPansiyon;Integrated Security=True");
        private void BtnOda101_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOda101", baglanti);
            SqlDataReader oku1 = komut.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " "+oku1["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda101.Text != "101") ;
            {
                BtnOda101.BackColor = Color.Red;
            }


        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOda102", baglanti);
            SqlDataReader oku2 = komut.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda102.Text != "102") ;
            {
                BtnOda102.BackColor = Color.Red;
            }
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOda103", baglanti);
            SqlDataReader oku3 = komut.ExecuteReader();


            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda103.Text != "103") ;
            {
                BtnOda103.BackColor = Color.Red;
            }
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOda104", baglanti);
            SqlDataReader oku4 = komut.ExecuteReader();


            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda104.Text != "104");
            {
                BtnOda104.BackColor = Color.Red;
            }

        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOda105", baglanti);
            SqlDataReader oku5 = komut.ExecuteReader();


            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda105.Text != "105") ;
            {
                BtnOda105.BackColor = Color.Red;
            }
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOda106", baglanti);
            SqlDataReader oku6 = komut.ExecuteReader();


            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda106.Text != "106") ;
            {
                BtnOda106.BackColor = Color.Red;
            }
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOda107", baglanti);
            SqlDataReader oku7 = komut.ExecuteReader();


            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda107.Text != "107") ;
            {
                BtnOda107.BackColor = Color.GreenYellow;
            }
           
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOda108", baglanti);
            SqlDataReader oku8 = komut.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();

            }
            baglanti.Close();

            /* if (BtnOda108.Text == "108");
             {
                 BtnOda108.BackColor = Color.GreenYellow;
             }*/
            if (BtnOda108.Text == "108 ")
            {
                BtnOda108.BackColor = Color.Red;
            }
            else 
            {
               
                BtnOda108.BackColor = Color.GreenYellow;
            }


        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOda109", baglanti);
            SqlDataReader oku9 = komut.ExecuteReader();


            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda109.Text != "109") ;
            {
                BtnOda109.BackColor = Color.GreenYellow;
            }
        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {

        }
    }
}
