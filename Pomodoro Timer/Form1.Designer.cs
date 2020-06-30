namespace Pomodoro_Timer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.cmbxRestTime = new System.Windows.Forms.ComboBox();
            this.lblRest = new System.Windows.Forms.Label();
            this.lblWork = new System.Windows.Forms.Label();
            this.cmbxWorkTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstFilename = new System.Windows.Forms.ListBox();
            this.grpWork = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxWork = new System.Windows.Forms.ComboBox();
            this.btnWorkPlay = new System.Windows.Forms.Button();
            this.lstNameWork = new System.Windows.Forms.ListBox();
            this.btnWorkSelect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btnWorkPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxPause = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstNamePause = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lstPauseName = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpWork.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axWindowsMediaPlayer2);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lstFilename);
            this.tabPage2.Controls.Add(this.grpWork);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lstPauseName);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ayarlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(363, 2);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(21, 19);
            this.axWindowsMediaPlayer2.TabIndex = 16;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(533, 75);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(390, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(19, 18);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(557, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 25);
            this.button5.TabIndex = 15;
            this.button5.Text = "Ekle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.btnDurdur);
            this.groupBox1.Controls.Add(this.btnBaslat);
            this.groupBox1.Controls.Add(this.cmbxRestTime);
            this.groupBox1.Controls.Add(this.lblRest);
            this.groupBox1.Controls.Add(this.lblWork);
            this.groupBox1.Controls.Add(this.cmbxWorkTime);
            this.groupBox1.Location = new System.Drawing.Point(4, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Süreler";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(55, 144);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 27);
            this.button8.TabIndex = 6;
            this.button8.Text = "Sıfırla";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(99, 105);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(72, 27);
            this.btnDurdur.TabIndex = 5;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(8, 105);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(72, 27);
            this.btnBaslat.TabIndex = 4;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // cmbxRestTime
            // 
            this.cmbxRestTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxRestTime.FormattingEnabled = true;
            this.cmbxRestTime.Items.AddRange(new object[] {
            "5 DK",
            "10 DK"});
            this.cmbxRestTime.Location = new System.Drawing.Point(8, 78);
            this.cmbxRestTime.Name = "cmbxRestTime";
            this.cmbxRestTime.Size = new System.Drawing.Size(163, 21);
            this.cmbxRestTime.TabIndex = 3;
            // 
            // lblRest
            // 
            this.lblRest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRest.AutoSize = true;
            this.lblRest.Location = new System.Drawing.Point(6, 62);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(77, 13);
            this.lblRest.TabIndex = 2;
            this.lblRest.Text = "Dinleme Süresi";
            // 
            // lblWork
            // 
            this.lblWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(3, 15);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(75, 13);
            this.lblWork.TabIndex = 1;
            this.lblWork.Text = "Çalışma Süresi";
            // 
            // cmbxWorkTime
            // 
            this.cmbxWorkTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxWorkTime.FormattingEnabled = true;
            this.cmbxWorkTime.Items.AddRange(new object[] {
            "15 DK",
            "20 DK",
            "25 DK"});
            this.cmbxWorkTime.Location = new System.Drawing.Point(8, 31);
            this.cmbxWorkTime.Name = "cmbxWorkTime";
            this.cmbxWorkTime.Size = new System.Drawing.Size(163, 21);
            this.cmbxWorkTime.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Görev Ekleyin:";
            // 
            // lstFilename
            // 
            this.lstFilename.FormattingEnabled = true;
            this.lstFilename.Location = new System.Drawing.Point(415, 2);
            this.lstFilename.Name = "lstFilename";
            this.lstFilename.Size = new System.Drawing.Size(58, 17);
            this.lstFilename.TabIndex = 6;
            // 
            // grpWork
            // 
            this.grpWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpWork.Controls.Add(this.button6);
            this.grpWork.Controls.Add(this.button3);
            this.grpWork.Controls.Add(this.label3);
            this.grpWork.Controls.Add(this.cmbxWork);
            this.grpWork.Controls.Add(this.btnWorkPlay);
            this.grpWork.Controls.Add(this.lstNameWork);
            this.grpWork.Controls.Add(this.btnWorkSelect);
            this.grpWork.Location = new System.Drawing.Point(187, 114);
            this.grpWork.Name = "grpWork";
            this.grpWork.Size = new System.Drawing.Size(229, 187);
            this.grpWork.TabIndex = 4;
            this.grpWork.TabStop = false;
            this.grpWork.Text = "Çalışma Bittiği Zamanki Çalacak Müzik";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Müziği Seç";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(167, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 53);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Listeden Seç:";
            // 
            // cmbxWork
            // 
            this.cmbxWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxWork.FormattingEnabled = true;
            this.cmbxWork.Items.AddRange(new object[] {
            "Music 1",
            "Music 2",
            "Music 3",
            "Music 4",
            "Music 5"});
            this.cmbxWork.Location = new System.Drawing.Point(84, 143);
            this.cmbxWork.Name = "cmbxWork";
            this.cmbxWork.Size = new System.Drawing.Size(137, 21);
            this.cmbxWork.TabIndex = 7;
            this.cmbxWork.SelectedIndexChanged += new System.EventHandler(this.cmbxWork_SelectedIndexChanged);
            // 
            // btnWorkPlay
            // 
            this.btnWorkPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWorkPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWorkPlay.BackgroundImage")));
            this.btnWorkPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWorkPlay.Location = new System.Drawing.Point(110, 23);
            this.btnWorkPlay.Name = "btnWorkPlay";
            this.btnWorkPlay.Size = new System.Drawing.Size(51, 54);
            this.btnWorkPlay.TabIndex = 4;
            this.btnWorkPlay.UseVisualStyleBackColor = true;
            this.btnWorkPlay.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstNameWork
            // 
            this.lstNameWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstNameWork.FormattingEnabled = true;
            this.lstNameWork.Location = new System.Drawing.Point(14, 104);
            this.lstNameWork.Name = "lstNameWork";
            this.lstNameWork.ScrollAlwaysVisible = true;
            this.lstNameWork.Size = new System.Drawing.Size(207, 30);
            this.lstNameWork.TabIndex = 5;
            this.lstNameWork.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnWorkSelect
            // 
            this.btnWorkSelect.Location = new System.Drawing.Point(6, 23);
            this.btnWorkSelect.Name = "btnWorkSelect";
            this.btnWorkSelect.Size = new System.Drawing.Size(100, 23);
            this.btnWorkSelect.TabIndex = 3;
            this.btnWorkSelect.Text = "Müzik Ekle";
            this.btnWorkSelect.UseVisualStyleBackColor = true;
            this.btnWorkSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.btnWorkPause);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbxPause);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lstNamePause);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(422, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 187);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dinlenme Bittiği Zaman Çalacak Müzik";
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Location = new System.Drawing.Point(8, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Müziği Seç";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnWorkPause
            // 
            this.btnWorkPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWorkPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWorkPause.BackgroundImage")));
            this.btnWorkPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWorkPause.Location = new System.Drawing.Point(170, 25);
            this.btnWorkPause.Name = "btnWorkPause";
            this.btnWorkPause.Size = new System.Drawing.Size(49, 53);
            this.btnWorkPause.TabIndex = 5;
            this.btnWorkPause.UseVisualStyleBackColor = true;
            this.btnWorkPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Listeden Seç:";
            // 
            // cmbxPause
            // 
            this.cmbxPause.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxPause.FormattingEnabled = true;
            this.cmbxPause.Items.AddRange(new object[] {
            "Music 1",
            "Music 2",
            "Music 3",
            "Music 4",
            "Music 5"});
            this.cmbxPause.Location = new System.Drawing.Point(81, 143);
            this.cmbxPause.Name = "cmbxPause";
            this.cmbxPause.Size = new System.Drawing.Size(138, 21);
            this.cmbxPause.TabIndex = 7;
            this.cmbxPause.SelectedIndexChanged += new System.EventHandler(this.cmbxPause_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(114, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 53);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lstNamePause
            // 
            this.lstNamePause.FormattingEnabled = true;
            this.lstNamePause.Location = new System.Drawing.Point(14, 102);
            this.lstNamePause.Name = "lstNamePause";
            this.lstNamePause.ScrollAlwaysVisible = true;
            this.lstNamePause.Size = new System.Drawing.Size(205, 30);
            this.lstNamePause.TabIndex = 5;
            this.lstNamePause.SelectedIndexChanged += new System.EventHandler(this.lstNamePause_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(8, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Müzik Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lstPauseName
            // 
            this.lstPauseName.FormattingEnabled = true;
            this.lstPauseName.Location = new System.Drawing.Point(479, 2);
            this.lstPauseName.Name = "lstPauseName";
            this.lstPauseName.Size = new System.Drawing.Size(58, 17);
            this.lstPauseName.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(557, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 25);
            this.button4.TabIndex = 13;
            this.button4.Text = "Yazı Ayarı";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ana Menü";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 312);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(261, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 43);
            this.label7.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(166, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 43);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sayaç:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(267, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 43);
            this.label5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(142, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Göreviniz Burda Gözükecektir.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 344);
            this.tabControl1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 332);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pomodoro Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpWork.ResumeLayout(false);
            this.grpWork.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage tabPage2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.ComboBox cmbxRestTime;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.ComboBox cmbxWorkTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstFilename;
        private System.Windows.Forms.GroupBox grpWork;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxWork;
        private System.Windows.Forms.Button btnWorkPlay;
        private System.Windows.Forms.ListBox lstNameWork;
        private System.Windows.Forms.Button btnWorkSelect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnWorkPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxPause;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstNamePause;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstPauseName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

