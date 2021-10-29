
namespace KutuphaneOtomasyonuV2.Forms
{
    partial class FormKitapEkle
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblKitapEkle = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.lblYayinEvi = new System.Windows.Forms.Label();
            this.lblSayfaSayi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblKitapAd = new System.Windows.Forms.Label();
            this.lblKitapNo = new System.Windows.Forms.Label();
            this.tbYayinEvi = new System.Windows.Forms.TextBox();
            this.tbSayfaSayi = new System.Windows.Forms.TextBox();
            this.tbYazar = new System.Windows.Forms.TextBox();
            this.tbKitapAdi = new System.Windows.Forms.TextBox();
            this.tbKitapNo = new System.Windows.Forms.TextBox();
            this.tbKitapNot = new System.Windows.Forms.TextBox();
            this.lblKitapNot = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.lblKitapEkle);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(356, 27);
            this.panelHeader.TabIndex = 31;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TasimaIslemi);
            // 
            // lblKitapEkle
            // 
            this.lblKitapEkle.AutoSize = true;
            this.lblKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblKitapEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKitapEkle.Location = new System.Drawing.Point(9, 3);
            this.lblKitapEkle.Name = "lblKitapEkle";
            this.lblKitapEkle.Size = new System.Drawing.Size(84, 20);
            this.lblKitapEkle.TabIndex = 5;
            this.lblKitapEkle.Text = "Kitap Ekle";
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
            this.btnExit.Location = new System.Drawing.Point(328, 4);
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
            this.btnMinimize.Location = new System.Drawing.Point(298, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 18);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.SystemColors.Window;
            this.btnKitapEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnKitapEkle.Location = new System.Drawing.Point(111, 271);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(134, 54);
            this.btnKitapEkle.TabIndex = 30;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // lblYayinEvi
            // 
            this.lblYayinEvi.AutoSize = true;
            this.lblYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYayinEvi.ForeColor = System.Drawing.SystemColors.Window;
            this.lblYayinEvi.Location = new System.Drawing.Point(45, 184);
            this.lblYayinEvi.Name = "lblYayinEvi";
            this.lblYayinEvi.Size = new System.Drawing.Size(103, 25);
            this.lblYayinEvi.TabIndex = 25;
            this.lblYayinEvi.Text = "Yayın Evi";
            // 
            // lblSayfaSayi
            // 
            this.lblSayfaSayi.AutoSize = true;
            this.lblSayfaSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayfaSayi.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSayfaSayi.Location = new System.Drawing.Point(17, 156);
            this.lblSayfaSayi.Name = "lblSayfaSayi";
            this.lblSayfaSayi.Size = new System.Drawing.Size(131, 25);
            this.lblSayfaSayi.TabIndex = 26;
            this.lblSayfaSayi.Text = "Sayfa Sayısı";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYazar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblYazar.Location = new System.Drawing.Point(79, 130);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(69, 25);
            this.lblYazar.TabIndex = 27;
            this.lblYazar.Text = "Yazar";
            // 
            // lblKitapAd
            // 
            this.lblKitapAd.AutoSize = true;
            this.lblKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapAd.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKitapAd.Location = new System.Drawing.Point(50, 103);
            this.lblKitapAd.Name = "lblKitapAd";
            this.lblKitapAd.Size = new System.Drawing.Size(98, 25);
            this.lblKitapAd.TabIndex = 28;
            this.lblKitapAd.Text = "Kitap Adı";
            // 
            // lblKitapNo
            // 
            this.lblKitapNo.AutoSize = true;
            this.lblKitapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapNo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKitapNo.Location = new System.Drawing.Point(54, 73);
            this.lblKitapNo.Name = "lblKitapNo";
            this.lblKitapNo.Size = new System.Drawing.Size(94, 25);
            this.lblKitapNo.TabIndex = 29;
            this.lblKitapNo.Text = "Kitap No";
            // 
            // tbYayinEvi
            // 
            this.tbYayinEvi.BackColor = System.Drawing.Color.White;
            this.tbYayinEvi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbYayinEvi.Location = new System.Drawing.Point(152, 186);
            this.tbYayinEvi.Name = "tbYayinEvi";
            this.tbYayinEvi.Size = new System.Drawing.Size(168, 23);
            this.tbYayinEvi.TabIndex = 20;
            // 
            // tbSayfaSayi
            // 
            this.tbSayfaSayi.BackColor = System.Drawing.Color.White;
            this.tbSayfaSayi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSayfaSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSayfaSayi.Location = new System.Drawing.Point(152, 158);
            this.tbSayfaSayi.Name = "tbSayfaSayi";
            this.tbSayfaSayi.Size = new System.Drawing.Size(168, 23);
            this.tbSayfaSayi.TabIndex = 21;
            // 
            // tbYazar
            // 
            this.tbYazar.BackColor = System.Drawing.Color.White;
            this.tbYazar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbYazar.Location = new System.Drawing.Point(152, 130);
            this.tbYazar.Name = "tbYazar";
            this.tbYazar.Size = new System.Drawing.Size(168, 23);
            this.tbYazar.TabIndex = 22;
            // 
            // tbKitapAdi
            // 
            this.tbKitapAdi.BackColor = System.Drawing.Color.White;
            this.tbKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbKitapAdi.Location = new System.Drawing.Point(152, 103);
            this.tbKitapAdi.Name = "tbKitapAdi";
            this.tbKitapAdi.Size = new System.Drawing.Size(168, 23);
            this.tbKitapAdi.TabIndex = 23;
            // 
            // tbKitapNo
            // 
            this.tbKitapNo.BackColor = System.Drawing.Color.White;
            this.tbKitapNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKitapNo.Enabled = false;
            this.tbKitapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbKitapNo.Location = new System.Drawing.Point(152, 75);
            this.tbKitapNo.Name = "tbKitapNo";
            this.tbKitapNo.Size = new System.Drawing.Size(168, 23);
            this.tbKitapNo.TabIndex = 24;
            this.tbKitapNo.Text = "Otomatik";
            // 
            // tbKitapNot
            // 
            this.tbKitapNot.BackColor = System.Drawing.Color.White;
            this.tbKitapNot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKitapNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbKitapNot.Location = new System.Drawing.Point(152, 213);
            this.tbKitapNot.Name = "tbKitapNot";
            this.tbKitapNot.Size = new System.Drawing.Size(168, 23);
            this.tbKitapNot.TabIndex = 20;
            // 
            // lblKitapNot
            // 
            this.lblKitapNot.AutoSize = true;
            this.lblKitapNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapNot.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKitapNot.Location = new System.Drawing.Point(48, 211);
            this.lblKitapNot.Name = "lblKitapNot";
            this.lblKitapNot.Size = new System.Drawing.Size(100, 25);
            this.lblKitapNot.TabIndex = 25;
            this.lblKitapNot.Text = "Kitap Not";
            // 
            // FormKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(356, 355);
            this.ControlBox = false;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.lblKitapNot);
            this.Controls.Add(this.lblYayinEvi);
            this.Controls.Add(this.lblSayfaSayi);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitapAd);
            this.Controls.Add(this.lblKitapNo);
            this.Controls.Add(this.tbKitapNot);
            this.Controls.Add(this.tbYayinEvi);
            this.Controls.Add(this.tbSayfaSayi);
            this.Controls.Add(this.tbYazar);
            this.Controls.Add(this.tbKitapAdi);
            this.Controls.Add(this.tbKitapNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKitapEkle";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblKitapEkle;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Label lblYayinEvi;
        private System.Windows.Forms.Label lblSayfaSayi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblKitapAd;
        private System.Windows.Forms.Label lblKitapNo;
        private System.Windows.Forms.TextBox tbYayinEvi;
        private System.Windows.Forms.TextBox tbSayfaSayi;
        private System.Windows.Forms.TextBox tbYazar;
        private System.Windows.Forms.TextBox tbKitapAdi;
        private System.Windows.Forms.TextBox tbKitapNo;
        private System.Windows.Forms.TextBox tbKitapNot;
        private System.Windows.Forms.Label lblKitapNot;
    }
}