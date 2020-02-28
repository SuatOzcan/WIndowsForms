using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * SWITCH - CASE
         * IF-Else mantigiyle calisan bir kontrol mekanizmasidir. Aradaki fark, if-else yapisi buyukluk-kucukluk gibi durumlari kontrol ederken,
         * switch-case yalnizca esitlik durumlarini kontrol edebilen karar yapimizdir.. Kendisine ait bir index mekanizmasi ile kosullari algilar, 
         * siraya koyar ve otomatik olarak yuzlerce kosulunuz olsa bile herbirine bakmadan hangisine uydugunu bulabilir. Bu da performansı direktman etkiler...
         * Switch blogu icerisine yazdiginiz veri tipiniz ne ise, case (durum) olarak belirttiginiz tum veriler de ayni veri tipinde olmalıdır!
         * break => Kosul saglandi, artik karar yapisindan kendini disari atabilirsin mesajini sisteme verir...
         */
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            switch (txtGirisAlani.Text)
            {
                case "Kış":
                    MessageBox.Show("Aralık-Ocak-Şubat");
                    break;
                case "İlkbahar":
                    MessageBox.Show("Mart-Nisan-Mayıs");
                    break;
                case "Yaz":
                    MessageBox.Show("Haziran-Temmuz-Ağustos");
                    break;
                case "Sonbahar":
                    MessageBox.Show("Eylül-Ekim-Kasım");
                    break;
                //Default => Ongorulen bir durum harici degerle karsilasirsak, varsayilan olarak karar yapisi ne gibi bir islem uygulasin. Tamamen opsiyoneldir. Kullanmasak da olur...
                default:
                    MessageBox.Show("Böyle bir mevsim hiç duymadım!");
                    break;



            }
        }

        private void btnKullaniciKontrolu_Click(object sender, EventArgs e)
        {
            //Eğer ilk textboxa "Admin","Moderatör","Yönetici" değerleri girilirse
            //mbox-->"Yönetici Paneline Yönlendiriliyorsunuz"
            //Harici bir durumda mbox--> "Bu sayfayı görme yetkiniz yok!"
            //string gelenDeger = txtGirisAlani.Text.ToLower();

            string girilenDeger = txtGirisAlani.Text;
            switch (girilenDeger)
            {
                case "Admin":
                case "Moderatör":
                case "Yönetici":
                    MessageBox.Show("Yönetici Paneline Yönlendiriliyorsunuz....");
                    break;
                case "Üye":
                    MessageBox.Show("Anasayfaya Yönlendiriliyorsunuz...");
                    break;
                default:
                    MessageBox.Show("Bu Sayfayı Görme Yetkiniz Yok!!!");
                    break;



            }


        }

        private void btnIcIceSwitch_Click(object sender, EventArgs e)
        {
            //İç içe switch kullanarak kullanıcı adını ve şifresini kontrol ediniz.eğer kullanıcı kullanıcıadını ve şifresini doğru girerse "Tebrikler, hem kullanıcı adı hemde şifreniz doğru" uyarısı
            //Kullanıcı adı doğru şifre yanlışsa "Kullanıcı adınız doğru ancak şifreniz yanlış!" uyarısı
            //kullanıcı adı yanlışsa "Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!" uyarusını kullanıcıya veriniz.


            string KullaniciAdi = txtGirisAlani.Text;
            string Sifre = txtIkinciGirisAlani.Text;

            //KullaniciAdi="bilgeadam"
            //Sifre="1234";
            switch (KullaniciAdi) {
                case "bilgeadam":
                    switch (Sifre)
                    {
                        case "1234":
                            MessageBox.Show("Hem kullanıcı adınız hem şifreniz doğru!!");
                            break;
                        default:
                            MessageBox.Show("Kulanıcı adı doğru ama şifre yanlış");
                            break;

                    }
                break;
                default:
                    MessageBox.Show("Kullanıcı adını yanlış girdiniz.Şifreyi kontrol etmedim bile!!");
                    break;



            }
            
                
        }
    }
}
