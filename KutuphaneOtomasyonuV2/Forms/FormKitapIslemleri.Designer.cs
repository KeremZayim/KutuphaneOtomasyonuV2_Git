
namespace KutuphaneOtomasyonuV2.Forms
{
    partial class FormKitapIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabloKitapIslemleri = new MaterialSkin.Controls.MaterialListView();
            this.KitapNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KitapAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KitapYazar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KitapSayfaSayi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KitapYayinEvi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.not = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerileriYenile = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TabloKitapIslemleri
            // 
            this.TabloKitapIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabloKitapIslemleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KitapNo,
            this.KitapAd,
            this.KitapYazar,
            this.KitapSayfaSayi,
            this.KitapYayinEvi,
            this.not});
            this.TabloKitapIslemleri.Depth = 0;
            this.TabloKitapIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TabloKitapIslemleri.FullRowSelect = true;
            this.TabloKitapIslemleri.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TabloKitapIslemleri.Location = new System.Drawing.Point(12, 80);
            this.TabloKitapIslemleri.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TabloKitapIslemleri.MouseState = MaterialSkin.MouseState.OUT;
            this.TabloKitapIslemleri.Name = "TabloKitapIslemleri";
            this.TabloKitapIslemleri.OwnerDraw = true;
            this.TabloKitapIslemleri.Scrollable = false;
            this.TabloKitapIslemleri.Size = new System.Drawing.Size(966, 529);
            this.TabloKitapIslemleri.TabIndex = 0;
            this.TabloKitapIslemleri.UseCompatibleStateImageBehavior = false;
            this.TabloKitapIslemleri.View = System.Windows.Forms.View.Details;
            this.TabloKitapIslemleri.Click += new System.EventHandler(this.TabloKitapIslemleri_Click);
            // 
            // KitapNo
            // 
            this.KitapNo.Text = "Kitap No";
            this.KitapNo.Width = 127;
            // 
            // KitapAd
            // 
            this.KitapAd.Text = "Kitap Adı";
            this.KitapAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KitapAd.Width = 136;
            // 
            // KitapYazar
            // 
            this.KitapYazar.Text = "Kitap Yazarı";
            this.KitapYazar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KitapYazar.Width = 177;
            // 
            // KitapSayfaSayi
            // 
            this.KitapSayfaSayi.Text = "Kitap Sayfa Sayısı";
            this.KitapSayfaSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KitapSayfaSayi.Width = 240;
            // 
            // KitapYayinEvi
            // 
            this.KitapYayinEvi.Text = "Kitap Yayın Evi";
            this.KitapYayinEvi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KitapYayinEvi.Width = 199;
            // 
            // not
            // 
            this.not.Text = "Not";
            this.not.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.not.Width = 63;
            // 
            // btnVerileriYenile
            // 
            this.btnVerileriYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerileriYenile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerileriYenile.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVerileriYenile.Location = new System.Drawing.Point(276, 615);
            this.btnVerileriYenile.Name = "btnVerileriYenile";
            this.btnVerileriYenile.Size = new System.Drawing.Size(134, 54);
            this.btnVerileriYenile.TabIndex = 1;
            this.btnVerileriYenile.Text = "Verileri Yenile";
            this.btnVerileriYenile.UseVisualStyleBackColor = false;
            this.btnVerileriYenile.Click += new System.EventHandler(this.btnVerileriYenile_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSil.Location = new System.Drawing.Point(579, 615);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 54);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnKitapEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKitapEkle.Location = new System.Drawing.Point(428, 615);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(134, 54);
            this.btnKitapEkle.TabIndex = 6;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // FormKitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 681);
            this.ControlBox = false;
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnVerileriYenile);
            this.Controls.Add(this.TabloKitapIslemleri);
            this.Name = "FormKitapIslemleri";
            this.Text = "Kitap Islemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView TabloKitapIslemleri;
        private System.Windows.Forms.ColumnHeader KitapNo;
        private System.Windows.Forms.ColumnHeader KitapAd;
        private System.Windows.Forms.ColumnHeader KitapYazar;
        private System.Windows.Forms.ColumnHeader KitapSayfaSayi;
        private System.Windows.Forms.ColumnHeader KitapYayinEvi;
        private System.Windows.Forms.Button btnVerileriYenile;
        private System.Windows.Forms.ColumnHeader not;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKitapEkle;
    }
}