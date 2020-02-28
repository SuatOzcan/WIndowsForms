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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Metotlarınız içerisine açıklama eklemek için "///" işareti koymanız yeterlidir.
        /// </summary>
        public void Saydirici()
        {
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                listBox1.Items.Add(rnd.Next(5,60));
            }
        }
        //public void Saydirici(int max)
        //{
        //    Random rnd = new Random();
        //    for (int i = 0; i < max; i++)
        //    {
        //        listBox1.Items.Add(rnd.Next());
        //    }
        //}

        
        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            Saydirici();
            //Saydirici(10);
            
        }

        void Tadilatci()
        {
            //Formun==>
            //Arkaplan rengi beyaz olsun
            //Boyutu da 400*400 olsun
            
            this.BackColor = Color.White;
            this.Size = new Size(400,400);
            

            
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            Tadilatci();
        }

        public void ParametreliSaydir(int sayi)
        {
            //KacaKadarSayacak=100;==>YANLIŞ!!!
            //KacaKadarSayacak=COnvert.ToInt32(txt.text);==>YANLIŞ!!!
            listBox1.Items.Clear();

            for (int i = 0; i < sayi; i++)
            {
                listBox1.Items.Add(i);
            }


        }   

        

        private void btnOrnek3_Click(object sender, EventArgs e)
        {

            //listboxı sıfırla
            //txtden gelen değer kadar saydır.
            //listboxa yazdır.
            //metot sayıyı dışarıdan alsın.
            int kacaKadarSayacak = Convert.ToInt32(txtGirisAlani.Text);
            //ParametreliSaydir(Convert.ToInt32(txtGirisAlani.Text));
            
            ParametreliSaydir(kacaKadarSayacak);

        }
        /// <summary>
        /// iki sayıyı toplar ve küpünü ekrana bastırır.
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        public void KupAlma(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            int sonuc = Convert.ToInt32(Math.Pow(toplam, 3));
            MessageBox.Show(sonuc.ToString());
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen iki sayının toplamının küpü
            //Mbox ile ekrana bastırın
            int a = Convert.ToInt32(txtBirinciSayi.Text);
            int b = Convert.ToInt32(txtIkinciSayi.Text);
            KupAlma(a,b);
            

            
        }
        /// <summary>
        /// içerisine string tipinden renk adı alıp formun backColorını değiştiren metot
        /// </summary>
        /// <param name="renkAdi"></param>
        public void RenkDegistir(string renkAdi)
        {

            //this.BackColor = Color.FromArgb(250,0,0);
            this.BackColor = Color.FromName(renkAdi);

        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            //Combobox'tan seçilen rengi formun arkaplanına atayın
            //cmbRenkler.SelectedItem.ToString();
            //Color.FromName("White");
            string renk = cmbRenkler.SelectedItem.ToString();
            RenkDegistir(renk);

        }
        /// <summary>
        /// Parametre olarak ad ve sunucu ismi girilen ve "ad@sunucuIsmi" adresi oluşturan metot
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="sunucuAdi"></param>
        public void MailOlusturucu(string ad,string sunucuAdi)
        {
            MessageBox.Show(ad+"@"+sunucuAdi);
        }


        /// <summary>
        /// Parametre olarak isim girilen ve "ad@hotmail.com" adresi oluşturan metot
        /// </summary>
        /// <param name="ad"></param>
        public void MailOlusturucu(string ad)
        {
            MessageBox.Show(ad+"@hotmail.com");
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            //Kullanıcıdan tercih ettiği adı ve tercih ettiği mail 
            //uzantısını alıp "ad@sunucu uzantısı.com" şeklinde,
            //Eğer tek parametre girilirse "hotmail.com" olarak çalışsın.
            //mboxa bastıran metot

            //cmbSunucuAdlari.SelectedIndex == -1;
            string ad = txtMail.Text;
           
            if (cmbSunucuAdlari.SelectedIndex==-1)
            {
                //comboboxtan değer seçilmediyse
                MailOlusturucu(ad);
            }
            else
            {
                //comboboxtan değer seçildiyse
                string sunucuAdi = cmbSunucuAdlari.SelectedItem.ToString();
                MailOlusturucu(ad, sunucuAdi);
                
            }
        }

        public void SonUcHarfKesici(string kelime)
        {
            if (kelime.Length<=3)
            {
                MessageBox.Show(kelime);
            }
            else
            {
                string sonuc = kelime.Substring(kelime.Length-3,3);
                MessageBox.Show(sonuc);
            }
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            //Textbox içerisine girilen metnin metot ile son üç 
            //harfini mbox ile ekrana yazdırın ancak
            //Girilen metin 3 harften kısa ise veya 3 harfli ise
            //metnin tamamını göster
            string kelime = txtGirilenMetin.Text;
            SonUcHarfKesici(kelime);
        }

        void Ayristirici(string mailAdresleri)
        {
            string[] adresler = mailAdresleri.Split(';');
            //diziyi ayrıstırma dısında kalanları metot dısına tasıyın.
            foreach (string item in adresler)
            {
                listBox1.Items.Add(item);
            }

        }
        private void btnOrnek8_Click(object sender, EventArgs e)
        {
            string adresler = txtGirilenMailler.Text;
            Ayristirici(adresler);
        }
    }
}
