using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using KutuphaneOtomasyonuV2.Classes;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonuV2.Forms
{
    public partial class FormUyeIslemleri : MaterialSkin.Controls.MaterialForm
    {
        public static MaterialSkin.Controls.MaterialListView TabloUye;

        //SQL ve MaterialSkinManager Tanımlamaları
        SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);
        MaterialSkinManager skinManager;
        public FormUyeIslemleri()
        {
            InitializeComponent();
            verileriGoruntule();
            this.TabloUyeIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            TabloUye = TabloUyeIslemleri;

            //Gereksiz Ama Kalsın (MaterialSkin Ayarları)
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue200, Primary.Blue200, Primary.Blue200, Accent.Yellow200, TextShade.WHITE);
        }

        private void FormUyeIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void verileriGoruntule()
        {
            //Her Butona Basıldığında Tabloyu Temizleme
            TabloUyeIslemleri.Items.Clear();

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

                TabloUyeIslemleri.Items.Add(ekle);
            }
            SQLBaglanti.Close();
        }

        private void btnVerileriYenile_Click(object sender, EventArgs e)
        {
            verileriGoruntule();
        }

        FormUyeEkle FormUyeEkleme = new FormUyeEkle();
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            FormUyeEkleme.Show();
        }

        //Sil Butonu
        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            SQLBaglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Uyeler where UyeNo = (" + id + ")", SQLBaglanti);
            komut.ExecuteNonQuery();
            SQLBaglanti.Close();
            verileriGoruntule();
        }

        private void TabloUyeIslemleri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(TabloUyeIslemleri.SelectedItems[0].SubItems[0].Text);
        }

        private void TabloUyeIslemleri_Click(object sender, EventArgs e)
        {
            id = int.Parse(TabloUyeIslemleri.SelectedItems[0].SubItems[0].Text);
        }
    }
}
