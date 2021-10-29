using KutuphaneOtomasyonuV2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuV2.Forms
{
    public partial class FormKitapEkle : Form
    {
        //SQL Bağlantısı
        SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);
        public FormKitapEkle()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        // Taşınabilir Form Ayarları
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TasimaIslemi(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void verileriGoruntule()
        {
            //Her Butona Basıldığında Tabloyu Temizleme
            FormKitapIslemleri.TabloKitap.Items.Clear();

            //SQL Bağlantısı
            SQLBaglanti.Open();
            SqlCommand command = new SqlCommand("Select *From Kitaplar", SQLBaglanti);
            SqlDataReader dr = command.ExecuteReader();

            //Tabloya klnn Veriler
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["KitapNo"].ToString();
                ekle.SubItems.Add(dr["KitapAd"].ToString());
                ekle.SubItems.Add(dr["KitapYazar"].ToString());
                ekle.SubItems.Add(dr["KitapSayfaSayi"].ToString());
                ekle.SubItems.Add(dr["KitapYayinEvi"].ToString());
                ekle.SubItems.Add(dr["KitapNot"].ToString());

                FormKitapIslemleri.TabloKitap.Items.Add(ekle);
            }
            SQLBaglanti.Close();
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            if (tbKitapAdi.Text != "" && tbKitapNo.Text != "" && tbSayfaSayi.Text != "" && tbYayinEvi.Text != "" && tbYazar.Text != "")
            {
                if (!Int32.TryParse(tbSayfaSayi.Text, out int sayi))
                {
                    MessageBox.Show($"Yanlış Sayfa Sayısı Giriniz: {tbSayfaSayi.Text}");
                }
                else
                {
                    SQLBaglanti.Open();
                    SqlCommand kitaplist = new SqlCommand("insert into Kitaplar (KitapAd,KitapYazar,KitapSayfaSayi,KitapYayinEvi,KitapNot) values ('" + tbKitapAdi.Text.ToString() + "','" + tbYazar.Text.ToString() + "','" + tbSayfaSayi.Text.ToString() + "','" + tbYayinEvi.Text.ToString() + "','" + tbKitapNot.Text.ToString() + "')", SQLBaglanti);
                    kitaplist.ExecuteNonQuery();
                    SQLBaglanti.Close();
                    verileriGoruntule();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!", "Kitap Eklenemedi!");
            }
        }
    }
}
