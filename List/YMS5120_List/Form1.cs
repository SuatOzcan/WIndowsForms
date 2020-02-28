using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_List
{
    public class Arac{

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Model { get; set; }
        public string Km{ get; set; }
        public string Yakit { get; set; }

    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List sınıfı ArrayList sınıfı gibi içeisinde object tipinde veri saklayabilen bir yapıdır.
            //aralarındaki en buyuk fark ArrayList sınıfı içerisine eklenen her türlü veriyi object tipinde saklarkeb List yapısına saklayacağı verilerin tipi bilgi olarak verilir.
            //BU şekilde List sınıfı içerisinde verilerin tipleri bilindiği için her hangi bir tip dönüştürme işlemi kllanılmadan direk işleme sokulabilir.
            Arac bmw = new Arac();
            bmw.Ad = "AdTest";
            bmw.Id = 1;
            bmw.Km = "80000";
            bmw.Yakit = "Benzin";
            bmw.Model = "ModelTest";

            List<Arac> arabaList = new List<Arac>();
            arabaList.Add(bmw);

            List<string> metinDizisi = new List<string>();
            metinDizisi.Add("Can");
            metinDizisi.Add("Oğuz");

        }
    }
}
