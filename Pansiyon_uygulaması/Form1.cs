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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=TP-GKARAGOZLU;Initial Catalog=DbPansiyon;Integrated Security=True");
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
              if(TxtKullaniciAdi.Text == "admin " && TxtSifre.Text == "12345") //Kullanıcı girişi admin ve şifre 12345 olmalı 
              {
                  FrmAnaForm fr = new FrmAnaForm();//Kullanıcı girişi doğru ise Anaform açılacak.
                  fr.Show();
                  fr.Hide();
              }
              else
              {
                  MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");//Şartlar sağlanmıyorsa mesaj verilecek.
              }
            
         

        }
    }
}
