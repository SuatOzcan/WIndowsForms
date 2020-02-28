using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5120_Konus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //References'a system.speech ekledik.
        private void btnKonus_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak(txtKelime.Text);
        }
    }
}
