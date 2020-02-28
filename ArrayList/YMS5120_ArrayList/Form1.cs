using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_ArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * ARRAYLIST
         * 
         * Su zamana dek gordugumuz ilkel dizilerin (veriTipi[] olarak tanimlanan) en buyuk iki ozelligi;
         * TİP BAĞIMLILIĞI ve ELEMAN SAYISI ZORUNLULUĞU idi...
         * 
         * Ancak, ArrayList nesnesiyle birlikte bu bagimliliklar ortadan kalktı. Bir ArrayList'i meydana getirirken ne eleman sayisi vermek zorundasiniz ne de bir veri tipi belirtmek zorundasiniz..
         * 
         * Dezavantajı nedir?
         * ArrayList icerisindeki elemanlari otomatik olarak object veri tipine dondurme ozelligine sahiptir. Dolayisiyla bu verileri geri almak istediginiz mecburen bir "cast" ya da "convert" işlemine gerek duymaktasiniz... Bu da ekstra iki kat is demektir... (object => bilinene : unboxing islemi)
         * 
         * ArrayList'i kullanima acabilmek icin namespace'lere using System.Collections; ibaresini eklemelisiniz...
         */


        ArrayList yeniDizi = new ArrayList();


        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            yeniDizi.Add("İstanbul");
            yeniDizi.Add("Kiev");
            yeniDizi.Add("Eskişehir");
            yeniDizi.Add("Ankara");
            yeniDizi.Add("Tokyo");
            yeniDizi.Add("Cape Town");
            //yeniDizi.Add(12);
            //yeniDizi.Add(DateTime.Now);

            foreach (object item in yeniDizi)
            {
                MessageBox.Show("Sıradaki Şehir: "+(string)item);
            }



        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            yeniDizi.Add("İstanbul");
            yeniDizi.Add("Kiev");
            yeniDizi.Add("Eskişehir");
            yeniDizi.Add("Ankara");
            yeniDizi.Add("Tokyo");
            yeniDizi.Add("Cape Town");
            yeniDizi.Add("Kiev");

            //Bir elemanı teslim alma
            //this.Text = (string)yeniDizi[0];

            //Dizinin eleman sayısına ulaşma
            //this.Text = yeniDizi.Count.ToString();

            //Dizideki elemanın indeksini alma
            //this.Text = yeniDizi.IndexOf("İstanbul").ToString();
            //this.Text = yeniDizi.LastIndexOf("Kiev").ToString();

            //Eleman dizide var mı yok mu?
            //this.Text = yeniDizi.Contains("Eskişehir") ? "Var!!!" : "Yok!!!";

            //Araya eleman ekleme
            yeniDizi.Insert(3,"İzmir");

            //Verilen elemanı silme
            yeniDizi.Remove("İzmir");

            //Diziyi sıralama küçükten büyüğe.
            yeniDizi.Sort();

            //Diziyi tersine çevirme
            yeniDizi.Reverse();

            //O anki kapasiteyi o anki eleman sayısına eşitleme
            yeniDizi.TrimToSize();

            //Diziyi temizleme
            yeniDizi.Clear();

        }
    }
}
