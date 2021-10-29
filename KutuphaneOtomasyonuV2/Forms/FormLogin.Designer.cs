
namespace KutuphaneOtomasyonuV2
{
    partial class FormLogin
    {
        //Kerem Zayim Tarafından Yapılmıştır!
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pbKutuphaneLogo = new System.Windows.Forms.PictureBox();
            this.MovableMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblKutuphaneBaslik2 = new System.Windows.Forms.Label();
            this.lblKutuphaneBaslik = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.MovableMenuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.pnlSifre = new System.Windows.Forms.Panel();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.pbSifre = new System.Windows.Forms.PictureBox();
            this.pnlKullaniciAdi = new System.Windows.Forms.Panel();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.pbKullaniciAdi = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKutuphaneLogo)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlSifre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifre)).BeginInit();
            this.pnlKullaniciAdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKullaniciAdi)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlLeft.Controls.Add(this.pbKutuphaneLogo);
            this.pnlLeft.Controls.Add(this.MovableMenuStrip1);
            this.pnlLeft.Controls.Add(this.lblKutuphaneBaslik2);
            this.pnlLeft.Controls.Add(this.lblKutuphaneBaslik);
            this.pnlLeft.Controls.Add(this.lblCreatedBy);
            this.pnlLeft.Controls.Add(this.lblAuthor);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(300, 491);
            this.pnlLeft.TabIndex = 0;
            // 
            // pbKutuphaneLogo
            // 
            this.pbKutuphaneLogo.Image = global::KutuphaneOtomasyonuV2.Properties.Resources.library;
            this.pbKutuphaneLogo.Location = new System.Drawing.Point(37, 56);
            this.pbKutuphaneLogo.Name = "pbKutuphaneLogo";
            this.pbKutuphaneLogo.Size = new System.Drawing.Size(226, 147);
            this.pbKutuphaneLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKutuphaneLogo.TabIndex = 3;
            this.pbKutuphaneLogo.TabStop = false;
            // 
            // MovableMenuStrip1
            // 
            this.MovableMenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MovableMenuStrip1.AutoSize = false;
            this.MovableMenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.MovableMenuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.MovableMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MovableMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MovableMenuStrip1.Name = "MovableMenuStrip1";
            this.MovableMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MovableMenuStrip1.Size = new System.Drawing.Size(300, 43);
            this.MovableMenuStrip1.TabIndex = 4;
            this.MovableMenuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableMenuStrip_MouseDown);
            // 
            // lblKutuphaneBaslik2
            // 
            this.lblKutuphaneBaslik2.AutoSize = true;
            this.lblKutuphaneBaslik2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblKutuphaneBaslik2.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKutuphaneBaslik2.Location = new System.Drawing.Point(34, 285);
            this.lblKutuphaneBaslik2.Name = "lblKutuphaneBaslik2";
            this.lblKutuphaneBaslik2.Size = new System.Drawing.Size(251, 25);
            this.lblKutuphaneBaslik2.TabIndex = 2;
            this.lblKutuphaneBaslik2.Text = "Sistemine Hoş Geldiniz!";
            // 
            // lblKutuphaneBaslik
            // 
            this.lblKutuphaneBaslik.AutoSize = true;
            this.lblKutuphaneBaslik.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblKutuphaneBaslik.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKutuphaneBaslik.Location = new System.Drawing.Point(93, 251);
            this.lblKutuphaneBaslik.Name = "lblKutuphaneBaslik";
            this.lblKutuphaneBaslik.Size = new System.Drawing.Size(190, 25);
            this.lblKutuphaneBaslik.TabIndex = 2;
            this.lblKutuphaneBaslik.Text = "Kütüphane Kayıt";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCreatedBy.Location = new System.Drawing.Point(221, 453);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(62, 15);
            this.lblCreatedBy.TabIndex = 1;
            this.lblCreatedBy.Text = "Created By";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAuthor.Location = new System.Drawing.Point(209, 468);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(74, 15);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Kerem Zayim";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.Window;
            this.pnlRight.Controls.Add(this.btnExit);
            this.pnlRight.Controls.Add(this.MovableMenuStrip2);
            this.pnlRight.Controls.Add(this.btnSifremiUnuttum);
            this.pnlRight.Controls.Add(this.btnGirisYap);
            this.pnlRight.Controls.Add(this.pnlSifre);
            this.pnlRight.Controls.Add(this.pnlKullaniciAdi);
            this.pnlRight.Controls.Add(this.label3);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRight.Location = new System.Drawing.Point(300, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(446, 491);
            this.pnlRight.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.Location = new System.Drawing.Point(406, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MovableMenuStrip2
            // 
            this.MovableMenuStrip2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MovableMenuStrip2.AutoSize = false;
            this.MovableMenuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.MovableMenuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.MovableMenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MovableMenuStrip2.Location = new System.Drawing.Point(0, 0);
            this.MovableMenuStrip2.Name = "MovableMenuStrip2";
            this.MovableMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MovableMenuStrip2.Size = new System.Drawing.Size(446, 43);
            this.MovableMenuStrip2.TabIndex = 4;
            this.MovableMenuStrip2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableMenuStrip_MouseDown);
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.BackColor = System.Drawing.SystemColors.Window;
            this.btnSifremiUnuttum.FlatAppearance.BorderSize = 0;
            this.btnSifremiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifremiUnuttum.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSifremiUnuttum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(197, 321);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(145, 35);
            this.btnSifremiUnuttum.TabIndex = 4;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = false;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGirisYap.Location = new System.Drawing.Point(56, 321);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(135, 35);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // pnlSifre
            // 
            this.pnlSifre.Controls.Add(this.tbSifre);
            this.pnlSifre.Controls.Add(this.pbSifre);
            this.pnlSifre.Location = new System.Drawing.Point(0, 241);
            this.pnlSifre.Name = "pnlSifre";
            this.pnlSifre.Size = new System.Drawing.Size(450, 45);
            this.pnlSifre.TabIndex = 2;
            // 
            // tbSifre
            // 
            this.tbSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSifre.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.tbSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbSifre.Location = new System.Drawing.Point(56, 12);
            this.tbSifre.MaxLength = 32;
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(370, 22);
            this.tbSifre.TabIndex = 2;
            this.tbSifre.Text = "Sifre";
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // pbSifre
            // 
            this.pbSifre.Image = global::KutuphaneOtomasyonuV2.Properties.Resources.password;
            this.pbSifre.Location = new System.Drawing.Point(6, 5);
            this.pbSifre.Name = "pbSifre";
            this.pbSifre.Size = new System.Drawing.Size(36, 36);
            this.pbSifre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSifre.TabIndex = 0;
            this.pbSifre.TabStop = false;
            // 
            // pnlKullaniciAdi
            // 
            this.pnlKullaniciAdi.Controls.Add(this.tbKullaniciAdi);
            this.pnlKullaniciAdi.Controls.Add(this.pbKullaniciAdi);
            this.pnlKullaniciAdi.Location = new System.Drawing.Point(0, 190);
            this.pnlKullaniciAdi.Name = "pnlKullaniciAdi";
            this.pnlKullaniciAdi.Size = new System.Drawing.Size(450, 45);
            this.pnlKullaniciAdi.TabIndex = 1;
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.tbKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbKullaniciAdi.Location = new System.Drawing.Point(56, 12);
            this.tbKullaniciAdi.MaxLength = 32;
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(370, 22);
            this.tbKullaniciAdi.TabIndex = 1;
            this.tbKullaniciAdi.Text = "Kullanici Adi";
            // 
            // pbKullaniciAdi
            // 
            this.pbKullaniciAdi.Image = global::KutuphaneOtomasyonuV2.Properties.Resources.user;
            this.pbKullaniciAdi.Location = new System.Drawing.Point(6, 5);
            this.pbKullaniciAdi.Name = "pbKullaniciAdi";
            this.pbKullaniciAdi.Size = new System.Drawing.Size(36, 36);
            this.pbKullaniciAdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKullaniciAdi.TabIndex = 0;
            this.pbKullaniciAdi.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(165, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giriş Yap";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(743, 18);
            this.toolStripContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(743, 43);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.Transparent;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 491);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MovableMenuStrip2;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKutuphaneLogo)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlSifre.ResumeLayout(false);
            this.pnlSifre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifre)).EndInit();
            this.pnlKullaniciAdi.ResumeLayout(false);
            this.pnlKullaniciAdi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKullaniciAdi)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Panel pnlSifre;
        private System.Windows.Forms.Panel pnlKullaniciAdi;
        private System.Windows.Forms.PictureBox pbSifre;
        private System.Windows.Forms.PictureBox pbKullaniciAdi;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.PictureBox pbKutuphaneLogo;
        private System.Windows.Forms.Label lblKutuphaneBaslik2;
        private System.Windows.Forms.Label lblKutuphaneBaslik;
        private System.Windows.Forms.Button btnSifremiUnuttum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip MovableMenuStrip2;
        private System.Windows.Forms.MenuStrip MovableMenuStrip1;
    }
}

