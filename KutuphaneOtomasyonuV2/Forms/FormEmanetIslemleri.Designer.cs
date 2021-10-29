
namespace KutuphaneOtomasyonuV2.Forms
{
    partial class FormEmanetIslemleri
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
            this.TabloEmanetIslemleri = new MaterialSkin.Controls.MaterialListView();
            this.EmanetNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UyeNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KitapNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmanetVermeTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmanetAlmaTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmanetNot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerileriYenile = new System.Windows.Forms.Button();
            this.btnEmanetEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEmanetTeslimTarihGuncelleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TabloEmanetIslemleri
            // 
            this.TabloEmanetIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabloEmanetIslemleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmanetNo,
            this.UyeNo,
            this.KitapNo,
            this.EmanetVermeTarihi,
            this.EmanetAlmaTarihi,
            this.EmanetNot});
            this.TabloEmanetIslemleri.Depth = 0;
            this.TabloEmanetIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TabloEmanetIslemleri.FullRowSelect = true;
            this.TabloEmanetIslemleri.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TabloEmanetIslemleri.Location = new System.Drawing.Point(12, 80);
            this.TabloEmanetIslemleri.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TabloEmanetIslemleri.MouseState = MaterialSkin.MouseState.OUT;
            this.TabloEmanetIslemleri.Name = "TabloEmanetIslemleri";
            this.TabloEmanetIslemleri.OwnerDraw = true;
            this.TabloEmanetIslemleri.Scrollable = false;
            this.TabloEmanetIslemleri.Size = new System.Drawing.Size(966, 529);
            this.TabloEmanetIslemleri.TabIndex = 2;
            this.TabloEmanetIslemleri.UseCompatibleStateImageBehavior = false;
            this.TabloEmanetIslemleri.View = System.Windows.Forms.View.Details;
            this.TabloEmanetIslemleri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabloEmanetIslemleri_MouseClick);
            // 
            // EmanetNo
            // 
            this.EmanetNo.Text = "Emanet No";
            this.EmanetNo.Width = 153;
            // 
            // UyeNo
            // 
            this.UyeNo.Text = "Uye No";
            this.UyeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UyeNo.Width = 136;
            // 
            // KitapNo
            // 
            this.KitapNo.Text = "Kitap No";
            this.KitapNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KitapNo.Width = 140;
            // 
            // EmanetVermeTarihi
            // 
            this.EmanetVermeTarihi.Text = "Veriliş Tarihi";
            this.EmanetVermeTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmanetVermeTarihi.Width = 175;
            // 
            // EmanetAlmaTarihi
            // 
            this.EmanetAlmaTarihi.Text = "İade Tarihi";
            this.EmanetAlmaTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmanetAlmaTarihi.Width = 161;
            // 
            // EmanetNot
            // 
            this.EmanetNot.Text = "Emanet Not";
            this.EmanetNot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmanetNot.Width = 156;
            // 
            // btnVerileriYenile
            // 
            this.btnVerileriYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerileriYenile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerileriYenile.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVerileriYenile.Location = new System.Drawing.Point(272, 615);
            this.btnVerileriYenile.Name = "btnVerileriYenile";
            this.btnVerileriYenile.Size = new System.Drawing.Size(134, 54);
            this.btnVerileriYenile.TabIndex = 3;
            this.btnVerileriYenile.Text = "Verileri Yenile";
            this.btnVerileriYenile.UseVisualStyleBackColor = false;
            this.btnVerileriYenile.Click += new System.EventHandler(this.btnVerileriYenile_Click);
            // 
            // btnEmanetEkle
            // 
            this.btnEmanetEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmanetEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEmanetEkle.Location = new System.Drawing.Point(429, 615);
            this.btnEmanetEkle.Name = "btnEmanetEkle";
            this.btnEmanetEkle.Size = new System.Drawing.Size(134, 54);
            this.btnEmanetEkle.TabIndex = 3;
            this.btnEmanetEkle.Text = "Emanet Ekle";
            this.btnEmanetEkle.UseVisualStyleBackColor = false;
            this.btnEmanetEkle.Click += new System.EventHandler(this.btnEmanetEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSil.Location = new System.Drawing.Point(584, 615);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 54);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEmanetTeslimTarihGuncelleme
            // 
            this.btnEmanetTeslimTarihGuncelleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmanetTeslimTarihGuncelleme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetTeslimTarihGuncelleme.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEmanetTeslimTarihGuncelleme.Location = new System.Drawing.Point(844, 615);
            this.btnEmanetTeslimTarihGuncelleme.Name = "btnEmanetTeslimTarihGuncelleme";
            this.btnEmanetTeslimTarihGuncelleme.Size = new System.Drawing.Size(134, 54);
            this.btnEmanetTeslimTarihGuncelleme.TabIndex = 3;
            this.btnEmanetTeslimTarihGuncelleme.Text = "Emanet Teslim Tarihi Güncelle";
            this.btnEmanetTeslimTarihGuncelleme.UseVisualStyleBackColor = false;
            this.btnEmanetTeslimTarihGuncelleme.Click += new System.EventHandler(this.btnEmanetTeslimTarihGuncelleme_Click);
            // 
            // FormEmanetIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 681);
            this.ControlBox = false;
            this.Controls.Add(this.TabloEmanetIslemleri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEmanetTeslimTarihGuncelleme);
            this.Controls.Add(this.btnEmanetEkle);
            this.Controls.Add(this.btnVerileriYenile);
            this.Name = "FormEmanetIslemleri";
            this.Text = "FormEmanetIslemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView TabloEmanetIslemleri;
        private System.Windows.Forms.ColumnHeader EmanetNo;
        private System.Windows.Forms.ColumnHeader UyeNo;
        private System.Windows.Forms.ColumnHeader KitapNo;
        private System.Windows.Forms.ColumnHeader EmanetVermeTarihi;
        private System.Windows.Forms.ColumnHeader EmanetAlmaTarihi;
        private System.Windows.Forms.ColumnHeader EmanetNot;
        private System.Windows.Forms.Button btnVerileriYenile;
        private System.Windows.Forms.Button btnEmanetEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEmanetTeslimTarihGuncelleme;
    }
}