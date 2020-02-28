using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_TernaryOperator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //TERNARY OPERATORU
        //Tek satirda ufak bir karar mekanizmasi ile yolunuza devam etmek istiyorsaniz, soru isareti operatoru size bu pratikligi saglar. Yazim formati;
        // kontrolEdilecekDeger (KarsilastirmaOperatoru) ? Durumun Olumlu Olma Durumu : "Durumun Olumsuz Olma Durumu;



        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            string girilenDeger = "Bilge Adam";

            //if (girilenDeger == "Bilge Adam")
            //{
            //    this.Text = "Dogru Cevap";

            //}
            //else
            //{
            //    this.Text = "Yanlış Cevap";
            //}

            this.Text = girilenDeger == "Bilge Adam" ? "Doğru Cevap" : "Yanlış Cevap";

            string sonuc = 10 < 0 ? "Küçüktür" : "Büyüktür";
            MessageBox.Show(sonuc);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Eğer kullanıcı bir değer girdiyse mbox ile göster.
            //Girmemiş ise "Default" bir değer göster.
            //text.lenght?


            string girilenDeğer;
            //if (textBox1.Text.Length>0)
            //{
            //    girilenDeğer = textBox1.Text;
            //    MessageBox.Show(girilenDeğer);
            //}
            //else
            //{
            //    MessageBox.Show("Default Değer");
            //}

            girilenDeğer = textBox1.Text.Length > 0 ? textBox1.Text : "Default Değer";
            MessageBox.Show(girilenDeğer);
            
        }
    }
}
