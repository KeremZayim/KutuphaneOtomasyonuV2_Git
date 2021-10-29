using KutuphaneOtomasyonuV2.Classes;
using KutuphaneOtomasyonuV2.Forms;
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
using MaterialSkin;

namespace KutuphaneOtomasyonuV2.Forms
{
    public partial class FormUyeEkle : Form
    {
        //SQL ve MaterialSkinManager Tanımlamaları
        SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);
        public FormUyeEkle()
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
            FormUyeIslemleri.TabloUye.Items.Clear();

            //SQL Bağlantısı
            SQLBaglanti.Open();
            SqlCommand command = new SqlCommand("Select *From Uyeler", SQLBaglanti);
            SqlDataReader dr = command.ExecuteReader();

            //Tabloya Eklenen Veriler
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["UyeNo"].ToString();
                ekle.SubItems.Add(dr["UyeAd"].ToString());
                ekle.SubItems.Add(dr["UyeSoyad"].ToString());
                ekle.SubItems.Add(dr["UyeTelefon"].ToString());
                ekle.SubItems.Add(dr["UyeEposta"].ToString());

                FormUyeIslemleri.TabloUye.Items.Add(ekle);
            }
            SQLBaglanti.Close();
        }
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            if (tbUyeAdi.Text != "" && tbUyeSoyad.Text != "" && tbUyeTelefon.Text != "" && tbUyeEposta.Text != "")
            {
                SQLBaglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Uyeler (UyeAd,UyeSoyad,UyeTelefon,UyeEposta) values ('" + tbUyeAdi.Text.ToString() + "','" + tbUyeSoyad.Text.ToString() + "','" + tbUyeTelefon.Text.ToString() + "','" + tbUyeEposta.Text.ToString() + "')", SQLBaglanti);
                komut.ExecuteNonQuery();
                SQLBaglanti.Close();
                verileriGoruntule();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!","Uye Eklenemedi!");
            }
        }
    }
}
