using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro_Timer
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        //
        //-------------------------- Çalışma Zamanı Müzik Seç Butonu -------------------------------
        //

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            for (UInt16 i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
            {
                lstNameWork.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                lstFilename.Items.Add(openFileDialog1.FileNames[i].ToString());
            }

        }
        Int16 saniye, dakika, saat, saniye1, dakika1, saat1;

        //
        //----------------------- FORMLOAD ---------------------
        //

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;      //false olacak
            lstFilename.Visible = false;                //false olacak
            lstPauseName.Visible = false;               //false olacak
            axWindowsMediaPlayer2.Visible = false;      //false olacak
            openFileDialog1.Filter = "Music |*.mp3|Music |*.wav";
            /* Bu Projede bir çok şeyi eksik yaptığımın farkındayım kendini geliştirmeye çalışıyorum.
              bu benim ilk projem lütfen kusura bakmayın.*/
        }

        //
        //---------------------Çalışma Zamanı Çal Butonu ----------------------------
        //

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFilename.SelectedIndex = lstNameWork.SelectedIndex;
            axWindowsMediaPlayer1.URL = lstFilename.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        //
        //------------------------------- Çalışma Combobox ---------------------------------
        //

        private void cmbxWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxWork.SelectedIndex == 0)
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Melih\\Desktop\\Music1.mp3";        // Müzik Yolunu Kendinize Göre Düzenleyin
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (cmbxWork.SelectedIndex == 1)
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Melih\\Desktop\\Music2.mp3";        // Müzik Yolunu Kendinize Göre Düzenleyin
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (cmbxWork.SelectedIndex == 2)
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Melih\\Desktop\\Music3.mp3";        // Müzik Yolunu Kendinize Göre Düzenleyin
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (cmbxWork.SelectedIndex == 3)
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Melih\\Desktop\\Music4.mp3";        // Müzik Yolunu Kendinize Göre Düzenleyin
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (cmbxWork.SelectedIndex == 4)
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Melih\\Desktop\\Music5.mp3";        // Müzik Yolunu Kendinize Göre Düzenleyin
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            
        }

        //
        //------------------------------ Dinlenme Combobox-------------------
        //

        private void cmbxPause_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxPause.SelectedIndex == 0)
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\Melih\\Desktop\\Music1.mp3";        // Müzik Yolunu Kendinize Göre Düzenleyin
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (cmbxPause.SelectedIndex == 1)
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\Melih\\Desktop\\Music2.mp3";        // Müzik Yolunu Kendinize Göre Düzenleyin
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (cmbxPause.SelectedIndex == 2)
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\Melih\\Desktop\\Music3.mp3";        // Müzik Yolunu Kendinize Göre Düzenleyin
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (cmbxPause.SelectedIndex == 3)
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\Melih\\Desktop\\Music4.mp3";        // Müzik Yolunu Kendinize Göre Düzenleyin
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (cmbxPause.SelectedIndex == 4)
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\Melih\\Desktop\\Music5.mp3";        // Müzik Yolunu Kendinize Göre Düzenleyin
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            for (UInt16 i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
            {
                lstNamePause.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                lstPauseName.Items.Add(openFileDialog1.FileNames[i].ToString());
            }
        }

        //
        //------------------------------- Dinlenme Listbox --------------------------
        //

        private void lstNamePause_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPauseName.SelectedIndex = lstNamePause.SelectedIndex;
            axWindowsMediaPlayer2.URL = lstPauseName.SelectedItem.ToString();
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        //
        // --------------------- TİMER1 TİCK -------------------------- 
        //

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (saniye < 59)
                saniye++;

            else
            {
                saniye = 0;

                if (dakika < 59)

                {
                    dakika++;
                }

                else
                {
                    dakika = 0;
                    if (saat < 24)
                            saat++;

                    else
                        saat = 0;
                }
            }
            label5.Text = saat.ToString() + " " + dakika.ToString() + " " + saniye.ToString();

            if (dakika == 15 & cmbxWorkTime.SelectedIndex == 0)// normal değeri 15dk siz değiştirebilirsiniz.
            {
                axWindowsMediaPlayer1.URL = cmbxWork.SelectedText;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Stop();
                saniye = 0;
                dakika = 0;
                saat = 0;
                label5.Text = "";
                timer2.Start();
            }
            
            else if (dakika == 20 & cmbxWorkTime.SelectedIndex == 1)// normal değeri 20dk siz değiştirebilirsiniz.
            {
                axWindowsMediaPlayer1.URL = cmbxWork.SelectedText;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Stop();
                saniye = 0;
                dakika = 0;
                saat = 0;
                timer2.Start();
            }

            else if (dakika == 25 & cmbxWorkTime.SelectedIndex == 2)// normal değeri 25dk siz değiştirebilirsiniz.
            {
                axWindowsMediaPlayer1.URL = cmbxWork.SelectedText;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Stop();
                saniye = 0;
                dakika = 0;
                saat = 0;
                timer2.Start();
            }

        }


        //
        //---------------------- Dinlenme Çal Butonu --------------------------
        //

        private void button1_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        //
        //--------------------- Dinlenme Durdurma Butonu --------------------------
        //

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }

        //
        //--------------------- TİMER2 TİCK -------------------------- 
        //

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (saniye1 < 59)
                saniye1++;

            else
            {
                saniye1 = 0;

                if (dakika1 < 59)

                {
                    dakika1++;
                }

                else
                {
                    dakika1 = 0;
                    if (saat1 < 24)
                        saat1++;

                    else
                        saat1 = 0;
                }
            }

            label7.Text = saat1.ToString() + " " + dakika1.ToString() + " " + saniye1.ToString();

            if (dakika1 == 5 & cmbxRestTime.SelectedIndex == 0)// normal değeri 5dk siz değiştirebilirsiniz.
            {
                axWindowsMediaPlayer2.URL = cmbxPause.SelectedText;
                axWindowsMediaPlayer2.Ctlcontrols.play();
                timer2.Stop();
                saniye1 = 0;
                dakika1 = 0;
                saat1 = 0;

            }

            if (dakika1 == 10 & cmbxRestTime.SelectedIndex == 1)// normal değeri 10dk siz değiştirebilirsiniz.
            {
                axWindowsMediaPlayer2.URL = cmbxPause.SelectedText;
                axWindowsMediaPlayer2.Ctlcontrols.play();
                timer2.Stop();
                saniye1 = 0;
                dakika1 = 0;
                saat1 = 0;
            }
        }

        //
        //çalışma bittiği zamanki müzik seç butonu
        //

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
               if (lstNameWork.Text == lstFilename.SelectedItem.ToString())

                axWindowsMediaPlayer1.URL = lstFilename.Text;
                MessageBox.Show("Müzik Başarılı Bir Şekilde Seçildi", "Müzik Seçme", MessageBoxButtons.OK);
                
            }
            catch
            {
                MessageBox.Show("Herhangi Bir Müzik Seçilmedi, Lütfen Seçim Yapınız.");
            }
           
        }

        //
        //dinlenme bittiği zamanki müzik seç butonu
        //

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstNamePause.Text == lstPauseName.SelectedItem.ToString())
               
                axWindowsMediaPlayer2.URL = lstFilename.Text;
                MessageBox.Show("Müzik Başarılı Bir Şekilde Seçildi", "Müzik Seçme", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Herhangi Bir Müzik Seçilmedi, Lütfen Seçim Yapınız.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saniye = 0;
            dakika = 0;
            saat = 0;
            label5.Text = "0 0 0";
        }

        FontDialog xyz = new FontDialog();

        //
        //------------------------ Yazı Ayarı Butonu------------------------------------
        //

        private void button4_Click(object sender, EventArgs e)
        {

            xyz.ShowDialog();
            richTextBox1.Font = xyz.Font;
        }

        //
        //---------------------- Yazı Ayarını Ekleme Butonu ----------------------------------
        //

        private void button5_Click_1(object sender, EventArgs e)
        {
            label4.Text = richTextBox1.Text;
            label4.Font = richTextBox1.Font;
        }

        //
        //---------------------- Pomodoro Başlat butonu ----------------------------------
        //

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            saniye = 0;
            dakika = 0;
            saat = 0;
            saniye1 = 0;
            dakika1 = 0;
            saat1 = 0;
            if (cmbxWorkTime.SelectedIndex == 0)
            {
                timer1.Interval = 1000;//1000 olarak değişecek
                timer1.Start();
            }
            else if (cmbxWorkTime.SelectedIndex == 1)
            {
                timer1.Interval = 1000;//1000 olarak değişecek
                timer1.Start();
            }
            else
            {
                timer1.Interval = 1000;//1000 olarak değişecek
                timer1.Start();
            }
            tabControl1.SelectedTab = tabPage1;
            
        }

        //
        //----------------------------- Pomodoro Durdur Butonu --------------------------------------
        //

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
        }

    }
}