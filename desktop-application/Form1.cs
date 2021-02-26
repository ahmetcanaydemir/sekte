using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekte
{
    public partial class SekteMain : Form
    {
        public SekteMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private string dosyaYolu;
        public string DosyaYolu
        {
            get
            {
                return dosyaYolu;
            }
            set
            {
                dosyaYolu = value;
                lblDosyaAdiTab2.Text = Path.GetFileName(dosyaYolu);
                playerOrijinal.URL = playerSesIcerik.URL = dosyaYolu;
                playerOrijinal.Ctlcontrols.stop();
            }
        }
        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                DosyaYolu = openFileDialog1.FileName;
                tabControl1.SelectedIndex=1;
            }
        }

        private async void btnGurultuAyristir_Click(object sender, EventArgs e)
        {
            btnGurultuDetaylari.Enabled = false;
            btnGurultuDetaylari.Text = "Detaylar Yükleniyor...";

            playerSesIcerik.Ctlcontrols.stop();

            timer1.Stop();
            timer1.Start();
            tabControl1.SelectedIndex = 2;

            using (var client = new HttpClient() { BaseAddress = new Uri(Program.BaseURL) })
            {
                var response = await client.GetAsync("?dosya=" + DosyaYolu);
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Internal server Error");

                var sesDalgasi = JsonConvert.DeserializeObject<SesDalgasi>(await response.Content.ReadAsStringAsync());

                pboxDalgaOrijinal.Image = Utils.Base64ToImage(sesDalgasi.Orijinal);
                pboxDalgaGurultusuz.Image = Utils.Base64ToImage(sesDalgasi.Gurultusuz);

                playerGurultusuz.URL = playerSesIcerik.URL = Path.Combine(Path.GetTempPath(), "sekte-sonuc.wav");
                playerGurultusuz.Ctlcontrols.stop();
                playerOrijinal.Ctlcontrols.stop();
                playerSesIcerik.Ctlcontrols.stop();



                response = await client.GetAsync("/detay?dosya=" + DosyaYolu);
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Internal server Error");

                var sesDetayi = JsonConvert.DeserializeObject<SesDetayi>(await response.Content.ReadAsStringAsync());
                pboxGurultuDetaylari.Image = Utils.Base64ToImage(sesDetayi.Detaylar);
                pboxSpektogram.Image = Utils.Base64ToImage(sesDetayi.Spektogram);

                btnGurultuDetaylari.Enabled = true;
                btnGurultuDetaylari.Text = "Gürültü Detaylarını Göster";
            }
        }

        private async Task SesDalgasiniYerlestir(HttpClient client)
        {
            var response = await client.GetAsync("?dosya=" + DosyaYolu);
            if (!response.IsSuccessStatusCode)
                throw new Exception("Internal server Error");

            var sesDalgasi = JsonConvert.DeserializeObject<SesDalgasi>(await response.Content.ReadAsStringAsync());

            pboxDalgaOrijinal.Image = Utils.Base64ToImage(sesDalgasi.Orijinal);
            pboxDalgaGurultusuz.Image = Utils.Base64ToImage(sesDalgasi.Gurultusuz);

            playerGurultusuz.URL = playerSesIcerik.URL = Path.Combine(Path.GetTempPath(), "sekte-sonuc.wav");
            playerGurultusuz.Ctlcontrols.stop();
            playerOrijinal.Ctlcontrols.stop();
            playerSesIcerik.Ctlcontrols.stop();
        }

        private async Task SesDetayiniYerlestir(HttpClient client)
        {
            var response = await client.GetAsync("/detay?dosya=" + DosyaYolu);
            if (!response.IsSuccessStatusCode)
                throw new Exception("Internal server Error");

            var sesDetayi = JsonConvert.DeserializeObject<SesDetayi>(await response.Content.ReadAsStringAsync());
            pboxGurultuDetaylari.Image = Utils.Base64ToImage(sesDetayi.Detaylar);
            pboxSpektogram.Image = Utils.Base64ToImage(sesDetayi.Spektogram);

            btnGurultuDetaylari.Enabled = true;
            btnGurultuDetaylari.Text = "Gürültü Detaylarını Göster";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            // Kullanıcının uygulama hissini artırmak için kısa sahte bir bekletme
            switch (progressBar1.Value)
            {
                case 50:
                    lblProgressBar.Text = "Ayrıştırılan gürültüden görüntüler elde ediliyor";
                    break;
                case 70:
                    lblProgressBar.Text = "Gürültü detayları getiriliyor";
                    break;
                case 95:
                    lblProgressBar.Text = "Tamamlanıyor";
                    break;
                case 100:
                    timer1.Stop();
                    tabControl1.SelectedIndex = 3;
                    progressBar1.Value = 0;
                    lblProgressBar.Text = "Gürültü Ayrıştırılıyor";
                    break;
            }
        }

        private void btnBasaDon_Click(object sender, EventArgs e)
        {
            playerOrijinal.Ctlcontrols.stop();
            playerSesIcerik.Ctlcontrols.stop();
            playerGurultusuz.Ctlcontrols.stop();
            tabControl1.SelectedIndex = 0;
        }

        private void btnGurultuDetaylari_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }
        #region Resim Görüntüleyicide Aç
        private void pboxDalgaOrijinal_Click(object sender, EventArgs e)
            => Utils.ResmiAc("dalga-orijinal.png", pboxDalgaOrijinal.Image);
        private void pboxDalgaGurultusuz_Click(object sender, EventArgs e)
            => Utils.ResmiAc("dalga-gurultusuz.png", pboxDalgaGurultusuz.Image);
        private void pboxSpektogram_Click(object sender, EventArgs e)
            => Utils.ResmiAc("gurultu-spektogram.png", pboxSpektogram.Image);
        private void pboxGurultuDetaylari_Click(object sender, EventArgs e)
            => Utils.ResmiAc("gurultu-detaylar.png", pboxGurultuDetaylari.Image);
        #endregion

        #region Genel Form Düzeni İşlemleri
        private void SekteMain_DragEnter(object sender, DragEventArgs e)
        {
            tabPage1.BackColor = Color.Bisque;
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void SekteMain_DragDrop(object sender, DragEventArgs e)
        {
            tabPage1.BackColor = Color.WhiteSmoke;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if(files.Length > 0 &&  (files[0].EndsWith(".mp3") || files[0].EndsWith(".wav")))
            {
                DosyaYolu = files[0];
                tabControl1.SelectedIndex = 1;
            }
        }

        private void SekteMain_DragLeave(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.WhiteSmoke;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSimgeDurumu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      
        private void lblEkraniKapla_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                lblEkraniKapla.Text = "☐";
                toolTip1.SetToolTip(lblEkraniKapla, "Ekranı Kapla");
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                lblEkraniKapla.Text = "◱";
                toolTip1.SetToolTip(lblEkraniKapla, "Aşağı Geri Getir");
                this.WindowState = FormWindowState.Maximized;
            }
        }
  
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void SekteMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.RoyalBlue, rc);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        private void SekteMain_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private  void btnSesiKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Wav Dosyası|*.wav|MP3 Dosyası|*.mp3";
            saveFileDialog1.Title = "Gürültüsü Azaltılmış Sesi Kaydet";
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                File.Copy(Path.Combine(Path.GetTempPath(), "sekte-sonuc.wav"), saveFileDialog1.FileName,true);
                MessageBox.Show($"Gürültüsü azaltılmış ses dosyası {saveFileDialog1.FileName} konumuna kayıt edildi!","Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
