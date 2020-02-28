using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenelCalisma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      

        string[] ornekKisiler = { "Can", "Ahmet", "Aslı", "Merve", "Osman", "Yasin", "Tuncay" };
        void ListboxTemizle()
        {
            listBox1.Items.Clear();
        }

        void TextBoxTemizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }


        void KisiEkle(string ad)
        {
            Array.Resize(ref ornekKisiler, ornekKisiler.Length + 1);
            ornekKisiler[ornekKisiler.Length - 1] = ad;
            listBox1.Items.Add(txtAd.Text);
            DiziSiralama();
            Listele();
            TextBoxTemizle();

        }
        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            string yeniAd = txtAd.Text;
            KisiEkle(yeniAd);
        }

       
        void Listele()
        {
            ListboxTemizle();
            foreach (string item in ornekKisiler)
            {
                listBox1.Items.Add(item);
            }
        }



        void KisiAra(string ad)
        {
            int sayac = 1;
            foreach (string item in listBox1.Items)
            {

                if (item.ToLower() == ad.ToLower())
                {
                    MessageBox.Show("Aradığınız Kişi: " + item + "==>" + " BULUNMUŞTUR!!!");
                    break;
                }
                if (sayac == listBox1.Items.Count)
                {
                    MessageBox.Show("Aradığınız Kişi: " + item + "==>" + " BULUNAMAMIŞTIR!!!");
                }
                sayac++;
            }
            TextBoxTemizle();



        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string ad = txtAranacakAd.Text;
            KisiAra(ad);
        }

        void DiziSiralama()
        {
            Array.Sort(ornekKisiler);
        }

        void Guncelle(string eskiAd, string yeniAd, int indexNo)
        {

            for (int i = 0; i < ornekKisiler.Length; i++)
            {
                if (i == indexNo)
                {
                    ornekKisiler[i] = yeniAd;
                    MessageBox.Show("Eski İsim: " + eskiAd + "\nYeni İsim: " + yeniAd);
                    break;
                }
            }
            
            DiziSiralama();
            Listele();
            TextBoxTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string eskiAd = listBox1.SelectedItem.ToString();
            int index = listBox1.SelectedIndex;


            string yeniAd = txtGuncellenecek.Text;
            Guncelle(eskiAd, yeniAd, index);
        }


        void Sil(string silinecekAd)
        {
            

            string[] yeniDizi = new string[ornekKisiler.Length - 1];
            int silinecekIndex = -1;

           
            for (int i = 0; i < ornekKisiler.Length; i++)
            {
                if (ornekKisiler[i].ToLower() == silinecekAd.ToLower())
                {
                    silinecekIndex = i;
                    
                    break;
                }

            }
            
            int diziSayaci = 0;
            if (silinecekIndex != -1)
            {
                for (int j = 0; j <= yeniDizi.Length; j++)
                {
                    if (j != silinecekIndex)
                    {
                        yeniDizi[diziSayaci] = ornekKisiler[j];
                        diziSayaci++;
                    }
                }
                Array.Resize(ref ornekKisiler, ornekKisiler.Length - 1);
                Array.Copy(yeniDizi, ornekKisiler, ornekKisiler.Length);
                MessageBox.Show("Silme Başarılı!!");
                DiziSiralama();
                Listele();
            }
            else
            {
                MessageBox.Show("Silinecek eleman dizide bulunamadı!");
            }



        }
        private void btnSil_Click(object sender, EventArgs e)
        {

            string silinecekAd = txtSilinecek.Text;
            Sil(silinecekAd);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Listele();
        }
        

    }
}
