namespace Sekte
{
    partial class SekteMain
    {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekteMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.playerSesIcerik = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblDosyaAdiTab2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGurultuAyristir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBasaDonTab2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pboxDalgaGurultusuz = new System.Windows.Forms.PictureBox();
            this.playerGurultusuz = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pboxDalgaOrijinal = new System.Windows.Forms.PictureBox();
            this.playerOrijinal = new AxWMPLib.AxWindowsMediaPlayer();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGurultuDetaylari = new System.Windows.Forms.Button();
            this.btnSesiKaydet = new System.Windows.Forms.Button();
            this.btnBasaDon = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pboxSpektogram = new System.Windows.Forms.PictureBox();
            this.pboxGurultuDetaylari = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSimgeDurumu = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblEkraniKapla = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSesIcerik)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDalgaGurultusuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerGurultusuz)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDalgaOrijinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOrijinal)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSpektogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGurultuDetaylari)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 444);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnDosyaSec);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(206, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 179);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gürültülü ses dosyasını buraya sürükle!";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDosyaSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDosyaSec.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaSec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDosyaSec.Location = new System.Drawing.Point(88, 134);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(199, 38);
            this.btnDosyaSec.TabIndex = 5;
            this.btnDosyaSec.Text = "Veya Buraya Tıkla ve Dosyayı Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = false;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(153, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 73);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.playerSesIcerik);
            this.tabPage2.Controls.Add(this.lblDosyaAdiTab2);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // playerSesIcerik
            // 
            this.playerSesIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerSesIcerik.Enabled = true;
            this.playerSesIcerik.Location = new System.Drawing.Point(3, 66);
            this.playerSesIcerik.Name = "playerSesIcerik";
            this.playerSesIcerik.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerSesIcerik.OcxState")));
            this.playerSesIcerik.Size = new System.Drawing.Size(773, 201);
            this.playerSesIcerik.TabIndex = 0;
            // 
            // lblDosyaAdiTab2
            // 
            this.lblDosyaAdiTab2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDosyaAdiTab2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDosyaAdiTab2.ForeColor = System.Drawing.Color.DimGray;
            this.lblDosyaAdiTab2.Location = new System.Drawing.Point(3, 267);
            this.lblDosyaAdiTab2.Name = "lblDosyaAdiTab2";
            this.lblDosyaAdiTab2.Size = new System.Drawing.Size(773, 20);
            this.lblDosyaAdiTab2.TabIndex = 7;
            this.lblDosyaAdiTab2.Text = "dosyaadi.mp3";
            this.lblDosyaAdiTab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDosyaAdiTab2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnGurultuAyristir);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(773, 98);
            this.panel6.TabIndex = 26;
            // 
            // btnGurultuAyristir
            // 
            this.btnGurultuAyristir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGurultuAyristir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGurultuAyristir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGurultuAyristir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGurultuAyristir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGurultuAyristir.Location = new System.Drawing.Point(285, 31);
            this.btnGurultuAyristir.Name = "btnGurultuAyristir";
            this.btnGurultuAyristir.Size = new System.Drawing.Size(210, 38);
            this.btnGurultuAyristir.TabIndex = 6;
            this.btnGurultuAyristir.Text = "Gürültüyü Ayrıştır";
            this.btnGurultuAyristir.UseVisualStyleBackColor = false;
            this.btnGurultuAyristir.Click += new System.EventHandler(this.btnGurultuAyristir_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gürültülü Ses İçeriği";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnBasaDonTab2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(773, 47);
            this.panel5.TabIndex = 25;
            // 
            // btnBasaDonTab2
            // 
            this.btnBasaDonTab2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBasaDonTab2.BackColor = System.Drawing.Color.Transparent;
            this.btnBasaDonTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasaDonTab2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasaDonTab2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBasaDonTab2.Location = new System.Drawing.Point(4, 5);
            this.btnBasaDonTab2.Name = "btnBasaDonTab2";
            this.btnBasaDonTab2.Size = new System.Drawing.Size(104, 38);
            this.btnBasaDonTab2.TabIndex = 23;
            this.btnBasaDonTab2.Text = "< Başa Dön";
            this.btnBasaDonTab2.UseVisualStyleBackColor = false;
            this.btnBasaDonTab2.Click += new System.EventHandler(this.btnBasaDon_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(773, 38);
            this.panel4.TabIndex = 25;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(779, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.Controls.Add(this.lblProgressBar);
            this.panel7.Controls.Add(this.progressBar1);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(86, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(589, 297);
            this.panel7.TabIndex = 9;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProgressBar.ForeColor = System.Drawing.Color.DimGray;
            this.lblProgressBar.Location = new System.Drawing.Point(19, 261);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(129, 20);
            this.lblProgressBar.TabIndex = 8;
            this.lblProgressBar.Text = "Gürültü ayrıştılıyor";
            this.lblProgressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(23, 213);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(558, 42);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.tableLayoutPanel3);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(779, 435);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(773, 358);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pboxDalgaGurultusuz, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.playerGurultusuz, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 222);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(767, 133);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // pboxDalgaGurultusuz
            // 
            this.pboxDalgaGurultusuz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxDalgaGurultusuz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxDalgaGurultusuz.Location = new System.Drawing.Point(386, 3);
            this.pboxDalgaGurultusuz.Name = "pboxDalgaGurultusuz";
            this.pboxDalgaGurultusuz.Size = new System.Drawing.Size(378, 127);
            this.pboxDalgaGurultusuz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDalgaGurultusuz.TabIndex = 12;
            this.pboxDalgaGurultusuz.TabStop = false;
            this.toolTip1.SetToolTip(this.pboxDalgaGurultusuz, "Resim görüntüleyicide açmak için tıklayın.");
            this.pboxDalgaGurultusuz.Click += new System.EventHandler(this.pboxDalgaGurultusuz_Click);
            // 
            // playerGurultusuz
            // 
            this.playerGurultusuz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerGurultusuz.Enabled = true;
            this.playerGurultusuz.Location = new System.Drawing.Point(3, 3);
            this.playerGurultusuz.Name = "playerGurultusuz";
            this.playerGurultusuz.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerGurultusuz.OcxState")));
            this.playerGurultusuz.Size = new System.Drawing.Size(377, 127);
            this.playerGurultusuz.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pboxDalgaOrijinal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerOrijinal, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 133);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // pboxDalgaOrijinal
            // 
            this.pboxDalgaOrijinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxDalgaOrijinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxDalgaOrijinal.Location = new System.Drawing.Point(386, 3);
            this.pboxDalgaOrijinal.Name = "pboxDalgaOrijinal";
            this.pboxDalgaOrijinal.Size = new System.Drawing.Size(378, 127);
            this.pboxDalgaOrijinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDalgaOrijinal.TabIndex = 12;
            this.pboxDalgaOrijinal.TabStop = false;
            this.toolTip1.SetToolTip(this.pboxDalgaOrijinal, "Resim görüntüleyicide açmak için tıklayın.");
            this.pboxDalgaOrijinal.Click += new System.EventHandler(this.pboxDalgaOrijinal_Click);
            // 
            // playerOrijinal
            // 
            this.playerOrijinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerOrijinal.Enabled = true;
            this.playerOrijinal.Location = new System.Drawing.Point(3, 3);
            this.playerOrijinal.Name = "playerOrijinal";
            this.playerOrijinal.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerOrijinal.OcxState")));
            this.playerOrijinal.Size = new System.Drawing.Size(377, 127);
            this.playerOrijinal.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(767, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Orijinal Ses";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(3, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(767, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Gürültüsü Azaltılmış Ses";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(3, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(767, 2);
            this.label8.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "SONUÇ";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGurultuDetaylari);
            this.panel1.Controls.Add(this.btnSesiKaydet);
            this.panel1.Controls.Add(this.btnBasaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 46);
            this.panel1.TabIndex = 27;
            // 
            // btnGurultuDetaylari
            // 
            this.btnGurultuDetaylari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGurultuDetaylari.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGurultuDetaylari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGurultuDetaylari.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGurultuDetaylari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGurultuDetaylari.Location = new System.Drawing.Point(494, 5);
            this.btnGurultuDetaylari.Name = "btnGurultuDetaylari";
            this.btnGurultuDetaylari.Size = new System.Drawing.Size(164, 38);
            this.btnGurultuDetaylari.TabIndex = 21;
            this.btnGurultuDetaylari.Text = "Gürültü Detaylarını Göster";
            this.btnGurultuDetaylari.UseVisualStyleBackColor = false;
            this.btnGurultuDetaylari.Click += new System.EventHandler(this.btnGurultuDetaylari_Click);
            // 
            // btnSesiKaydet
            // 
            this.btnSesiKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSesiKaydet.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSesiKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesiKaydet.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSesiKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSesiKaydet.Location = new System.Drawing.Point(664, 5);
            this.btnSesiKaydet.Name = "btnSesiKaydet";
            this.btnSesiKaydet.Size = new System.Drawing.Size(104, 38);
            this.btnSesiKaydet.TabIndex = 20;
            this.btnSesiKaydet.Text = "Sesi Kaydet";
            this.btnSesiKaydet.UseVisualStyleBackColor = false;
            this.btnSesiKaydet.Click += new System.EventHandler(this.btnSesiKaydet_Click);
            // 
            // btnBasaDon
            // 
            this.btnBasaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnBasaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasaDon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBasaDon.Location = new System.Drawing.Point(1, 5);
            this.btnBasaDon.Name = "btnBasaDon";
            this.btnBasaDon.Size = new System.Drawing.Size(104, 38);
            this.btnBasaDon.TabIndex = 22;
            this.btnBasaDon.Text = "< Başa Dön";
            this.btnBasaDon.UseVisualStyleBackColor = false;
            this.btnBasaDon.Click += new System.EventHandler(this.btnBasaDon_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Controls.Add(this.tableLayoutPanel4);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.panel2);
            this.tabPage5.Location = new System.Drawing.Point(4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(779, 435);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.pboxSpektogram, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pboxGurultuDetaylari, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(773, 361);
            this.tableLayoutPanel4.TabIndex = 28;
            // 
            // pboxSpektogram
            // 
            this.pboxSpektogram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxSpektogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxSpektogram.Location = new System.Drawing.Point(3, 3);
            this.pboxSpektogram.Name = "pboxSpektogram";
            this.pboxSpektogram.Size = new System.Drawing.Size(767, 174);
            this.pboxSpektogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSpektogram.TabIndex = 30;
            this.pboxSpektogram.TabStop = false;
            this.toolTip1.SetToolTip(this.pboxSpektogram, "Resim görüntüleyicide açmak için tıklayın.");
            this.pboxSpektogram.Click += new System.EventHandler(this.pboxSpektogram_Click);
            // 
            // pboxGurultuDetaylari
            // 
            this.pboxGurultuDetaylari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxGurultuDetaylari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxGurultuDetaylari.Location = new System.Drawing.Point(3, 183);
            this.pboxGurultuDetaylari.Name = "pboxGurultuDetaylari";
            this.pboxGurultuDetaylari.Size = new System.Drawing.Size(767, 175);
            this.pboxGurultuDetaylari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxGurultuDetaylari.TabIndex = 29;
            this.pboxGurultuDetaylari.TabStop = false;
            this.toolTip1.SetToolTip(this.pboxGurultuDetaylari, "Resim görüntüleyicide açmak için tıklayın.");
            this.pboxGurultuDetaylari.Click += new System.EventHandler(this.pboxGurultuDetaylari_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "GÜRÜLTÜ DETAYLARI";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGeriDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 43);
            this.panel2.TabIndex = 27;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeriDon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeriDon.Location = new System.Drawing.Point(668, 2);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(97, 38);
            this.btnGeriDon.TabIndex = 26;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Mp3 Dosyaları|*.mp3|Wav dosyaları|*.wav";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Mp3 Dosyaları|*.mp3";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSimgeDurumu
            // 
            this.lblSimgeDurumu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimgeDurumu.AutoSize = true;
            this.lblSimgeDurumu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSimgeDurumu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSimgeDurumu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSimgeDurumu.Location = new System.Drawing.Point(684, 1);
            this.lblSimgeDurumu.Name = "lblSimgeDurumu";
            this.lblSimgeDurumu.Size = new System.Drawing.Size(31, 25);
            this.lblSimgeDurumu.TabIndex = 4;
            this.lblSimgeDurumu.Text = "▁";
            this.toolTip1.SetToolTip(this.lblSimgeDurumu, "Simge Durumuna Küçült");
            this.lblSimgeDurumu.Click += new System.EventHandler(this.lblSimgeDurumu_Click);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClose.Location = new System.Drawing.Point(752, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(28, 23);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "╳";
            this.toolTip1.SetToolTip(this.lblClose, "Kapat");
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(15, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Sekte";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(72, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "by Ahmet Can Aydemir";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            // 
            // lblEkraniKapla
            // 
            this.lblEkraniKapla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEkraniKapla.AutoSize = true;
            this.lblEkraniKapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEkraniKapla.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkraniKapla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEkraniKapla.Location = new System.Drawing.Point(718, 4);
            this.lblEkraniKapla.Name = "lblEkraniKapla";
            this.lblEkraniKapla.Size = new System.Drawing.Size(34, 25);
            this.lblEkraniKapla.TabIndex = 8;
            this.lblEkraniKapla.Text = "☐ ";
            this.toolTip1.SetToolTip(this.lblEkraniKapla, "Ekranı Kapla");
            this.lblEkraniKapla.Click += new System.EventHandler(this.lblEkraniKapla_Click);
            // 
            // SekteMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(811, 483);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblSimgeDurumu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblEkraniKapla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "SekteMain";
            this.Text = "Sekte";
            this.Load += new System.EventHandler(this.SekteMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SekteMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SekteMain_DragEnter);
            this.DragLeave += new System.EventHandler(this.SekteMain_DragLeave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SekteMain_MouseDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerSesIcerik)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDalgaGurultusuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerGurultusuz)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDalgaOrijinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOrijinal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSpektogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGurultuDetaylari)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDosyaAdiTab2;
        private System.Windows.Forms.Button btnGurultuAyristir;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer playerSesIcerik;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBasaDonTab2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBasaDon;
        private System.Windows.Forms.Button btnGurultuDetaylari;
        private System.Windows.Forms.Button btnSesiKaydet;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSimgeDurumu;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pboxDalgaOrijinal;
        private AxWMPLib.AxWindowsMediaPlayer playerOrijinal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pboxDalgaGurultusuz;
        private AxWMPLib.AxWindowsMediaPlayer playerGurultusuz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblEkraniKapla;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pboxSpektogram;
        private System.Windows.Forms.PictureBox pboxGurultuDetaylari;
    }
}

