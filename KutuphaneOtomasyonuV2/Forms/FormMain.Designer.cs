
namespace KutuphaneOtomasyonuV2.Forms
{
    partial class FormMain
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
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnRestore = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.btnIcon = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.menuPaneli = new System.Windows.Forms.Panel();
            this.btnHakkinda = new FontAwesome.Sharp.IconButton();
            this.btnAdminPaneli = new FontAwesome.Sharp.IconButton();
            this.btnEmanetIslemleri = new FontAwesome.Sharp.IconButton();
            this.btnYetkililer = new FontAwesome.Sharp.IconButton();
            this.btnKitapEkle = new FontAwesome.Sharp.IconButton();
            this.panelHeader.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnIcon)).BeginInit();
            this.menuPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Aquire", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitleChildForm.Location = new System.Drawing.Point(100, 36);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(83, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Ana Sayfa";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.btnRestore);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(990, 20);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TasimaIslemi);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestore.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestore.IconSize = 16;
            this.btnRestore.Location = new System.Drawing.Point(937, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(22, 18);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
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
            this.btnExit.Location = new System.Drawing.Point(962, 4);
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
            this.btnMinimize.Location = new System.Drawing.Point(912, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 18);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.btnMenu);
            this.panelTitleBar.Controls.Add(this.panelHeader);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(274, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(990, 75);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TasimaIslemi);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 42;
            this.btnMenu.Location = new System.Drawing.Point(14, 27);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 43);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Blue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Blue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(62, 30);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoPanel.Controls.Add(this.btnIcon);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(274, 140);
            this.logoPanel.TabIndex = 0;
            // 
            // btnIcon
            // 
            this.btnIcon.Image = global::KutuphaneOtomasyonuV2.Properties.Resources.library;
            this.btnIcon.Location = new System.Drawing.Point(20, 4);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(201, 130);
            this.btnIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnIcon.TabIndex = 0;
            this.btnIcon.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.Location = new System.Drawing.Point(274, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(990, 681);
            this.panelDesktop.TabIndex = 8;
            // 
            // menuPaneli
            // 
            this.menuPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuPaneli.Controls.Add(this.btnHakkinda);
            this.menuPaneli.Controls.Add(this.btnAdminPaneli);
            this.menuPaneli.Controls.Add(this.btnEmanetIslemleri);
            this.menuPaneli.Controls.Add(this.btnYetkililer);
            this.menuPaneli.Controls.Add(this.btnKitapEkle);
            this.menuPaneli.Controls.Add(this.logoPanel);
            this.menuPaneli.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPaneli.Location = new System.Drawing.Point(0, 0);
            this.menuPaneli.Name = "menuPaneli";
            this.menuPaneli.Size = new System.Drawing.Size(274, 681);
            this.menuPaneli.TabIndex = 4;
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHakkinda.FlatAppearance.BorderSize = 0;
            this.btnHakkinda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHakkinda.Font = new System.Drawing.Font("Aquire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHakkinda.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHakkinda.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnHakkinda.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHakkinda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHakkinda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHakkinda.Location = new System.Drawing.Point(0, 621);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnHakkinda.Size = new System.Drawing.Size(274, 60);
            this.btnHakkinda.TabIndex = 6;
            this.btnHakkinda.Text = "Hakkinda";
            this.btnHakkinda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHakkinda.UseVisualStyleBackColor = true;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // btnAdminPaneli
            // 
            this.btnAdminPaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminPaneli.FlatAppearance.BorderSize = 0;
            this.btnAdminPaneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPaneli.Font = new System.Drawing.Font("Aquire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPaneli.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdminPaneli.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnAdminPaneli.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAdminPaneli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdminPaneli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPaneli.Location = new System.Drawing.Point(0, 320);
            this.btnAdminPaneli.Name = "btnAdminPaneli";
            this.btnAdminPaneli.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAdminPaneli.Size = new System.Drawing.Size(274, 60);
            this.btnAdminPaneli.TabIndex = 5;
            this.btnAdminPaneli.Text = "Admin Paneli";
            this.btnAdminPaneli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminPaneli.UseVisualStyleBackColor = true;
            this.btnAdminPaneli.Click += new System.EventHandler(this.btnAdminPaneli_Click);
            // 
            // btnEmanetIslemleri
            // 
            this.btnEmanetIslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmanetIslemleri.FlatAppearance.BorderSize = 0;
            this.btnEmanetIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetIslemleri.Font = new System.Drawing.Font("Aquire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmanetIslemleri.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEmanetIslemleri.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.btnEmanetIslemleri.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEmanetIslemleri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmanetIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetIslemleri.Location = new System.Drawing.Point(0, 260);
            this.btnEmanetIslemleri.Name = "btnEmanetIslemleri";
            this.btnEmanetIslemleri.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnEmanetIslemleri.Size = new System.Drawing.Size(274, 60);
            this.btnEmanetIslemleri.TabIndex = 4;
            this.btnEmanetIslemleri.Text = "Emanet islemleri";
            this.btnEmanetIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmanetIslemleri.UseVisualStyleBackColor = true;
            this.btnEmanetIslemleri.Click += new System.EventHandler(this.btnEmanetIslemleri_Click);
            // 
            // btnYetkililer
            // 
            this.btnYetkililer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYetkililer.FlatAppearance.BorderSize = 0;
            this.btnYetkililer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYetkililer.Font = new System.Drawing.Font("Aquire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYetkililer.ForeColor = System.Drawing.SystemColors.Window;
            this.btnYetkililer.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnYetkililer.IconColor = System.Drawing.Color.Gainsboro;
            this.btnYetkililer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnYetkililer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYetkililer.Location = new System.Drawing.Point(0, 200);
            this.btnYetkililer.Name = "btnYetkililer";
            this.btnYetkililer.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnYetkililer.Size = new System.Drawing.Size(274, 60);
            this.btnYetkililer.TabIndex = 3;
            this.btnYetkililer.Text = "uye islemleri";
            this.btnYetkililer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYetkililer.UseVisualStyleBackColor = true;
            this.btnYetkililer.Click += new System.EventHandler(this.btnUyeIslemleri_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKitapEkle.FlatAppearance.BorderSize = 0;
            this.btnKitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapEkle.Font = new System.Drawing.Font("Aquire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitapEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKitapEkle.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnKitapEkle.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKitapEkle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapEkle.Location = new System.Drawing.Point(0, 140);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnKitapEkle.Size = new System.Drawing.Size(274, 60);
            this.btnKitapEkle.TabIndex = 1;
            this.btnKitapEkle.Text = "kitap islemleri";
            this.btnKitapEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapIslemleri_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.menuPaneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panelHeader.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnIcon)).EndInit();
            this.menuPaneli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton btnRestore;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox btnIcon;
        private FontAwesome.Sharp.IconButton btnHakkinda;
        private FontAwesome.Sharp.IconButton btnAdminPaneli;
        private FontAwesome.Sharp.IconButton btnEmanetIslemleri;
        private FontAwesome.Sharp.IconButton btnYetkililer;
        private FontAwesome.Sharp.IconButton btnKitapEkle;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel menuPaneli;
    }
}