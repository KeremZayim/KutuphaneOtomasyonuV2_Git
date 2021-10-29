
namespace KutuphaneOtomasyonuV2.Forms
{
    partial class FormUyeEkle
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
            this.lblUyeEkle = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.lblUyeEposta = new System.Windows.Forms.Label();
            this.lblUyeTelefon = new System.Windows.Forms.Label();
            this.lblUyeSoyad = new System.Windows.Forms.Label();
            this.lblUyeAd = new System.Windows.Forms.Label();
            this.lblUyeNo = new System.Windows.Forms.Label();
            this.tbUyeEposta = new System.Windows.Forms.TextBox();
            this.tbUyeTelefon = new System.Windows.Forms.TextBox();
            this.tbUyeSoyad = new System.Windows.Forms.TextBox();
            this.tbUyeAdi = new System.Windows.Forms.TextBox();
            this.tbUyeNo = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.lblUyeEkle);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(356, 27);
            this.panelHeader.TabIndex = 19;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TasimaIslemi);
            // 
            // lblUyeEkle
            // 
            this.lblUyeEkle.AutoSize = true;
            this.lblUyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblUyeEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUyeEkle.Location = new System.Drawing.Point(9, 3);
            this.lblUyeEkle.Name = "lblUyeEkle";
            this.lblUyeEkle.Size = new System.Drawing.Size(75, 20);
            this.lblUyeEkle.TabIndex = 5;
            this.lblUyeEkle.Text = "Uye Ekle";
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
            // btnUyeEkle
            // 
            this.btnUyeEkle.BackColor = System.Drawing.SystemColors.Window;
            this.btnUyeEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeEkle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnUyeEkle.Location = new System.Drawing.Point(112, 267);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(134, 54);
            this.btnUyeEkle.TabIndex = 18;
            this.btnUyeEkle.Text = "Üye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = false;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // lblUyeEposta
            // 
            this.lblUyeEposta.AutoSize = true;
            this.lblUyeEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUyeEposta.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUyeEposta.Location = new System.Drawing.Point(53, 189);
            this.lblUyeEposta.Name = "lblUyeEposta";
            this.lblUyeEposta.Size = new System.Drawing.Size(87, 25);
            this.lblUyeEposta.TabIndex = 12;
            this.lblUyeEposta.Text = "E Posta";
            // 
            // lblUyeTelefon
            // 
            this.lblUyeTelefon.AutoSize = true;
            this.lblUyeTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUyeTelefon.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUyeTelefon.Location = new System.Drawing.Point(23, 161);
            this.lblUyeTelefon.Name = "lblUyeTelefon";
            this.lblUyeTelefon.Size = new System.Drawing.Size(117, 25);
            this.lblUyeTelefon.TabIndex = 13;
            this.lblUyeTelefon.Text = "Telefon No";
            // 
            // lblUyeSoyad
            // 
            this.lblUyeSoyad.AutoSize = true;
            this.lblUyeSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUyeSoyad.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUyeSoyad.Location = new System.Drawing.Point(18, 135);
            this.lblUyeSoyad.Name = "lblUyeSoyad";
            this.lblUyeSoyad.Size = new System.Drawing.Size(122, 25);
            this.lblUyeSoyad.TabIndex = 14;
            this.lblUyeSoyad.Text = "Üye Soyadı";
            // 
            // lblUyeAd
            // 
            this.lblUyeAd.AutoSize = true;
            this.lblUyeAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUyeAd.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUyeAd.Location = new System.Drawing.Point(53, 108);
            this.lblUyeAd.Name = "lblUyeAd";
            this.lblUyeAd.Size = new System.Drawing.Size(87, 25);
            this.lblUyeAd.TabIndex = 15;
            this.lblUyeAd.Text = "Üye Adı";
            // 
            // lblUyeNo
            // 
            this.lblUyeNo.AutoSize = true;
            this.lblUyeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUyeNo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUyeNo.Location = new System.Drawing.Point(57, 78);
            this.lblUyeNo.Name = "lblUyeNo";
            this.lblUyeNo.Size = new System.Drawing.Size(83, 25);
            this.lblUyeNo.TabIndex = 16;
            this.lblUyeNo.Text = "Üye No";
            // 
            // tbUyeEposta
            // 
            this.tbUyeEposta.BackColor = System.Drawing.Color.White;
            this.tbUyeEposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUyeEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUyeEposta.Location = new System.Drawing.Point(157, 191);
            this.tbUyeEposta.Name = "tbUyeEposta";
            this.tbUyeEposta.Size = new System.Drawing.Size(163, 23);
            this.tbUyeEposta.TabIndex = 7;
            // 
            // tbUyeTelefon
            // 
            this.tbUyeTelefon.BackColor = System.Drawing.Color.White;
            this.tbUyeTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUyeTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUyeTelefon.Location = new System.Drawing.Point(157, 163);
            this.tbUyeTelefon.Name = "tbUyeTelefon";
            this.tbUyeTelefon.Size = new System.Drawing.Size(163, 23);
            this.tbUyeTelefon.TabIndex = 8;
            // 
            // tbUyeSoyad
            // 
            this.tbUyeSoyad.BackColor = System.Drawing.Color.White;
            this.tbUyeSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUyeSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUyeSoyad.Location = new System.Drawing.Point(157, 135);
            this.tbUyeSoyad.Name = "tbUyeSoyad";
            this.tbUyeSoyad.Size = new System.Drawing.Size(163, 23);
            this.tbUyeSoyad.TabIndex = 9;
            // 
            // tbUyeAdi
            // 
            this.tbUyeAdi.BackColor = System.Drawing.Color.White;
            this.tbUyeAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUyeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUyeAdi.Location = new System.Drawing.Point(157, 108);
            this.tbUyeAdi.Name = "tbUyeAdi";
            this.tbUyeAdi.Size = new System.Drawing.Size(163, 23);
            this.tbUyeAdi.TabIndex = 10;
            // 
            // tbUyeNo
            // 
            this.tbUyeNo.BackColor = System.Drawing.Color.White;
            this.tbUyeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUyeNo.Enabled = false;
            this.tbUyeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUyeNo.Location = new System.Drawing.Point(157, 80);
            this.tbUyeNo.Name = "tbUyeNo";
            this.tbUyeNo.Size = new System.Drawing.Size(163, 23);
            this.tbUyeNo.TabIndex = 11;
            this.tbUyeNo.Text = "Otomatik";
            // 
            // FormUyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(356, 355);
            this.ControlBox = false;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnUyeEkle);
            this.Controls.Add(this.lblUyeEposta);
            this.Controls.Add(this.lblUyeTelefon);
            this.Controls.Add(this.lblUyeSoyad);
            this.Controls.Add(this.lblUyeAd);
            this.Controls.Add(this.lblUyeNo);
            this.Controls.Add(this.tbUyeEposta);
            this.Controls.Add(this.tbUyeTelefon);
            this.Controls.Add(this.tbUyeSoyad);
            this.Controls.Add(this.tbUyeAdi);
            this.Controls.Add(this.tbUyeNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(356, 355);
            this.MinimumSize = new System.Drawing.Size(356, 355);
            this.Name = "FormUyeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUyeEkleme";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Label lblUyeEposta;
        private System.Windows.Forms.Label lblUyeTelefon;
        private System.Windows.Forms.Label lblUyeSoyad;
        private System.Windows.Forms.Label lblUyeAd;
        private System.Windows.Forms.Label lblUyeNo;
        private System.Windows.Forms.TextBox tbUyeEposta;
        private System.Windows.Forms.TextBox tbUyeTelefon;
        private System.Windows.Forms.TextBox tbUyeSoyad;
        private System.Windows.Forms.TextBox tbUyeAdi;
        private System.Windows.Forms.TextBox tbUyeNo;
        private System.Windows.Forms.Label lblUyeEkle;
    }
}