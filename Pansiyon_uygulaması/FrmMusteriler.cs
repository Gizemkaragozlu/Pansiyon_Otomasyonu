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
    public partial class FrmMusteriler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=TP-GKARAGOZLU;Initial Catalog=DbPansiyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblMusteriEkle" ,baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarih"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //Verileri Textboxlara taşıma işlemi
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);//Kök değer
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;//SubItems[1] tablodaki kaçıncı sütuna denk geliyorsa o yazılır.
            TxtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarih.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarih.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
          
            if(TxtOdaNo.Text == "101")
                {
                baglanti.Open();
                // SqlCommand komut = new SqlCommand("Delete From TblMusteriEkle Where Musteriid=(" + id + ")",baglanti);
                SqlCommand komut = new SqlCommand("Delete From TblOda101" , baglanti);//Veri tabanından siler
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
            }

            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From TblOda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
            }

            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From TblOda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
            }

            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From TblOda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
            }

            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From TblOda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
            }

            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From TblOda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
            }

            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From TblOda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
            }

            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From TblOda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
            }

            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From TblOda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyad.Clear();
            comboBox1.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Clear();
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarih.Text = "";
            DtpCikisTarih.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand ("update TblMusteriEkle set " +
                "Adi='"+TxtAdi.Text+"'," +
                "Soyadi='"+TxtSoyad.Text+"'," +
                "Cinsiyet='"+comboBox1.Text+"'," +
                "Telefon='"+MskTxtTelefon.Text+ "'," +
                "Mail='" + TxtMail.Text + "'," +
                "TC='" + TxtKimlikNo.Text + "'," +
                "OdaNo='" + TxtOdaNo.Text + "'," +
                "Ucret='" + TxtUcret.Text + "'," +
                "GirisTarihi='" + DtpGirisTarih.Value.ToString("yyyy.MM.dd") + "'," +
                "CikisTarih='" + DtpCikisTarih.Value.ToString("yyyy.MM.dd") + "' " +
                "where Musteriid=" + id+"",baglanti);
            komut.ExecuteNonQuery();//Gönderilen parametreler üzerinde değişiklik yapar
            baglanti.Close();
            verilerigoster();
        }

        private void TxtIsimAra_EditValueChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblMusteriEkle where Adi Like '%"+TxtIsimAra.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarih"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {

        }
    }
}
