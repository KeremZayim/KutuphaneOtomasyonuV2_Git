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
    public partial class FormAdminEkle : Form
    {
        //SQL ve MaterialSkinManager Tanımlamaları
        SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);

        public FormAdminEkle()
        {
            InitializeComponent();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();   
        }
        private void verileriGoruntule()
        {
            //Her Butona Basıldığında Tabloyu Temizleme
            FormAdminPaneli.TabloAdmin.Items.Clear();

            //SQL Bağlantısı
            SQLBaglanti.Open();
            SqlCommand command = new SqlCommand("Select *From Admin", SQLBaglanti);
            SqlDataReader dr = command.ExecuteReader();

            //Tabloya Eklenen Veriler
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["AdminID"].ToString();
                ekle.SubItems.Add(dr["username"].ToString());
                ekle.SubItems.Add(dr["password"].ToString());

                FormAdminPaneli.TabloAdmin.Items.Add(ekle);
            }
            SQLBaglanti.Close();
        }
        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            if (tbKullaniciAdi.Text != "" && tbSifre.Text != "")
            {
                SQLBaglanti.Open();
                SqlCommand EmanetEkle = new SqlCommand("insert into Admin (username,password) values ('" + tbKullaniciAdi.Text.ToString() + "','" + tbSifre.Text.ToString() + "')", SQLBaglanti);
                EmanetEkle.ExecuteNonQuery();
                SQLBaglanti.Close();
                verileriGoruntule();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!", "Admin Eklenemedi!");
            }
        }
    }
}
