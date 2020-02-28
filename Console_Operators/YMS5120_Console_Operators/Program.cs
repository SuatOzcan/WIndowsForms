using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5120_Console_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lutfen bir sayi giriniz ");
            string sayi1;
            sayi1 = Console.ReadLine();
            Console.WriteLine("Lutfen ikinci sayiyi giriniz");
            string sayi2;
            sayi2 = Console.ReadLine();

            int yeniSayi1 = Convert.ToInt32(sayi1);//3
            int yeniSayi2 = Convert.ToInt32(sayi2);//2

            yeniSayi1++;//4
            yeniSayi2--;//1

            yeniSayi1 *= yeniSayi2;//yenisayi1=yenisayi1*yenisayi2;-->yenisayi1=4*1;

            Console.WriteLine(yeniSayi1);//?

            Console.ReadKey();
            
        }
    }
}
