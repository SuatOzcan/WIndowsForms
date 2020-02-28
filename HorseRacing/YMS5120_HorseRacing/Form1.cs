using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_HorseRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        

        private void btnYarisiBaslat_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            //Bir kontrolün "Left" property'si, o kontrolün
            //sola olan uzaklığını size teslim eder.



            //Burada sayılar random değerler olarak atanacaktır.

            //pcbBirinciAt.Left += 5;
            //pcbIkinciAt.Left += 10;
            //pcbUcuncuAt.Left += 7;
            
            //pcbBirinciAt.Left = pcbBirinciAt.Left + 5;
            pcbBirinciAt.Left += rnd.Next(5,16);
            pcbIkinciAt.Left += rnd.Next(5,16);
            pcbUcuncuAt.Left += rnd.Next(5,16);


            if (pcbBirinciAt.Left>pcbIkinciAt.Left && pcbBirinciAt.Left>pcbUcuncuAt.Left)//eğer birinci at öndeyse ***&&**--> ve işlemi.
            {
                lblDurum.Text = "Birinci at önde!!";
            }
            else if (true)//eğer ikinci at öndeyse
            {

            }
            else if (true)//eğer üçüncü at öndeyse
            {

            }


            //Bir kontrolun "Width" ozelligi, o kontrolun genisligini size teslim eder...
            //Bir kontrolun "Height" ozelligi, o kontrolun yuksekligini size teslim eder...

            if (pcbBirinciAt.Left + pcbBirinciAt.Width>=lblBitis.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı birinci kulvardaki atımız kazandı");
            }
            else if(pcbIkinciAt.Left+pcbIkinciAt.Width>=lblBitis.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı ikinci kulvardaki atımız kazandı");

            }
            else if (pcbUcuncuAt.Left+pcbUcuncuAt.Width>=lblBitis.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı üçüncü kulvardaki atımız kazandı");
            }



            //HİLE EKLEMEYİ UNUTMAYIN!!


        }

        private void btnYarisiSifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcbBirinciAt.Left = 16;
            pcbIkinciAt.Left = 16;
            pcbUcuncuAt.Left = 16;
        }
    }
}
