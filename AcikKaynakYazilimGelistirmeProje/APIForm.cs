using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcikKaynakYazilimGelistirmeProje
{
    public partial class APIForm : Form
    {
        public APIForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://emojihub.herokuapp.com/");
            HttpResponseMessage responce = await client.GetAsync("api/random/category_food_and_drink");
            string result = await responce.Content.ReadAsStringAsync();
            label1.Text = result;
        }
    }
}
