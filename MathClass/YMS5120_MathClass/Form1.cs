using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_MathClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            string deger = Math.PI.ToString();
            deger = deger.Substring(0,4);
            this.Text = deger;
            
            
            //this.Text = Math.PI.ToString();

        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            //Mutlak Değer işlemi.
            int mutlakDeger = Math.Abs(-45);
            this.Text = mutlakDeger.ToString();
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            //Aşağı sayı yuvarlama
            double deger = Math.Floor(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            //Yukarı sayı yuvarlama
            double deger = Math.Ceiling(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //Round => Sayinin yarisindan fazlasini bir uste, yarisindan azini ise bir alttaki tam sayiya yuvarlar...

            //NOT : .'dan önceki sayı çift ise bir alt değere, tek ise bir üst değere tamamlar. (NOT: .'dan sonraki değer 50 ise)
            double deger = Math.Round(11.50);
            MessageBox.Show(deger.ToString());
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            //Sayının ondalıklı kısmına bakmaz, yalnızca tam kısmını getirir.
            double deger = Math.Truncate(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            //İki değer arasından maximum olanı alır.
            int maxDeger = Math.Max(45,65);
            MessageBox.Show(maxDeger.ToString());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //İki değer arasından minimum olanı alır.
            int minDeger = Math.Min(45,65);
            MessageBox.Show(minDeger.ToString());
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            //Kuvvet alma işlemini gerçekleştirir.
            double deger = Math.Pow(3,4);
            MessageBox.Show(deger.ToString());
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            //Sayının karekökünü alma işlemi.
            double deger = Math.Sqrt(16);
            MessageBox.Show(deger.ToString());
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            //SIGN => Bir sayinin negatif, pozitif ya da 0'a esit olup olmadigiyla ilgili bildirim doner...
            //Eger sayi negatifse -1, pozitifse +1, 0 ise size 0 degerini doner...
            int sonuc = Math.Sign(-25);
            MessageBox.Show(sonuc.ToString());

        }

        private void btnMinDeger_Click(object sender, EventArgs e)
        {
            //Textboxtan girilen üç değer arasından en
            //küçük olanı formun textinde göster.
            //math.min işlemi üç sayı için tek satırda
            //tamamlansın

            int birinciSayi = Convert.ToInt32(txtBirinci.Text);
            int ikinciSayi = Convert.ToInt32(txtIkinci.Text);
            int ucuncuSayi = Convert.ToInt32(txtUcuncu.Text);
            int minDeger = Math.Min(birinciSayi,(Math.Min(ikinciSayi,ucuncuSayi)));
            this.Text = minDeger.ToString();




        }
    }
}
