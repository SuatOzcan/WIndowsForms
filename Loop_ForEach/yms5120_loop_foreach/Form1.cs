using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_Loop_ForEach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] sehirler = {"İstanbul","İzmir","Ankara","Muğla","Trabzon","Kayseri"};
        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //İlgili dizi icerisindeki her bir elemana gecici olarak "sehir" takma adi verilir ve dongunun her bir adiminda size dizinin her bir elemani teslim edilir...
            // sehirler dizisindeki her elemanı listbox1'e ekleyin.
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            int[] sayilar = {123,45,76,5467,23,77,798,999,190,731 };

            //ikiye bölünenleri listbox1e atın.
            //bölünmeyenleri lst2ye atın.
            //hem ikiye hem üçe bölünenlerin sayısını
            //mbox ile gösterin
            int tamBolunenSayilar = 0;
            foreach (int sayi in sayilar)
            {
                if (sayi%2==0 && sayi%3==0)
                {
                    tamBolunenSayilar++;
                }


                if (sayi%2==0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi);
                }
                
            }
            MessageBox.Show("hem ikiye hem üçe bölünenlerin sayısı: " + tamBolunenSayilar);
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {

            //Listbox1den listbox2 ye eleman taşıma
            //foreach (string item in listBox1.Items)
            //{
            //    listBox2.Items.Add(item);
            //}




            //Sadece seçili elemanları taşıma işlemi
            
            foreach (string item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }


        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Form üzerindeki tüm butonların arkaplan ve yazı 
            //renklerini değiştiriniz.

            //Form içerisindeki tüm Kontrollerde geziniyoruz ve Control tipinden olan tüm elemanları yakalıyoruz. Eğer eleman bir button ise renk değiştiriyoruz

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    
                    //if (ctrl.Name=="btnOrnek4")
                    //{
                    //    ctrl.BackColor = Color.Yellow;
                    //}
                    ctrl.BackColor = Color.Black;
                    ctrl.ForeColor = Color.Orange;
                }
            }

        }
    }
}
