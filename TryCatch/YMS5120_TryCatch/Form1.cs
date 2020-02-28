using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_TryCatch
{
    /*Istısna Tipleri
 * Calisma Zamani Hatalari (Runtime Exception)--> Cogunlukla kullanıcı kaynaklı hatalardır(Verinin eksik/boş geçilmesi gibi.) Cozu Yolu: Try-catch ile hataları ele alabilirsiniz.
 * Derleme Zamanı Hataları (Compile Exception)--> Tamamen yazılımcı kaynaklı hatalardır. Yazım hataları meydana geldiğinde devreye girer. En kolay cözülen hata tipidir. Visual Studio Sizi uyaracaktır.(Error List penceresinde) İlgili hataya çüft tıklayarak gidebilirsiniz.
 * Mantıksal Hatalar-->Tamamen programcı kaynaklı hatalardır. Uygulamanın algoritmasında meydana gelir. Örneğin bir bölme yapılacak yerde islem unutulması değerin yanlış girilmesi ya da yanlış değer ile değiştirilmesi vb. Çözülmesi en zonr hatalardır. Anlık olarak derleme aşaması takip edilmeli ve değerlerinizi gozlemlemelisiniz.
 * Breakpoint-->Derleme aşamasına adım adım dahil olmak için kullandıgımız yardımcı tool'dur. Yapmanız gereken tek şey hangi satırdan derleme anına dahil olmak istiyorsanız ilgili satırın en sol kısmına gelip (gri alan) mouse'un sol tusuyla bir kırmızı top yerlestirmek.
 */
    //Eger disaridan bir veri aliyorsaniz, verinin tutarligindan emin de degilseniz, orada mutlaka hata riski vardır!
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int gelenDeger = Convert.ToInt32(txtGirisAlani.Text);
            MessageBox.Show("Tebrikler! Doğru telefon formatı girdiniz.");
        }

        private void btnHataYönetimliOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                //Bu alana hata riski olan kodlar yazılır. 

                int gelenDeger = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler! Doğru telefon formatı girdiniz.");
            }
            catch 
            {
                // Try bloğu içerisine yazmış olduğunuz kodlara herhagi bir
                // hata meydana gelirse, catch blogu devreye girer.

                MessageBox.Show("Telefon numarası yazmayı bile beceremedin!!!");

            }
        }

        private void btnDetaylıOnayla_Click(object sender, EventArgs e)
        {
            

            try
            {
                int gelenDeger = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler! Doğru telefon formatı girdiniz.");
            }
            catch (Exception hata)
            {

                //catch ifadesinin yanındaki Exception'ın kelime anlamı-->istisnadır.
                //Uygulamanızın kararlılığını bozan istisnai durumla ilgili size detayları teslim eden nesnedir. 
                MessageBox.Show(hata.Message);//Hatanın sistem tarafından atanan mesajını size teslim eder.

            }
            
        }

        private void btnFinallyOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int gelenDeger = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler! Doğru telefon formatı girdiniz.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                //hata olsa da olmasa da 
                //çalışmasını istediğimiz kodları yazdığımız alandır.
                //try-catch-finally üçlüsünde en son çalışor.
                MessageBox.Show("Hata var mı yok mu bilmiyorum ama çalıştım!");
            }
        }
    }
}
