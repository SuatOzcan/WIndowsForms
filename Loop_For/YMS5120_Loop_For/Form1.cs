using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_Loop_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // DÖNGÜLER - LOOPS
        //Bir baslangic degeri olan, belirli bir kosul gerceklesene dek suren ve bu surec icerisinde bir takim islemleri tekrarli olarak gerceklestiren nesnelere "dongu" adini vermekteyiz.
        //FOR - FOREACH - WHILE - DOWHILE
        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Donguye ilk giris aninda derleyici baslangic degerine bakar ve bir daha asla bu bloga ugramaz. 
            //Bundan sonraki islemler once arttir, daha sonra kosula bak, kosul uygunsa dongunun kod blogunu harekete gecir, uygun degilse donguden cik...

            //for(BaslangicDegeri; BitisKosulu; Artis-AzalisMiktari)
            for (int i = 0; i < 1000; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            for (int i = 1000; i >= 1; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            for (int i = 2; i <= 1000; i += 2)
            {
                //if (i%2==0)
                //{
                //    listBox1.Items.Add(i);
                //}
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Charlar arkaplanda ASCII değerler barındırırlar.
            //Charları int32'ye çevirirsek bize ASCII değerlerini teslim ederler.
            for (char c = 'A'; c <= 'Z'; c++)
            {
                listBox1.Items.Add(c + "-" + Convert.ToInt32(c));
            }

        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i <= 100; i++)
            {
                toplam += i;
            }
            MessageBox.Show("Sonuç: " + toplam);

        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            //1-100 arasindaki cift sayilarin toplami ile, 
            //tek sayilarin toplaminin farklari karesi kactir?
            int ciftToplam = 0;
            int tekToplam = 0;
            int sonuc;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }
            //sonuc = (ciftToplam - tekToplam) * (ciftToplam - tekToplam);
            sonuc = ciftToplam - tekToplam;
            sonuc = sonuc * sonuc;
            //sonuc *= sonuc;
            MessageBox.Show("Sonuç: "+sonuc);

        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            //1945 - günümüz yılları arasındaki yılları
            //Listboxa ekle ama 1990 ve 1992 yıllarını ekleme!
            //DateTime.Now.Year

            for (int i = 1945; i < DateTime.Now.Year; i++)
            {
                if (i != 1990 && i != 1992)
                {
                    listBox1.Items.Add(i);
                }

                //if (i==1990 || i == 1992)
                //{

                //}
                //else
                //{
                //    listBox1.Items.Add(i);
                //}

            }

        }
    }
}
