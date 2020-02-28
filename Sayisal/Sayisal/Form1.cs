using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayisal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        Random rnd = new Random();
        int[] bilet = new int[6];
        int[] sayilar = new int[6];

        void CekilisSonucu()
        {
            
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 50);
                
            }
                
            
            Array.Sort(sayilar);
            
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (i == 0)
                {
                    t1.Text = sayilar[i].ToString();
                }
                else if (i == 1)
                {
                    t2.Text = sayilar[i].ToString();
                }
                else if (i == 2)
                {
                    t3.Text = sayilar[i].ToString();
                }
                else if (i == 3)
                {
                    t4.Text = sayilar[i].ToString();
                }
                else if (i == 4)
                {
                    t5.Text = sayilar[i].ToString();
                }
                else if (i == 5)
                {
                    t6.Text = sayilar[i].ToString();
                }
            }
            
        }

        void KazandikMi()
        {
            
            int tutanSayilar=0;
            for (int i = 0; i < bilet.Length; i++)
            {
                for (int j = 0; j < bilet.Length; j++)
                {
                    if (bilet[i] == sayilar[j])
                    {
                        tutanSayilar++;
                        if (j==0)
                        {
                            t1.BackColor = Color.Tomato;
                        }
                        else if (j==1)
                        {
                            t2.BackColor = Color.Tomato;
                        }
                        else if (j == 2)
                        {
                            t3.BackColor = Color.Tomato;
                        }
                        else if (j == 3)
                        {
                            t4.BackColor = Color.Tomato;
                        }
                        else if (j == 4)
                        {
                            t5.BackColor = Color.Tomato;
                        }
                        else if (j == 5)
                        {
                            t6.BackColor = Color.Tomato;
                        }
                    }
                }
                
            }
            btnCekilis.Text = "Tutturduğunuz sayıların adedi: "+tutanSayilar.ToString()+" (Tekrar denemek için tıklayınız)";
        }
        void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void btnCekilis_Click(object sender, EventArgs e)
        {

           
            Temizle();
            CekilisSonucu();
            KazandikMi();

            

        }

        void BiletOlustur()
        {
            lblBilet.Text = "-";
            for (int i = 0; i < bilet.Length; i++)
            {
                bilet[i] = rnd.Next(0, 50);
                
            }
            Array.Sort(bilet);
            
            for (int i = 0; i < bilet.Length; i++)
            {

                lblBilet.Text += bilet[i].ToString() + "-";
            }
            
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            BiletOlustur();

        }
    }
}
