using KutuphaneOtomasyonuV2.Classes;
using MaterialSkin;
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
    public partial class FormAdminPaneli : MaterialSkin.Controls.MaterialForm
    {
        public static MaterialSkin.Controls.MaterialListView TabloAdmin;

        //SQL ve MaterialSkinManager Tanımlamaları
        SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);
        MaterialSkinManager skinManager;
        public FormAdminPaneli()
        {
            InitializeComponent();
            TabloAdmin = TabloAdminIslemleri;
            
            //Gereksiz Ama Kalsın (MaterialSkin Ayarları)
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue200, Primary.Blue200, Primary.Blue200, Accent.Yellow200, TextShade.WHITE);
        }
        private void verileriGoruntule()
        {
            //Her Butona Basıldığında Tabloyu Temizleme
            TabloAdminIslemleri.Items.Clear();

            //SQL Bağlantısı
            SQLBaglanti.Open();
            SqlCommand command = new SqlCommand("Select *From Admin", SQLBaglanti);
            SqlDataReader dr = command.ExecuteReader();

            //Tabloya klnn Veriler
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["AdminID"].ToString();
                ekle.SubItems.Add(dr["username"].ToString());
                ekle.SubItems.Add(dr["password"].ToString());

                TabloAdminIslemleri.Items.Add(ekle);
            }
            SQLBaglanti.Close();
        }

        private void btnVerileriYenile_Click(object sender, EventArgs e)
        {
            verileriGoruntule();
        }

        private void FormAdminPaneli_Load(object sender, EventArgs e)
        {
            verileriGoruntule();
        }
        FormAdminEkle AddAdmin = new FormAdminEkle();
        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            AddAdmin.Show();
        }
        
        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            SQLBaglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Admin where AdminID = (" + id + ")", SQLBaglanti);
            komut.ExecuteNonQuery();
            SQLBaglanti.Close();
            verileriGoruntule();
        }

        private void TabloAdminIslemleri_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(TabloAdminIslemleri.SelectedItems[0].SubItems[0].Text);
        }
    }
}
