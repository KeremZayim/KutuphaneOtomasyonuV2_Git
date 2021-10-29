
namespace KutuphaneOtomasyonuV2.Forms
{
    partial class FormAdminPaneli
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
            this.TabloAdminIslemleri = new MaterialSkin.Controls.MaterialListView();
            this.AdminNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAdminEkle = new System.Windows.Forms.Button();
            this.btnVerileriYenile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TabloAdminIslemleri
            // 
            this.TabloAdminIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabloAdminIslemleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AdminNo,
            this.username,
            this.password});
            this.TabloAdminIslemleri.Depth = 0;
            this.TabloAdminIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TabloAdminIslemleri.FullRowSelect = true;
            this.TabloAdminIslemleri.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TabloAdminIslemleri.Location = new System.Drawing.Point(12, 80);
            this.TabloAdminIslemleri.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TabloAdminIslemleri.MouseState = MaterialSkin.MouseState.OUT;
            this.TabloAdminIslemleri.Name = "TabloAdminIslemleri";
            this.TabloAdminIslemleri.OwnerDraw = true;
            this.TabloAdminIslemleri.Scrollable = false;
            this.TabloAdminIslemleri.Size = new System.Drawing.Size(966, 529);
            this.TabloAdminIslemleri.TabIndex = 7;
            this.TabloAdminIslemleri.UseCompatibleStateImageBehavior = false;
            this.TabloAdminIslemleri.View = System.Windows.Forms.View.Details;
            this.TabloAdminIslemleri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabloAdminIslemleri_MouseClick);
            // 
            // AdminNo
            // 
            this.AdminNo.Text = "Admin ID";
            this.AdminNo.Width = 268;
            // 
            // username
            // 
            this.username.Text = "Kullanıcı Adı";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.Width = 400;
            // 
            // password
            // 
            this.password.Text = "Şifre";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.Width = 201;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSil.Location = new System.Drawing.Point(579, 615);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 54);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAdminEkle
            // 
            this.btnAdminEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdminEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdminEkle.Location = new System.Drawing.Point(428, 615);
            this.btnAdminEkle.Name = "btnAdminEkle";
            this.btnAdminEkle.Size = new System.Drawing.Size(134, 54);
            this.btnAdminEkle.TabIndex = 10;
            this.btnAdminEkle.Text = "Admin Ekle";
            this.btnAdminEkle.UseVisualStyleBackColor = false;
            this.btnAdminEkle.Click += new System.EventHandler(this.btnAdminEkle_Click);
            // 
            // btnVerileriYenile
            // 
            this.btnVerileriYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerileriYenile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerileriYenile.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVerileriYenile.Location = new System.Drawing.Point(276, 615);
            this.btnVerileriYenile.Name = "btnVerileriYenile";
            this.btnVerileriYenile.Size = new System.Drawing.Size(134, 54);
            this.btnVerileriYenile.TabIndex = 8;
            this.btnVerileriYenile.Text = "Verileri Yenile";
            this.btnVerileriYenile.UseVisualStyleBackColor = false;
            this.btnVerileriYenile.Click += new System.EventHandler(this.btnVerileriYenile_Click);
            // 
            // FormAdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 681);
            this.ControlBox = false;
            this.Controls.Add(this.TabloAdminIslemleri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAdminEkle);
            this.Controls.Add(this.btnVerileriYenile);
            this.Name = "FormAdminPaneli";
            this.Text = "FormAdminPaneli";
            this.Load += new System.EventHandler(this.FormAdminPaneli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView TabloAdminIslemleri;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAdminEkle;
        private System.Windows.Forms.Button btnVerileriYenile;
        private System.Windows.Forms.ColumnHeader AdminNo;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader password;
    }
}