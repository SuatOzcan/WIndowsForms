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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






        string[] arabalar = {"Mercedes","Volkswagen","Ferrari","Bugatti","Audi","Seat","Ford","Alfa Romeo","Tesla" };
        
        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //dizi uzunluğunu bilmiyoruz.
            //dizinin son elemanını mbox ile gösterin.
            //arr.Lenght--> Dizi uzunluğunu verir.

            
            string sonEleman = arabalar[arabalar.Length-1];
            MessageBox.Show(sonEleman);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int dizi örneği
            int[] dizi = new int[3];
            dizi[2] = 656;
            dizi[0] = 565;
            dizi[1] = 11;



            //string dizi örneği
            string[] sehirler = new string[4] { "izmir", "İstanbul", "Kiev", "Eskişehir" };


            //char dizi örneği
            char[] karakterler = {'a','b','c','d'};

            //Dizi içerisinde gezinme
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = i + 5;    
            //}

        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Rastgele olarak dizinin bir elemanı, formun
            //tepesine yazılsın--> "this.Text"
            //Random rnd = new Random();


            Random rnd = new Random();
            int sayi = rnd.Next(0,arabalar.Length);
            this.Text = arabalar[sayi];
        }
        int[] sayilar = {10,20,30,40,50};
        int index=0;
        int havuz=0;
        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //Butona her bastığımızda bir elemanı 
            //sırası ile listboxa ekle.
            //ancak eklediğimiz her elemanı da 
            //bir havuzda toplayarak anlık olarak 
            //eleman toplamlarını tepeye yazdır

            
            if (index<sayilar.Length)
            {
                listBox1.Items.Add(sayilar[index]);
                havuz += sayilar[index];
                this.Text = "Şu ana dek toplam=>"+havuz;
                index++;
            }
            else
            {
                MessageBox.Show("Dizinin son elemanına geldik!");
            }




        }
    }
}
