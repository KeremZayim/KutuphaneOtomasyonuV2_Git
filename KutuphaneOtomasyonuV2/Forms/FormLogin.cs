using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using MaterialSkin;
using KutuphaneOtomasyonuV2.Forms;
using KutuphaneOtomasyonuV2.Classes;

namespace KutuphaneOtomasyonuV2
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        public static bool Sonuc = false;

        // Taşınabilir Form Ayarları
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void MovableMenuStrip_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //Sağ Üstteki Exit Butonu
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Şifremi Unuttum Butonu
        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            //MessageBox Ya Da Farklı Bir Form Oluşturulabilir!
        }

        //Giriş Yap Butonu

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);
            string query = "Select *From Admin Where username = '" + tbKullaniciAdi.Text.Trim() + "' and password = '" + tbSifre.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, SQLBaglanti);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                //Login Formunu Kapatıp Main Formu Açtırma
                FormMain AnaForm = new FormMain();
                this.Hide();
                AnaForm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adın veya şifren yanlış!", "Giriş Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
