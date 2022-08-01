using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D0LP1EG;Initial Catalog=Databaseencyription;Integrated Security=True");
        private void BTNKAYDET_Click(object sender, EventArgs e)
        {  
         
            //Ad şifreleme
            String ad = TXTAD.Text;
            //girdiğim adı asci deger tablosuna göre kodladı ve veridizisi değişkenin içine attı
            byte[]addizisi=ASCIIEncoding.ASCII.GetBytes(ad);
            //tobase64 bir şifreleme metodudur. bu metot ile veridizisindeki şifrelidiziyi string formatında şifreli veri içine yazdı
            string adsifre = Convert.ToBase64String(addizisi);

            // soyad şifreleme
            string soyad = TXTSOYAD.Text;
            byte[] soyaddizisi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizisi);
            //Mail şifreleme
            string mail =TXTMAIL.Text;
            byte[] maildizisi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizisi);

            string sifre = TXTSIFRE.Text;
            byte[] sifredizisi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizisi);

            string hesapno = TXTHESAPNO.Text;
            byte[] hesapnodizisi = ASCIIEncoding.ASCII.GetBytes(hesapno);
            string hesapnosifre= Convert.ToBase64String(hesapnodizisi);
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) VALUES (@P1,@P2,@P3,@P4,@P5)", baglanti);
            komut.Parameters.AddWithValue("@P1", adsifre);
            komut.Parameters.AddWithValue("@P2", soyadsifre);
            komut.Parameters.AddWithValue("@P3", mailsifre);
            komut.Parameters.AddWithValue("@P4", sifresifre);
            komut.Parameters.AddWithValue("@P5", hesapnosifre);
            komut.ExecuteNonQuery();
          baglanti.cl
            
            MessageBox.Show("Kişi Kaydedildi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLVERILER ", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
