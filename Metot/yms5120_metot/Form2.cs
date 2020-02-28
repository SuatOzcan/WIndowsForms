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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Random sayılardan 10 elemanlı dizi oluşturma
        public int[] DiziOlusturma()
        {
            int[] sayilar = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0,100);
            }
            return sayilar;
        }


        //İlk Örnek çift sayıları ayıran ve listboxa ekleyen
        //arkasından da kaç tane çift olduğunu mbox ile
        //gösteren metot olacaktır

        // İlk Örnekte parametre alan değer döndürmeyen metot ile yaplacak
        // CiftBulma metodu içerisine int tipinden bir dizi alıyor
        // Geriye bir sonuç döndürmediği için sonda "return" kelimesine 
        // ihtiyaç yoktur. "void" kelimesi kullanılır.
        
        public void CiftBUlma(int[] sayiDizisi)
        {
            int ciftMiktari = 0;
            foreach (int sayi in sayiDizisi)
            {
                if (sayi%2==0)
                {
                    listBox1.Items.Add(sayi);
                    ciftMiktari++;
                }
            }
            MessageBox.Show("Çift sayı miktarı: "+ciftMiktari);
        }

        
        private void btnOrnek11_Click(object sender, EventArgs e)
        {
            int[] sayilar = DiziOlusturma();
            CiftBUlma(sayilar);
        }
        //İkinci örnekte parametre almayacak,geri değer döndürmeyecek
        //Dışarıdan parametre almadığı için diziyi içeride tanımladık.
        //diğer işlemler ilk örnekteki ile aynı.
        public void CiftBulma2()
        {
            int[] sayilar = DiziOlusturma();
            int ciftMiktari = 0;
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                    ciftMiktari++;
                }
            }
            MessageBox.Show("Çift sayı miktarı: " + ciftMiktari);
        }


        private void btnOrnek12_Click(object sender, EventArgs e)
        {
            CiftBulma2();
        }
        //üçüncü örnekte parametre almıyoruz
        //listboxa çiftleri bastırdıktan sonra
        //bize kaç tane çift sayı odugunu döndürsün.
        
        public int CiftBulma3()
        {
            int ciftMiktari = 0;
            int[] sayilar = DiziOlusturma();
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                    ciftMiktari++;
                }
            }


            return ciftMiktari;
        }
        
        private void btnOrnek13_Click(object sender, EventArgs e)
        {
            int sayac=CiftBulma3();
            MessageBox.Show("Çift Miktarı: "+sayac);
        }
        //Dördüncü örnekte parametre alacak ve geriye değer döndürecek



        public int CiftBulma4(int[] sayilar)
        {
            int sayac = 0;

            foreach (int sayi in sayilar)
            {
                if (sayi%2==0)
                {
                    listBox1.Items.Add(sayi);
                    sayac++;
                }
            }
            
            return sayac;
        }

        private void btnOrnek14_Click(object sender, EventArgs e)
        {
            int[] sayilar = DiziOlusturma();
            int sayac = CiftBulma4(sayilar);
            MessageBox.Show("Çift Sayısı: "+sayac);
        }

        //Bir string dizisini sıralayıp sonra ters çevirecek, listeye bas
        //dizi boyutunu mbox ile göster.
        //string[] sehirler = new string[20];

        //string[] sehirler = { };

        public string[] Siralama(string[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            return arr;
        }

        public int SayiHesapla(string[] arr)
        {
            return arr.Length;
        }

        //public void SayiHesapla(string[] arr)
        //{
        //    MessageBox.Show("Dizideki Eleman Sayısı: "+arr.Length);
        //}

        public void EkranaBastir(string[] dizi)
        {
            foreach (string item in dizi)
            {
                listBox1.Items.Add(item);
            }
        }

        
        private void btnOrnek21_Click(object sender, EventArgs e)
        {
            string[] sehirler = {"Ankara","İzmir","Kiev","Eskişehir","İstanbul","Trabzon","Londra","New York"};
            sehirler = Siralama(sehirler);
            EkranaBastir(sehirler);
            int diziMiktari = SayiHesapla(sehirler);
            MessageBox.Show("Dizideki Eleman Sayısı: "+diziMiktari);
            //MessageBox.Show("Dizideki Eleman Sayısı: "+sehirler.Length);

        }
    }
}
