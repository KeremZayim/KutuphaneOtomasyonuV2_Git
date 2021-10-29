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

namespace KutuphaneOtomasyonuV2.Forms
{
    public partial class FormEmanetEkle : Form
    {
        //SQL ve MaterialSkinManager Tanımlamaları
        SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);
        public FormEmanetEkle()
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

        void KitapNoList()
        {
            SQLBaglanti.Open();

            SqlCommand KitapNoEkle = new SqlCommand("SELECT KitapNo FROM Kitaplar", SQLBaglanti);
            SqlDataReader dr = KitapNoEkle.ExecuteReader();
            while (dr.Read())
            {
                cbKitapNo.Items.Add(dr[0]);
            }


            SQLBaglanti.Close();
        }
        void UyeNoList()
        {
            SQLBaglanti.Open();

            SqlCommand KitapNoEkle = new SqlCommand("SELECT UyeNo FROM Uyeler", SQLBaglanti);
            SqlDataReader dr = KitapNoEkle.ExecuteReader();
            while (dr.Read())
            {
                cbUyeNo.Items.Add(dr[0]);
            }


            SQLBaglanti.Close();
        }

        private void FormEmanetEkle_Load(object sender, EventArgs e)
        {
            KitapNoList();
            UyeNoList();
        }

        private void verileriGoruntule()
        {
            //Her Butona Basıldığında Tabloyu Temizleme
            FormEmanetIslemleri.TabloEmanet.Items.Clear();

            //SQL Bağlantısı
            SQLBaglanti.Open();
            SqlCommand command = new SqlCommand("Select *From Emanetler", SQLBaglanti);
            SqlDataReader dr = command.ExecuteReader();

            //Tabloya Eklenen Veriler
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["EmanetNo"].ToString();
                ekle.SubItems.Add(dr["UyeNo"].ToString());
                ekle.SubItems.Add(dr["KitapNo"].ToString());
                ekle.SubItems.Add(dr["EmanetVermeTarihi"].ToString());
                ekle.SubItems.Add(dr["EmanetAlmaTarihi"].ToString());
                ekle.SubItems.Add(dr["EmanetNot"].ToString());

                FormEmanetIslemleri.TabloEmanet.Items.Add(ekle);
            }
            SQLBaglanti.Close();
        }
        private void btnEmanetEkle_Click(object sender, EventArgs e)
        {
            if (cbUyeNo.Text != "" && cbKitapNo.Text != "")
            {
                SQLBaglanti.Open();
                SqlCommand EmanetEkle = new SqlCommand("insert into Emanetler (UyeNo,KitapNo,EmanetVermeTarihi,EmanetAlmaTarihi,EmanetNot) values ('" + cbUyeNo.Text.ToString() + "','" + cbKitapNo.Text.ToString() + "','" + DateTime.Now.Date.ToString() + "','" + tbEmanetAlmaTarihi.Text.ToString() + "','" + tbEmanetNot.Text.ToString() + "')", SQLBaglanti);
                EmanetEkle.ExecuteNonQuery();
                SQLBaglanti.Close();
                verileriGoruntule();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!", "Emanet Eklenemedi!");
            }
        }
    }
}
