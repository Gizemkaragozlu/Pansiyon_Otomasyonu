using System;
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
    public partial class FrmStoklarcs : Form
    {
        public FrmStoklarcs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TP-GKARAGOZLU;Initial Catalog=DbPansiyon;Integrated Security=True");
        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblStoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblFaturalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Elektrik"].ToString();
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["Dogalgaz"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();

        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblStoklar(Gida,İcecek,Cerezler) values (@s1,@s2,@s3)", baglanti);
            cmd.Parameters.AddWithValue("@s1", TxtGidalar.Text);
            cmd.Parameters.AddWithValue("@s2", TxtIcecekler.Text);
            cmd.Parameters.AddWithValue("@s3", TxtCerezler.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            veriler();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void FrmStoklarcs_Load(object sender, EventArgs e)
        {
            veriler();
        }

        private void GrpFaturalar_Enter(object sender, EventArgs e)
        {
            veriler2();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TblFaturalar(Elektrik,Su,Dogalgaz) values (@f1,@f2,@f3)", baglanti);
            cmd.Parameters.AddWithValue("@f1", TxtElektrik.Text);
            cmd.Parameters.AddWithValue("@f2", TxtSu.Text);
            cmd.Parameters.AddWithValue("@f3", TxtDgaz.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
            MessageBox.Show("Kayıt Başarılı");
        

        }
    }
}
