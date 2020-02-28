using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int ToplamaYap(int s1,int s2, int s3)
        {
            int toplam = s1 + s2 + s3;
            return toplam;
            //return s1 + s2 + s3;
        }

        public string TekCiftKontrolu(int girilenDeger)
        {
            string sonuc;
            if (girilenDeger%2==0)
            {
                //return "çift";
                sonuc = "çift";
            }
            else
            {
                //return "tek";
                sonuc = "tek";
            }
            
            return sonuc;
        }



        private void btnToplama_Click(object sender, EventArgs e)
        {
            int toplananSayilar = ToplamaYap(4, 5, 9);
            MessageBox.Show("Sonuç: "+toplananSayilar);
        }

        private void btnCiftTek_Click(object sender, EventArgs e)
        {
            int gelenDeger = Convert.ToInt32(txtOrnekIki.Text);
            string sonuc = TekCiftKontrolu(gelenDeger);
     
            MessageBox.Show("Sonuç: "+sonuc);
        }
        public string MailOlusturma(string ad,string soyad)
        {
            //string mail = ad + "." + soyad + "@hotmail.com";
            //return mail;
            return (ad+"."+soyad+"@hotmail.com");
        }

        public string MailOlusturma()
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            

            return ad+"."+soyad+"@hotmail.com";
        }

        public void Mail()
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string sonuc = ad + "." + soyad + "@hotmail.com";
            MessageBox.Show(sonuc);
        }

        private void btnMetin_Click(object sender, EventArgs e)
        {

            //string ad = txtAd.Text;
            //string soyad = txtSoyad.Text;
            //string sonuc = MailOlusturma(ad, soyad);

            //MessageBox.Show(sonuc);

            //string sonuc = MailOlusturma();
            //MessageBox.Show(MailOlusturma());


            Mail();



            //MessageBox.Show(MailOlusturma(txtAd.Text, txtSoyad.Text));

        }
        int[] sayilar = { 2, 67, 24, 1, 56, 13, 109 };
        public void DiziBastirma()
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            MessageBox.Show("Sonuç: " + toplam);
        }
        private void btnDizi_Click(object sender, EventArgs e)
        {
            //metot ile dizi elemanlarını topla ve ekrana bas.
            DiziBastirma();
        }

        private void btnRenkYakala_Click(object sender, EventArgs e)
        {
            //butonun rengini yakalayan bir metot
            //rengi yakaladıktan sonra diger 
            //butonlardan birini de cevirin.

            //btnToplama.BackColor = btnRenkYakala.BackColor;

            this.BackColor = ArkaPlanYakalayici(btnRenkYakala);
        }
        public Color ArkaPlanYakalayici(Control arkaPlaniYakalanacakKontrol)
        {
            return arkaPlaniYakalanacakKontrol.BackColor;
        }
    }
}
