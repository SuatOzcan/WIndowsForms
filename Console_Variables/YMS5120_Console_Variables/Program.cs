using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5120_Console_Variables
{
    class Program
    {
        /*      
             Değişken Nedir?       
             Değişkenleri en sabit şekilde verilerin depolandğı yerler olarak tanımlayabiliriz.

            */

        /*
         Degisken Kuralları

         1)Kullanmayacagimiz degiskenleri asla tanimlamamaliyiz...
         2)Deger araliklarina gore dogru veri tiplerini secmeye ozen gostermeliyiz... (Degisken Yonetimi = Performans Yonetimi)
         3)Bir degisken adi asla iki kelimeden olusamaz... Eger iki kelime ise mutlaka izin verilen ozel bir karakterle (_) birbirinden ayrilmalidir...
         4)Degisken adlari asla sayiyla baslamaz ancak sayiyla bitebilir...
        */
        static void Main(string[] args)
        {
            //sbyte => -128 ~ 127 Aralığı => 8 BİT
            sbyte degiskenBir = 24;

            //byte => 0 ~ 255 => 8 BİT
            byte degisken_Iki = 45;

            //short => -32767 ~ 32768 => 16 BİT
            short degiskenUc = -2345;

            //ushort => 0 ~ 65536 => 16 BİT
            ushort degiskenDort = 234;

            //int => -2.1 Milyar ~ 2.1 Milyar => 32 BİT
            int degiskenBes = -234567;

            //uint => 0 ~ 4.2 Milyar => 32 BİT
            uint degiskenAlti = 34445;

            //long => -9.1 Katrilyon ~ 9.1 Katrilyon => 64 BİT
            long degiskenYedi = -4567232332;

            //ulong => 0 ~ 18 Katrilyon => 64 BİT
            ulong degiskenSekiz = 238293892;

            //decimal => .'dan sonra 27-28 hane destegi => 128 BİT
            decimal ondalikliBir = 2.234M;

            //double => .'dan sonra 13-14 hane destegi => 64 BİT
            double ondalikliIki = 2.34343;

            //decimal => .'dan sonra 27-28 hane destegi => 128 BİT
            float OndalikliUc = 1.2312F;



            //Metinsel Veri Tipleri
            // 16 bit => Unicode Karakter
            char basHarfim = '$';

            //string => Uzerinde ansiklopedik verilerden tutun da iki - tek karakterlik verilere kadar tum metinsel ifadeleri uzerinde barindiran veri tipimizdir...
            string bosMetin = "İstediğimiz kadar metin";

            // "\n" satır atlamamızı sağlar.
            // "\t" Metin arasında bir tab'lık bosluk birakmak icin kullanılır.



            //Mantıksal Verip Tipleri
            bool bugunTatilMi = false;
            bool kayitVarmi = true;

            bool buyukMu = 10 > 2;



        }
    }
}
