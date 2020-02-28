using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_Loop_For
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Label'a 5 defa yan yana 'X' yazdır.
            //lblYaziAlani.Text
            for (int i = 0; i < 5; i++)
            {
                lblYaziAlani.Text += "X";
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Label'a alt alta 5 defa "X" yazdırılsın
            //"X\n" --> "\n" alt satıra geç işlemidir.

            for (int i = 0; i < 5; i++)
            {
                lblYaziAlani.Text += "X\n";
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //İçiçe dongulerde unutmamamiz gereken en onemli nokta, disaridaki dongunun bir defa donmesi demek; icerideki dongunun o anlik tum hareketlerini tamamlamasi demektir...
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    lblYaziAlani.Text += "X"; 
                }
                lblYaziAlani.Text += "\n";
            }

        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    lblYaziAlani.Text += "X";
                }
                lblYaziAlani.Text += "\n";
            }
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            //1-10'a kadar olan sayilarin carpim tablosunu
            //listbox'a yazdiriniz...
            //Format => 3 X 5 = 15;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    listBox1.Items.Add(i+"X"+j+"="+(i*j));
                }
                listBox1.Items.Add("----------------");
            }
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {//Bir dongu icerisinde, kosullara sahipseniz ve kosulunuz saglandigi takdirde donguye devam etme gereğini duymuyorsaniz, "break" anahtar kelimesiyle donguyu sonlandirabilir ve donguden sonraki islemlerinize gecebilirsiniz...
            for (int i = 0; i < 100; i++)
            {
                if (i==20)
                {
                    listBox1.Items.Add(i);
                    break;
                }
                listBox1.Items.Add(i);
            }
            MessageBox.Show("Döngüden çıktım işleme devam ediyorum");
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Listbox temizleme metodu.
            Random rnd = new Random();
            for (int i = 0; i <7 ; i++)
            {
                int karmasikSayi = rnd.Next(1,50);
                if (listBox1.Items.Contains(karmasikSayi))
                {
                    i--;
                    continue;
                    //continue sadece o anki durumu atlayacak ve 
                    //bir sonraki turdan dönmeye devam edecektir
                }
                else
                {
                    listBox1.Items.Add(karmasikSayi);
                }
            }
        }

        private void btnOrnek8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i==5)
                {
                    listBox1.Items.Add(i);
                    //MessageBox.Show("Test");
                    //Sartim saglandigi icin donguden cikabilirim...
                    return;
                    //Unreachable Code Detected => Bu kod asla calistirilamayacak!
                    //MessageBox.Show("Test2");

                }
                listBox1.Items.Add(i);
            }
            MessageBox.Show("Döngüden çıktım işleme devam ediyorum");
        }
    }
}
