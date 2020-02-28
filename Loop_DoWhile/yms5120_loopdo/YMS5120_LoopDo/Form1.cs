using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_LoopDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
              DOWHILE
              While'ın isleyis prensibi olarak tam tersi mantıkla calisir...
              Oncelikle isleminizi sarta bakmaksizin en az bir defa calistirir, daha sonraki tum islemlerine sarta bagimli olarak gerceklestirir. Bu sebeple, DİKKATLİ KULLANMAKTA FAYDA VAR!
              Cok sık tercih edilen bir dongu tipi degildir...
        */
        private void btnWhile1_Click(object sender, EventArgs e)
        {
            //1-100 arasında olan 
            //çift sayıları listbox'a at.
            //int i = 0;
            //while (i<100)
            //{
            //    if (i%2==0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //    i++;
            //}

            
            //ilk yüz çift sayı?
            //break kullanımı vs
            bool ciftSayiKontrolu = true;
            int i = 0;
            int ciftSayiMiktari = 0;
            while (ciftSayiKontrolu)//içeriye direk true kelimesini de koyabilirdik.
            {
                if (i%2==0)
                {
                    listBox1.Items.Add(i);
                    ciftSayiMiktari++;
                }
                i++;
                if (ciftSayiMiktari==100)
                {
                    ciftSayiKontrolu = false;
                    //break;

                }
            }


        }

        private void btnDoWhile1_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i < 100);

            //int i = 0;
            //while (i<100)
            //{
            //    listBox1.Items.Add(i);
            //    i++;
            //}
        }

        private void btnWhile2_Click(object sender, EventArgs e)
        {
            // Herhangi bir sayının faktoriyelini hesapla

            //int sayi =5;
            //int sonuc = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //    //sonuc = sonuc * i;
            //}
            //MessageBox.Show("Faktoriyel Sonucu: "+sonuc);

            int sayi = 5;
            int sonuc = 1;
            int i = 1;
            while (i<=sayi)
            {
                sonuc *= i;
                i++;
            }
            MessageBox.Show("Faktoriyel Sonucu: "+sonuc);


        }

        private void btnDoWhile2_Click(object sender, EventArgs e)
        {
            int sayi = 5;
            //sayi=Convert.ToInt32(txtsayi.text);
            int sonuc = 1;
            int i = 1;
            do
            {
                sonuc *= i;
                i++;
                //listBox1.Items.Add(sonuc);
            } while (i<=sayi);
            MessageBox.Show("Sonuç: "+sonuc);
            

        }
    }
}
