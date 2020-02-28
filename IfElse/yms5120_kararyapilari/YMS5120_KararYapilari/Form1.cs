using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdminKontrolu_Click(object sender, EventArgs e)
        {
            if (txtGirisAlani.Text=="admin")
            {
                MessageBox.Show("Hoşgeldin Sahip!");
            }
            else
            {
                MessageBox.Show("Tanıyamadım?");
            }
        }

        private void btnNotKontrolu_Click(object sender, EventArgs e)
        {
            // eğer not 0'dan küçükse veya 100den büyükse kontrolleri

            int girilenNot = Convert.ToInt32(txtGirisAlani.Text);

            if (girilenNot<0)
            {
                MessageBox.Show("0'dan küçük bir not girişi yapamazsınız!!");
            }
            else if (girilenNot>100)
            {
                MessageBox.Show("100'den büyük bir not girişi yapamazsınız!!");
            }
            else
            {
                MessageBox.Show("Notunuz Hatasız Girilmiştir!");
            }

        }
        
        private void btnCiftTekKontrolu_Click(object sender, EventArgs e)
        {
            //Girilen sayı çift ise Sayı çifttir,Tek ise Tektir yazdır.
            //Mod alma için "%" kullanabiliriz.
            int girilenSayi = Convert.ToInt32(txtGirisAlani.Text);
            if (girilenSayi %2==0)
            {
                MessageBox.Show("Sayı çifttir!");
            }
            else
            {
                MessageBox.Show("Sayı tektir!");
            }

        }

        private void btnDegerKontrolu_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen kelimenin uzunluğu 8 karaktere
            //eşit ya da büyük ise kayıt onaylandı
            //değil ise "Daha uzun bir şifre giriniz." Hatası basılsın.
            //text.Lenght-->karakter sayısı

            if (txtGirisAlani.Text.Length>=8)
            {
                MessageBox.Show("Kayıt Onaylandı!");
            }
            else
            {
                MessageBox.Show("Parolanız çok kısa!");
            }

        }
    }
}
