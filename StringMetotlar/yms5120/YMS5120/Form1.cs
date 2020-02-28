using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ornekMetin;
        private void btnCompare_Click(object sender, EventArgs e)
        {
            //CompareTo => Metodu kullandiginiz string degerle metoda verdiginiz parametredeki string degeri sozluk mantigiyla karsilastirir... Eger sozlukte ayni lokasyonlardasa 0, parametredeki deger, ana degerimizden sozlukte onceyse -1; sonraysa 1 degerini dondurur...
            ornekMetin = txtGirisAlani.Text;
            int sonuc = ornekMetin.CompareTo("BilgeAdam");
            MessageBox.Show("Sonuc: "+sonuc);
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            //Contains => Aradıgınz char ya da string deger, arama yaptiginiz metinsel ifade icerisinde gecmekte mi gecmemekte mi cevabini size "bool" olarak dondurur..
            ornekMetin = txtGirisAlani.Text;
            bool varMi = ornekMetin.Contains("adam");
            //MessageBox.Show(varMi ? "Aradığınız değer bulunmaktadır!":"Aradığınız değer bulunmamaktadır!");

            if (varMi)
            {
                MessageBox.Show("Değer bulunmakta!");
            }
            else
            {
                MessageBox.Show("Değer Bulunmamakta!");
            }
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            //StartsWith => Kelimenizin parametrede gonderdiginiz degerle baslayip baslamadigini size "bool" olarak dondurur...
            ornekMetin = txtGirisAlani.Text;
            bool sonuc = ornekMetin.StartsWith("bil");
            string mesaj = sonuc ? "Kelime \"bil\" ile başlamaktadır" : "Kelime \"bil\" ile başlamamaktadır!";
            MessageBox.Show(mesaj);
        }

        private void benEndsWith_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;

            MessageBox.Show(ornekMetin.EndsWith("dam")?"Kelime\"dam\"ile bitmektedir":"Kelime \"dam\" ile bitmemektedir");

        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //IndexOf => Dizilerde gordugumuz metodun ayni prensibleriyle calisir. Eger harf varsa harfin indexini, yoksa -1 degerini, harf birden fazla var ise ilk harfin indexini dondurur...
            ornekMetin = txtGirisAlani.Text;
            int index = ornekMetin.IndexOf('g');
            MessageBox.Show(index.ToString());
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            int lastIndex = ornekMetin.LastIndexOf('a');
            MessageBox.Show(lastIndex.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;

            ornekMetin = ornekMetin.Remove(4); //=> Verdiginiz index numarasi dahil, o indexteki ve sonraki tum karakterleri ortadan kaldirir...
            //ornekMetin=ornekMetin.Remove(3,2); //=> Verdiginiz index numarasi dahil, o indexteki elemandan baslayarak, ikinci parametrede gonderdiginiz deger kadar eleman siler...
            MessageBox.Show(ornekMetin);

        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Replace("a","hatun");
            MessageBox.Show(ornekMetin);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string mailAdresleri = txtGirisAlani.Text;
            string[] adresler = mailAdresleri.Split(';',',');
            foreach (string item in adresler)
            {
                MessageBox.Show(item);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Insert => Bir metinsel degerin herhangi bir pozisyonuna (index) yeni bir degeri ilistirmek istiyorsaniz bu metodu kullanabilirsiniz. İlk parameterde kacinci indexten sonra ekleyecegini, ikinci parametrede ise hangi metni ekleyecegini sorar...
            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Insert(5,"cik");
            MessageBox.Show(ornekMetin);
        }

        private void btnToLowerToUpper_Click(object sender, EventArgs e)
        {
            //ToLower => İlgili metnin tamamını küçük harfe çevirmenize olanak saglar..
            //ToUpper => İlgili metnin tamamini buyuk harfe cevirmenize olanak saglar..
            ornekMetin = txtGirisAlani.Text;
            this.Text = ornekMetin.ToLower();
            MessageBox.Show(ornekMetin.ToUpper());
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {

            //Substring (1.Kullanım) => Metninizden, parametrede gonderdiginiz indexten baslayarak, geri kalan kismi cekip almaniza olanak saglar...
            //Substring (2.Kullanım) => Metninizden, ilk parametrede verdiginiz indexten baslayip, ikinci parametrede verdiginiz deger kadarlik kismi cekip almaniza olanak saglar..
            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Substring(5);
            //ornekMetin = ornekMetin.Substring(3,2);
            MessageBox.Show(ornekMetin);
        }



        private void btnToCharArray_Click(object sender, EventArgs e)
        {
            //ToCharArray==> stringinizi charlarına ayırarak size char[] olarak teslim eder.
            ornekMetin = txtGirisAlani.Text;
            char[] karakterler = ornekMetin.ToCharArray();

            for (int i = 0; i < karakterler.Length; i++)
            {
                MessageBox.Show(i+". karakter: "+karakterler[i]);
            }
        }


        private void btnTrim_Click(object sender, EventArgs e)
        {
            //Trim => Metninizin saginda ya da solundaki tum bosluklari temizlemenize olanak saglayan metottur...
            ornekMetin = txtGirisAlani.Text;
            string yeniDeger = ornekMetin.Trim();
            MessageBox.Show(string.Format("Boşluklarla Hesaplanan Karakter Sayısı: {0}\nBoşluklar temizlenip hesaplanan karakter sayısı: {1}",ornekMetin.Length,yeniDeger.Length));
        }
    }
}
