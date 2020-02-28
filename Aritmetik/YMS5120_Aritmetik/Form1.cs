using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_Aritmetik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            int sayi1 = 102;
            int sayi2 = 25;
            //toplama
            MessageBox.Show("Test"+sayi1);
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            int sayi1 = 105;
            int sayi2 = 67;
            int sonuc = sayi1 - sayi2;
            MessageBox.Show("Çıkartma Cevabı : "+sonuc);
            //mbox cıkartma islemi
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            int sayi1 = 12;
            int sayi2 = 10;
            //carpma
            //MessageBox.Show(sayi1); string istiyor
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            double sayi1 = 67;
            double sayi2 = 13;
            double sonuc = sayi1 / sayi2;
            MessageBox.Show("Bölme Sonucu :"+sonuc);
            //bolme sonucu
        }

        private void btnKalan_Click(object sender, EventArgs e)
        {
            int sayi1 = 15;
            int sayi2 = 4;
            //mod yani %
            int sonuc = sayi1 % sayi2;
            MessageBox.Show("Kalan :"+sonuc);
        }

        private void btnBirBir_Click(object sender, EventArgs e)
        {
            int sayi = 15;
            sayi--;//bir eksilt
            MessageBox.Show("eksilt cevap:"+sayi);
            sayi++;//bir arttır
            MessageBox.Show("arrtır cevap:"+sayi);

        }
    }
}
