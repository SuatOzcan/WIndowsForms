using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ARRAY SINIFI (CLASS)
        // Su ana dek gormus oldugumuz ilkel diziler, bize uzerinde cok fazla islem yapma olanagi saglamamaktadir. Eger dizinizi yeniden boyutlandirmak, temizlemek, siralamak, tersine cevirmek gibi temel islemler yapmak istiyorsaniz, Array sınıfı size yardimci olacaktir...

        //string sehir = "istanbul";
        string[] ornekDizi = {"İstanbul", "Ankara", "İzmir", "Eskişehir", "Bursa", "Edirne", "Muğla", "Tekirdağ","Eskişehir" };
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Array.Clear() -->Diziden eleman silmek için kullanılan metot.
            Array.Clear(ornekDizi,2,3);

            //Dizinin tamamını temizleme
            Array.Clear(ornekDizi,0,ornekDizi.Length);
            

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Birinci Kullanım
            //Array.Copy()-->Bir diziden baska bir diziye eleman kopyalamak için kullandığımız metot.
            string[] geciciDizi = new string[4];
            //Array.Copy(ornekDizi,geciciDizi,3);

            //ikinci kullanım
            Array.Copy(ornekDizi,3,geciciDizi,0,geciciDizi.Length);
            //kaynak dizimiz hangisi?
            //kaçıncı indexten başlasın?
            //hangi diziye kopyalansın?
            //kopyaladığım dizinin hangi indexine kopyalamaya başlayım?
            //nereye kadar kopyalayayım?


            //foreach (string sehir in geciciDizi)
            //{
            //    MessageBox.Show("sıradaki eleman " + sehir);
            //}

        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //Array.IndexOf()--> Dizide aradığımız elemanın index numarasını döndüren metot.
            int aranilanIndex = Array.IndexOf(ornekDizi,"Eskişehir");
            MessageBox.Show("Aradığınız şehirin indexi: "+aranilanIndex);
        }

        private void btnLastIndex_Click(object sender, EventArgs e)
        {
            int aranilanSonIndex = Array.LastIndexOf(ornekDizi,"Eskişehir");
            MessageBox.Show("Son Eskişehir indexi: "+aranilanSonIndex);

            //int aranilanIndex = Array.IndexOf(ornekDizi,"Eskişehir");

            //if (aranilanIndex==aranilanSonIndex)
            //{
            //    MessageBox.Show("Bir adet Eskişehir var");
            //}
            //else if (aranilanIndex != aranilanSonIndex)
            //{
            //    MessageBox.Show("Birden çok Eskişehir var");
            //}


        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            Array.Resize(ref ornekDizi,25);
            //Array.Resize<string>(ref ornekDizi,25);
            //Birinci kullanım ile ikinci kullanım arasındaki fark sizden öncelikle bir dizi tipi istemesi ve daha sonra sadece o tipteki dizileri resize edebilme kabiliyetine kavuşmasıdır. Kısaca tip güvenliğini sağlar.


        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            //Array.Sort() => Dizinizi siralamak icin kullanacaginiz metot... Elemanlarin yerlerini degistirdigi icin, indexleri de degisecektir. Siralama islemi A'dan Z'ye (kucukten - buyuge) gerceklestirilir...
            Array.Sort(ornekDizi);


            //foreach (string item in ornekDizi)
            //{
            //    MessageBox.Show(item);
            //}
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            //Array.Reverse()-->Dizinizi tersine çevirmeye yarayan metot.
            Array.Reverse(ornekDizi);
            //foreach (string item in ornekDizi)
            //{
            //    MessageBox.Show(item);
            //}
        }
    }
}
