using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_Array
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dizi boyutu ve Random sayıların aralığı dışarıdan 
            //girilen bir dizi oluşturup listboxa yazdıralım

            //dışarıdan gelen değerleri alıyoruz
            int diziBoyutu = Convert.ToInt32(txtBoyut.Text);
            int min = Convert.ToInt32(txtMin.Text);
            int max = Convert.ToInt32(txtMax.Text);

            //random değişkeni oluştur
            Random rnd = new Random();

            //dizi boyutu dışarıdan girilen bir dizi oluştur
            int[] randomSayilar = new int[diziBoyutu];

            //diziye eleman ekleme işlemi
            for (int i = 0; i < randomSayilar.Length; i++)
            {
                randomSayilar[i] = rnd.Next(min,max);
                //listBox1.Items.Add(randomSayilar[i]);
            }

            //listboxa dizi elemanlarını ekleme
            int sayac = 0;
            foreach (int sayi in randomSayilar)
            {
                listBox1.Items.Add(sayac+": "+sayi);
                sayac++;
            }
        }
    }
}
