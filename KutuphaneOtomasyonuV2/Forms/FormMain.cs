using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtomasyonuV2.Forms;
using KutuphaneOtomasyonuV2.Classes;


namespace KutuphaneOtomasyonuV2.Forms
{
    public partial class FormMain : Form
    {
        /*
         
         
         Başlangıç Formu Program.cs'ten Değişiyor!
          

         
         */

        private Form currentChildForm;
        public FormMain()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnUyeIslemleri_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUyeIslemleri());
            lblTitleChildForm.Text = "Üye Islemleri";
        }

        private void btnKitapIslemleri_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormKitapIslemleri());
            lblTitleChildForm.Text = "Kitap Islemleri";
        }

        private void btnEmanetIslemleri_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEmanetIslemleri());
            lblTitleChildForm.Text = "Emanet Islemleri";
        }
        private void btnAdminPaneli_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdminPaneli());
            lblTitleChildForm.Text = "Admin Islemleri";
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/1741kerem/KutuphaneOtomasyonuV2");
        }

        // Taşınabilir Form Ayarları
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TasimaIslemi(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
