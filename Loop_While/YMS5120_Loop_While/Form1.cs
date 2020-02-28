using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_Loop_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Aşağıdaki örnek bir sonsuz döngü örneğidir.
            //bool sonuc = false;
            //while (!sonuc)
            //{
            //    listBox1.Items.Add('a');
            //}



            int i = 0;
            while (i < 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
            //for (int i = 0; i < 100; i++)
            //{
            //    listBox1.Items.Add(i);
            //}


        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {   //Form üzerinde yer alan tüm kontrollerin içinde gezinme işlemi.
            //Buttonların genişliğini 100 px olarak ayarlıyoruz.
            //Yukarıya olan uzaklıklarını 20 arttırıyoruz.
            int index = 0;
            while (index<this.Controls.Count)
            {
                if (this.Controls[index] is Button)
                {
                    this.Controls[index].Width = 100;
                    this.Controls[index].Top += 20;
                }
                index++;
            }
        }
    }
}
