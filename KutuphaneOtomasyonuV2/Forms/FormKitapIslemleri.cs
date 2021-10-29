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
    public partial class FormKitapIslemleri : MaterialSkin.Controls.MaterialForm
    {
        public static MaterialSkin.Controls.MaterialListView TabloKitap;

        //SQL ve MaterialSkinManager Tanımlamaları
        SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);
        MaterialSkinManager skinManager;
        public FormKitapIslemleri()
        {
            InitializeComponent();
            verileriGoruntule();
            this.TabloKitapIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            TabloKitap = TabloKitapIslemleri;

            //Gereksiz Ama Kalsın (MaterialSkin Ayarları)
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue200, Primary.Blue200, Primary.Blue200, Accent.Yellow200, TextShade.WHITE);
        }

        private void verileriGoruntule()
        {
            //Her Butona Basıldığında Tabloyu Temizleme
            TabloKitapIslemleri.Items.Clear();

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

                TabloKitapIslemleri.Items.Add(ekle);
            }
            SQLBaglanti.Close();
        }

        private void btnVerileriYenile_Click(object sender, EventArgs e)
        {
            verileriGoruntule();
        }

        //Sil Butonu
        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            SQLBaglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Kitaplar where KitapNo = (" + id + ")", SQLBaglanti);
            komut.ExecuteNonQuery();
            SQLBaglanti.Close();
            verileriGoruntule();
        }
        private void TabloKitapIslemleri_Click(object sender, EventArgs e)
        {
            id = int.Parse(TabloKitapIslemleri.SelectedItems[0].SubItems[0].Text);
        }
        FormKitapEkle FormKitapEkleme = new FormKitapEkle();
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                FormKitapEkleme.Show();
            }
            catch (Exception)
            {

            }
        }
    }
}
