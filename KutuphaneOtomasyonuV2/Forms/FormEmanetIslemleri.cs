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
    public partial class FormEmanetIslemleri : MaterialSkin.Controls.MaterialForm
    {
        public static MaterialSkin.Controls.MaterialListView TabloEmanet;

        //SQL ve MaterialSkinManager Tanımlamaları
        SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);
        MaterialSkinManager skinManager;
        public FormEmanetIslemleri()
        {
            InitializeComponent();
            verileriGoruntule();
            this.TabloEmanetIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            TabloEmanet = TabloEmanetIslemleri;
            //Gereksiz Ama Kalsın (MaterialSkin Ayarları)
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue200, Primary.Blue200, Primary.Blue200, Accent.Yellow200, TextShade.WHITE);
        }

        private void verileriGoruntule()
        {
            //Her Butona Basıldığında Tabloyu Temizleme
            TabloEmanetIslemleri.Items.Clear();

            //SQL Bağlantısı
            SQLBaglanti.Open();
            SqlCommand command = new SqlCommand("Select *From Emanetler", SQLBaglanti);
            SqlDataReader dr = command.ExecuteReader();

            //Tabloya klnn Veriler
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["EmanetNo"].ToString();
                ekle.SubItems.Add(dr["UyeNo"].ToString());
                ekle.SubItems.Add(dr["KitapNo"].ToString());
                ekle.SubItems.Add(dr["EmanetVermeTarihi"].ToString());
                ekle.SubItems.Add(dr["EmanetAlmaTarihi"].ToString());
                ekle.SubItems.Add(dr["EmanetNot"].ToString());

                TabloEmanetIslemleri.Items.Add(ekle);
            }
            SQLBaglanti.Close();
        }

        private void btnVerileriYenile_Click(object sender, EventArgs e)
        {
            verileriGoruntule();
        }

        FormEmanetEkle FormEmanetEkleme = new FormEmanetEkle();
        private void btnEmanetEkle_Click(object sender, EventArgs e)
        {
            FormEmanetEkleme.Show();
        }

        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            SQLBaglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Emanetler where EmanetNo = (" + id + ")", SQLBaglanti);
            komut.ExecuteNonQuery();
            SQLBaglanti.Close();
            verileriGoruntule();
        }

        private void btnEmanetTeslimTarihGuncelleme_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select *From Emanetler where EmanetAlmaTarihi='"+ EmanetAlmaTarihi +"'", SQLBaglanti);
            SQLBaglanti.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string tarih = Convert.ToString(reader["EmanetAlmaTarihi"]);
                tarih = Convert.ToString(DateTime.Now.Date);
            }
            SQLBaglanti.Close();
            
        }

        private void TabloEmanetIslemleri_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(TabloEmanetIslemleri.SelectedItems[0].SubItems[0].Text);
        }
    }
}
