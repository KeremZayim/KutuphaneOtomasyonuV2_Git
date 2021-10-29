
namespace KutuphaneOtomasyonuV2.Forms
{
    partial class FormUyeIslemleri
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
            this.TabloUyeIslemleri = new MaterialSkin.Controls.MaterialListView();
            this.UyeNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UyeAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UyeSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UyeTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UyeEposta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerileriYenile = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TabloUyeIslemleri
            // 
            this.TabloUyeIslemleri.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.TabloUyeIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabloUyeIslemleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UyeNo,
            this.UyeAd,
            this.UyeSoyad,
            this.UyeTelefon,
            this.UyeEposta});
            this.TabloUyeIslemleri.Depth = 0;
            this.TabloUyeIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TabloUyeIslemleri.FullRowSelect = true;
            this.TabloUyeIslemleri.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TabloUyeIslemleri.Location = new System.Drawing.Point(12, 80);
            this.TabloUyeIslemleri.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TabloUyeIslemleri.MouseState = MaterialSkin.MouseState.OUT;
            this.TabloUyeIslemleri.Name = "TabloUyeIslemleri";
            this.TabloUyeIslemleri.OwnerDraw = true;
            this.TabloUyeIslemleri.Scrollable = false;
            this.TabloUyeIslemleri.Size = new System.Drawing.Size(966, 529);
            this.TabloUyeIslemleri.TabIndex = 2;
            this.TabloUyeIslemleri.UseCompatibleStateImageBehavior = false;
            this.TabloUyeIslemleri.View = System.Windows.Forms.View.Details;
            this.TabloUyeIslemleri.Click += new System.EventHandler(this.TabloUyeIslemleri_Click);
            this.TabloUyeIslemleri.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TabloUyeIslemleri_MouseDoubleClick);
            // 
            // UyeNo
            // 
            this.UyeNo.Text = "Üye No";
            this.UyeNo.Width = 138;
            // 
            // UyeAd
            // 
            this.UyeAd.Text = "Üye Adı";
            this.UyeAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UyeAd.Width = 152;
            // 
            // UyeSoyad
            // 
            this.UyeSoyad.Text = "Üye Soyadı";
            this.UyeSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UyeSoyad.Width = 210;
            // 
            // UyeTelefon
            // 
            this.UyeTelefon.Text = "Üye Telefonu";
            this.UyeTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UyeTelefon.Width = 215;
            // 
            // UyeEposta
            // 
            this.UyeEposta.Text = "Üye Maili";
            this.UyeEposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UyeEposta.Width = 220;
            // 
            // btnVerileriYenile
            // 
            this.btnVerileriYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerileriYenile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerileriYenile.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVerileriYenile.Location = new System.Drawing.Point(279, 615);
            this.btnVerileriYenile.Name = "btnVerileriYenile";
            this.btnVerileriYenile.Size = new System.Drawing.Size(134, 54);
            this.btnVerileriYenile.TabIndex = 3;
            this.btnVerileriYenile.Text = "Verileri Yenile";
            this.btnVerileriYenile.UseVisualStyleBackColor = false;
            this.btnVerileriYenile.Click += new System.EventHandler(this.btnVerileriYenile_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUyeEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUyeEkle.Location = new System.Drawing.Point(428, 615);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(134, 54);
            this.btnUyeEkle.TabIndex = 4;
            this.btnUyeEkle.Text = "Uye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = false;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSil.Location = new System.Drawing.Point(579, 615);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 54);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FormUyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 681);
            this.ControlBox = false;
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnUyeEkle);
            this.Controls.Add(this.TabloUyeIslemleri);
            this.Controls.Add(this.btnVerileriYenile);
            this.Name = "FormUyeIslemleri";
            this.Text = "Form Uye Islemleri";
            this.Load += new System.EventHandler(this.FormUyeIslemleri_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader UyeNo;
        private System.Windows.Forms.ColumnHeader UyeAd;
        private System.Windows.Forms.ColumnHeader UyeSoyad;
        private System.Windows.Forms.ColumnHeader UyeTelefon;
        private System.Windows.Forms.ColumnHeader UyeEposta;
        private System.Windows.Forms.Button btnVerileriYenile;
        private System.Windows.Forms.Button btnUyeEkle;
        public MaterialSkin.Controls.MaterialListView TabloUyeIslemleri;
        private System.Windows.Forms.Button btnSil;
    }
}