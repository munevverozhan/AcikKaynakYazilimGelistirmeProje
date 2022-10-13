using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcikKaynakYazilimGelistirmeProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad=txtAd.Text;
            string soyad = txtSoyad.Text;
            int sinif = Convert.ToInt32(txtSinif.Text);
            int numara = Convert.ToInt32(txtNumara.Text);
            listBox1.Items.Add("AD:  " + ad).ToString();
            listBox1.Items.Add("SOYAD:  " + soyad).ToString();
            listBox1.Items.Add("SINIF:  " + sinif).ToString();
            listBox1.Items.Add("NUMARA:  " + numara).ToString();
            

        }
    }
}
