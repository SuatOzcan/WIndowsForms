using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_MathematicalOperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBirinciAlistirma_Click(object sender, EventArgs e)
        {
            //Dışarıdan alınan iki sayının toplamıyla 
            //farkının birbirine bölümünden kalanın sonucu.

            //Convert.ToInt32();-->string to integer convert işlemi
            //mbox-->cevap message box uzerınden gosterilecek.
            //txtSayi1.Text;-->sayının geleceği kontrol.

            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;

            int bolumdenKalan = toplam % fark;
            MessageBox.Show("Sonuç: "+bolumdenKalan);


        }

        private void btnİkinciAlistirma_Click(object sender, EventArgs e)
        {
            //Sadece ilk textbox kullanılacak!
            //Dışarıdan girilen bir sayının 10 eksiğinin 20 fazlasının
            //ikiye bölümünden kalanın karesi kaçtır?

            // %-->mod alma(bölümden kalan)
            //Convert.ToDouble();

            double sayi = Convert.ToDouble(txtSayi1.Text);
            double sonuc = (sayi - 10 + 20) % 2;
            double karesi = sonuc * sonuc;
            MessageBox.Show("Sonuc :"+karesi);
        }

        private void btnUcuncuAlistirma_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen iki sayının karelerinin toplamı ile
            //karelerinin farkı toplamı kaçtır?

            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            int sayi1kare = sayi1 * sayi1;
            int sayi2kare = sayi2 * sayi2;

            int toplam = sayi1kare + sayi2kare;
            int fark = sayi1kare - sayi2kare;

            int sonuc = toplam + fark;
            MessageBox.Show("Gelen Sonuç: "+sonuc);

        }

        private void btnDorduncuAlistirma_Click(object sender, EventArgs e)
        {
            //ilk textbox-->Vize Notu
            //İkinci textbox-->Final Notu

            //Vize notu'nun %30'u, Fİnal notu'nun %70'ini alıp,
            //Not ortalamasını çıkarın.
            //double!!! (*0.30)

            double vizeNotu = Convert.ToDouble(txtSayi1.Text);
            double finalNotu = Convert.ToDouble(txtSayi2.Text);

            double sonuc = (vizeNotu * 0.30) + (finalNotu * 0.70);

            MessageBox.Show("Not Ortalaması: "+ sonuc);
            //txtSayi1.Text = sonuc.ToString();
        }

        private void btnBesinciAlistirma_Click(object sender, EventArgs e)
        {
            //Kullanıcı ilk textbox'a adını,İkinci Textbox'a
            //soyadını girsin. Mbox ile kullanıcıya 
            //adi.soyadı@hotmail.com şeklinde uyarı çıkartın.

            string isim = txtSayi1.Text;
            string soyisim = txtSayi2.Text;
            MessageBox.Show(isim+"."+soyisim+"@hotmail.com");

        
        }

        //Mouse alana girdiği anda textbox 
        //arkaplan ve yazı rengi değişssin

        // ---.BackColor=Color.White;
        private void txtSayi1_MouseEnter(object sender, EventArgs e)
        {
            txtSayi1.BackColor = Color.Maroon;
            txtSayi1.ForeColor = Color.Orange;
        }
        // Mouse alandan çıktığı anda renkleri geri döndürelim.
        private void txtSayi1_MouseLeave(object sender, EventArgs e)
        {
            txtSayi1.BackColor = Color.White;
            txtSayi1.ForeColor = Color.Black;
        }


    }
}
