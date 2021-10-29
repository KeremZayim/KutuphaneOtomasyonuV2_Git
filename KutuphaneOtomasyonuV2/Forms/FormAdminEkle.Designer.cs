
namespace KutuphaneOtomasyonuV2.Forms
{
    partial class FormAdminEkle
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
            this.lblAdminEkle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnAdminEkle = new System.Windows.Forms.Button();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblAdminNo = new System.Windows.Forms.Label();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tbEmanetNo = new System.Windows.Forms.TextBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminEkle
            // 
            this.lblAdminEkle.AutoSize = true;
            this.lblAdminEkle.Font = new System.Drawing.Font("Aquire", 12.25F);
            this.lblAdminEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAdminEkle.Location = new System.Drawing.Point(11, 4);
            this.lblAdminEkle.Name = "lblAdminEkle";
            this.lblAdminEkle.Size = new System.Drawing.Size(114, 17);
            this.lblAdminEkle.TabIndex = 6;
            this.lblAdminEkle.Text = "Admin Ekle";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.lblAdminEkle);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(365, 27);
            this.panelHeader.TabIndex = 18;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TasimaIslemi);
            // 
            // btnAdminEkle
            // 
            this.btnAdminEkle.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdminEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminEkle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAdminEkle.Location = new System.Drawing.Point(119, 242);
            this.btnAdminEkle.Name = "btnAdminEkle";
            this.btnAdminEkle.Size = new System.Drawing.Size(134, 54);
            this.btnAdminEkle.TabIndex = 17;
            this.btnAdminEkle.Text = "Admin Ekle";
            this.btnAdminEkle.UseVisualStyleBackColor = false;
            this.btnAdminEkle.Click += new System.EventHandler(this.btnAdminEkle_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Aquire", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSifre.Location = new System.Drawing.Point(116, 120);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(72, 21);
            this.lblSifre.TabIndex = 11;
            this.lblSifre.Text = "Sifre";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Aquire", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(25, 92);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(163, 21);
            this.lblKullaniciAdi.TabIndex = 12;
            this.lblKullaniciAdi.Text = "Kullanici Adi";
            // 
            // lblAdminNo
            // 
            this.lblAdminNo.AutoSize = true;
            this.lblAdminNo.Font = new System.Drawing.Font("Aquire", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminNo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAdminNo.Location = new System.Drawing.Point(76, 63);
            this.lblAdminNo.Name = "lblAdminNo";
            this.lblAdminNo.Size = new System.Drawing.Size(112, 21);
            this.lblAdminNo.TabIndex = 16;
            this.lblAdminNo.Text = "Admin No";
            // 
            // tbSifre
            // 
            this.tbSifre.BackColor = System.Drawing.Color.White;
            this.tbSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSifre.Location = new System.Drawing.Point(194, 122);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(114, 23);
            this.tbSifre.TabIndex = 8;
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.tbKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbKullaniciAdi.Location = new System.Drawing.Point(194, 94);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(114, 23);
            this.tbKullaniciAdi.TabIndex = 9;
            // 
            // tbEmanetNo
            // 
            this.tbEmanetNo.BackColor = System.Drawing.Color.White;
            this.tbEmanetNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmanetNo.Enabled = false;
            this.tbEmanetNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbEmanetNo.Location = new System.Drawing.Point(194, 65);
            this.tbEmanetNo.Name = "tbEmanetNo";
            this.tbEmanetNo.Size = new System.Drawing.Size(114, 23);
            this.tbEmanetNo.TabIndex = 7;
            this.tbEmanetNo.Text = "Otomatik";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 16;
            this.btnExit.Location = new System.Drawing.Point(337, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 18);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 16;
            this.btnMinimize.Location = new System.Drawing.Point(307, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 18);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // FormAdminEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(365, 308);
            this.ControlBox = false;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnAdminEkle);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblAdminNo);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbKullaniciAdi);
            this.Controls.Add(this.tbEmanetNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminEkle";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAdminEkle;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnAdminEkle;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblAdminNo;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.TextBox tbEmanetNo;
    }
}